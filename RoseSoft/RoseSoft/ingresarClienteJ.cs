using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoseSoft
{
    public partial class ingresarClienteJ : Form
    {
        public ingresarClienteJ()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();
        ValidarSoloLetrasSoloNumeros validar = new ValidarSoloLetrasSoloNumeros();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar.verificarRuc(txtIdentificacion.Text) == true)
            {
                string consutar = bd.selectstring("select Cedula from ClienteJ WHERE Cedula =" + txtIdentificacion.Text + "");
                string agregar = "INSERT INTO ClienteJ (ruc, nombreEmpresa,rasonSocial,paisCJ,ciudadCJ, direccionCJ,telefonoCJ,emailCJ ) VALUES ('" + txtIdentificacion.Text + "','" + txtNombre.Text + "','" + txtApellidos.Text + "','" + txtPais.Text + "','" + txtCiudad.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "','" + txtEmail.Text + "')";

                if (txtNombre.Text.Equals("") || txtIdentificacion.Text.Equals("") || txtEmail.Text.Equals("") ||
                txtApellidos.Text.Equals("") || txtPais.Text.Equals("") || txtCiudad.Text.Equals("") || txtDireccion.Text.Equals("") || txtTelefono.Text.Equals(""))
                {
                    MessageBox.Show("Error uno o mas campos vacios");
                }

                else
                {
                    if (consutar == txtIdentificacion.Text)
                    {

                        MessageBox.Show("DATOS YA REGISTRADOS");
                    }
                    else
                    {
                        if (bd.executecommand(agregar))
                        {

                            string strDate = DateTime.Now.ToString("yyyy-MM-dd");
                            MessageBox.Show("Registrado");
                            txtIdentificacion.Text = "";
                            txtApellidos.Text = "";
                            txtNombre.Text = "";
                            txtCiudad.Text = "";
                            txtDireccion.Text = "";
                            txtPais.Text = "";
                            txtTelefono.Text = "";
                            txtEmail.Text = "";
                            string nuevo = bd.selectstring(" INSERT INTO CLIENTENUEVO (fechaEmision) VALUES  ('" + strDate + "')");


                        }
                        else
                        {

                            MessageBox.Show("Error al agregar");

                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("cedula de identidad no valida");
            }

            
        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text = "";
            txtApellidos.Text = "";
            txtNombre.Text = "";
            txtCiudad.Text = "";
            txtDireccion.Text = "";
            txtPais.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(79, 55);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(73, 49);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(79, 55);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(73, 49);
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(79, 55);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(73, 49);
        }

        private void txtIdentificacion_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
