using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Clases.Calumnos objetoAlumnos = new Clases.Calumnos();
            objetoAlumnos.mostrarAlumnos(listaAlumnos);
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtnombre.Text = "Nombre";
            txtnombre.ForeColor = Color.Gray;
            txtapellido.Text = "Apellido";
            txtapellido.ForeColor = Color.Gray;
            txtcarrera.Text = "Carrera";
            txtcarrera.ForeColor = Color.Gray;
            txtcorreo.Text = "Correo electrónico";
            txtcorreo.ForeColor = Color.Gray;
            txtedad.Text = "Edad";
            txtedad.ForeColor = Color.Gray;
            txtaño.Text = "Año carrera";
            txtaño.ForeColor = Color.Gray;
            txtid.Text = "ID";
            txtid.ForeColor = Color.Gray;
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void listaAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Calumnos objetoalumnos = new Clases.Calumnos();
            objetoalumnos.seleccionaralumnos(listaAlumnos, txtid, txtnombre,
                txtapellido, txtedad, txtcorreo, txtcarrera, txtaño);
        }
        //botones
        private void btninscribir_Click(object sender, EventArgs e)
        {
            string nombre, apellido, carrera, correo;


            nombre = this.txtnombre.Text;
            apellido = this.txtapellido.Text;
            carrera = this.txtcarrera.Text;
            correo = this.txtcorreo.Text;

            //validacion de datos
            if (!int.TryParse(this.txtaño.Text, out int año))
            {

                MessageBox.Show("Ingrese un año de carrera válido");
                return;
            }
            else
            {
                if (año > 3 || año < 1)
                {
                    MessageBox.Show("Ingrese un año de carrera válido");
                    return;
                }
            }

            if (!int.TryParse(this.txtedad.Text, out int edad))
            {
                MessageBox.Show("Ingrese una edad válida");
                return;
            }
            else
            {
                if (edad < 18)
                {
                    MessageBox.Show("Ingrese una edad válida");
                    return;
                }
            }

            if (nombre == "" || nombre == "Nombre")
            {
                MessageBox.Show("Ingrese nombre");
                return;
            }
            else
            {
                
            }

            if (apellido == "" || apellido == "Apellido")
            {
                MessageBox.Show("Ingrese apellido");
                return;
            }
           

            if (correo == "" || correo == "Correo")
            {
                MessageBox.Show("Ingrese correo");
                return;
            }
            else
            {
                if (CorreoValido(correo))
                {
                    
                }
                else
                {
                    MessageBox.Show("Ingrese un correo electrónico válido");
                    return;
                }
            }
            

            if (carrera == "" || carrera == "Carrera")
            {
                MessageBox.Show("Ingrese carrera");
                return;
            }
            LimpiarFormulario();

            Clases.Calumnos objetoAlumnos = new Clases.Calumnos();
            objetoAlumnos.guardaralumnos(txtnombre, txtapellido, txtedad, txtcorreo, txtcarrera, txtaño);
            objetoAlumnos.mostrarAlumnos(listaAlumnos);
        }
        
        private bool CorreoValido(string correo)
        {
            
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(correo);
        }
        private bool ContieneSoloLetras( string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;

            
        }

        private void LimpiarFormulario()//sirve
        {
            this.txtnombre.Text = "Nombre";
            this.txtapellido.Text = "Apellido";
            this.txtcarrera.Text = "Carrera";
            this.txtcorreo.Text = "Correo";
            this.txtaño.Text = "Año";
            this.txtedad.Text = "Edad";
            this.txtid.Text = "Id";

        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Clases.Calumnos objetoAlumnos = new Clases.Calumnos();
            objetoAlumnos.modificaralumnos(txtid, txtnombre, txtapellido, txtedad,
                txtcorreo, txtcarrera, txtaño);
            objetoAlumnos.mostrarAlumnos(listaAlumnos);
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            Clases.Calumnos objetoAlumnos = new Clases.Calumnos();
            objetoAlumnos.eliminaralumnos(txtid);
            objetoAlumnos.mostrarAlumnos(listaAlumnos);
        } 
       
        //placeholdertextbox
        private void txtnombre_Enter(object sender, EventArgs e)
        {
            if (txtnombre.Text == "Nombre")
            {
                txtnombre.Text = "";
                txtnombre.ForeColor = Color.Black;
            }
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                txtnombre.Text = "Nombre";
                txtnombre.ForeColor = Color.Gray;
            }
        }


        private void txtapellido_Enter(object sender, EventArgs e)
        {
            if (txtapellido.Text == "Apellido")
            {
                txtapellido.Text = "";
                txtapellido.ForeColor = Color.Black;
            }
        }
        private void txtapellido_Leave(object sender, EventArgs e)
        {
            if (txtapellido.Text == "")
            {
                txtapellido.Text = "Apellido";
                txtapellido.ForeColor = Color.Gray;
            }
        }
        private void txtedad_Enter(object sender, EventArgs e)
        {
            if (txtedad.Text == "Edad")
            {
                txtedad.Text = "";
                txtedad.ForeColor = Color.Black;
            }
        }

        private void txtedad_Leave(object sender, EventArgs e)
        {
            if (txtedad.Text == "")
            {
                txtedad.Text = "Edad";
                txtedad.ForeColor = Color.Gray;
            }
        }

        private void txtcorreo_Enter(object sender, EventArgs e)
        {
            if (txtcorreo.Text == "Correo electrónico")
            {
                txtcorreo.Text = "";
                txtcorreo.ForeColor = Color.Black;
            }
        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            if (txtcorreo.Text == "")
            {
                txtcorreo.Text = "Correo electrónico";
                txtcorreo.ForeColor = Color.Gray;
            }
        }

        private void txtcarrera_Enter(object sender, EventArgs e)
        {
            if (txtcarrera.Text == "Carrera")
            {
                txtcarrera.Text = "";
                txtcarrera.ForeColor = Color.Black;
            }
        }

        private void txtcarrera_Leave(object sender, EventArgs e)
        {
            if (txtcarrera.Text == "")
            {
                txtcarrera.Text = "Carrera";
                txtcarrera.ForeColor = Color.Gray;
            }
        }

        private void txtaño_Enter(object sender, EventArgs e)
        {
            if (txtaño.Text == "Año carrera")
            {
                txtaño.Text = "";
                txtaño.ForeColor = Color.Black;
            }
        }

        private void txtaño_Leave(object sender, EventArgs e)
        {
            if (txtaño.Text == "")
            {
                txtaño.Text = "Año carrera";
                txtaño.ForeColor = Color.Gray;
            }
        }
        private void txtid_Enter(object sender, EventArgs e)
        {
            if (txtid.Text == "ID")
            {
                txtid.Text = "";
                txtid.ForeColor = Color.Black;
            }
        }

        private void txtid_Leave(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                txtid.Text = "ID";
                txtid.ForeColor = Color.Gray;
            }
        }
        //finplaceholder
        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
        //validaciones de textbox
        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtcarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }*/
        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
