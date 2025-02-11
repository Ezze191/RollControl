namespace Inventario
{
    partial class UserControl3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tx_dinero = new System.Windows.Forms.Label();
            this.tx_peso = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_pornumeros = new System.Windows.Forms.Panel();
            this.tb_buscarNumero = new MaterialSkin.Controls.MaterialTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_filtrar = new System.Windows.Forms.Panel();
            this.dp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_aply = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_medidas = new MaterialSkin.Controls.MaterialComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_costo_kilo = new MaterialSkin.Controls.MaterialButton();
            this.costo_kilo = new MaterialSkin.Controls.MaterialComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_pornumeros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_filtrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_aply)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(650, 661);
            this.dataGridView1.TabIndex = 2;
            // 
            // tx_dinero
            // 
            this.tx_dinero.AutoSize = true;
            this.tx_dinero.Location = new System.Drawing.Point(527, 691);
            this.tx_dinero.Name = "tx_dinero";
            this.tx_dinero.Size = new System.Drawing.Size(14, 16);
            this.tx_dinero.TabIndex = 18;
            this.tx_dinero.Text = "0";
            // 
            // tx_peso
            // 
            this.tx_peso.AutoSize = true;
            this.tx_peso.Location = new System.Drawing.Point(169, 691);
            this.tx_peso.Name = "tx_peso";
            this.tx_peso.Size = new System.Drawing.Size(14, 16);
            this.tx_peso.TabIndex = 17;
            this.tx_peso.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 692);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "TOTAL DINERO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 692);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "TOTAL PESO :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(872, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 69);
            this.label1.TabIndex = 19;
            this.label1.Text = "INVENTARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1096, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "FILTRAR";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancel.Image = ((System.Drawing.Image)(resources.GetObject("bt_cancel.Image")));
            this.bt_cancel.Location = new System.Drawing.Point(985, 147);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(34, 31);
            this.bt_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_cancel.TabIndex = 28;
            this.bt_cancel.TabStop = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1034, 136);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // panel_pornumeros
            // 
            this.panel_pornumeros.Controls.Add(this.tb_buscarNumero);
            this.panel_pornumeros.Controls.Add(this.label9);
            this.panel_pornumeros.Controls.Add(this.pictureBox2);
            this.panel_pornumeros.Location = new System.Drawing.Point(1115, 230);
            this.panel_pornumeros.Name = "panel_pornumeros";
            this.panel_pornumeros.Size = new System.Drawing.Size(254, 128);
            this.panel_pornumeros.TabIndex = 32;
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
            this.label9.Location = new System.Drawing.Point(46, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "BUSCAR POR NUMERO";
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
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel_filtrar
            // 
            this.panel_filtrar.Controls.Add(this.dp_fecha_fin);
            this.panel_filtrar.Controls.Add(this.label7);
            this.panel_filtrar.Controls.Add(this.dp_fecha_inicio);
            this.panel_filtrar.Controls.Add(this.label6);
            this.panel_filtrar.Controls.Add(this.bt_aply);
            this.panel_filtrar.Location = new System.Drawing.Point(765, 230);
            this.panel_filtrar.Name = "panel_filtrar";
            this.panel_filtrar.Size = new System.Drawing.Size(254, 128);
            this.panel_filtrar.TabIndex = 31;
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
            this.label6.Location = new System.Drawing.Point(98, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "FECHA";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.combo_medidas);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(765, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 128);
            this.panel1.TabIndex = 32;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(159, 53);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(88, 36);
            this.materialButton1.TabIndex = 34;
            this.materialButton1.Text = "AGREGAR";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "MEDIDAS";
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
            "76.0 CMs"});
            this.combo_medidas.Location = new System.Drawing.Point(9, 48);
            this.combo_medidas.MaxDropDownItems = 4;
            this.combo_medidas.MouseState = MaterialSkin.MouseState.OUT;
            this.combo_medidas.Name = "combo_medidas";
            this.combo_medidas.Size = new System.Drawing.Size(138, 49);
            this.combo_medidas.StartIndex = 0;
            this.combo_medidas.TabIndex = 33;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_costo_kilo);
            this.panel2.Controls.Add(this.costo_kilo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(1115, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 128);
            this.panel2.TabIndex = 33;
            // 
            // bt_costo_kilo
            // 
            this.bt_costo_kilo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_costo_kilo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_costo_kilo.Depth = 0;
            this.bt_costo_kilo.HighEmphasis = true;
            this.bt_costo_kilo.Icon = null;
            this.bt_costo_kilo.Location = new System.Drawing.Point(161, 53);
            this.bt_costo_kilo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_costo_kilo.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_costo_kilo.Name = "bt_costo_kilo";
            this.bt_costo_kilo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_costo_kilo.Size = new System.Drawing.Size(88, 36);
            this.bt_costo_kilo.TabIndex = 22;
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
            this.costo_kilo.Location = new System.Drawing.Point(11, 48);
            this.costo_kilo.MaxDropDownItems = 4;
            this.costo_kilo.MouseState = MaterialSkin.MouseState.OUT;
            this.costo_kilo.Name = "costo_kilo";
            this.costo_kilo.Size = new System.Drawing.Size(138, 49);
            this.costo_kilo.StartIndex = 0;
            this.costo_kilo.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "COSTO POR KILO";
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
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_pornumeros);
            this.Controls.Add(this.panel_filtrar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_dinero);
            this.Controls.Add(this.tx_peso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(1437, 733);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_pornumeros.ResumeLayout(false);
            this.panel_pornumeros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_filtrar.ResumeLayout(false);
            this.panel_filtrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_aply)).EndInit();
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
        private System.Windows.Forms.Label tx_dinero;
        private System.Windows.Forms.Label tx_peso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox bt_cancel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel_pornumeros;
        private MaterialSkin.Controls.MaterialTextBox tb_buscarNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_filtrar;
        private System.Windows.Forms.DateTimePicker dp_fecha_fin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dp_fecha_inicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox bt_aply;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialComboBox combo_medidas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialButton bt_costo_kilo;
        private MaterialSkin.Controls.MaterialComboBox costo_kilo;
    }
}
