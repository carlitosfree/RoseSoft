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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BaseDeDatos bd = new BaseDeDatos();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bd.SelectDataTable("Select * from PROVEEDOR");
        }
    }
}
