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
    public partial class Buscar_Producto : Form
    {
        public Buscar_Producto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //nombre, numCedula, provincia,ciudad
            
            if (comboBox1_Buscar.Text == "NOMBRE") { MessageBox.Show("nombre");
                /*
                                SELECT numBonche, variedad, tamTallo, tallBonch, stock, fechaIngreso, mercado
                FROM producto 
                WHERE numBonche = textBox1_Buscar.Text*/

            }
            else if (comboBox1_Buscar.Text == "NÚMERO DE CÉDULA") { MessageBox.Show("numcedula");

                /*
                                 SELECT numBonche, variedad, tamTallo, tallBonch, stock, fechaIngreso, mercado
                FROM variedad 
                WHERE variedad = textBox1_Buscar.Text*/


            }
            else if (comboBox1_Buscar.Text == "PROVINCIA") { MessageBox.Show("provincia");
                /*
                 SELECT numBonche, variedad, tamTallo, tallBonch, stock, fechaIngreso, mercado
                FROM tamTallo
                WHERE tamTallo = textBox1_Buscar.Text*/



            }
            else { MessageBox.Show("ciudad");

                /*
                 SELECT numBonche, variedad, tamTallo, tallBonch, stock, fechaIngreso, mercado
                FROM stock
                WHERE stock = textBox1_Buscar.Text*/


            }

           

        }
    }
}
