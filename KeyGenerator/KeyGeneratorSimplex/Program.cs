using APIDB_Secure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyGeneratorSimplex;

namespace KeyGeneratorSimplex
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var connString = "Server=localhost;Database=parcialplataformas;Uid=root;Pwd=;";
            DBConnection.getInstance().connect(connString);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

           
        }
    }
}
