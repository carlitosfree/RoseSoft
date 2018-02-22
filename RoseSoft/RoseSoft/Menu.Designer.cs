using System;

namespace RoseSoft
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarClienteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFacturaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracciónDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamañosDelTalloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamañoPorBoncheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bonchePorCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mercadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeRoseSoftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.comprasVentasToolStripMenuItem,
            this.facturaciónToolStripMenuItem1,
            this.inventarioToolStripMenuItem,
            this.administracciónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem,
            this.actualizarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem1,
            this.actualizarClienteToolStripMenuItem1,
            this.buscarClienteToolStripMenuItem});
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.registrarClienteToolStripMenuItem.Text = "Persona Natural";
            this.registrarClienteToolStripMenuItem.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem_Click);
            // 
            // registrarClienteToolStripMenuItem1
            // 
            this.registrarClienteToolStripMenuItem1.Name = "registrarClienteToolStripMenuItem1";
            this.registrarClienteToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.registrarClienteToolStripMenuItem1.Text = "Registrar Cliente";
            this.registrarClienteToolStripMenuItem1.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem1_Click);
            // 
            // actualizarClienteToolStripMenuItem1
            // 
            this.actualizarClienteToolStripMenuItem1.Name = "actualizarClienteToolStripMenuItem1";
            this.actualizarClienteToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.actualizarClienteToolStripMenuItem1.Text = "Actualizar Cliente";
            this.actualizarClienteToolStripMenuItem1.Click += new System.EventHandler(this.actualizarClienteToolStripMenuItem1_Click);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // actualizarClienteToolStripMenuItem
            // 
            this.actualizarClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem2,
            this.actualizarClienteToolStripMenuItem2,
            this.buscarClienteToolStripMenuItem1});
            this.actualizarClienteToolStripMenuItem.Name = "actualizarClienteToolStripMenuItem";
            this.actualizarClienteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.actualizarClienteToolStripMenuItem.Text = "Persona Jurídica";
            this.actualizarClienteToolStripMenuItem.Click += new System.EventHandler(this.actualizarClienteToolStripMenuItem_Click);
            // 
            // registrarClienteToolStripMenuItem2
            // 
            this.registrarClienteToolStripMenuItem2.Name = "registrarClienteToolStripMenuItem2";
            this.registrarClienteToolStripMenuItem2.Size = new System.Drawing.Size(166, 22);
            this.registrarClienteToolStripMenuItem2.Text = "Registrar Cliente";
            this.registrarClienteToolStripMenuItem2.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem2_Click);
            // 
            // actualizarClienteToolStripMenuItem2
            // 
            this.actualizarClienteToolStripMenuItem2.Name = "actualizarClienteToolStripMenuItem2";
            this.actualizarClienteToolStripMenuItem2.Size = new System.Drawing.Size(166, 22);
            this.actualizarClienteToolStripMenuItem2.Text = "Actualizar Cliente";
            this.actualizarClienteToolStripMenuItem2.Click += new System.EventHandler(this.actualizarClienteToolStripMenuItem2_Click);
            // 
            // buscarClienteToolStripMenuItem1
            // 
            this.buscarClienteToolStripMenuItem1.Name = "buscarClienteToolStripMenuItem1";
            this.buscarClienteToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.buscarClienteToolStripMenuItem1.Text = "Buscar Cliente";
            this.buscarClienteToolStripMenuItem1.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem1_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProveedorToolStripMenuItem,
            this.actualizarProveedorToolStripMenuItem,
            this.buscarProveedorToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // registrarProveedorToolStripMenuItem
            // 
            this.registrarProveedorToolStripMenuItem.Name = "registrarProveedorToolStripMenuItem";
            this.registrarProveedorToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registrarProveedorToolStripMenuItem.Text = "Ingresar Proveedor";
            this.registrarProveedorToolStripMenuItem.Click += new System.EventHandler(this.registrarProveedorToolStripMenuItem_Click);
            // 
            // actualizarProveedorToolStripMenuItem
            // 
            this.actualizarProveedorToolStripMenuItem.Name = "actualizarProveedorToolStripMenuItem";
            this.actualizarProveedorToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.actualizarProveedorToolStripMenuItem.Text = "Actualizar Proveedor";
            this.actualizarProveedorToolStripMenuItem.Click += new System.EventHandler(this.actualizarProveedorToolStripMenuItem_Click);
            // 
            // buscarProveedorToolStripMenuItem
            // 
            this.buscarProveedorToolStripMenuItem.Name = "buscarProveedorToolStripMenuItem";
            this.buscarProveedorToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.buscarProveedorToolStripMenuItem.Text = "Buscar Proveedor";
            this.buscarProveedorToolStripMenuItem.Click += new System.EventHandler(this.buscarProveedorToolStripMenuItem_Click_1);
            // 
            // comprasVentasToolStripMenuItem
            // 
            this.comprasVentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.comprasVentasToolStripMenuItem.Name = "comprasVentasToolStripMenuItem";
            this.comprasVentasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasVentasToolStripMenuItem.Text = "Compras";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.comprasToolStripMenuItem.Text = "Orden de Compra";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.ventasToolStripMenuItem.Text = "Buscar Orden de Compra";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // facturaciónToolStripMenuItem1
            // 
            this.facturaciónToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarFacturaToolStripMenuItem,
            this.buscarFacturaToolStripMenuItem1});
            this.facturaciónToolStripMenuItem1.Name = "facturaciónToolStripMenuItem1";
            this.facturaciónToolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.facturaciónToolStripMenuItem1.Text = "Facturación";
            // 
            // registrarFacturaToolStripMenuItem
            // 
            this.registrarFacturaToolStripMenuItem.Name = "registrarFacturaToolStripMenuItem";
            this.registrarFacturaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.registrarFacturaToolStripMenuItem.Text = "Registrar Factura";
            this.registrarFacturaToolStripMenuItem.Click += new System.EventHandler(this.registrarFacturaToolStripMenuItem_Click);
            // 
            // buscarFacturaToolStripMenuItem1
            // 
            this.buscarFacturaToolStripMenuItem1.Name = "buscarFacturaToolStripMenuItem1";
            this.buscarFacturaToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.buscarFacturaToolStripMenuItem1.Text = "Buscar Factura";
            this.buscarFacturaToolStripMenuItem1.Click += new System.EventHandler(this.buscarFacturaToolStripMenuItem1_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProductoToolStripMenuItem,
            this.actualizarProductoToolStripMenuItem,
            this.buscarProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // registrarProductoToolStripMenuItem
            // 
            this.registrarProductoToolStripMenuItem.Name = "registrarProductoToolStripMenuItem";
            this.registrarProductoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.registrarProductoToolStripMenuItem.Text = "Registrar Producto";
            this.registrarProductoToolStripMenuItem.Click += new System.EventHandler(this.registrarProductoToolStripMenuItem_Click);
            // 
            // actualizarProductoToolStripMenuItem
            // 
            this.actualizarProductoToolStripMenuItem.Name = "actualizarProductoToolStripMenuItem";
            this.actualizarProductoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.actualizarProductoToolStripMenuItem.Text = "Actualizar Producto";
            this.actualizarProductoToolStripMenuItem.Click += new System.EventHandler(this.actualizarProductoToolStripMenuItem_Click);
            // 
            // buscarProductoToolStripMenuItem
            // 
            this.buscarProductoToolStripMenuItem.Name = "buscarProductoToolStripMenuItem";
            this.buscarProductoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.buscarProductoToolStripMenuItem.Text = "Buscar Producto";
            this.buscarProductoToolStripMenuItem.Click += new System.EventHandler(this.buscarProductoToolStripMenuItem_Click);
            // 
            // administracciónToolStripMenuItem
            // 
            this.administracciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracciónDeUsuariosToolStripMenuItem,
            this.parametrosToolStripMenuItem});
            this.administracciónToolStripMenuItem.Name = "administracciónToolStripMenuItem";
            this.administracciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracciónToolStripMenuItem.Text = "Administración";
            // 
            // administracciónDeUsuariosToolStripMenuItem
            // 
            this.administracciónDeUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuariosToolStripMenuItem,
            this.actualizarUsuarioToolStripMenuItem,
            this.anularUsuarioToolStripMenuItem});
            this.administracciónDeUsuariosToolStripMenuItem.Name = "administracciónDeUsuariosToolStripMenuItem";
            this.administracciónDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.administracciónDeUsuariosToolStripMenuItem.Text = "Administración de Usuarios";
            // 
            // registrarUsuariosToolStripMenuItem
            // 
            this.registrarUsuariosToolStripMenuItem.Name = "registrarUsuariosToolStripMenuItem";
            this.registrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.registrarUsuariosToolStripMenuItem.Text = "Registrar Usuarios";
            this.registrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuariosToolStripMenuItem_Click);
            // 
            // actualizarUsuarioToolStripMenuItem
            // 
            this.actualizarUsuarioToolStripMenuItem.Name = "actualizarUsuarioToolStripMenuItem";
            this.actualizarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.actualizarUsuarioToolStripMenuItem.Text = "Actualizar Usuario";
            this.actualizarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.actualizarUsuarioToolStripMenuItem_Click);
            // 
            // anularUsuarioToolStripMenuItem
            // 
            this.anularUsuarioToolStripMenuItem.Name = "anularUsuarioToolStripMenuItem";
            this.anularUsuarioToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.anularUsuarioToolStripMenuItem.Text = "Anular Usuario";
            this.anularUsuarioToolStripMenuItem.Click += new System.EventHandler(this.anularUsuarioToolStripMenuItem_Click);
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeCajaToolStripMenuItem,
            this.tamañosDelTalloToolStripMenuItem,
            this.tamañoPorBoncheToolStripMenuItem,
            this.bonchePorCajaToolStripMenuItem,
            this.mercadoToolStripMenuItem});
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.parametrosToolStripMenuItem.Text = "Parámetros";
            // 
            // tiposDeCajaToolStripMenuItem
            // 
            this.tiposDeCajaToolStripMenuItem.Name = "tiposDeCajaToolStripMenuItem";
            this.tiposDeCajaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tiposDeCajaToolStripMenuItem.Text = "Tipos de Caja";
            // 
            // tamañosDelTalloToolStripMenuItem
            // 
            this.tamañosDelTalloToolStripMenuItem.Name = "tamañosDelTalloToolStripMenuItem";
            this.tamañosDelTalloToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tamañosDelTalloToolStripMenuItem.Text = "Tamaños del Tallo";
            // 
            // tamañoPorBoncheToolStripMenuItem
            // 
            this.tamañoPorBoncheToolStripMenuItem.Name = "tamañoPorBoncheToolStripMenuItem";
            this.tamañoPorBoncheToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tamañoPorBoncheToolStripMenuItem.Text = "Tamaño por Bonche";
            // 
            // bonchePorCajaToolStripMenuItem
            // 
            this.bonchePorCajaToolStripMenuItem.Name = "bonchePorCajaToolStripMenuItem";
            this.bonchePorCajaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.bonchePorCajaToolStripMenuItem.Text = "Bonche por Caja ";
            // 
            // mercadoToolStripMenuItem
            // 
            this.mercadoToolStripMenuItem.Name = "mercadoToolStripMenuItem";
            this.mercadoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.mercadoToolStripMenuItem.Text = "Mercado";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeRoseSoftToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeRoseSoftToolStripMenuItem
            // 
            this.acercaDeRoseSoftToolStripMenuItem.Name = "acercaDeRoseSoftToolStripMenuItem";
            this.acercaDeRoseSoftToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.acercaDeRoseSoftToolStripMenuItem.Text = "Acerca de RoseSoft";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = global::RoseSoft.Properties.Resources.img_3_1;
            this.ClientSize = new System.Drawing.Size(622, 418);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "RoseSoft";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracciónDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registrarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarFacturaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actualizarClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem actualizarClienteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamañosDelTalloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamañoPorBoncheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bonchePorCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mercadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeRoseSoftToolStripMenuItem;
    }
}