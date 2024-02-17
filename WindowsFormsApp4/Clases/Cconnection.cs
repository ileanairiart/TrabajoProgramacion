using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.Clases
{
    internal class Cconnection
    {
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string db = "Tpprogramacion";
        static string usuario = "root";
        static string contraseña = "beppolevi";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + contraseña + ";" + "database=" + db + ";";
           
        public MySqlConnection establecerconexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                //MessageBox.Show("Se conectó la base de datos");

            }
            catch (Exception ex) 
            {
                MessageBox.Show("No se conectó a la base de datos, error : " + ex.ToString());
            }

            return conex;

        }
        public void cerrarconexion()
        {
            conex.Close();
        }
       
    }
}
