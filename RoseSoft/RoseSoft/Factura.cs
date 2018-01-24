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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
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
    }
}
