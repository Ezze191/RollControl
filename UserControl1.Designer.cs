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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_numero = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_peso = new MaterialSkin.Controls.MaterialTextBox();
            this.combo_medidas = new MaterialSkin.Controls.MaterialComboBox();
            this.panel_opciones = new System.Windows.Forms.Panel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.costo_kilo = new MaterialSkin.Controls.MaterialComboBox();
            this.bt_costo_kilo = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_medidas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(854, 735);
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
            "71.0 CMs"});
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
            this.panel_opciones.Controls.Add(this.label2);
            this.panel_opciones.Controls.Add(this.lb_medidas);
            this.panel_opciones.Controls.Add(this.bt_costo_kilo);
            this.panel_opciones.Controls.Add(this.costo_kilo);
            this.panel_opciones.Controls.Add(this.materialButton2);
            this.panel_opciones.Controls.Add(this.materialButton1);
            this.panel_opciones.Controls.Add(this.tb_numero);
            this.panel_opciones.Controls.Add(this.combo_medidas);
            this.panel_opciones.Controls.Add(this.tb_peso);
            this.panel_opciones.Location = new System.Drawing.Point(940, 168);
            this.panel_opciones.Name = "panel_opciones";
            this.panel_opciones.Size = new System.Drawing.Size(318, 462);
            this.panel_opciones.TabIndex = 5;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(113, 399);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(141, 36);
            this.materialButton2.TabIndex = 7;
            this.materialButton2.Text = "Agregar SALIDA";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
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
            "17.4"});
            this.costo_kilo.Location = new System.Drawing.Point(41, 296);
            this.costo_kilo.MaxDropDownItems = 4;
            this.costo_kilo.MouseState = MaterialSkin.MouseState.OUT;
            this.costo_kilo.Name = "costo_kilo";
            this.costo_kilo.Size = new System.Drawing.Size(138, 49);
            this.costo_kilo.StartIndex = 0;
            this.costo_kilo.TabIndex = 8;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(979, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 69);
            this.label1.TabIndex = 6;
            this.label1.Text = "SALIDAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "COSTO POR KILO";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_opciones);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1305, 735);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_opciones.ResumeLayout(false);
            this.panel_opciones.PerformLayout();
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
    }
}
