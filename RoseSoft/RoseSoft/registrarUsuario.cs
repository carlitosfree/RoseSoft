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
    public partial class registrarUsuario : Form
    {
        public registrarUsuario()
        {
            InitializeComponent();
        }

        private void registrarUsuario_Load(object sender, EventArgs e)
        {
            Size deskTopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            Int32 alto = (deskTopSize.Height - 524) / 2;
            Int32 ancho = (deskTopSize.Width - 485) / 2;
            
        }
    }
}
