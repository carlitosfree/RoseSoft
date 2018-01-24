namespace RoseSoft
{
    partial class Factura
    {

        /*BLOQUE PARA VALIDAR QUE NO SE ABRA VARIAS VECES LA VENTA*/
        public static Factura facturaInstance = null;

        public static Factura Instance()
        {
            if (((facturaInstance == null) || (facturaInstance.IsDisposed == true)))
            {
                facturaInstance = new Factura();
            }
            facturaInstance.BringToFront();
            return facturaInstance;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UnidadesFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCajaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EqFullCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCajaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCajasFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoncheCajaFacura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBoncheFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TallosFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxEqCaja = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cBoxBoncheCaja = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cBoxTB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cBoxTipoCaja = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.cBoxProducto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(30, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 685);
            this.panel1.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(13, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(121, 33);
            this.label22.TabIndex = 10;
            this.label22.Text = "Factura";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.textBox13);
            this.groupBox4.Controls.Add(this.textBox12);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(9, 289);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 203);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Factura";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(102, 158);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(156, 20);
            this.textBox11.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 158);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Cuarto Frio";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(102, 131);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(156, 20);
            this.textBox13.TabIndex = 25;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(102, 105);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(156, 20);
            this.textBox12.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 130);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "H.A.W:B";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 105);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "A.W:B";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(102, 79);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(156, 20);
            this.textBox10.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Aerolinea";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.Value = new System.DateTime(2018, 1, 24, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fecha";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Número Factura";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(295, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1001, 499);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle Factura";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnidadesFactura,
            this.TipoCajaFactura,
            this.EqFullCaja,
            this.NumeroCajaFactura,
            this.NumeroCajasFactura,
            this.DescripcionFactura,
            this.BoncheCajaFacura,
            this.TotalBoncheFactura,
            this.TallosFactura,
            this.precioUnitarioFactura,
            this.TotalFactura});
            this.dataGridView1.Location = new System.Drawing.Point(17, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(964, 545);
            this.dataGridView1.TabIndex = 11;
            // 
            // UnidadesFactura
            // 
            this.UnidadesFactura.HeaderText = "Unidades";
            this.UnidadesFactura.Name = "UnidadesFactura";
            this.UnidadesFactura.ReadOnly = true;
            // 
            // TipoCajaFactura
            // 
            this.TipoCajaFactura.HeaderText = "Tipo Caja";
            this.TipoCajaFactura.Name = "TipoCajaFactura";
            this.TipoCajaFactura.ReadOnly = true;
            // 
            // EqFullCaja
            // 
            this.EqFullCaja.HeaderText = "Eq.FullCaja";
            this.EqFullCaja.Name = "EqFullCaja";
            this.EqFullCaja.ReadOnly = true;
            // 
            // NumeroCajaFactura
            // 
            this.NumeroCajaFactura.HeaderText = "# Caja";
            this.NumeroCajaFactura.Name = "NumeroCajaFactura";
            this.NumeroCajaFactura.ReadOnly = true;
            // 
            // NumeroCajasFactura
            // 
            this.NumeroCajasFactura.HeaderText = "T/B";
            this.NumeroCajasFactura.Name = "NumeroCajasFactura";
            this.NumeroCajasFactura.ReadOnly = true;
            // 
            // DescripcionFactura
            // 
            this.DescripcionFactura.HeaderText = "Descripción";
            this.DescripcionFactura.Name = "DescripcionFactura";
            this.DescripcionFactura.ReadOnly = true;
            // 
            // BoncheCajaFacura
            // 
            this.BoncheCajaFacura.HeaderText = "Bonche/Caja";
            this.BoncheCajaFacura.Name = "BoncheCajaFacura";
            this.BoncheCajaFacura.ReadOnly = true;
            // 
            // TotalBoncheFactura
            // 
            this.TotalBoncheFactura.HeaderText = "Total Bonche";
            this.TotalBoncheFactura.Name = "TotalBoncheFactura";
            this.TotalBoncheFactura.ReadOnly = true;
            // 
            // TallosFactura
            // 
            this.TallosFactura.HeaderText = "# Tallos";
            this.TallosFactura.Name = "TallosFactura";
            this.TallosFactura.ReadOnly = true;
            // 
            // precioUnitarioFactura
            // 
            this.precioUnitarioFactura.HeaderText = "Precio Unitario";
            this.precioUnitarioFactura.Name = "precioUnitarioFactura";
            this.precioUnitarioFactura.ReadOnly = true;
            // 
            // TotalFactura
            // 
            this.TotalFactura.HeaderText = "Total";
            this.TotalFactura.Name = "TotalFactura";
            this.TotalFactura.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBoxEqCaja);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.txtPrecioUnitario);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cBoxBoncheCaja);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cBoxTB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cBoxTipoCaja);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtUnidades);
            this.groupBox2.Controls.Add(this.cBoxProducto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(297, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(999, 85);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cBoxEqCaja
            // 
            this.cBoxEqCaja.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cBoxEqCaja.FormattingEnabled = true;
            this.cBoxEqCaja.Items.AddRange(new object[] {
            "1,00",
            "0,50",
            "0,25"});
            this.cBoxEqCaja.Location = new System.Drawing.Point(782, 42);
            this.cBoxEqCaja.Name = "cBoxEqCaja";
            this.cBoxEqCaja.Size = new System.Drawing.Size(89, 21);
            this.cBoxEqCaja.TabIndex = 28;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(700, 42);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 13);
            this.label23.TabIndex = 27;
            this.label23.Text = "Eq.Full Caja";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(782, 15);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(89, 20);
            this.txtPrecioUnitario.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(700, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Precio Unitario";
            // 
            // cBoxBoncheCaja
            // 
            this.cBoxBoncheCaja.FormattingEnabled = true;
            this.cBoxBoncheCaja.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cBoxBoncheCaja.Location = new System.Drawing.Point(583, 42);
            this.cBoxBoncheCaja.Name = "cBoxBoncheCaja";
            this.cBoxBoncheCaja.Size = new System.Drawing.Size(89, 21);
            this.cBoxBoncheCaja.TabIndex = 24;
            this.cBoxBoncheCaja.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(507, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Bonche/Caja";
            // 
            // cBoxTB
            // 
            this.cBoxTB.FormattingEnabled = true;
            this.cBoxTB.Items.AddRange(new object[] {
            "20",
            "25"});
            this.cBoxTB.Location = new System.Drawing.Point(583, 15);
            this.cBoxTB.Name = "cBoxTB";
            this.cBoxTB.Size = new System.Drawing.Size(89, 21);
            this.cBoxTB.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(507, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "T/B";
            // 
            // cBoxTipoCaja
            // 
            this.cBoxTipoCaja.FormattingEnabled = true;
            this.cBoxTipoCaja.Items.AddRange(new object[] {
            "ST",
            "HB",
            "Ct"});
            this.cBoxTipoCaja.Location = new System.Drawing.Point(412, 42);
            this.cBoxTipoCaja.Name = "cBoxTipoCaja";
            this.cBoxTipoCaja.Size = new System.Drawing.Size(89, 21);
            this.cBoxTipoCaja.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tipo Caja";
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(412, 15);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(89, 20);
            this.txtUnidades.TabIndex = 18;
            // 
            // cBoxProducto
            // 
            this.cBoxProducto.FormattingEnabled = true;
            this.cBoxProducto.Items.AddRange(new object[] {
            "EXPLORED\t60cm",
            "FREEDOM\t\t60cm",
            "PLAYA BLANCA\t60cm",
            "EXPLORED\t70cm",
            "FREEDOM\t\t70cm",
            "PLAYA BLANCA\t70cm",
            "EXPLORED\t80cm",
            "FREEDOM\t\t80cm",
            "PLAYA BLANCA\t80cm",
            "EXPLORED\t90cm",
            "FREEDOM\t\t90cm",
            "PLAYA BLANCA\t90cm"});
            this.cBoxProducto.Location = new System.Drawing.Point(26, 19);
            this.cBoxProducto.Name = "cBoxProducto";
            this.cBoxProducto.Size = new System.Drawing.Size(322, 21);
            this.cBoxProducto.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Unidades";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(943, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 21);
            this.button2.TabIndex = 15;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AllowDrop = true;
            this.button3.Location = new System.Drawing.Point(943, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 21);
            this.button3.TabIndex = 16;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox15);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(9, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 208);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(87, 151);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(165, 20);
            this.textBox15.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 154);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "E-mail";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(87, 70);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(165, 20);
            this.textBox14.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "País";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(202, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 20);
            this.button6.TabIndex = 15;
            this.button6.Text = "Nuevo";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cédula / RUC";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(87, 124);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(165, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(87, 99);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(87, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Teléfono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dirección";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox9);
            this.panel5.Controls.Add(this.textBox8);
            this.panel5.Controls.Add(this.textBox7);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(9, 535);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 103);
            this.panel5.TabIndex = 5;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(84, 63);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(101, 20);
            this.textBox9.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(84, 37);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(101, 20);
            this.textBox8.TabIndex = 4;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(84, 11);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(101, 20);
            this.textBox7.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "IVA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Subtotal";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(183, 645);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 28);
            this.button5.TabIndex = 4;
            this.button5.Text = "Anular";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 645);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1217, 522);
            this.Controls.Add(this.panel1);
            this.Name = "Factura";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cBoxProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadesFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCajaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn EqFullCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCajaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCajasFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoncheCajaFacura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBoncheFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TallosFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cBoxBoncheCaja;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cBoxTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cBoxTipoCaja;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cBoxEqCaja;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
    }
}