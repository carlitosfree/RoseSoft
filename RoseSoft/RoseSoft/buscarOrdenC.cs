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
    public partial class buscarOrdenC : Form
    {
        public buscarOrdenC()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SELECT* FROM ordenCompra WHERE numCedula=textBox1_busqueda.Text;
            //SELECT* FROM ordenCompra WHERE ruc=textBox1_busqueda.Text;
        }
    }
}
