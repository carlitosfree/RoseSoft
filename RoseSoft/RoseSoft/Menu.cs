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
            Buscar_Proveedor proveedor = null;
            proveedor = Buscar_Proveedor.Instance();
            proveedor.Show();
            
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura factura = null;
            factura = Factura.Instance();
            factura.Show();
            
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void actualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrarProducto registroProducto = null;
            registroProducto = registrarProducto.Instance();
            registroProducto.Show();
        
        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarProducto actualizarProducto = null;
            actualizarProducto = ActualizarProducto.Instance();
            actualizarProducto.Show();
        }

        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar_Producto buscarProducto = null;
            buscarProducto = Buscar_Producto.Instance();
            buscarProducto.Show();

        }

        private void registrarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrarProveedor registroProveedor = null;
            registroProveedor = registrarProveedor.Instance();
            registroProveedor.Show();
        }

        private void actualizarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proveedorModificar actualizarProveedor = null;
            actualizarProveedor = proveedorModificar.Instance();
            actualizarProveedor.Show();
        }

        private void registrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrarUsuario registroUsuario = null;
            registroUsuario = registrarUsuario.Instance();
            registroUsuario.Show();

        }

        private void actualizarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizarUsuario actualizarUsu = null;
            actualizarUsu = actualizarUsuario.Instance();
            actualizarUsu.Show();
        }

        private void anularUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anularUsuario anularUsu = null;
            anularUsu = anularUsuario.Instance();
            anularUsu.Show();
        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenCompra orden = null;
            orden = OrdenCompra.Instance();
            orden.Show();
        }

        private void buscarOrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarOrdenC buscar = null;
            buscar = buscarOrdenC.Instance();
            buscar.Show();

        }

        private void registrarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            registrarCliente registrar = null;
            registrar = registrarCliente.Instance();
            registrar.Show();
        }

        private void actualizarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            actualizarCliente actualizar = null;
            actualizar = actualizarCliente.Instance();
            actualizar.Show();
         
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            busquedaCliente busqueda = null;
            busqueda = busquedaCliente.Instance();
            busqueda.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenCompra orden = null;
            orden = OrdenCompra.Instance();
            orden.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarOrdenC buscar = null;
            buscar = buscarOrdenC.Instance();
            buscar.Show();

        }

        private void buscarFacturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buscarFactura buscar = null;
            buscar = buscarFactura.Instance();
            buscar.Show();
        }

        private void registrarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura factura = null;
            factura = Factura.Instance();
            factura.Show();
        }

        private void buscarProveedorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Buscar_Proveedor buscar = null;
            buscar = Buscar_Proveedor.Instance();
            buscar.Show();
        }

        private void registrarClienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ingresarClienteJ ingresar = null;
            ingresar = ingresarClienteJ.Instance();
            ingresar.Show();
        }

        private void actualizarClienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            actualizarClienteJ actualizar = null;
            actualizar = actualizarClienteJ.Instance();
            actualizar.Show();
        }

        private void buscarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buscarClienteJ buscar = null;
            buscar = buscarClienteJ.Instance();
            buscar.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}