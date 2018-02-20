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
    public partial class tiposDeCaja : Form
    {


        BaseDeDatos bd = new BaseDeDatos();
        ValidarSoloLetrasSoloNumeros validar = new ValidarSoloLetrasSoloNumeros();



        public tiposDeCaja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string agregar = "INSERT INTO TamanioTallo (nombreTT) VALUES ('" + textBox1.Text + "')";

            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Error uno o mas campos vacios");
            }

            else
            {
                /* if (consutar == txtIdentificacion.Text)
                 {

                     MessageBox.Show("DATOS YA REGISTRADOS");
                 }
                 else*/
                {
                    if (bd.executecommand(agregar))
                    {

                        string strDate = DateTime.Now.ToString("yyyy-MM-dd");
                        MessageBox.Show("Registrado");
                        textBox1.Text = "";


                        //string nuevo = bd.selectstring(" INSERT INTO CLIENTENUEVO (fechaEmision) VALUES  ('" + strDate + "')");


                    }
                    else
                    {

                        MessageBox.Show("Error al agregar");

                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
