namespace Inventario
{
    partial class UserControl4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl4));
            this.label1 = new System.Windows.Forms.Label();
            this.panel_entrada = new System.Windows.Forms.Panel();
            this.panel_salidas = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EntradasEditar = new MaterialSkin.Controls.MaterialButton();
            this.SalidasEditar = new MaterialSkin.Controls.MaterialButton();
            this.EntradasNumero = new MaterialSkin.Controls.MaterialTextBox();
            this.SalidasNumero = new MaterialSkin.Controls.MaterialTextBox();
            this.EntradasBuscar = new System.Windows.Forms.PictureBox();
            this.SalidasBuscar = new System.Windows.Forms.PictureBox();
            this.EntradasUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.EntradasPeso = new MaterialSkin.Controls.MaterialTextBox();
            this.EntradasTipo = new MaterialSkin.Controls.MaterialTextBox();
            this.EntradasCostoKilo = new MaterialSkin.Controls.MaterialTextBox();
            this.EntradasTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.EntradasStatus = new MaterialSkin.Controls.MaterialTextBox();
            this.SalidasTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.SalidasCostoKilo = new MaterialSkin.Controls.MaterialTextBox();
            this.SalidasTipo = new MaterialSkin.Controls.MaterialTextBox();
            this.SalidasPeso = new MaterialSkin.Controls.MaterialTextBox();
            this.SalidasUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.EntradasBasura = new System.Windows.Forms.PictureBox();
            this.SalidasBasura = new System.Windows.Forms.PictureBox();
            this.EntradasFecha = new System.Windows.Forms.DateTimePicker();
            this.SalidasFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SalidasFechDesalida = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_entrada.SuspendLayout();
            this.panel_salidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntradasBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalidasBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradasBasura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalidasBasura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(894, 69);
            this.label1.TabIndex = 20;
            this.label1.Text = "EDITAR ENTRADAS / SALIDAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_entrada
            // 
            this.panel_entrada.Controls.Add(this.label4);
            this.panel_entrada.Controls.Add(this.EntradasFecha);
            this.panel_entrada.Controls.Add(this.EntradasBasura);
            this.panel_entrada.Controls.Add(this.EntradasStatus);
            this.panel_entrada.Controls.Add(this.EntradasTotal);
            this.panel_entrada.Controls.Add(this.EntradasCostoKilo);
            this.panel_entrada.Controls.Add(this.EntradasTipo);
            this.panel_entrada.Controls.Add(this.EntradasPeso);
            this.panel_entrada.Controls.Add(this.EntradasUsuario);
            this.panel_entrada.Controls.Add(this.EntradasBuscar);
            this.panel_entrada.Controls.Add(this.EntradasNumero);
            this.panel_entrada.Controls.Add(this.EntradasEditar);
            this.panel_entrada.Controls.Add(this.label2);
            this.panel_entrada.Location = new System.Drawing.Point(267, 105);
            this.panel_entrada.Name = "panel_entrada";
            this.panel_entrada.Size = new System.Drawing.Size(314, 606);
            this.panel_entrada.TabIndex = 21;
            // 
            // panel_salidas
            // 
            this.panel_salidas.Controls.Add(this.label6);
            this.panel_salidas.Controls.Add(this.SalidasFechDesalida);
            this.panel_salidas.Controls.Add(this.label5);
            this.panel_salidas.Controls.Add(this.SalidasFecha);
            this.panel_salidas.Controls.Add(this.SalidasBasura);
            this.panel_salidas.Controls.Add(this.SalidasBuscar);
            this.panel_salidas.Controls.Add(this.SalidasTotal);
            this.panel_salidas.Controls.Add(this.SalidasNumero);
            this.panel_salidas.Controls.Add(this.SalidasCostoKilo);
            this.panel_salidas.Controls.Add(this.SalidasEditar);
            this.panel_salidas.Controls.Add(this.SalidasTipo);
            this.panel_salidas.Controls.Add(this.label3);
            this.panel_salidas.Controls.Add(this.SalidasPeso);
            this.panel_salidas.Controls.Add(this.SalidasUsuario);
            this.panel_salidas.Location = new System.Drawing.Point(772, 105);
            this.panel_salidas.Name = "panel_salidas";
            this.panel_salidas.Size = new System.Drawing.Size(314, 606);
            this.panel_salidas.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ENTRADAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "SALIDAS";
            // 
            // EntradasEditar
            // 
            this.EntradasEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EntradasEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EntradasEditar.Depth = 0;
            this.EntradasEditar.HighEmphasis = true;
            this.EntradasEditar.Icon = null;
            this.EntradasEditar.Location = new System.Drawing.Point(107, 564);
            this.EntradasEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EntradasEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.EntradasEditar.Name = "EntradasEditar";
            this.EntradasEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EntradasEditar.Size = new System.Drawing.Size(71, 36);
            this.EntradasEditar.TabIndex = 1;
            this.EntradasEditar.Text = "Editar";
            this.EntradasEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EntradasEditar.UseAccentColor = false;
            this.EntradasEditar.UseVisualStyleBackColor = true;
            this.EntradasEditar.Click += new System.EventHandler(this.EntradasEditar_Click);
            // 
            // SalidasEditar
            // 
            this.SalidasEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SalidasEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SalidasEditar.Depth = 0;
            this.SalidasEditar.HighEmphasis = true;
            this.SalidasEditar.Icon = null;
            this.SalidasEditar.Location = new System.Drawing.Point(132, 564);
            this.SalidasEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SalidasEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.SalidasEditar.Name = "SalidasEditar";
            this.SalidasEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SalidasEditar.Size = new System.Drawing.Size(71, 36);
            this.SalidasEditar.TabIndex = 2;
            this.SalidasEditar.Text = "Editar";
            this.SalidasEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SalidasEditar.UseAccentColor = false;
            this.SalidasEditar.UseVisualStyleBackColor = true;
            this.SalidasEditar.Click += new System.EventHandler(this.SalidasEditar_Click);
            // 
            // EntradasNumero
            // 
            this.EntradasNumero.AnimateReadOnly = false;
            this.EntradasNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntradasNumero.Depth = 0;
            this.EntradasNumero.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EntradasNumero.Hint = "Numero";
            this.EntradasNumero.LeadingIcon = null;
            this.EntradasNumero.Location = new System.Drawing.Point(58, 41);
            this.EntradasNumero.MaxLength = 50;
            this.EntradasNumero.MouseState = MaterialSkin.MouseState.OUT;
            this.EntradasNumero.Multiline = false;
            this.EntradasNumero.Name = "EntradasNumero";
            this.EntradasNumero.Size = new System.Drawing.Size(207, 50);
            this.EntradasNumero.TabIndex = 2;
            this.EntradasNumero.Text = "";
            this.EntradasNumero.TrailingIcon = null;
            // 
            // SalidasNumero
            // 
            this.SalidasNumero.AnimateReadOnly = false;
            this.SalidasNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalidasNumero.Depth = 0;
            this.SalidasNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SalidasNumero.Hint = "Numero";
            this.SalidasNumero.LeadingIcon = null;
            this.SalidasNumero.Location = new System.Drawing.Point(55, 41);
            this.SalidasNumero.MaxLength = 50;
            this.SalidasNumero.MouseState = MaterialSkin.MouseState.OUT;
            this.SalidasNumero.Multiline = false;
            this.SalidasNumero.Name = "SalidasNumero";
            this.SalidasNumero.Size = new System.Drawing.Size(207, 50);
            this.SalidasNumero.TabIndex = 3;
            this.SalidasNumero.Text = "";
            this.SalidasNumero.TrailingIcon = null;
            // 
            // EntradasBuscar
            // 
            this.EntradasBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EntradasBuscar.Image = ((System.Drawing.Image)(resources.GetObject("EntradasBuscar.Image")));
            this.EntradasBuscar.Location = new System.Drawing.Point(244, 42);
            this.EntradasBuscar.Name = "EntradasBuscar";
            this.EntradasBuscar.Size = new System.Drawing.Size(53, 50);
            this.EntradasBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EntradasBuscar.TabIndex = 3;
            this.EntradasBuscar.TabStop = false;
            this.EntradasBuscar.Click += new System.EventHandler(this.EntradasBuscar_Click);
            // 
            // SalidasBuscar
            // 
            this.SalidasBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalidasBuscar.Image = ((System.Drawing.Image)(resources.GetObject("SalidasBuscar.Image")));
            this.SalidasBuscar.Location = new System.Drawing.Point(243, 42);
            this.SalidasBuscar.Name = "SalidasBuscar";
            this.SalidasBuscar.Size = new System.Drawing.Size(53, 50);
            this.SalidasBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SalidasBuscar.TabIndex = 4;
            this.SalidasBuscar.TabStop = false;
            this.SalidasBuscar.Click += new System.EventHandler(this.SalidasBuscar_Click);
            // 
            // EntradasUsuario
            // 
            this.EntradasUsuario.AnimateReadOnly = false;
            this.EntradasUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntradasUsuario.Depth = 0;
            this.EntradasUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EntradasUsuario.Hint = "USUARIO";
            this.EntradasUsuario.LeadingIcon = null;
            this.EntradasUsuario.Location = new System.Drawing.Point(58, 102);
            this.EntradasUsuario.MaxLength = 50;
            this.EntradasUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.EntradasUsuario.Multiline = false;
            this.EntradasUsuario.Name = "EntradasUsuario";
            this.EntradasUsuario.Size = new System.Drawing.Size(207, 50);
            this.EntradasUsuario.TabIndex = 4;
            this.EntradasUsuario.Text = "";
            this.EntradasUsuario.TrailingIcon = null;
            // 
            // EntradasPeso
            // 
            this.EntradasPeso.AnimateReadOnly = false;
            this.EntradasPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntradasPeso.Depth = 0;
            this.EntradasPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EntradasPeso.Hint = "PESO";
            this.EntradasPeso.LeadingIcon = null;
            this.EntradasPeso.Location = new System.Drawing.Point(58, 227);
            this.EntradasPeso.MaxLength = 50;
            this.EntradasPeso.MouseState = MaterialSkin.MouseState.OUT;
            this.EntradasPeso.Multiline = false;
            this.EntradasPeso.Name = "EntradasPeso";
            this.EntradasPeso.Size = new System.Drawing.Size(207, 50);
            this.EntradasPeso.TabIndex = 6;
            this.EntradasPeso.Text = "";
            this.EntradasPeso.TrailingIcon = null;
            // 
            // EntradasTipo
            // 
            this.EntradasTipo.AnimateReadOnly = false;
            this.EntradasTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntradasTipo.Depth = 0;
            this.EntradasTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EntradasTipo.Hint = "TIPO";
            this.EntradasTipo.LeadingIcon = null;
            this.EntradasTipo.Location = new System.Drawing.Point(58, 293);
            this.EntradasTipo.MaxLength = 50;
            this.EntradasTipo.MouseState = MaterialSkin.MouseState.OUT;
            this.EntradasTipo.Multiline = false;
            this.EntradasTipo.Name = "EntradasTipo";
            this.EntradasTipo.Size = new System.Drawing.Size(207, 50);
            this.EntradasTipo.TabIndex = 7;
            this.EntradasTipo.Text = "";
            this.EntradasTipo.TrailingIcon = null;
            // 
            // EntradasCostoKilo
            // 
            this.EntradasCostoKilo.AnimateReadOnly = false;
            this.EntradasCostoKilo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntradasCostoKilo.Depth = 0;
            this.EntradasCostoKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EntradasCostoKilo.Hint = "COSTO KILO";
            this.EntradasCostoKilo.LeadingIcon = null;
            this.EntradasCostoKilo.Location = new System.Drawing.Point(58, 361);
            this.EntradasCostoKilo.MaxLength = 50;
            this.EntradasCostoKilo.MouseState = MaterialSkin.MouseState.OUT;
            this.EntradasCostoKilo.Multiline = false;
            this.EntradasCostoKilo.Name = "EntradasCostoKilo";
            this.EntradasCostoKilo.Size = new System.Drawing.Size(207, 50);
            this.EntradasCostoKilo.TabIndex = 8;
            this.EntradasCostoKilo.Text = "";
            this.EntradasCostoKilo.TrailingIcon = null;
            // 
            // EntradasTotal
            // 
            this.EntradasTotal.AnimateReadOnly = false;
            this.EntradasTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntradasTotal.Depth = 0;
            this.EntradasTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EntradasTotal.Hint = "TOTAL";
            this.EntradasTotal.LeadingIcon = null;
            this.EntradasTotal.Location = new System.Drawing.Point(58, 436);
            this.EntradasTotal.MaxLength = 50;
            this.EntradasTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.EntradasTotal.Multiline = false;
            this.EntradasTotal.Name = "EntradasTotal";
            this.EntradasTotal.Size = new System.Drawing.Size(207, 50);
            this.EntradasTotal.TabIndex = 9;
            this.EntradasTotal.Text = "";
            this.EntradasTotal.TrailingIcon = null;
            // 
            // EntradasStatus
            // 
            this.EntradasStatus.AnimateReadOnly = false;
            this.EntradasStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntradasStatus.Depth = 0;
            this.EntradasStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EntradasStatus.Hint = "STATUS";
            this.EntradasStatus.LeadingIcon = null;
            this.EntradasStatus.Location = new System.Drawing.Point(58, 505);
            this.EntradasStatus.MaxLength = 50;
            this.EntradasStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.EntradasStatus.Multiline = false;
            this.EntradasStatus.Name = "EntradasStatus";
            this.EntradasStatus.Size = new System.Drawing.Size(207, 50);
            this.EntradasStatus.TabIndex = 10;
            this.EntradasStatus.Text = "";
            this.EntradasStatus.TrailingIcon = null;
            // 
            // SalidasTotal
            // 
            this.SalidasTotal.AnimateReadOnly = false;
            this.SalidasTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalidasTotal.Depth = 0;
            this.SalidasTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SalidasTotal.Hint = "TOTAL";
            this.SalidasTotal.LeadingIcon = null;
            this.SalidasTotal.Location = new System.Drawing.Point(55, 436);
            this.SalidasTotal.MaxLength = 50;
            this.SalidasTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.SalidasTotal.Multiline = false;
            this.SalidasTotal.Name = "SalidasTotal";
            this.SalidasTotal.Size = new System.Drawing.Size(207, 50);
            this.SalidasTotal.TabIndex = 16;
            this.SalidasTotal.Text = "";
            this.SalidasTotal.TrailingIcon = null;
            // 
            // SalidasCostoKilo
            // 
            this.SalidasCostoKilo.AnimateReadOnly = false;
            this.SalidasCostoKilo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalidasCostoKilo.Depth = 0;
            this.SalidasCostoKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SalidasCostoKilo.Hint = "COSTO KILO";
            this.SalidasCostoKilo.LeadingIcon = null;
            this.SalidasCostoKilo.Location = new System.Drawing.Point(55, 361);
            this.SalidasCostoKilo.MaxLength = 50;
            this.SalidasCostoKilo.MouseState = MaterialSkin.MouseState.OUT;
            this.SalidasCostoKilo.Multiline = false;
            this.SalidasCostoKilo.Name = "SalidasCostoKilo";
            this.SalidasCostoKilo.Size = new System.Drawing.Size(207, 50);
            this.SalidasCostoKilo.TabIndex = 15;
            this.SalidasCostoKilo.Text = "";
            this.SalidasCostoKilo.TrailingIcon = null;
            // 
            // SalidasTipo
            // 
            this.SalidasTipo.AnimateReadOnly = false;
            this.SalidasTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalidasTipo.Depth = 0;
            this.SalidasTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SalidasTipo.Hint = "TIPO";
            this.SalidasTipo.LeadingIcon = null;
            this.SalidasTipo.Location = new System.Drawing.Point(55, 293);
            this.SalidasTipo.MaxLength = 50;
            this.SalidasTipo.MouseState = MaterialSkin.MouseState.OUT;
            this.SalidasTipo.Multiline = false;
            this.SalidasTipo.Name = "SalidasTipo";
            this.SalidasTipo.Size = new System.Drawing.Size(207, 50);
            this.SalidasTipo.TabIndex = 14;
            this.SalidasTipo.Text = "";
            this.SalidasTipo.TrailingIcon = null;
            // 
            // SalidasPeso
            // 
            this.SalidasPeso.AnimateReadOnly = false;
            this.SalidasPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalidasPeso.Depth = 0;
            this.SalidasPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SalidasPeso.Hint = "PESO";
            this.SalidasPeso.LeadingIcon = null;
            this.SalidasPeso.Location = new System.Drawing.Point(55, 227);
            this.SalidasPeso.MaxLength = 50;
            this.SalidasPeso.MouseState = MaterialSkin.MouseState.OUT;
            this.SalidasPeso.Multiline = false;
            this.SalidasPeso.Name = "SalidasPeso";
            this.SalidasPeso.Size = new System.Drawing.Size(207, 50);
            this.SalidasPeso.TabIndex = 13;
            this.SalidasPeso.Text = "";
            this.SalidasPeso.TrailingIcon = null;
            // 
            // SalidasUsuario
            // 
            this.SalidasUsuario.AnimateReadOnly = false;
            this.SalidasUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalidasUsuario.Depth = 0;
            this.SalidasUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SalidasUsuario.Hint = "USUARIO";
            this.SalidasUsuario.LeadingIcon = null;
            this.SalidasUsuario.Location = new System.Drawing.Point(55, 102);
            this.SalidasUsuario.MaxLength = 50;
            this.SalidasUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.SalidasUsuario.Multiline = false;
            this.SalidasUsuario.Name = "SalidasUsuario";
            this.SalidasUsuario.Size = new System.Drawing.Size(207, 50);
            this.SalidasUsuario.TabIndex = 11;
            this.SalidasUsuario.Text = "";
            this.SalidasUsuario.TrailingIcon = null;
            // 
            // EntradasBasura
            // 
            this.EntradasBasura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EntradasBasura.Image = ((System.Drawing.Image)(resources.GetObject("EntradasBasura.Image")));
            this.EntradasBasura.Location = new System.Drawing.Point(263, 550);
            this.EntradasBasura.Name = "EntradasBasura";
            this.EntradasBasura.Size = new System.Drawing.Size(48, 50);
            this.EntradasBasura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EntradasBasura.TabIndex = 11;
            this.EntradasBasura.TabStop = false;
            this.EntradasBasura.Click += new System.EventHandler(this.EntradasBasura_Click);
            // 
            // SalidasBasura
            // 
            this.SalidasBasura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalidasBasura.Image = ((System.Drawing.Image)(resources.GetObject("SalidasBasura.Image")));
            this.SalidasBasura.Location = new System.Drawing.Point(263, 550);
            this.SalidasBasura.Name = "SalidasBasura";
            this.SalidasBasura.Size = new System.Drawing.Size(48, 50);
            this.SalidasBasura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SalidasBasura.TabIndex = 12;
            this.SalidasBasura.TabStop = false;
            this.SalidasBasura.Click += new System.EventHandler(this.SalidasBasura_Click);
            // 
            // EntradasFecha
            // 
            this.EntradasFecha.Location = new System.Drawing.Point(58, 180);
            this.EntradasFecha.Name = "EntradasFecha";
            this.EntradasFecha.Size = new System.Drawing.Size(200, 22);
            this.EntradasFecha.TabIndex = 12;
            // 
            // SalidasFecha
            // 
            this.SalidasFecha.Location = new System.Drawing.Point(55, 171);
            this.SalidasFecha.Name = "SalidasFecha";
            this.SalidasFecha.Size = new System.Drawing.Size(200, 22);
            this.SalidasFecha.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "FECHA";
            // 
            // SalidasFechDesalida
            // 
            this.SalidasFechDesalida.Location = new System.Drawing.Point(55, 519);
            this.SalidasFechDesalida.Name = "SalidasFechDesalida";
            this.SalidasFechDesalida.Size = new System.Drawing.Size(200, 22);
            this.SalidasFechDesalida.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "FECHA DE SALIDA";
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_salidas);
            this.Controls.Add(this.panel_entrada);
            this.Controls.Add(this.label1);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(1437, 733);
            this.Load += new System.EventHandler(this.UserControl4_Load);
            this.panel_entrada.ResumeLayout(false);
            this.panel_entrada.PerformLayout();
            this.panel_salidas.ResumeLayout(false);
            this.panel_salidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntradasBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalidasBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradasBasura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalidasBasura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_entrada;
        private System.Windows.Forms.Panel panel_salidas;
        private MaterialSkin.Controls.MaterialButton EntradasEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialButton SalidasEditar;
        private MaterialSkin.Controls.MaterialTextBox EntradasNumero;
        private MaterialSkin.Controls.MaterialTextBox SalidasNumero;
        private System.Windows.Forms.PictureBox EntradasBuscar;
        private System.Windows.Forms.PictureBox SalidasBuscar;
        private MaterialSkin.Controls.MaterialTextBox EntradasTipo;
        private MaterialSkin.Controls.MaterialTextBox EntradasPeso;
        private MaterialSkin.Controls.MaterialTextBox EntradasUsuario;
        private System.Windows.Forms.PictureBox EntradasBasura;
        private MaterialSkin.Controls.MaterialTextBox EntradasStatus;
        private MaterialSkin.Controls.MaterialTextBox EntradasTotal;
        private MaterialSkin.Controls.MaterialTextBox EntradasCostoKilo;
        private System.Windows.Forms.PictureBox SalidasBasura;
        private MaterialSkin.Controls.MaterialTextBox SalidasTotal;
        private MaterialSkin.Controls.MaterialTextBox SalidasCostoKilo;
        private MaterialSkin.Controls.MaterialTextBox SalidasTipo;
        private MaterialSkin.Controls.MaterialTextBox SalidasPeso;
        private MaterialSkin.Controls.MaterialTextBox SalidasUsuario;
        private System.Windows.Forms.DateTimePicker EntradasFecha;
        private System.Windows.Forms.DateTimePicker SalidasFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker SalidasFechDesalida;
        private System.Windows.Forms.Label label5;
    }
}
