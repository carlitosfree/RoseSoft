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
    public partial class proveedorModificar : Form
    {
        public proveedorModificar()
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
            if (comboBox1_buscar.Text.Equals("") || textBox1.Text.Equals(""))
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
        }
        private void dataGridView1_Proveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridView1_Proveedor.Rows[e.RowIndex];
            textBox1.Text = dgv.Cells[0].Value.ToString();
            textBox2.Text = dgv.Cells[1].Value.ToString();
            textBox3.Text = dgv.Cells[2].Value.ToString();
            textBox4.Text = dgv.Cells[3].Value.ToString();
            textBox5.Text = dgv.Cells[4].Value.ToString();
            textBox6.Text = dgv.Cells[5].Value.ToString();
            textBox7.Text = dgv.Cells[6].Value.ToString();
         
            // comboBox1_TipoCLiente.Text = dgv.Cells[8].Value.ToString();
            // textBox1_Nombre.Enabled = false;
            textBox1.Enabled = false;
        }

        private void textBox9_Buscar_TextChanged(object sender, EventArgs e)
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (comboBox1_buscar.Text.Equals("") || textBox1.Text.Equals(""))
            {
                MessageBox.Show("Ingrese parametros de busqueda");
            }
            else
            {
                buscar();
            }
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string actualizarCliente = "UPDATE Proveedor set nombresP ='" + textBox2.Text + "' ,paisP ='" + textBox3.Text + "',ciudadP='" + textBox4.Text + "',direccionP='" + textBox5.Text + "', telefonoP = '" + textBox6.Text + "', emailP='" + textBox7.Text + "' where cedulaP = " + textBox1.Text + "";

            if (bd.executecommand(actualizarCliente))
            {
                MessageBox.Show("Datos actualizados exitosamente");
                dataGridView1_Proveedor.DataSource = bd.SelectDataTable("select * FROM Proveeder");
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
