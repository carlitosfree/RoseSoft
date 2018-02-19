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
            dataGridView1_Proveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1_Proveedor.DataSource = bd.SelectDataTable("select * from Proveedor");
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
            if (comboBox1_buscar.Text.Equals("") || textBox9_Buscar.Text.Equals(""))
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
            if (comboBox1_buscar.Text.Equals("NÚMERO DE CÉDULA"))
            {
                string sql;
                sql = "SELECT * FROM Proveedor WHERE cedulaP='" + textBox9_Buscar.Text + "'";
                dataGridView1_Proveedor.DataSource = bd.SelectDataTable(sql);
            }
            else if (comboBox1_buscar.Text.Equals("NOMBRE"))
            {
                string sql;
                sql = "SELECT * FROM Proveedor WHERE nombresP='" + textBox9_Buscar.Text + "'";
                dataGridView1_Proveedor.DataSource = bd.SelectDataTable(sql);


            }
            else if (comboBox1_buscar.Text.Equals("PAÍS"))
            {
                string sql;
                sql = "SELECT * FROM Proveedor WHERE paisP='" + textBox9_Buscar.Text + "'";
                dataGridView1_Proveedor.DataSource = bd.SelectDataTable(sql);


            }
            else if (comboBox1_buscar.Text.Equals("CIUDAD"))
            {
                string sql;
                sql = "SELECT * FROM Proveedor WHERE ciudadP='" + textBox9_Buscar.Text + "'";
                dataGridView1_Proveedor.DataSource = bd.SelectDataTable(sql);


            }
        }

        private void textBox1_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1_buscar.Text.Equals("NOMBRE"))
            {

                string sql;
                //SELECT * FROM CLIENTE WHERE NOMBRE LIKE 'C%';
                sql = "SELECT * FROM Proveedor WHERE nombresP LIKE '" + textBox9_Buscar.Text + "%'";
                dataGridView1_Proveedor.DataSource = bd.SelectDataTable(sql);

            }
            else if (comboBox1_buscar.Text.Equals("NÚMERO DE CÉDULA"))
            {
                string sql;
                sql = "SELECT * FROM Proveedor WHERE cedulaP LIKE '" + textBox9_Buscar.Text + "%'";
                dataGridView1_Proveedor.DataSource = bd.SelectDataTable(sql);


            }
            else if (comboBox1_buscar.Text.Equals("PAÍS"))
            {

                string sql;
                sql = "SELECT * FROM Proveedor WHERE paisP LIKE '" + textBox9_Buscar.Text + "%'";
                dataGridView1_Proveedor.DataSource = bd.SelectDataTable(sql);


            }

            else if (comboBox1_buscar.Text.Equals("CUIDAD"))
            {
                string sql;
                sql = "SELECT * FROM Proveedor WHERE ciudadP LIKE '" + textBox9_Buscar.Text + "%'";
                dataGridView1_Proveedor.DataSource = bd.SelectDataTable(sql);


            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (comboBox1_buscar.Text.Equals("") || textBox9_Buscar.Text.Equals(""))
            {
                MessageBox.Show("Ingrese parametros de busqueda");
            }
            else
            {
                buscar();
            }
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
