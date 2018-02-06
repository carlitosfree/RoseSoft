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
    public partial class Buscar_Proveedor : Form
    {
        public Buscar_Proveedor()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();
        private void Buscar_Proveedor_Load(object sender, EventArgs e)
        {
            
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (comboBox1_Buscar.Text == "NOMBRE")
            {
                MessageBox.Show("nombre");
                /*
                                SELECT * from proveedor
                WHERE nombre = textBox1_Buscar.Text*/

            }
            else if (comboBox1_Buscar.Text == "NÚMERO DE CÉDULA")
            {
                MessageBox.Show("numcedula");
                /*
                SELECT * from proveedor
              WHERE numCedula = textBox1_Buscar.Text */
              

            }
            else if (comboBox1_Buscar.Text == "PROVINCIA")
            {
                MessageBox.Show("provincia");


                /*
               SELECT * from proveedor
             WHERE provincia = textBox1_Buscar.Text */



            }
            else
            {
                MessageBox.Show("ciudad");

                /*
                SELECT * from proveedor
              WHERE ciudad = textBox1_Buscar.Text */


            }



        }
    }
}
