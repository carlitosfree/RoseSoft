namespace RoseSoft
{
    partial class actualizarClienteJ
    {
        /*BLOQUE PARA VALIDAR QUE NO SE ABRA VARIAS VECES LA VENTA*/
        public static actualizarClienteJ actualizarClienteJInstance = null;

        public static actualizarClienteJ Instance()
        {
            if (((actualizarClienteJInstance == null) || (actualizarClienteJInstance.IsDisposed == true)))
            {
                actualizarClienteJInstance = new actualizarClienteJ();
            }
            actualizarClienteJInstance.BringToFront();
            return actualizarClienteJInstance;
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1_buscar = new System.Windows.Forms.ComboBox();
            this.textBox9_Buscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 294);
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
            this.button2.Location = new System.Drawing.Point(17, 289);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 24);
            this.button2.TabIndex = 58;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1_buscar);
            this.groupBox3.Controls.Add(this.textBox9_Buscar);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(14, 38);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(460, 87);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda";
            // 
            // comboBox1_buscar
            // 
            this.comboBox1_buscar.FormattingEnabled = true;
            this.comboBox1_buscar.Items.AddRange(new object[] {
            "NOMBRE EMPRESA",
            "RUC"});
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
            this.groupBox1.Location = new System.Drawing.Point(14, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(508, 268);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados Búsqueda";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 17);
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
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Actualizar Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txt5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt6);
            this.groupBox2.Controls.Add(this.txt7);
            this.groupBox2.Controls.Add(this.txt3);
            this.groupBox2.Controls.Add(this.txt2);
            this.groupBox2.Controls.Add(this.txt1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(550, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 318);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Cliente";
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(214, 153);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(121, 20);
            this.txt5.TabIndex = 55;
            this.txt5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt5_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Ciudad";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(214, 127);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(121, 20);
            this.txt4.TabIndex = 53;
            this.txt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "País";
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(214, 231);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(121, 20);
            this.txt8.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "E-mail";
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(214, 179);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(121, 20);
            this.txt6.TabIndex = 49;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(214, 205);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(121, 20);
            this.txt7.TabIndex = 48;
            this.txt7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt7_KeyPress);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(214, 99);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(121, 20);
            this.txt3.TabIndex = 47;
            this.txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt3_KeyPress);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(214, 73);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(121, 20);
            this.txt2.TabIndex = 46;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2_KeyPress);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(214, 47);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(121, 20);
            this.txt1.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Número de Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Rasón Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nombre de la Empresa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "RUC";
            // 
            // actualizarClienteJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 414);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "actualizarClienteJ";
            this.Text = "actualizarClienteJ";
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1_buscar;
        private System.Windows.Forms.TextBox textBox9_Buscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}