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
    public partial class Buscar_Proveedor : Form
    {
        public Buscar_Proveedor()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();
        private void Buscar_Proveedor_Load(object sender, EventArgs e)
        {
            
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bd.SelectDataTable("Select * from PROVEEDOR");
        }
    }
}
