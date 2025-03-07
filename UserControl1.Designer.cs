namespace Inventario
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_numero = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_peso = new MaterialSkin.Controls.MaterialTextBox();
            this.combo_medidas = new MaterialSkin.Controls.MaterialComboBox();
            this.panel_opciones = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFECHA = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_medidas = new System.Windows.Forms.Label();
            this.bt_costo_kilo = new MaterialSkin.Controls.MaterialButton();
            this.costo_kilo = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_peso = new System.Windows.Forms.Label();
            this.tx_dinero = new System.Windows.Forms.Label();
            this.panel_filtrar = new System.Windows.Forms.Panel();
            this.dp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_aply = new System.Windows.Forms.PictureBox();
            this.bt_cancel = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel_pornumeros = new System.Windows.Forms.Panel();
            this.tb_buscarNumero = new MaterialSkin.Controls.MaterialTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.lb_total_rollos = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_opciones.SuspendLayout();
            this.panel_filtrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_aply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_cancel)).BeginInit();
            this.panel_pornumeros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(824, 661);
            this.dataGridView1.TabIndex = 0;
            // 
            // tb_numero
            // 
            this.tb_numero.AnimateReadOnly = false;
            this.tb_numero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_numero.Depth = 0;
            this.tb_numero.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_numero.Hint = "Numero";
            this.tb_numero.LeadingIcon = null;
            this.tb_numero.Location = new System.Drawing.Point(40, 13);
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
            this.tb_peso.Hint = "Peso";
            this.tb_peso.LeadingIcon = null;
            this.tb_peso.Location = new System.Drawing.Point(41, 92);
            this.tb_peso.MaxLength = 50;
            this.tb_peso.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_peso.Multiline = false;
            this.tb_peso.Name = "tb_peso";
            this.tb_peso.Size = new System.Drawing.Size(261, 50);
            this.tb_peso.TabIndex = 3;
            this.tb_peso.Text = "";
            this.tb_peso.TrailingIcon = null;
            this.tb_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_peso_KeyPress);
            // 
            // combo_medidas
            // 
            this.combo_medidas.AutoResize = false;
            this.combo_medidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.combo_medidas.Depth = 0;
            this.combo_medidas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.combo_medidas.DropDownHeight = 174;
            this.combo_medidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_medidas.DropDownWidth = 121;
            this.combo_medidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.combo_medidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.combo_medidas.FormattingEnabled = true;
            this.combo_medidas.IntegralHeight = false;
            this.combo_medidas.ItemHeight = 43;
            this.combo_medidas.Items.AddRange(new object[] {
            "71.0 CMs",
            "76.0 CMs",
            "38.0 CMs"});
            this.combo_medidas.Location = new System.Drawing.Point(41, 192);
            this.combo_medidas.MaxDropDownItems = 4;
            this.combo_medidas.MouseState = MaterialSkin.MouseState.OUT;
            this.combo_medidas.Name = "combo_medidas";
            this.combo_medidas.Size = new System.Drawing.Size(138, 49);
            this.combo_medidas.StartIndex = 0;
            this.combo_medidas.TabIndex = 4;
            // 
            // panel_opciones
            // 
            this.panel_opciones.Controls.Add(this.label3);
            this.panel_opciones.Controls.Add(this.dtpFECHA);
            this.panel_opciones.Controls.Add(this.label2);
            this.panel_opciones.Controls.Add(this.lb_medidas);
            this.panel_opciones.Controls.Add(this.bt_costo_kilo);
            this.panel_opciones.Controls.Add(this.costo_kilo);
            this.panel_opciones.Controls.Add(this.materialButton2);
            this.panel_opciones.Controls.Add(this.materialButton1);
            this.panel_opciones.Controls.Add(this.tb_numero);
            this.panel_opciones.Controls.Add(this.combo_medidas);
            this.panel_opciones.Controls.Add(this.tb_peso);
            this.panel_opciones.Location = new System.Drawing.Point(830, 76);
            this.panel_opciones.Name = "panel_opciones";
            this.panel_opciones.Size = new System.Drawing.Size(318, 585);
            this.panel_opciones.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "FECHA DE ENTRADA";
            // 
            // dtpFECHA
            // 
            this.dtpFECHA.Location = new System.Drawing.Point(41, 412);
            this.dtpFECHA.Name = "dtpFECHA";
            this.dtpFECHA.Size = new System.Drawing.Size(200, 22);
            this.dtpFECHA.TabIndex = 7;
            this.dtpFECHA.ValueChanged += new System.EventHandler(this.dtpFECHA_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "COSTO POR KILO";
            // 
            // lb_medidas
            // 
            this.lb_medidas.AutoSize = true;
            this.lb_medidas.Location = new System.Drawing.Point(48, 164);
            this.lb_medidas.Name = "lb_medidas";
            this.lb_medidas.Size = new System.Drawing.Size(68, 16);
            this.lb_medidas.TabIndex = 10;
            this.lb_medidas.Text = "MEDIDAS";
            // 
            // bt_costo_kilo
            // 
            this.bt_costo_kilo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_costo_kilo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_costo_kilo.Depth = 0;
            this.bt_costo_kilo.HighEmphasis = true;
            this.bt_costo_kilo.Icon = null;
            this.bt_costo_kilo.Location = new System.Drawing.Point(197, 309);
            this.bt_costo_kilo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_costo_kilo.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_costo_kilo.Name = "bt_costo_kilo";
            this.bt_costo_kilo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_costo_kilo.Size = new System.Drawing.Size(88, 36);
            this.bt_costo_kilo.TabIndex = 9;
            this.bt_costo_kilo.Text = "AGREGAR";
            this.bt_costo_kilo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_costo_kilo.UseAccentColor = false;
            this.bt_costo_kilo.UseVisualStyleBackColor = true;
            this.bt_costo_kilo.Click += new System.EventHandler(this.bt_costo_kilo_Click);
            // 
            // costo_kilo
            // 
            this.costo_kilo.AutoResize = false;
            this.costo_kilo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.costo_kilo.Depth = 0;
            this.costo_kilo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.costo_kilo.DropDownHeight = 174;
            this.costo_kilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.costo_kilo.DropDownWidth = 121;
            this.costo_kilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.costo_kilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.costo_kilo.FormattingEnabled = true;
            this.costo_kilo.IntegralHeight = false;
            this.costo_kilo.ItemHeight = 43;
            this.costo_kilo.Items.AddRange(new object[] {
            "17.4",
            "13.87",
            "16.2",
            "18.79",
            "15.5",
            "14.9"});
            this.costo_kilo.Location = new System.Drawing.Point(41, 296);
            this.costo_kilo.MaxDropDownItems = 4;
            this.costo_kilo.MouseState = MaterialSkin.MouseState.OUT;
            this.costo_kilo.Name = "costo_kilo";
            this.costo_kilo.Size = new System.Drawing.Size(138, 49);
            this.costo_kilo.StartIndex = 0;
            this.costo_kilo.TabIndex = 8;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.BackColor = System.Drawing.Color.Lime;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(80, 471);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(157, 36);
            this.materialButton2.TabIndex = 7;
            this.materialButton2.Text = "Agregar ENTRADA";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = false;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(197, 202);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(88, 36);
            this.materialButton1.TabIndex = 5;
            this.materialButton1.Text = "AGREGAR";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1036, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 69);
            this.label1.TabIndex = 6;
            this.label1.Text = "ENTRADAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 686);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "TOTAL PESO :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 686);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "TOTAL DINERO:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tx_peso
            // 
            this.tx_peso.AutoSize = true;
            this.tx_peso.Location = new System.Drawing.Point(105, 685);
            this.tx_peso.Name = "tx_peso";
            this.tx_peso.Size = new System.Drawing.Size(14, 16);
            this.tx_peso.TabIndex = 9;
            this.tx_peso.Text = "0";
            this.tx_peso.Click += new System.EventHandler(this.tx_peso_Click);
            // 
            // tx_dinero
            // 
            this.tx_dinero.AutoSize = true;
            this.tx_dinero.Location = new System.Drawing.Point(372, 685);
            this.tx_dinero.Name = "tx_dinero";
            this.tx_dinero.Size = new System.Drawing.Size(14, 16);
            this.tx_dinero.TabIndex = 10;
            this.tx_dinero.Text = "0";
            this.tx_dinero.Click += new System.EventHandler(this.tx_dinero_Click);
            // 
            // panel_filtrar
            // 
            this.panel_filtrar.Controls.Add(this.dp_fecha_fin);
            this.panel_filtrar.Controls.Add(this.label7);
            this.panel_filtrar.Controls.Add(this.dp_fecha_inicio);
            this.panel_filtrar.Controls.Add(this.label6);
            this.panel_filtrar.Controls.Add(this.bt_aply);
            this.panel_filtrar.Location = new System.Drawing.Point(1172, 139);
            this.panel_filtrar.Name = "panel_filtrar";
            this.panel_filtrar.Size = new System.Drawing.Size(254, 128);
            this.panel_filtrar.TabIndex = 11;
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
            this.dp_fecha_inicio.ValueChanged += new System.EventHandler(this.dp_fecha_inicio_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Seguimiento por fechas";
            // 
            // bt_aply
            // 
            this.bt_aply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_aply.Image = ((System.Drawing.Image)(resources.GetObject("bt_aply.Image")));
            this.bt_aply.Location = new System.Drawing.Point(212, -2);
            this.bt_aply.Name = "bt_aply";
            this.bt_aply.Size = new System.Drawing.Size(37, 33);
            this.bt_aply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_aply.TabIndex = 20;
            this.bt_aply.TabStop = false;
            this.bt_aply.Click += new System.EventHandler(this.bt_aply_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancel.Image = ((System.Drawing.Image)(resources.GetObject("bt_cancel.Image")));
            this.bt_cancel.Location = new System.Drawing.Point(1198, 72);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(34, 31);
            this.bt_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_cancel.TabIndex = 21;
            this.bt_cancel.TabStop = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1241, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "SEGUIMIENTO";
            // 
            // panel_pornumeros
            // 
            this.panel_pornumeros.Controls.Add(this.tb_buscarNumero);
            this.panel_pornumeros.Controls.Add(this.label9);
            this.panel_pornumeros.Controls.Add(this.pictureBox2);
            this.panel_pornumeros.Location = new System.Drawing.Point(1172, 280);
            this.panel_pornumeros.Name = "panel_pornumeros";
            this.panel_pornumeros.Size = new System.Drawing.Size(254, 128);
            this.panel_pornumeros.TabIndex = 22;
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
            this.tb_buscarNumero.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Seguimiento por Numero";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(212, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(759, 676);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(65, 36);
            this.materialButton3.TabIndex = 36;
            this.materialButton3.Text = "EXCEL";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // lb_total_rollos
            // 
            this.lb_total_rollos.AutoSize = true;
            this.lb_total_rollos.Location = new System.Drawing.Point(619, 685);
            this.lb_total_rollos.Name = "lb_total_rollos";
            this.lb_total_rollos.Size = new System.Drawing.Size(14, 16);
            this.lb_total_rollos.TabIndex = 38;
            this.lb_total_rollos.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(479, 685);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "TOTAL DE ROLLOS:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialComboBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1172, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 128);
            this.panel1.TabIndex = 23;
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
            "76.0 CMs",
            "38.0 CMs"});
            this.materialComboBox1.Location = new System.Drawing.Point(72, 36);
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
            this.label8.Location = new System.Drawing.Point(49, 15);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialComboBox2);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(1172, 573);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 128);
            this.panel2.TabIndex = 24;
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
            this.materialComboBox2.Location = new System.Drawing.Point(72, 39);
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
            this.label12.Location = new System.Drawing.Point(38, 6);
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
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_total_rollos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.panel_pornumeros);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.panel_filtrar);
            this.Controls.Add(this.tx_dinero);
            this.Controls.Add(this.tx_peso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_opciones);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1437, 735);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_opciones.ResumeLayout(false);
            this.panel_opciones.PerformLayout();
            this.panel_filtrar.ResumeLayout(false);
            this.panel_filtrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_aply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_cancel)).EndInit();
            this.panel_pornumeros.ResumeLayout(false);
            this.panel_pornumeros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialTextBox tb_numero;
        private MaterialSkin.Controls.MaterialTextBox tb_peso;
        private MaterialSkin.Controls.MaterialComboBox combo_medidas;
        private System.Windows.Forms.Panel panel_opciones;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton bt_costo_kilo;
        private MaterialSkin.Controls.MaterialComboBox costo_kilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_medidas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFECHA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tx_peso;
        private System.Windows.Forms.Label tx_dinero;
        private System.Windows.Forms.Panel panel_filtrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dp_fecha_inicio;
        private System.Windows.Forms.DateTimePicker dp_fecha_fin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox bt_aply;
        private System.Windows.Forms.PictureBox bt_cancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel_pornumeros;
        private MaterialSkin.Controls.MaterialTextBox tb_buscarNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private System.Windows.Forms.Label lb_total_rollos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
