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
                dataGridView1_Proveedor.DataSource = bd.SelectDataTable(sql);
            }
            else if (comboBox1_buscar.Text.Equals("NOMBRE"))
            {
                string sql;
                sql = "SELECT * FROM CLIENTEN WHERE NOMBRE='" + textBox9_Buscar.Text + "'";
                dataGridView1_Proveedor.DataSource = bd.SelectDataTable(sql);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridView1_Proveedor.Rows[e.RowIndex];
            txtIdentificacion.Text = dgv.Cells[0].Value.ToString();
            txtApellidos.Text = dgv.Cells[1].Value.ToString();
            txtNombre.Text = dgv.Cells[2].Value.ToString();
            txtCiudad.Text = dgv.Cells[3].Value.ToString();
            txtDireccion.Text = dgv.Cells[4].Value.ToString();
            txtPais.Text = dgv.Cells[5].Value.ToString();
            txtTelefono.Text = dgv.Cells[6].Value.ToString();
            txtEmail.Text = dgv.Cells[7].Value.ToString();
            txtIdentificacion.Text = dgv.Cells[8].Value.ToString();


            // comboBox1_TipoCLiente.Text = dgv.Cells[8].Value.ToString();
            // textBox1_Nombre.Enabled = false;
            txtIdentificacion.Enabled = false;
        }

        private void textBox9_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1_buscar.Text.Equals("NOMBRE"))
            {

                string sql;
                sql = "SELECT * FROM CLIENTEN WHERE nombres LIKE '" + textBox9_Buscar.Text + "%'";
                dataGridView1_Proveedor.DataSource = bd.SelectDataTable(sql);
            }

            else if (comboBox1_buscar.Text.Equals("NÚMERO DE CÉDULA"))
            {

                string sql;
                sql = "SELECT* FROM CLIENTEN WHERE cedula LIKE '" + textBox9_Buscar.Text + "%'";
                dataGridView1_Proveedor.DataSource = bd.SelectDataTable(sql);


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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
