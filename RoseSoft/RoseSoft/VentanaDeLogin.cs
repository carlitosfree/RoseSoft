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
        BaseDeDatos bd = new BaseDeDatos();

        private void bIngresar_Click(object sender, EventArgs e)
        {
           
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
            IsKeyLocked(Keys.CapsLock);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtUsuario.Text.Equals("") && txtPassword.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese sus credenciales");
                }
                else
                {
                    Menu menu = new Menu();
                    string usuario = (bd.selectstring("select USUARIO FROM USUARIOS WHERE  USUARIO ='" + txtUsuario.Text + "';"));
                   // MessageBox.Show(usuario);
                    if (txtUsuario.Text == usuario)
                    {
                        string contraseña = (bd.selectstring("select CONTRASENA FROM USUARIOS WHERE  USUARIO ='" + txtUsuario.Text + "';"));
                       // MessageBox.Show(contraseña);
                        if (txtPassword.Text == contraseña)
                        {
                            MessageBox.Show("Bienvenidos al Sistema RoseSoft");
                            menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña Incorrecta");
                            txtPassword.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no existe");
                        txtUsuario.Text = "";
                        txtPassword.Text = "";
                    }
                }
            }

        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {     
            txtPassword.PasswordChar = '*';
        }
        Point fromPosicion;
        Boolean mouseAccion;
        private void VentanaDeLogin_MouseDown(object sender, MouseEventArgs e)
        {
            fromPosicion = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAccion = true;
        }

        private void VentanaDeLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAccion == true)
            {
                Location = new Point(Cursor.Position.X - fromPosicion.X, Cursor.Position.Y - fromPosicion.Y);
            }
        }

        private void VentanaDeLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAccion = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(54, 51);
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") && txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Ingrese sus credenciales");
            }
            else
            {
                Menu menu = new Menu();
                string usuario = (bd.selectstring("select USUARIO FROM USUARIOS WHERE  USUARIO ='" + txtUsuario.Text + "';"));
             
                if (txtUsuario.Text == usuario)
                {
                    string contraseña = (bd.selectstring("select CONTRASENA FROM USUARIOS WHERE  USUARIO ='" + txtUsuario.Text + "';"));
        
                    if (txtPassword.Text == contraseña)
                    {
                        MessageBox.Show("Bienvenidos al Sistema RoseSoft");
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Incorrecta");
                        txtPassword.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no existe");
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                
                }
            } 
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(54, 51);
            
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(60, 57);
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(60, 57);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
 
