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
        
        public void buscar()
        {
            if (comboBox1_buscar.Text.Equals("NÚMERO DE CÉDULA"))
            {
                string sql;
                sql = "SELECT * FROM PERSONANATURAL WHERE CEDULACN='" + textBox9_Buscar.Text + "'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);
            }
            else if (comboBox1_buscar.Text.Equals("NOMBRE"))
            {
                string sql;
                sql = "SELECT * FROM PERSONANATURAL WHERE NOMBRESCN='" + textBox9_Buscar.Text + "'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridView1_Cliente.Rows[e.RowIndex];
            txtNombre.Text = dgv.Cells[0].Value.ToString();
            txtApellidos.Text = dgv.Cells[1].Value.ToString();
            txtDireccion.Text = dgv.Cells[2].Value.ToString();
            txtTelefono.Text = dgv.Cells[3].Value.ToString();
            txtEmail.Text = dgv.Cells[4].Value.ToString();
            txtIdentificacion.Text = dgv.Cells[5].Value.ToString();
            txtCiudad.Text = dgv.Cells[6].Value.ToString();
            txtPais.Text = dgv.Cells[7].Value.ToString();
            txtIdentificacion.Enabled = false;
        }

        private void textBox9_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1_buscar.Text.Equals("NOMBRE"))
            {

                string sql;
                sql = "SELECT * FROM PERSONANATURAL WHERE NOMBRESCN LIKE '" + textBox9_Buscar.Text + "%'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);
            }

            else if (comboBox1_buscar.Text.Equals("NÚMERO DE CÉDULA"))
            {

                string sql;
                sql = "SELECT* FROM PERSONANATURAL WHERE CEDULACN LIKE '" + textBox9_Buscar.Text + "%'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string actualizarCliente = "UPDATE PERSONANATURAL set NOMBRESCN ='" + txtNombre.Text +
                "' ,APELLIDOSCN ='" + txtApellidos.Text + "',DIRECCIONCN='" + txtDireccion.Text+
                "',NUMEROTELEFONOCN='" + txtTelefono.Text + "', EMAILCN = '" + txtEmail.Text + "', " +
                "CEDULACN='" + txtIdentificacion.Text + "', CIUDADCN='" + txtCiudad.Text + "'," +
                " PAISCN='" + txtPais.Text + "' where CEDULACN = " +txtIdentificacion.Text + "";

            if (bd.executecommand(actualizarCliente))
            {
                MessageBox.Show("Datos actualizados exitosamente");
                dataGridView1_Cliente.DataSource = bd.SelectDataTable("select * FROM PERSONANATURAL");
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
                buscar();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
