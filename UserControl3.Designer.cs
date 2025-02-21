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
            this.panel_filtrar = new System.Windows.Forms.Panel();
            this.dtpMesSeleccionado = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_aply = new System.Windows.Forms.PictureBox();
            this.lb_total_rollos = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.excelButtom = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_filtrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_aply)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(650, 672);
            this.dataGridView1.TabIndex = 2;
            // 
            // tx_dinero
            // 
            this.tx_dinero.AutoSize = true;
            this.tx_dinero.Location = new System.Drawing.Point(286, 691);
            this.tx_dinero.Name = "tx_dinero";
            this.tx_dinero.Size = new System.Drawing.Size(14, 16);
            this.tx_dinero.TabIndex = 18;
            this.tx_dinero.Text = "0";
            // 
            // tx_peso
            // 
            this.tx_peso.AutoSize = true;
            this.tx_peso.Location = new System.Drawing.Point(102, 691);
            this.tx_peso.Name = "tx_peso";
            this.tx_peso.Size = new System.Drawing.Size(14, 16);
            this.tx_peso.TabIndex = 17;
            this.tx_peso.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 692);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "TOTAL DINERO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 692);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "TOTAL PESO :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(825, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 69);
            this.label1.TabIndex = 19;
            this.label1.Text = "INVENTARIO FINAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_filtrar
            // 
            this.panel_filtrar.Controls.Add(this.dtpMesSeleccionado);
            this.panel_filtrar.Controls.Add(this.label6);
            this.panel_filtrar.Controls.Add(this.bt_aply);
            this.panel_filtrar.Location = new System.Drawing.Point(917, 142);
            this.panel_filtrar.Name = "panel_filtrar";
            this.panel_filtrar.Size = new System.Drawing.Size(350, 102);
            this.panel_filtrar.TabIndex = 31;
            // 
            // dtpMesSeleccionado
            // 
            this.dtpMesSeleccionado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMesSeleccionado.Location = new System.Drawing.Point(98, 53);
            this.dtpMesSeleccionado.Name = "dtpMesSeleccionado";
            this.dtpMesSeleccionado.Size = new System.Drawing.Size(155, 22);
            this.dtpMesSeleccionado.TabIndex = 13;
            this.dtpMesSeleccionado.ValueChanged += new System.EventHandler(this.dtpMesSeleccionado_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "SELECCIONAR FECHA DEL INVENTARIO";
            // 
            // bt_aply
            // 
            this.bt_aply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_aply.Image = ((System.Drawing.Image)(resources.GetObject("bt_aply.Image")));
            this.bt_aply.Location = new System.Drawing.Point(310, 3);
            this.bt_aply.Name = "bt_aply";
            this.bt_aply.Size = new System.Drawing.Size(37, 33);
            this.bt_aply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_aply.TabIndex = 20;
            this.bt_aply.TabStop = false;
            this.bt_aply.Click += new System.EventHandler(this.bt_aply_Click);
            // 
            // lb_total_rollos
            // 
            this.lb_total_rollos.AutoSize = true;
            this.lb_total_rollos.Location = new System.Drawing.Point(538, 691);
            this.lb_total_rollos.Name = "lb_total_rollos";
            this.lb_total_rollos.Size = new System.Drawing.Size(14, 16);
            this.lb_total_rollos.TabIndex = 40;
            this.lb_total_rollos.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(406, 691);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "TOTAL DE ROLLOS:";
            // 
            // excelButtom
            // 
            this.excelButtom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.excelButtom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.excelButtom.Depth = 0;
            this.excelButtom.HighEmphasis = true;
            this.excelButtom.Icon = null;
            this.excelButtom.Location = new System.Drawing.Point(585, 681);
            this.excelButtom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.excelButtom.MouseState = MaterialSkin.MouseState.HOVER;
            this.excelButtom.Name = "excelButtom";
            this.excelButtom.NoAccentTextColor = System.Drawing.Color.Empty;
            this.excelButtom.Size = new System.Drawing.Size(65, 36);
            this.excelButtom.TabIndex = 41;
            this.excelButtom.Text = "EXCEL";
            this.excelButtom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.excelButtom.UseAccentColor = false;
            this.excelButtom.UseVisualStyleBackColor = true;
            this.excelButtom.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.excelButtom);
            this.Controls.Add(this.lb_total_rollos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel_filtrar);
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
            this.panel_filtrar.ResumeLayout(false);
            this.panel_filtrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_aply)).EndInit();
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
        private System.Windows.Forms.Panel panel_filtrar;
        private System.Windows.Forms.DateTimePicker dtpMesSeleccionado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox bt_aply;
        private System.Windows.Forms.Label lb_total_rollos;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialButton excelButtom;
    }
}
