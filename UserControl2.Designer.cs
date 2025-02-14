namespace Inventario
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_dinero = new System.Windows.Forms.Label();
            this.tx_peso = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_opciones = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFECHA = new System.Windows.Forms.DateTimePicker();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.tb_numero = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_peso = new MaterialSkin.Controls.MaterialTextBox();
            this.panel_pornumeros = new System.Windows.Forms.Panel();
            this.tb_buscarNumero = new MaterialSkin.Controls.MaterialTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.PictureBox();
            this.panel_filtrar = new System.Windows.Forms.Panel();
            this.dp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_aply = new System.Windows.Forms.PictureBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.lb_total_rollos = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_opciones.SuspendLayout();
            this.panel_pornumeros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_cancel)).BeginInit();
            this.panel_filtrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_aply)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(850, 661);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1024, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 69);
            this.label1.TabIndex = 7;
            this.label1.Text = "SALIDAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tx_dinero
            // 
            this.tx_dinero.AutoSize = true;
            this.tx_dinero.Location = new System.Drawing.Point(493, 690);
            this.tx_dinero.Name = "tx_dinero";
            this.tx_dinero.Size = new System.Drawing.Size(14, 16);
            this.tx_dinero.TabIndex = 14;
            this.tx_dinero.Text = "0";
            // 
            // tx_peso
            // 
            this.tx_peso.AutoSize = true;
            this.tx_peso.Location = new System.Drawing.Point(175, 690);
            this.tx_peso.Name = "tx_peso";
            this.tx_peso.Size = new System.Drawing.Size(14, 16);
            this.tx_peso.TabIndex = 13;
            this.tx_peso.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 691);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "TOTAL DINERO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 691);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "TOTAL PESO :";
            // 
            // panel_opciones
            // 
            this.panel_opciones.Controls.Add(this.label3);
            this.panel_opciones.Controls.Add(this.dtpFECHA);
            this.panel_opciones.Controls.Add(this.materialButton2);
            this.panel_opciones.Controls.Add(this.tb_numero);
            this.panel_opciones.Controls.Add(this.tb_peso);
            this.panel_opciones.Location = new System.Drawing.Point(859, 107);
            this.panel_opciones.Name = "panel_opciones";
            this.panel_opciones.Size = new System.Drawing.Size(318, 365);
            this.panel_opciones.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "FECHA DE SALIDA";
            // 
            // dtpFECHA
            // 
            this.dtpFECHA.Location = new System.Drawing.Point(41, 245);
            this.dtpFECHA.Name = "dtpFECHA";
            this.dtpFECHA.Size = new System.Drawing.Size(200, 22);
            this.dtpFECHA.TabIndex = 7;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.BackColor = System.Drawing.Color.Lime;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(84, 292);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(141, 36);
            this.materialButton2.TabIndex = 7;
            this.materialButton2.Text = "AGREGAR SALIDA";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = false;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // tb_numero
            // 
            this.tb_numero.AnimateReadOnly = false;
            this.tb_numero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_numero.Depth = 0;
            this.tb_numero.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_numero.Hint = "Numero";
            this.tb_numero.LeadingIcon = null;
            this.tb_numero.Location = new System.Drawing.Point(37, 13);
            this.tb_numero.MaxLength = 50;
            this.tb_numero.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_numero.Multiline = false;
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(262, 50);
            this.tb_numero.TabIndex = 2;
            this.tb_numero.Text = "";
            this.tb_numero.TrailingIcon = null;
            // 
            // tb_peso
            // 
            this.tb_peso.AnimateReadOnly = false;
            this.tb_peso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_peso.Depth = 0;
            this.tb_peso.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_peso.Hint = "Peso a salir";
            this.tb_peso.LeadingIcon = null;
            this.tb_peso.Location = new System.Drawing.Point(39, 123);
            this.tb_peso.MaxLength = 50;
            this.tb_peso.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_peso.Multiline = false;
            this.tb_peso.Name = "tb_peso";
            this.tb_peso.Size = new System.Drawing.Size(261, 50);
            this.tb_peso.TabIndex = 3;
            this.tb_peso.Text = "";
            this.tb_peso.TrailingIcon = null;
            // 
            // panel_pornumeros
            // 
            this.panel_pornumeros.Controls.Add(this.tb_buscarNumero);
            this.panel_pornumeros.Controls.Add(this.label9);
            this.panel_pornumeros.Controls.Add(this.pictureBox2);
            this.panel_pornumeros.Location = new System.Drawing.Point(1183, 298);
            this.panel_pornumeros.Name = "panel_pornumeros";
            this.panel_pornumeros.Size = new System.Drawing.Size(254, 128);
            this.panel_pornumeros.TabIndex = 26;
            // 
            // tb_buscarNumero
            // 
            this.tb_buscarNumero.AnimateReadOnly = false;
            this.tb_buscarNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_buscarNumero.Depth = 0;
            this.tb_buscarNumero.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_buscarNumero.Hint = "Numero";
            this.tb_buscarNumero.LeadingIcon = null;
            this.tb_buscarNumero.Location = new System.Drawing.Point(64, 52);
            this.tb_buscarNumero.MaxLength = 50;
            this.tb_buscarNumero.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_buscarNumero.Multiline = false;
            this.tb_buscarNumero.Name = "tb_buscarNumero";
            this.tb_buscarNumero.Size = new System.Drawing.Size(174, 50);
            this.tb_buscarNumero.TabIndex = 13;
            this.tb_buscarNumero.Text = "";
            this.tb_buscarNumero.TrailingIcon = null;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Seguimiento Por Numero";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(201, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1252, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "SEGUIMIENTO";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancel.Image = ((System.Drawing.Image)(resources.GetObject("bt_cancel.Image")));
            this.bt_cancel.Location = new System.Drawing.Point(1208, 98);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(34, 31);
            this.bt_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_cancel.TabIndex = 24;
            this.bt_cancel.TabStop = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // panel_filtrar
            // 
            this.panel_filtrar.Controls.Add(this.dp_fecha_fin);
            this.panel_filtrar.Controls.Add(this.label7);
            this.panel_filtrar.Controls.Add(this.dp_fecha_inicio);
            this.panel_filtrar.Controls.Add(this.label6);
            this.panel_filtrar.Controls.Add(this.bt_aply);
            this.panel_filtrar.Location = new System.Drawing.Point(1183, 164);
            this.panel_filtrar.Name = "panel_filtrar";
            this.panel_filtrar.Size = new System.Drawing.Size(254, 128);
            this.panel_filtrar.TabIndex = 23;
            // 
            // dp_fecha_fin
            // 
            this.dp_fecha_fin.Location = new System.Drawing.Point(57, 86);
            this.dp_fecha_fin.Name = "dp_fecha_fin";
            this.dp_fecha_fin.Size = new System.Drawing.Size(155, 22);
            this.dp_fecha_fin.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "a:";
            // 
            // dp_fecha_inicio
            // 
            this.dp_fecha_inicio.Location = new System.Drawing.Point(57, 37);
            this.dp_fecha_inicio.Name = "dp_fecha_inicio";
            this.dp_fecha_inicio.Size = new System.Drawing.Size(155, 22);
            this.dp_fecha_inicio.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Seguimiento Por Fecha";
            // 
            // bt_aply
            // 
            this.bt_aply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_aply.Image = ((System.Drawing.Image)(resources.GetObject("bt_aply.Image")));
            this.bt_aply.Location = new System.Drawing.Point(201, -2);
            this.bt_aply.Name = "bt_aply";
            this.bt_aply.Size = new System.Drawing.Size(37, 33);
            this.bt_aply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_aply.TabIndex = 20;
            this.bt_aply.TabStop = false;
            this.bt_aply.Click += new System.EventHandler(this.bt_aply_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(786, 671);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(64, 36);
            this.materialButton1.TabIndex = 35;
            this.materialButton1.Text = "PDF";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // lb_total_rollos
            // 
            this.lb_total_rollos.AutoSize = true;
            this.lb_total_rollos.Location = new System.Drawing.Point(727, 691);
            this.lb_total_rollos.Name = "lb_total_rollos";
            this.lb_total_rollos.Size = new System.Drawing.Size(14, 16);
            this.lb_total_rollos.TabIndex = 40;
            this.lb_total_rollos.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(587, 691);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "TOTAL DE ROLLOS:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialButton3);
            this.panel2.Controls.Add(this.materialComboBox2);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(1183, 580);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 128);
            this.panel2.TabIndex = 42;
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.AutoResize = false;
            this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox2.Depth = 0;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownHeight = 174;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 43;
            this.materialComboBox2.Items.AddRange(new object[] {
            "17.4",
            "13.87",
            "16.2",
            "18.79",
            "15.5",
            "14.9"});
            this.materialComboBox2.Location = new System.Drawing.Point(72, 33);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(138, 49);
            this.materialComboBox2.StartIndex = 0;
            this.materialComboBox2.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Seguimiento por Costo Kilo";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(212, -2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialButton4);
            this.panel1.Controls.Add(this.materialComboBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1183, 432);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 128);
            this.panel1.TabIndex = 41;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "71.0 CMs",
            "76.0 CMs"});
            this.materialComboBox1.Location = new System.Drawing.Point(72, 31);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(138, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Seguimiento por Tipo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(96, 86);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(88, 36);
            this.materialButton4.TabIndex = 43;
            this.materialButton4.Text = "AGREGAR";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(96, 87);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(88, 36);
            this.materialButton3.TabIndex = 44;
            this.materialButton3.Text = "AGREGAR";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_total_rollos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.panel_pornumeros);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.panel_filtrar);
            this.Controls.Add(this.panel_opciones);
            this.Controls.Add(this.tx_dinero);
            this.Controls.Add(this.tx_peso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1437, 733);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_opciones.ResumeLayout(false);
            this.panel_opciones.PerformLayout();
            this.panel_pornumeros.ResumeLayout(false);
            this.panel_pornumeros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_cancel)).EndInit();
            this.panel_filtrar.ResumeLayout(false);
            this.panel_filtrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_aply)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tx_dinero;
        private System.Windows.Forms.Label tx_peso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_opciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFECHA;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox tb_numero;
        private MaterialSkin.Controls.MaterialTextBox tb_peso;
        private System.Windows.Forms.Panel panel_pornumeros;
        private MaterialSkin.Controls.MaterialTextBox tb_buscarNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox bt_cancel;
        private System.Windows.Forms.Panel panel_filtrar;
        private System.Windows.Forms.DateTimePicker dp_fecha_fin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dp_fecha_inicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox bt_aply;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Label lb_total_rollos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton4;
    }
}
