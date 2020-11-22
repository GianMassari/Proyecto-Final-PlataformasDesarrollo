using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDB_Secure;
using PaginaWeb.Models;

namespace PaginaWeb
{
    public class UsuarioDAO
    {
        public static UsuarioDAO instancia = null;
        //public List<Usuario> usuarios = new List<Usuario>();

        private UsuarioDAO() { }

        //INSTANCIA DE USUARIOSDAO
        public static UsuarioDAO getInstancia()
        {
            if (instancia == null)
            {
                instancia = new UsuarioDAO();
            }
            return instancia;
        }


        //CHECK USUARIO CONTRASEÑA
        public Boolean confirmarLogueo(string username , string password)
        {

            var objUsuario = GetUser(username);
            if (objUsuario != null)
            {
                if (objUsuario.usuario == username && objUsuario.password == password)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }else{
                return false;
            }
           
        }

/*
        //REMOVE
        public Boolean remove(string username, string password)
        {
            var objUsuario = usuarios.Find(usuarioObj => usuarioObj.usuario == username && usuarioObj.password == password);
            if (objUsuario == null)
            {
                return false;

            }
            else
            {
                return true;
            }
        }
*/
       
        //METODOS PARA CONFIRMAR USUARIO
        //METODOS BD
        public Usuario GetUser(string username)
        {
            var queryBuilder = DBConnection.getInstance().getQueryBuilder();

            queryBuilder.setQuery("SELECT * FROM user WHERE username=@username");
            queryBuilder.addParam("@username", username);

            var dataReader = DBConnection.getInstance().select(queryBuilder);
            Usuario usuario = null;
            while (dataReader.Read())
            {
                usuario = new Usuario(dataReader.GetString(1), dataReader.GetString(2));
            }

            return usuario;
        }

        public Boolean validarClave(string clave)
        {
            var queryBuilder = DBConnection.getInstance().getQueryBuilder();

            queryBuilder.setQuery("SELECT * FROM claves WHERE clave=@clave");
            queryBuilder.addParam("@clave", clave);

            var dataReader = DBConnection.getInstance().select(queryBuilder);
            String claveEncontrada = null;
            String estado = null;
            while (dataReader.Read())
            {
                claveEncontrada = dataReader.GetString(1);
                estado = dataReader.GetString(2);
            }
            if (claveEncontrada !=null && estado == "nueva")
            {
                usarClave(claveEncontrada);
                return true;
               
            }else{
                return false;
            }

            
        }

        public void usarClave(string clave)
        {

            var queryBuilder = DBConnection.getInstance().getQueryBuilder();

            queryBuilder.setQuery("UPDATE claves SET estado='usada' WHERE clave=@clave");
            queryBuilder.addParam("@clave", clave);
            DBConnection.getInstance().abm(queryBuilder);

        }

        public void agregarUser(Usuario user)
        {

            var queryBuilder = DBConnection.getInstance().getQueryBuilder();

            queryBuilder.setQuery("INSERT INTO user (username,password) VALUES (@username,@password)");
            queryBuilder.addParam("@username", user.usuario);
            queryBuilder.addParam("@password", user.password);

            DBConnection.getInstance().abm(queryBuilder);

        }

        public void eliminarUser(Usuario user)
        {
      
            var queryBuilder = DBConnection.getInstance().getQueryBuilder();

            queryBuilder.setQuery("DELETE FROM user WHERE username=@username");
            queryBuilder.addParam("@username", user.usuario);

            DBConnection.getInstance().abm(queryBuilder);

        }

        //SOBRECARGA    
        public void eliminarUser(string username)
        {
          
            var queryBuilder = DBConnection.getInstance().getQueryBuilder();
            queryBuilder.setQuery("DELETE FROM user WHERE username=@username");
            queryBuilder.addParam("@username", username);

            DBConnection.getInstance().abm(queryBuilder);

        }
        //MODIFICAR
        public void modificarUser(string username , string password)
        {
         
            var queryBuilder = DBConnection.getInstance().getQueryBuilder();

            queryBuilder.setQuery("UPDATE user SET password=@password WHERE username=@username");
            queryBuilder.addParam("@username", username);
            queryBuilder.addParam("@password", password);

            DBConnection.getInstance().abm(queryBuilder);


        }


    }

    }
