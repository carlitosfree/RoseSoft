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
    public partial class actualizarClienteJ : Form
    {
        public actualizarClienteJ()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();
        ValidarSoloLetrasSoloNumeros validar = new ValidarSoloLetrasSoloNumeros();
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
            if (comboBox1_buscar.Text.Equals("RAZÓN SOCIAL"))
            {
                
                string consultar = bd.selectstring("SELECT RAZONSOCIALCJ FROM PERSONAJURIDICA WHERE RAZONSOCIALCJ='" + textBox9_Buscar.Text + "'");
                
                     string sql;
                        sql = "SELECT * FROM PERSONAJURIDICA WHERE RAZONSOCIALCJ LIKE '" + textBox9_Buscar.Text + "%'";
                        dataGridView1_Proveedor.DataSource = bd.SelectDataTable(sql);

            }

            else if (comboBox1_buscar.Text.Equals("RUC"))
            {
                
                    string sql;
                    sql = "SELECT* FROM PERSONAJURIDICA WHERE RUCCJ LIKE '" + textBox9_Buscar.Text + "%'";
                    dataGridView1_Proveedor.DataSource = bd.SelectDataTable(sql);
                

            }

        }

        private void textBox9_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1_buscar.Text.Equals("RAZÓN SOCIAL"))
            {
                
                    string sql;
                    sql = "SELECT * FROM PERSONAJURIDICA WHERE RAZONSOCIALCJ LIKE '" + textBox9_Buscar.Text + "%'";
                    dataGridView1_Proveedor.DataSource = bd.SelectDataTable(sql);
               

            }

            else if (comboBox1_buscar.Text.Equals("RUC"))
            {
                
                    string sql;
                    sql = "SELECT* FROM PERSONAJURIDICA WHERE RUCCJ LIKE '" + textBox9_Buscar.Text + "%'";
                    dataGridView1_Proveedor.DataSource = bd.SelectDataTable(sql);
              

            }
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow dgv = dataGridView1_Proveedor.Rows[e.RowIndex];
            txtIdentificacion.Text = dgv.Cells[0].Value.ToString();
            txtApellidos.Text = dgv.Cells[1].Value.ToString();
            txtDireccion.Text = dgv.Cells[2].Value.ToString();
            txtTelefono.Text = dgv.Cells[3].Value.ToString();
            txtEmail.Text = dgv.Cells[4].Value.ToString();
            txtCiudad.Text = dgv.Cells[5].Value.ToString();
            txtPais.Text = dgv.Cells[6].Value.ToString();
            txtIdentificacion.Enabled = false;

        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txt7_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string actualizarCliente = "UPDATE PERSONAJURIDICA set RAZonSocialCJ ='" + txtApellidos.Text + "',paisCJ='" + txtPais.Text + "', ciudadCJ = '" + txtCiudad.Text + "', direccionCJ='" + txtDireccion.Text + "', NUMEROtelefonoCJ='" + txtTelefono.Text + "', emailCJ='" + txtEmail.Text + "' where RUCCJ = " + txtIdentificacion.Text + "";

            if (bd.executecommand(actualizarCliente))
            {
                MessageBox.Show("Datos actualizados exitosamente");
                dataGridView1_Proveedor.DataSource = bd.SelectDataTable("select * FROM PERSONAJURIDICA");
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            
            if (comboBox1_buscar.Text.Equals("") || textBox9_Buscar.Text.Equals(""))
            {
                MessageBox.Show("Ingrese datos a buscar");
            }
            else
            {
                string consultar = bd.selectstring("select RAZONSOCIALCJ from PERSONAJURIDICA where RAZONSOCIALCJ ='"+textBox9_Buscar.Text+"'");
                if (consultar.Equals(textBox9_Buscar.Text))
                {
                    buscar();
                }
                else
                {
                    MessageBox.Show("Dato no encontrado");
                }

            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void textBox9_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloLetrasSoloNumeros validar = new ValidarSoloLetrasSoloNumeros();

            if (comboBox1_buscar.Text.Equals("RUC"))
            {
                validar.SoloNumeros(e);
            }
        }
    }
}
