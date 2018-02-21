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
                string agregar = "INSERT INTO ClienteJ (ruc, nombreEmpresa,rasonSocial,paisCJ,ciudadCJ, direccionCJ,telefonoCJ,emailCJ ) VALUES ('" + txtIdentificacion.Text + "','" + txtApellidos.Text + "','" + txtApellidos.Text + "','" + txtPais.Text + "','" + txtCiudad.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "','" + txtEmail.Text + "')";

                if (txtApellidos.Text.Equals("") || txtIdentificacion.Text.Equals("") || txtEmail.Text.Equals("") ||
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text = "";
            txtApellidos.Text = "";
            txtCiudad.Text = "";
            txtDireccion.Text = "";
            txtPais.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string cadena = txtIdentificacion.Text;
            int sitioDeCorte = 10;
            string parte1 = cadena.Substring(0, sitioDeCorte);
            if (validar.VerificarCedula(parte1) == true)
            {
                string consutar = bd.selectstring("select CEDULACN from PERSONJURIDICA WHERE RUCCJ =" + txtIdentificacion.Text + "");
                string agregar = "INSERT INTO PERSONAJURIDICA (RUCCJ, RAZONSOCIALCJ, NUMEROTELEFONOCJ,EMAILCJ,DIRECCIONCJ, CIUDADCJ, PAISCJ) VALUES " +
                " (" + txtIdentificacion.Text + ",'" +
                txtApellidos.Text + "','" + txtTelefono.Text +
                "','" + txtEmail.Text + "','" + txtDireccion.Text + "','" + txtCiudad.Text + "','" + txtPais.Text + "')";
              //  MessageBox.Show(agregar);
                if (txtIdentificacion.Text.Equals("") || txtEmail.Text.Equals("") ||
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
                        //MessageBox.Show(bd.executecommand(agregar) + "..");
                        if (bd.executecommand(agregar))
                        {
                            MessageBox.Show("Registrado");
                            txtIdentificacion.Text = "";
                            txtApellidos.Text = "";
                            txtCiudad.Text = "";
                            txtDireccion.Text = "";
                            txtPais.Text = "";
                            txtTelefono.Text = "";
                            txtEmail.Text = "";
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
                MessageBox.Show("RUC no válido");
            }
        }

        private void txtIdentificacion_Leave(object sender, EventArgs e)
        {
            string cadena = txtIdentificacion.Text;
            if (txtIdentificacion.TextLength == 13)
            {
                String aux = cadena.Substring(10, 3);
                string parte1 = cadena.Substring(0, 10);
                if (txtIdentificacion.TextLength != 13 || aux.Length != 3 || !aux.Contains("001") || !validar.VerificarCedula(parte1))
                {
                    MessageBox.Show("RUC no válido");
                }
            }
            else
            {
                MessageBox.Show("Faltan dígitos del RUC");
                txtIdentificacion.Text = "";
            }
        }

        private void txtIdentificacion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtPais_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtCiudad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtTelefono_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
