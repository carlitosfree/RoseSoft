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
    public partial class busquedaCliente : Form
    {
        public busquedaCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1_Buscar.Text == "NOMBRE")
            {
                MessageBox.Show("nombres");
                /*
                                SELECT * from CLIENTE
                WHERE nombre = textBox1_Buscar.Text*/

            }
            else if (comboBox1_Buscar.Text == "NÚMERO DE CÉDULA")
            {
                MessageBox.Show("numcedula");
                /*
                SELECT * from cliente
              WHERE numIdentificacion = textBox1_Buscar.Text */

           
            }
            else if (comboBox1_Buscar.Text == "PROVINCIA")
            {
                MessageBox.Show("provincia");


                /*
               SELECT * from cliente
             WHERE nacionalidad = textBox1_Buscar.Text */



            }
            else
            {
                MessageBox.Show("ciudad");

                /*
                SELECT * from cliente
              WHERE apellidos = textBox1_Buscar.Text */


            }

        }
    }
}
