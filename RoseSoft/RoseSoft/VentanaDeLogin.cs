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
    public partial class VentanaDeLogin : Form
    {
        public VentanaDeLogin()
        {
            InitializeComponent();
        }

        private void bIngresar_Click(object sender, EventArgs e)
        {
            string usuario = "Ronald";
            string contraseña = "12345";
            Menu menu = new Menu();
            if (txtUsuario.Text == usuario & txtPassword.Text == contraseña)
            {
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
                txtUsuario.Text = "";
                txtPassword.Text = "";
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                string usuario = "Ronald";
                string contraseña = "12345";
                Menu menu = new Menu();
                if (txtUsuario.Text == usuario & txtPassword.Text == contraseña)
                {
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                }
            }
        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
