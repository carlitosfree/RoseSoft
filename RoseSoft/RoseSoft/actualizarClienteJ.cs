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
            if (comboBox1_buscar.Text.Equals("RUC"))
            {
                string sql;
                sql = "SELECT * FROM CLIENTEJ WHERE ruc='" + textBox9_Buscar.Text + "'";
                dataGridView1.DataSource = bd.SelectDataTable(sql);
            }
            else if (comboBox1_buscar.Text.Equals("NOMBRE"))
            {
                string sql;
                sql = "SELECT * FROM CLIENTEJ WHERE nombreEmpresa='" + textBox9_Buscar.Text + "'";
                dataGridView1.DataSource = bd.SelectDataTable(sql);

            }
        }

        private void textBox9_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1_buscar.Text.Equals("NOMBRE EMPRESA"))
            {

                string sql;
                sql = "SELECT * FROM CLIENTEJ WHERE nombreEmpresa LIKE '" + textBox9_Buscar.Text + "%'";
                dataGridView1.DataSource = bd.SelectDataTable(sql);
            }

            else if (comboBox1_buscar.Text.Equals("RUC"))
            {

                string sql;
                sql = "SELECT* FROM CLIENTEJ WHERE ruc LIKE '" + textBox9_Buscar.Text + "%'";
                dataGridView1.DataSource = bd.SelectDataTable(sql);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string actualizarCliente = "UPDATE CLIENTEJ set nombreEmpresa ='" + txt2.Text + "' ,rasonSocial ='" + txt3.Text + "',paisCJ='" + txt4.Text + "', ciudadCJ = '" + txt5.Text + "', direccionCJ='" + txt6.Text + "', telefonoCJ='" + txt7.Text + "', emailCJ='" + txt8.Text + "' where ruc = " + txt1.Text + "";

            if (bd.executecommand(actualizarCliente))
            {
                MessageBox.Show("Datos actualizados exitosamente");
                dataGridView1.DataSource = bd.SelectDataTable("select * FROM CLIENTEJ");
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow dgv = dataGridView1.Rows[e.RowIndex];
            txt1.Text = dgv.Cells[0].Value.ToString();
            txt2.Text = dgv.Cells[1].Value.ToString();
            txt3.Text = dgv.Cells[2].Value.ToString();
            txt4.Text = dgv.Cells[3].Value.ToString();
            txt5.Text = dgv.Cells[4].Value.ToString();
            txt6.Text = dgv.Cells[5].Value.ToString();
            txt7.Text = dgv.Cells[6].Value.ToString();
            txt8.Text = dgv.Cells[7].Value.ToString();
            // comboBox1_TipoCLiente.Text = dgv.Cells[8].Value.ToString();
            // textBox1_Nombre.Enabled = false;
            txt1.Enabled = false;
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
    }
}
