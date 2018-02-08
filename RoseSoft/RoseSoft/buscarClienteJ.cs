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
    public partial class buscarClienteJ : Form
    {
        public buscarClienteJ()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();
        
        
        public void buscar()
        {
            if (comboBox1_Buscar.Text.Equals("RUC"))
            {
                string sql;
                sql = "SELECT * FROM CLienteJ WHERE ruc='" + textBox1_Buscar.Text + "'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);
            }
            else if (comboBox1_Buscar.Text.Equals("NOMBRE"))
            {
                string sql;
                sql = "SELECT * FROM CLienteJ WHERE nombres='" + textBox1_Buscar.Text + "'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }
            else if (comboBox1_Buscar.Text.Equals("PAÍS"))
            {
                string sql;
                sql = "SELECT * FROM CLientJ WHERE paisCJ='" + textBox1_Buscar.Text + "'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }
            else if (comboBox1_Buscar.Text.Equals("CIUDAD"))
            {
                string sql;
                sql = "SELECT * FROM CLienteJ WHERE ciudadCJ='" + textBox1_Buscar.Text + "'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }
        }
        private void buscarClienteJ_Load(object sender, EventArgs e)
        {
            dataGridView1_Cliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1_Cliente.DataSource = bd.SelectDataTable("select * from ClienteJ");
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
        private void textBox1_Cedula_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1_Buscar.Text.Equals("NOMBRE"))
            {

                string sql;
                //SELECT * FROM CLIENTE WHERE NOMBRE LIKE 'C%';
                sql = "SELECT * FROM ClienteJ WHERE nombre LIKE '" + textBox1_Buscar.Text + "%'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);

            }
            else if (comboBox1_Buscar.Text.Equals("RUC"))
            {
                string sql;
                sql = "SELECT * FROM CLienteJ WHERE ruc LIKE '" + textBox1_Buscar.Text + "%'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }
            else if (comboBox1_Buscar.Text.Equals("PAÍS"))
            {

                string sql;
                sql = "SELECT * FROM CLienteJ WHERE paisCJ LIKE '" + textBox1_Buscar.Text + "%'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }

            else if (comboBox1_Buscar.Text.Equals("CUIDAD"))
            {
                string sql;
                sql = "SELECT * FROM CLienteJ WHERE ciudadCJ LIKE '" + textBox1_Buscar.Text + "%'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }
        }

        private void textBox1_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1_Buscar.Text.Equals("NOMBRE"))
            {

                string sql;
                //SELECT * FROM CLIENTE WHERE NOMBRE LIKE 'C%';
                sql = "SELECT * FROM CLIENTEJ WHERE nombres LIKE '" + textBox1_Buscar.Text + "%'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);

            }
            else if (comboBox1_Buscar.Text.Equals("RUC"))
            {
                string sql;
                sql = "SELECT * FROM CLIENTEJ WHERE ruc LIKE '" + textBox1_Buscar.Text + "%'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }
            else if (comboBox1_Buscar.Text.Equals("PAÍS"))
            {

                string sql;
                sql = "SELECT * FROM CLIENTEJ WHERE paisCJ LIKE '" + textBox1_Buscar.Text + "%'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }

            else if (comboBox1_Buscar.Text.Equals("CUIDAD"))
            {
                string sql;
                sql = "SELECT * FROM CLIENTEJ WHERE ciudadCJ LIKE '" + textBox1_Buscar.Text + "%'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }
        }
    }
}
