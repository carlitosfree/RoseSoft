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

    public partial class Factura : Form
    {
        DateTime hoy = DateTime.Now;
        ValidarSoloLetrasSoloNumeros v = new ValidarSoloLetrasSoloNumeros();
        public Factura()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            busquedaCliente buscarCliente= new busquedaCliente();
            buscarCliente.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            registrarCliente nuevoCliente = new registrarCliente();
            nuevoCliente.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static int contador_fila = 0;
        

        private void button2_Click(object sender, EventArgs e)
        {
            
            String selectProducto = (String)cBoxProducto.SelectedItem;
            String selectTipoCaja = (String)cBoxTipoCaja.SelectedItem;
            int selectTB = Convert.ToInt16(cBoxTB.SelectedItem);
            int selectUnidades = Convert.ToInt16 (txtUnidades.Text);
            int selectPrecio =Convert.ToInt16(txtPrecioUnitario.Text);
            String selectEqCajas = (String)cBoxEqCaja.SelectedItem;
            int selectBCaja = Convert.ToInt16(cBoxBoncheCaja.SelectedItem);
            
            int tB = (int)selectTB;
          
            int totalBonche = selectBCaja *(int)selectUnidades;
            int totalTallos = tB * totalBonche;
      
            int total = selectPrecio * totalTallos;

            bool existe = false;
            int num_fila = 0;
          /*  if (contador_fila == 0)
            {
                dataGridView1.Rows.Add(selectUnidades,selectTipoCaja,selectEqCajas,selectUnidades,
                    selectTB,selectProducto,selectBCaja,totalBonche,totalTallos,selectPrecio,total);

                contador_fila++;

            }
            else
            {*/
                foreach (DataGridViewRow Fila in dataGridView1.Rows)
                {
                    if (Fila.Cells[1].Value.ToString() == selectProducto)
                    {

                        existe = true;
                        num_fila = Fila.Index;

                    }

                }
                if (existe == true)
                {

                    dataGridView1.Rows[num_fila].Cells[0].Value = (Convert.ToDouble(selectUnidades) + Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[0].Value)).ToString();
                    double valorTotal = Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[0].Value) * Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[2].Value);

                    dataGridView1.Rows[num_fila].Cells[3].Value = valorTotal;
                }
                else
                {

                    dataGridView1.Rows.Add(selectUnidades, selectTipoCaja, selectEqCajas, selectUnidades,
                    selectTB, selectProducto, selectBCaja, totalBonche, totalTallos, selectPrecio, total);

                    contador_fila++;
                }

                MessageBox.Show("Item agregado");

         //   }

           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(79, 55);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(73, 49);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(79, 55);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(73, 49);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(79, 55);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(73, 49);
        }
    }
}
