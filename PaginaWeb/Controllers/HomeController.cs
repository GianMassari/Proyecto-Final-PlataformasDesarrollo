using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PaginaWeb.Models;

namespace PaginaWeb.Controllers
{
 
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var usuarioSession = HttpContext.Session.GetString("usuario");

            if (usuarioSession != null)
            {
                ViewBag.usuario = usuarioSession;
            }
        

            return View("Index");
            
        }

        public IActionResult Inicio()
        {
            var usuarioSession = HttpContext.Session.GetString("usuario");

            if (usuarioSession != null)
            {
                ViewBag.usuario = usuarioSession;
            }


            return Redirect("/Home/Index");
        }

        public IActionResult Privacy()
        {
            var usuarioSession = HttpContext.Session.GetString("usuario");

            if (usuarioSession != null)
            {

                ViewBag.usuario = usuarioSession;
                return View("Privacy");

            }
            else
            {
                return Redirect("/Home/Index");
            }
        }

        public IActionResult LogIn()
        {
            var usuarioSession = HttpContext.Session.GetString("usuario");

            if (usuarioSession != null)
            {
                ViewBag.usuario = usuarioSession;
                return Redirect("/Home");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Registro()
        {
            var usuarioSession = HttpContext.Session.GetString("usuario");

            if (usuarioSession != null)
            {
                ViewBag.usuario = usuarioSession;
                return Redirect("/Home");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Perfil()
        {
            var usuarioSession = HttpContext.Session.GetString("usuario");

            if (usuarioSession != null)
            {
                ViewBag.usuario = usuarioSession;
                return View();
            }
            else
            {
                return Redirect("/Home");
            }
        }


        [HttpPost]
        public IActionResult Logear(string username , string password) 
        {
            if (username != null && password != null)
            {
                
                if (UsuarioDAO.getInstancia().confirmarLogueo(username, password))
                {
                    HttpContext.Session.SetString("usuario", username);
                    return Redirect("/Home/Privacy");

                }
                else
                {
  
                    ViewBag.error = "Usuario o contraseña incorrectas";
                    return View("LogIn");
                }
  
            }
            else
            {
          
                ViewBag.error = "Complete todos los campos";
                return View("LogIn");
            }

        }

        [HttpPost]
        public IActionResult AgregarUsuario(string username , string password,string clave)
        {

            if (username != null && password !=null) {

               if (CaracteresPassword(password))
                {
                    if (UsuarioDAO.getInstancia().GetUser(username) != null)
                    {
                        ViewBag.error = "El usuario ya esta en uso";
                        return View("Registro");

                    }
                    else
                    {
                        if (UsuarioDAO.getInstancia().validarClave(clave))
                        {
                            UsuarioDAO.getInstancia().agregarUser(new Usuario(username, password));
                            HttpContext.Session.SetString("usuario", username);
                            return Redirect("/Home/Index");
                        }
                        else
                        {
                            ViewBag.error = "La clave ya esta en uso o es incorrecta , ingresala con los '-'";
                            return View("Registro");
                        }

                    }
                }
                else
                {
                    ViewBag.error = "La contraseña debe contener al menos 8 caracteres";
                    return View("Registro");
                }
               
                
            }
            else
            {
                ViewBag.error = "Complete todos los campos";
                return View("Registro");
            }

           

        }

        [HttpPost]
        public IActionResult ModificarUser(string username,string password1 ,string password2)
        {
            var usuarioSession = HttpContext.Session.GetString("usuario");
            if (password1 != null && password2 != null)
            {
                   
                if (CaracteresPassword(password1)) 
             
                {
                    if (compararPassword(password1, password2))
                    {
                        UsuarioDAO.getInstancia().modificarUser(username, password1);
                        HttpContext.Session.SetString("usuario", username);
                        return Redirect("/Home/Index");
                    }
                    else
                    {
                        ViewBag.error = "Las contraselas no coinciden";
                        ViewBag.usuario = usuarioSession;
                        return View("Perfil");
                    }
                }
                else
                {
                    ViewBag.error = "La contraseña debe contener al menos 8 caracteres";
                    ViewBag.usuario = usuarioSession;
                    return View("Perfil");
                }
               
               
            }
            else
            {
                ViewBag.error = "Complete todos los campos";
                ViewBag.usuario = usuarioSession;
                return View("Perfil");
            }
        }

        private Boolean compararPassword(string pass1, string pass2)
        {
            return pass1.Equals(pass2) ? true : false;

        }

        public IActionResult Logout()
        {

            HttpContext.Session.Clear();
            ViewBag.mensaje = "La Sesion se cerro correctamente";
            return Redirect("/Home/Index");

        }

        private Boolean CaracteresPassword(string password)
        {
            return password.Length >= 8 ? true : false; 
        }

        /*
        [HttpPost]
        public JsonResult BuscarUsuario([FromBody] JsonUsuario jsonUsuario)
        {
            Usuario usuario = UsuarioDAO.getInstancia().GetUsuarioById(jsonUsuario.id);
            var jsonResult = JsonConvert.SerializeObject(usuario);
            return Json(jsonResult);
        }

        */

        //METODOS API
       //LLAMADO API CON CONTRASEÑA
        [HttpGet("{username}/{password}/{claveSeguridad}")]
        public string Get(string username , string password,string claveSeguridad)
        {
            if (claveSeguridad == "MasSeguroImposible")
            {
                dynamic estado = new ExpandoObject();
                estado = UsuarioDAO.getInstancia().confirmarLogueo(username, password);
                return JsonConvert.SerializeObject(estado);
            }
            else
            {

                return JsonConvert.SerializeObject("No estas autorizado a consultar la api");
            }
           
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }


}
