using PaginaWeb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyGeneratorSimplex;
using MySql.Data.MySqlClient;
using APIDB_Secure;

namespace KeyGeneratorSimplex
{
    public partial class Form1 : Form
    {
        
        string caracteres = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789";

        
        public Form1()
        {
            InitializeComponent();
        }
        private String[] generar(int cantidad)
        {
            Random rd = new Random();
            string[] keyarray = new string[cantidad];
         
            for (int j = 0; j <cantidad; j++)
            {
                string key = "";
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
               if (Controller.getInstancia().verificarExist(key) != null)
                {
                   var keyexiste=generar(1);
                    key = keyexiste[0];
                }
                   
                    keyarray[j] = key;
                
                
            }
            return keyarray;
        }

      
    

    private void buttonGenerar_Click(object sender, EventArgs e)
        {
           
            int cantidad = 0;
            if(textBoxCantidad.Text.Length ==0)
            {
                MessageBox.Show("Ingrese la cantidad", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Int32.TryParse(textBoxCantidad.Text, out cantidad)==true)
                {
                    var keysgeneradas = generar(cantidad);
                    Controller.getInstancia().agregarKey(keysgeneradas);
                    MessageBox.Show("Se ejecuto con exito", "Generador de keys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se aceptan letras , solo numeros", "Caracteres invalidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }

            
            
          



        }
    }
}
