﻿using System;
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
    public partial class buscarClienteJ : Form
    {
        public buscarClienteJ()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();
        
        
        public void buscar()
        {
            if (comboBox1_Buscar.Text.Equals("RUC"))
            {
                string sql;
                sql = "SELECT * FROM PERSONAJURIDICA  WHERE RUCCJ='" + textBox1_Buscar.Text + "'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);
            }
            else if (comboBox1_Buscar.Text.Equals("RAZÓN SOCIAL"))
            {
                string sql;
                sql = "SELECT * FROM PERSONAJURIDICA  WHERE NOMBRESCJ='" + textBox1_Buscar.Text + "'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }
            else if (comboBox1_Buscar.Text.Equals("PAÍS"))
            {
                string sql;
                sql = "SELECT * FROM PERSONAJURIDICA  WHERE PAISCJ='" + textBox1_Buscar.Text + "'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }
            else if (comboBox1_Buscar.Text.Equals("CIUDAD"))
            {
                string sql;
                sql = "SELECT * FROM PERSONAJURIDICA  WHERE CIUDADCJ='" + textBox1_Buscar.Text + "'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }
        }
        private void buscarClienteJ_Load(object sender, EventArgs e)
        {
            dataGridView1_Cliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1_Cliente.DataSource = bd.SelectDataTable("select * from PERSONAJURIDICA ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1_Buscar.Text.Equals("") || textBox1_Buscar.Text.Equals(""))
            {
                MessageBox.Show("Ingrese parametros de busqueda");
            }
            else
            {
                buscar();
            }
        }
        private void textBox1_Cedula_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1_Buscar.Text.Equals("RAZÓN SOCIAL"))
            {

                string sql;
                sql = "SELECT * FROM PERSONAJURIDICA  WHERE RAZONSOCIALCJ LIKE '" + textBox1_Buscar.Text + "%'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);

            }
            else if (comboBox1_Buscar.Text.Equals("RUC"))
            {
                string sql;
                sql = "SELECT * FROM PERSONAJURIDICA WHERE RUCCJ= " + textBox1_Buscar.Text + "";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);

            }
            
        }

        private void textBox1_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1_Buscar.Text.Equals("RAZÓN SOCIAL"))
            {

                string sql;
                sql = "SELECT * FROM PERSONAJURIDICA WHERE RAZONSOCIALCJ LIKE '" + textBox1_Buscar.Text + "%'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }

            else if (comboBox1_Buscar.Text.Equals("RUC"))
            {

                string sql;
                sql = "SELECT * FROM PERSONAJURIDICA WHERE RUCCJ LIKE '" + textBox1_Buscar.Text + "%'";
                dataGridView1_Cliente.DataSource = bd.SelectDataTable(sql);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (comboBox1_Buscar.Text.Equals("") || textBox1_Buscar.Text.Equals(""))
            {
                MessageBox.Show("Ingrese datos a buscar");
            }
            else
            {
                string consultar = bd.selectstring("select RAZONSOCIALCJ from PERSONAJURIDICA where RAZONSOCIALCJ ='" + textBox1_Buscar.Text + "'");
                if (consultar.Equals(textBox1_Buscar.Text))
                {
                    buscar();
                }
                else
                {
                    MessageBox.Show("Dato no encontrado");
                }

            }
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(79, 55);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(73, 49);
        }


        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(79, 55);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(73, 49);
        }

        private void textBox1_Buscar_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloLetrasSoloNumeros validar = new ValidarSoloLetrasSoloNumeros();

            if (comboBox1_Buscar.Text.Equals("RUC"))
            {
                validar.SoloNumeros(e);
            }
        }
    }
}
