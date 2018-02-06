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
    public partial class registrarProducto : Form
    {
        ValidarSoloLetrasSoloNumeros v = new ValidarSoloLetrasSoloNumeros();
        public registrarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { MessageBox.Show("Producto agregado");

            textBox1.Text = "";
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            dateTimePicker1.Text = "";

            /* INSERT INTO producto(numBonche, variedad, tamanoTallo, tallosBonche, stock, fechaIngreso, mercado)
             VALUES( textBox1.Text, textBox2.Text,  comboBox1.Text, comboBox2.Text,  textBox3.Text,  dateTimePicker1.Text, comboBox3.Text);*/


            //SELECT * FROM producto

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            dateTimePicker1.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
