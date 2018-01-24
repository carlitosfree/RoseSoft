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

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura factura = null;
            factura = Factura.Instance();
            factura.Show();
            
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrarCliente registro = null;
            registro = registrarCliente.Instance();
            registro.Show();
        }

        private void actualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizarCliente actualizar = null;
            actualizar = actualizarCliente.Instance();
            actualizar.Show();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            busquedaCliente busqueda = null;
            busqueda = busquedaCliente.Instance();
            busqueda.Show();
            
        }

        private void buscarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarFactura buscarFactura = null;
            buscarFactura = buscarFactura.Instance();
            buscarFactura.Show();
        }
    }
}
