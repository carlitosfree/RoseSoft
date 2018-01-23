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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ingresarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar_Proveedor proveedor = new Buscar_Proveedor();
            proveedor.Show();
            this.Hide();
        }
    }
}
