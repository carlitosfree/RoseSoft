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
        BaseDeDatos bd = new BaseDeDatos();
        public registrarProducto()
        {
            InitializeComponent();
            
            string sql;
            comboBox3.ValueMember = "NOMBREM";
            sql = "SELECT NOMBREM FROM MERCADO ORDER BY NOMBREM";
            comboBox3.DataSource = bd.SelectDataTable(sql);

            string sql1;

            comboBox2.ValueMember = "NOMBRETB";
            sql1 = "SELECT NOMBRETB FROM TALLOBONCHE";

            comboBox2.DataSource = bd.SelectDataTable(sql1);
            string sql2;

            comboBox1.ValueMember = "TAMANIOTALLOID";
            sql2 = "SELECT NOMBRETT FROM TAMANIOTALLO";

            comboBox1.DataSource = bd.SelectDataTable(sql2);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            MessageBox.Show("Producto agregado");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
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
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
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
           
                string consutar = bd.selectstring("select NUMEROBONCHE from PRODUCTO WHERE NUMEROBONCHE =" +
                    textBox1.Text + "");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
