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
        BaseDeDatos bd = new BaseDeDatos();
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_Buscar_TextChanged(object sender, EventArgs e)
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
            if (comboBox1_Buscar.Text.Equals("") || textBox1_Buscar.Text.Equals(""))
            {
                MessageBox.Show("Ingrese parametros de busqueda");
            }
            else
            {
                buscar();
            }
        }
        public void buscar()
        {
            if (comboBox1_Buscar.Text.Equals("NÚMERO DE CÉDULA"))
            {
                string sql;
                sql = "SELECT * FROM Proveedor WHERE cedulaP='" + textBox1_Buscar.Text + "'";
                dataGridView1_Producto.DataSource = bd.SelectDataTable(sql);
            }
            else if (comboBox1_Buscar.Text.Equals("NOMBRE"))
            {
                string sql;
                sql = "SELECT * FROM Proveedor WHERE nombresP='" + textBox1_Buscar.Text + "'";
                dataGridView1_Producto.DataSource = bd.SelectDataTable(sql);


            }
            else if (comboBox1_Buscar.Text.Equals("PAÍS"))
            {
                string sql;
                sql = "SELECT * FROM Proveedor WHERE paisP='" + textBox1_Buscar.Text + "'";
                dataGridView1_Producto.DataSource = bd.SelectDataTable(sql);


            }
            else if (comboBox1_Buscar.Text.Equals("CIUDAD"))
            {
                string sql;
                sql = "SELECT * FROM Proveedor WHERE ciudadP='" + textBox1_Buscar.Text + "'";
                dataGridView1_Producto.DataSource = bd.SelectDataTable(sql);


            }
        }
    }
}
