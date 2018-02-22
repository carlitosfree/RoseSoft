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
    public partial class registrarProveedor : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        ValidarSoloLetrasSoloNumeros validar =new ValidarSoloLetrasSoloNumeros();
        public registrarProveedor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar.VerificarCedula(textBox1.Text) == true)
            {
                string consutar = bd.selectstring("select Cedula from PROVEEDPOR  WHERE ruc =" + textBox1.Text + "");
                string agregar = "INSERT INTO ClienteJ (cedulaP, nombresP,paisP, ciudadP,direccioP, telefonoP, emailP,cantidadProductoN,cantidadProductoI ) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text +  "')";

                if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") ||
               textBox4.Text.Equals("") || textBox5.Text.Equals("") || textBox6.Text.Equals("") || textBox7.Text.Equals("") )
                {
                    MessageBox.Show("Error uno o mas campos vacios");
                }

                else
                {
                    if (consutar == textBox1.Text)
                    {

                        MessageBox.Show("DATOS YA REGISTRADOS");
                    }
                    else
                    {
                        if (bd.executecommand(agregar))
                        {

                            string strDate = DateTime.Now.ToString("yyyy-MM-dd");
                            MessageBox.Show("Registrado");
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox5.Text = "";
                            textBox6.Text = "";
                            textBox7.Text = "";
                           
                            string nuevo = bd.selectstring(" INSERT INTO PROVEEDORNUEVO (fechaEmision) VALUES  ('" + strDate + "')");


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
;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (validar.VerificarCedula(textBox1.Text) == true) { 
           
            string consultarLocalidad = bd.selectstring("SELECT LOCALIDADID FROM LOCALIDAD WHERE PAIS=" + textBox3 + "AND CIUDAD=" + textBox4 + ";");
            string consultarCedula = bd.selectstring("SELECT CEDULAP FROM PROVEEDOR WHERE CEDULAP="+textBox1+";");
            string registrar = "INSERT INTO PROVEEDOR (CEDULAP, LOCALIDAID, NOMBREP, DIRECCIONP,NUMEROTELEFONOP,EMAILP)VALUES ("+textBox1+  "," + textBox2+ "','" + textBox5+ "','" + textBox6+ "','"+textBox7+"')";
                if (textBox1.Equals("") || textBox2.Equals("") || textBox3.Equals("") || textBox4.Equals("") ||
                    textBox5.Equals("") || textBox6.Equals("") || textBox7.Equals("")) 
                {
                    MessageBox.Show("Error uno o mas campos vacios");
                }

                else
                {
                    if (consultarCedula == textBox1.Text)
                    {

                        MessageBox.Show("DATOS YA REGISTRADOS");
                    }
                    else
                    {
                        if (bd.executecommand(registrar))
                        {


                            MessageBox.Show("Registrado");
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox5.Text = "";
                            textBox6.Text = "";
                            textBox7.Text = "";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 10;
            if (textBox1.TextLength == 10)
            {
                if (validar.VerificarCedula(textBox1.Text) == true)
                {


                }
                else
                {
                    MessageBox.Show("Cédula de identidad no válida");
                    textBox1.Text = "";
                }

            }

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void textBox1_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void registrarProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
