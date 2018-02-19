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
    public partial class registrarCliente : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        ValidarSoloLetrasSoloNumeros validar = new ValidarSoloLetrasSoloNumeros();
        public registrarCliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void registrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtIdentificacion.MaxLength = 10;
            if (txtIdentificacion.TextLength == 10) { 
            if (validar.VerificarCedula(txtIdentificacion.Text) == true)
            {


            }
            else
            {
                MessageBox.Show("Cédula de identidad no válida");
                    txtIdentificacion.Text = "";
            }

        }
        }

        private void txtIdentificacion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtNacionalidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(79,55);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(73,49);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (validar.VerificarCedula(txtIdentificacion.Text) == true)
            {
                string idCliente = bd.selectstring("SELECT CLIENTEID FROM CLIENTE WHERE CLIENTEID = (SELECT MAX(CLIENTEID) from CLIENTE);");
               
                if (idCliente == null)
                {
                    idCliente = "1";
                    
                }
                else
                {
                    int idcli = Int32.Parse(idCliente);
                    idcli = idcli + 1;
                    idCliente = idcli.ToString();
                    
                }
                
             

                string consutar = bd.selectstring("select cedula from CLIENTEN WHERE cedula =" + txtIdentificacion.Text + "");
                string agregar = "INSERT INTO CLIENTEN (cedula, nombres, apellidos, nacionalidad, paisCN, ciudadCN, direccionCN, telefonoCN, emailCN ) VALUES ('" + txtIdentificacion.Text + "','" + txtNombre.Text + "','" + txtApellidos.Text + "','" + txtPais.Text + "','" + txtCiudad.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "','" + txtEmail.Text + "')";

                if (txtNombre.Text.Equals("") || txtIdentificacion.Text.Equals("") ||  txtEmail.Text.Equals("") ||
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

                            
                            MessageBox.Show("Registrado");
                            txtIdentificacion.Text = "";
                            txtApellidos.Text = "";
                            txtNombre.Text = "";
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
                MessageBox.Show("Cédula de identidad no válida");
            }
        }
    }
}
