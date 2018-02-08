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
    public partial class actualizarCliente : Form
    {
        public actualizarCliente()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();
        ValidarSoloLetrasSoloNumeros validar = new ValidarSoloLetrasSoloNumeros();

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1_buscar.Text.Equals("") || textBox9_Buscar.Text.Equals(""))
            {
                MessageBox.Show("Ingrese número de cédula");
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
                sql = "SELECT * FROM CLIENTEN WHERE CEDULA='" + textBox9_Buscar.Text + "'";
                dataGridView1.DataSource = bd.SelectDataTable(sql);
            }
            else if (comboBox1_buscar.Text.Equals("NOMBRE"))
            {
                string sql;
                sql = "SELECT * FROM CLIENTEN WHERE NOMBRE='" + textBox9_Buscar.Text + "'";
                dataGridView1.DataSource = bd.SelectDataTable(sql);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = dgv.Cells[0].Value.ToString();
            textBox2.Text = dgv.Cells[1].Value.ToString();
            textBox3.Text = dgv.Cells[2].Value.ToString();
            textBox4.Text = dgv.Cells[3].Value.ToString();
            textBox5.Text = dgv.Cells[4].Value.ToString();
            textBox6.Text = dgv.Cells[5].Value.ToString();
            textBox7.Text = dgv.Cells[6].Value.ToString();
            textBox8.Text = dgv.Cells[7].Value.ToString();
            textBox9.Text = dgv.Cells[8].Value.ToString();
            // comboBox1_TipoCLiente.Text = dgv.Cells[8].Value.ToString();
            // textBox1_Nombre.Enabled = false;
            textBox1.Enabled = false;
        }

        private void textBox9_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1_buscar.Text.Equals("NOMBRE"))
            {

                string sql;
                sql = "SELECT * FROM CLIENTEN WHERE nombres LIKE '" + textBox9_Buscar.Text + "%'";
                dataGridView1.DataSource = bd.SelectDataTable(sql);
            }

            else if (comboBox1_buscar.Text.Equals("NÚMERO DE CÉDULA"))
            {

                string sql;
                sql = "SELECT* FROM CLIENTEN WHERE cedula LIKE '" + textBox9_Buscar.Text + "%'";
                dataGridView1.DataSource = bd.SelectDataTable(sql);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string actualizarCliente = "UPDATE CLIENTEN set nombres ='" + textBox2.Text + "' ,apellidos ='" + textBox3.Text + "',nacionalidad='" + textBox4.Text + "',paisCN='" + textBox5.Text + "', ciudadCN = '" + textBox6.Text + "', direccionCN='" + textBox7.Text + "', telefonoCN='" + textBox8.Text + "', emailCN='" + textBox9.Text + "' where cedula = " + textBox1.Text + "";

            if (bd.executecommand(actualizarCliente))
            {
                MessageBox.Show("Datos actualizados exitosamente");
                dataGridView1.DataSource = bd.SelectDataTable("select * FROM CLIENTEN");
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);   
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }
    }
}
