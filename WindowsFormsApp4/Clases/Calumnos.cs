using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.Clases
{
    internal class Calumnos
    {
        public void mostrarAlumnos(DataGridView listaAlumnos)
        {
            String query = "select * from formulario";
            try
            {
                Cconnection objetoConexion = new Cconnection();
                listaAlumnos.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter
                    (query, objetoConexion.establecerconexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                listaAlumnos.DataSource = dt;
                objetoConexion.cerrarconexion();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron los datos, error: " + ex.ToString());

            }

        }
        public void guardaralumnos(TextBox nombre, TextBox apellido, TextBox edad,
      TextBox correo, TextBox carrera, TextBox año)
        {
            try
            {
                Cconnection objetoconexion = new Cconnection();

                String query = ("insert into formulario (nombre,apellido,edad,correo,carrera,año)"
                    + "values('" + nombre.Text + "' , '" + apellido.Text + "' , '" + edad.Text +
                     "' , '" + correo.Text + "' , '" + carrera.Text + "' , '" + año.Text + "')");
                MySqlCommand myComand = new MySqlCommand(query, objetoconexion.establecerconexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se guardaron los registros correctamente");
                while (reader.Read())
                {

                }
                objetoconexion.cerrarconexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los registros, error: " + ex.ToString());

            }

        }


        public void seleccionaralumnos(DataGridView listaalumnos, TextBox id, TextBox nombre, TextBox apellido, TextBox edad,
             TextBox correo, TextBox carrera, TextBox año)
        {
            try
            {
                id.Text = listaalumnos.CurrentRow.Cells[0].Value.ToString();
                nombre.Text = listaalumnos.CurrentRow.Cells[1].Value.ToString();
                apellido.Text = listaalumnos.CurrentRow.Cells[2].Value.ToString();
                edad.Text = listaalumnos.CurrentRow.Cells[3].Value.ToString();
                correo.Text = listaalumnos.CurrentRow.Cells[4].Value.ToString();
                carrera.Text = listaalumnos.CurrentRow.Cells[5].Value.ToString();
                año.Text = listaalumnos.CurrentRow.Cells[6].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró seleccionar, error: " + ex.ToString());

            }

        }

        public void modificaralumnos(TextBox id,TextBox nombre, TextBox apellido, TextBox edad,
             TextBox correo, TextBox carrera, TextBox año)
        {
            try
            {
                Cconnection objetoconexion = new Cconnection();

                String query = ("update formulario set nombre='" + nombre.Text +
                    "', apellido='" + apellido.Text + "', edad='" + edad.Text +
                    "',  correo='" + correo.Text + "', carrera='" + carrera.Text +
                    "', año='" + año.Text + "' where id='" + id.Text + "';" );
                MySqlCommand myComand = new MySqlCommand(query, objetoconexion.establecerconexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se modificaron los registros correctamente");
                while (reader.Read())
                {

                }
                objetoconexion.cerrarconexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se modificaron los registros, error: " + ex.ToString());

            }
        }

        public void eliminaralumnos(TextBox id)
        {
            try
            {
                Cconnection objetoconexion = new Cconnection();

                String query = "delete from formulario where id= '" + id.Text + "';";

                MySqlCommand myComand = new MySqlCommand(query, objetoconexion.establecerconexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se eliminaron los registros correctamente");
                while (reader.Read())
                {

                }
                objetoconexion.cerrarconexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se eliminaron los registros, error: " + ex.ToString());

            }
        }

        
    }

   


}





    

