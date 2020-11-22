using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDB_Secure;


namespace PaginaWeb
{
    public class Controller
    {
        public static Controller instancia = null;
        string caracteres = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789";
        //public List<Usuario> usuarios = new List<Usuario>();

        private Controller() { }

        private String[] generar(int cantidad)
        {
            Random rd = new Random();
            string [] keyarray = new string [cantidad];
            string key="";

            for (int j = 0; j < cantidad; j++)
            {
            for (int i = 0; i < 24; i++)
            {
                if (i == 4 || i == 9 || i == 14 || i == 19)
                {
                    key = key + "-";
                }
                else
                {
                    int num = rd.Next(caracteres.Length);
                    key = key + this.caracteres.ElementAt(num);
                }


            }

                keyarray[j] = key;
            }
            return keyarray;
        }
      

        
        public static Controller getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Controller();
            }
            return instancia;
        }


        public void agregarKey(Array keysgeneradas)
        {
            foreach (string key in keysgeneradas)
            {

                var queryBuilder = DBConnection.getInstance().getQueryBuilder();

                queryBuilder.setQuery("INSERT INTO claves (clave,estado) VALUES (@clave,'nueva')");
                queryBuilder.addParam("@clave", key);


                DBConnection.getInstance().abm(queryBuilder);
            }



        }

    
        public string verificarExist(string key)
        {

            var queryBuilder = DBConnection.getInstance().getQueryBuilder();

            queryBuilder.setQuery("select clave from claves where clave=@clave");
            queryBuilder.addParam("@clave", key);

            var dataReader = DBConnection.getInstance().select(queryBuilder);
            key= null;
            while (dataReader.Read())
            {
               key = (dataReader.GetString(0));
            }

            return key;
           
        }

    }

    }
