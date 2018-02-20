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
        BaseDeDatos bd = new BaseDeDatos();
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
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
                sql = "SELECT * FROM PERSONANATURAL WHERE CEDULACN='" + textBox1_Buscar.Text + "'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);
            }
            else if (comboBox1_Buscar.Text.Equals("NOMBRE"))
            {
                string sql;
                sql = "SELECT * FROM PERSONANATURAL WHERE NOMBRESCN='" + textBox1_Buscar.Text + "'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }
            else if (comboBox1_Buscar.Text.Equals("PAÍS"))
            {
                string sql;
                sql = "SELECT * FROM PERSONANATURAL WHERE PAISCN='" + textBox1_Buscar.Text + "'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }
            else if (comboBox1_Buscar.Text.Equals("CIUDAD"))
            {
                string sql;
                sql = "SELECT * FROM PERSONANATURAL WHERE CIUDADCN='" + textBox1_Buscar.Text + "'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }
        }

        private void busquedaCliente_Load(object sender, EventArgs e)
        {
            dataGridView1_Cliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1_Cliente.DataSource = bd.SelectDataTable("select * from PERSONANATURAL");
        }

        private void textBox1_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1_Buscar.Text.Equals("NOMBRE"))
            {

                string sql;
                //SELECT * FROM CLIENTE WHERE NOMBRE LIKE 'C%';
                sql = "SELECT * FROM PERSONANATURAL WHERE NOMBRESCN LIKE '" + textBox1_Buscar.Text + "%'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);

            }
            else if (comboBox1_Buscar.Text.Equals("NÚMERO DE CÉDULA"))
            {
                string sql;
                sql = "SELECT * FROM PERSONANATURAL WHERE CEDULACN LIKE '" + textBox1_Buscar.Text + "%'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }
            else if (comboBox1_Buscar.Text.Equals("PAÍS"))
            {

                string sql;
                sql = "SELECT * FROM PERSONANATURAL WHERE paisCN LIKE '" + textBox1_Buscar.Text + "%'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }

            else if (comboBox1_Buscar.Text.Equals("CUIDAD"))
            {
                string sql;
                sql = "SELECT * FROM PERSONANATURAL WHERE ciudadCN LIKE '" + textBox1_Buscar.Text + "%'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
    }
}
