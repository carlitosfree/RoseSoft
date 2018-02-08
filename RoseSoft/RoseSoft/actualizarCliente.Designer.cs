namespace RoseSoft
{
    partial class actualizarCliente
    {
        /*BLOQUE PARA VALIDAR QUE NO SE ABRA VARIAS VECES LA VENTA*/
        public static actualizarCliente acturalizarClienteInstance = null;

        public static actualizarCliente Instance()
        {
            if (((acturalizarClienteInstance == null) || (acturalizarClienteInstance.IsDisposed == true)))
            {
                acturalizarClienteInstance = new actualizarCliente();
            }
            acturalizarClienteInstance.BringToFront();
            return acturalizarClienteInstance;
        }


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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1_buscar = new System.Windows.Forms.ComboBox();
            this.textBox9_Buscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1_buscar);
            this.groupBox3.Controls.Add(this.textBox9_Buscar);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(14, 61);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(460, 87);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda";
            // 
            // comboBox1_buscar
            // 
            this.comboBox1_buscar.FormattingEnabled = true;
            this.comboBox1_buscar.Items.AddRange(new object[] {
            "NOMBRE",
            "NÚMERO DE CÉDULA"});
            this.comboBox1_buscar.Location = new System.Drawing.Point(19, 40);
            this.comboBox1_buscar.Name = "comboBox1_buscar";
            this.comboBox1_buscar.Size = new System.Drawing.Size(136, 21);
            this.comboBox1_buscar.TabIndex = 7;
            // 
            // textBox9_Buscar
            // 
            this.textBox9_Buscar.Location = new System.Drawing.Point(170, 42);
            this.textBox9_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9_Buscar.Name = "textBox9_Buscar";
            this.textBox9_Buscar.Size = new System.Drawing.Size(170, 20);
            this.textBox9_Buscar.TabIndex = 6;
            this.textBox9_Buscar.TextChanged += new System.EventHandler(this.textBox9_Buscar_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar por:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(14, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(508, 268);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados Búsqueda";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(472, 228);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Actualizar Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(532, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 386);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Cliente";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 351);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 24);
            this.button3.TabIndex = 59;
            this.button3.Text = "Regresar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 351);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 24);
            this.button2.TabIndex = 58;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(215, 131);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 57;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Nacionalidad";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(214, 261);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(121, 20);
            this.textBox9.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Ciudad";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(215, 235);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(121, 20);
            this.textBox8.TabIndex = 53;
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "País";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(215, 209);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 20);
            this.textBox7.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "E-mail";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(214, 183);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 20);
            this.textBox6.TabIndex = 49;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(214, 157);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 48;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(215, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 47;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(215, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 46;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Numero de Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nombres";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Cédula";
            // 
            // actualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 445);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "actualizarCliente";
            this.Text = "Actualizar Cliente";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1_buscar;
        private System.Windows.Forms.TextBox textBox9_Buscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
    }
}