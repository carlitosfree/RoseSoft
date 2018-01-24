namespace RoseSoft
{
    partial class Factura
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UnidadesFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCajasFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoncheCajaFacura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBoncheFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TallosFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 584);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(297, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(644, 472);
            this.panel4.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnidadesFactura,
            this.NumeroCajasFactura,
            this.DescripcionFactura,
            this.BoncheCajaFacura,
            this.TotalBoncheFactura,
            this.TallosFactura,
            this.precioUnitarioFactura,
            this.TotalFactura});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Location = new System.Drawing.Point(295, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 82);
            this.panel3.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 565);
            this.panel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cédula / RUC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero de Factura";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UnidadesFactura
            // 
            this.UnidadesFactura.HeaderText = "Unidades";
            this.UnidadesFactura.Name = "UnidadesFactura";
            this.UnidadesFactura.Width = 77;
            // 
            // NumeroCajasFactura
            // 
            this.NumeroCajasFactura.HeaderText = "T/B";
            this.NumeroCajasFactura.Name = "NumeroCajasFactura";
            this.NumeroCajasFactura.Width = 51;
            // 
            // DescripcionFactura
            // 
            this.DescripcionFactura.HeaderText = "Descripción";
            this.DescripcionFactura.Name = "DescripcionFactura";
            this.DescripcionFactura.Width = 88;
            // 
            // BoncheCajaFacura
            // 
            this.BoncheCajaFacura.HeaderText = "Bonche/Caja";
            this.BoncheCajaFacura.Name = "BoncheCajaFacura";
            this.BoncheCajaFacura.Width = 95;
            // 
            // TotalBoncheFactura
            // 
            this.TotalBoncheFactura.HeaderText = "Total Bonche";
            this.TotalBoncheFactura.Name = "TotalBoncheFactura";
            this.TotalBoncheFactura.Width = 96;
            // 
            // TallosFactura
            // 
            this.TallosFactura.HeaderText = "# Tallos";
            this.TallosFactura.Name = "TallosFactura";
            this.TallosFactura.Width = 70;
            // 
            // precioUnitarioFactura
            // 
            this.precioUnitarioFactura.HeaderText = "Precio Unitario";
            this.precioUnitarioFactura.Name = "precioUnitarioFactura";
            this.precioUnitarioFactura.Width = 101;
            // 
            // TotalFactura
            // 
            this.TotalFactura.HeaderText = "Total";
            this.TotalFactura.Name = "TotalFactura";
            this.TotalFactura.Width = 56;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 582);
            this.Controls.Add(this.panel1);
            this.Name = "Factura";
            this.Text = "Factura";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadesFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCajasFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoncheCajaFacura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBoncheFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TallosFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFactura;
    }
}