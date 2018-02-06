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
            //SELECT* FROM Customers
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* INSERT INTO usuario(nombreUsuario, contraseña, cargo)
               VALUES(txtBox1.Text, txtBox2.Text,  comboBoxCargoUsuario.Text);*/
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";         
            comboBoxCargoUsuario.Text = "";

            //SELECT * FROM usuario
        }
    }
}
