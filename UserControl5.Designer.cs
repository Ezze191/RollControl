namespace Inventario
{
    partial class UserControl5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl5));
            this.panel_AgregarUsuarios = new System.Windows.Forms.Panel();
            this.tipo_de_rol = new MaterialSkin.Controls.MaterialComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_repetir_password = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_password = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_username = new MaterialSkin.Controls.MaterialTextBox();
            this.EntradasEditar = new MaterialSkin.Controls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_editarUsuarios = new System.Windows.Forms.Panel();
            this.BasuraBT = new System.Windows.Forms.PictureBox();
            this.SalidasBuscar = new System.Windows.Forms.PictureBox();
            this.Editarbt = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.User = new MaterialSkin.Controls.MaterialTextBox();
            this.Contra = new MaterialSkin.Controls.MaterialTextBox();
            this.bl_tiporol = new System.Windows.Forms.Label();
            this.opciones = new MaterialSkin.Controls.MaterialComboBox();
            this.panel_AgregarUsuarios.SuspendLayout();
            this.panel_editarUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BasuraBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalidasBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_AgregarUsuarios
            // 
            this.panel_AgregarUsuarios.Controls.Add(this.tipo_de_rol);
            this.panel_AgregarUsuarios.Controls.Add(this.label1);
            this.panel_AgregarUsuarios.Controls.Add(this.tb_repetir_password);
            this.panel_AgregarUsuarios.Controls.Add(this.tb_password);
            this.panel_AgregarUsuarios.Controls.Add(this.tb_username);
            this.panel_AgregarUsuarios.Controls.Add(this.EntradasEditar);
            this.panel_AgregarUsuarios.Controls.Add(this.label2);
            this.panel_AgregarUsuarios.Location = new System.Drawing.Point(238, 99);
            this.panel_AgregarUsuarios.Name = "panel_AgregarUsuarios";
            this.panel_AgregarUsuarios.Size = new System.Drawing.Size(314, 606);
            this.panel_AgregarUsuarios.TabIndex = 22;
            // 
            // tipo_de_rol
            // 
            this.tipo_de_rol.AutoResize = false;
            this.tipo_de_rol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tipo_de_rol.Depth = 0;
            this.tipo_de_rol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.tipo_de_rol.DropDownHeight = 174;
            this.tipo_de_rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo_de_rol.DropDownWidth = 121;
            this.tipo_de_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tipo_de_rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tipo_de_rol.FormattingEnabled = true;
            this.tipo_de_rol.IntegralHeight = false;
            this.tipo_de_rol.ItemHeight = 43;
            this.tipo_de_rol.Items.AddRange(new object[] {
            "NORMAL",
            "ADMINISTRADOR"});
            this.tipo_de_rol.Location = new System.Drawing.Point(51, 376);
            this.tipo_de_rol.MaxDropDownItems = 4;
            this.tipo_de_rol.MouseState = MaterialSkin.MouseState.OUT;
            this.tipo_de_rol.Name = "tipo_de_rol";
            this.tipo_de_rol.Size = new System.Drawing.Size(221, 49);
            this.tipo_de_rol.StartIndex = 0;
            this.tipo_de_rol.TabIndex = 15;
            this.tipo_de_rol.SelectedIndexChanged += new System.EventHandler(this.tipo_de_rol_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo de Rol";
            // 
            // tb_repetir_password
            // 
            this.tb_repetir_password.AnimateReadOnly = false;
            this.tb_repetir_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_repetir_password.Depth = 0;
            this.tb_repetir_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_repetir_password.Hint = "Repetir Contraseña";
            this.tb_repetir_password.LeadingIcon = null;
            this.tb_repetir_password.Location = new System.Drawing.Point(51, 261);
            this.tb_repetir_password.MaxLength = 50;
            this.tb_repetir_password.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_repetir_password.Multiline = false;
            this.tb_repetir_password.Name = "tb_repetir_password";
            this.tb_repetir_password.Password = true;
            this.tb_repetir_password.Size = new System.Drawing.Size(221, 50);
            this.tb_repetir_password.TabIndex = 13;
            this.tb_repetir_password.Text = "";
            this.tb_repetir_password.TrailingIcon = null;
            // 
            // tb_password
            // 
            this.tb_password.AnimateReadOnly = false;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Depth = 0;
            this.tb_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_password.Hint = "Contraseña";
            this.tb_password.LeadingIcon = null;
            this.tb_password.Location = new System.Drawing.Point(51, 164);
            this.tb_password.MaxLength = 50;
            this.tb_password.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_password.Multiline = false;
            this.tb_password.Name = "tb_password";
            this.tb_password.Password = true;
            this.tb_password.Size = new System.Drawing.Size(221, 50);
            this.tb_password.TabIndex = 12;
            this.tb_password.Text = "";
            this.tb_password.TrailingIcon = null;
            // 
            // tb_username
            // 
            this.tb_username.AnimateReadOnly = false;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Depth = 0;
            this.tb_username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_username.Hint = "Nombre de Usuario";
            this.tb_username.LeadingIcon = null;
            this.tb_username.Location = new System.Drawing.Point(51, 68);
            this.tb_username.MaxLength = 50;
            this.tb_username.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_username.Multiline = false;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(221, 50);
            this.tb_username.TabIndex = 4;
            this.tb_username.Text = "";
            this.tb_username.TrailingIcon = null;
            // 
            // EntradasEditar
            // 
            this.EntradasEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EntradasEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EntradasEditar.Depth = 0;
            this.EntradasEditar.HighEmphasis = true;
            this.EntradasEditar.Icon = null;
            this.EntradasEditar.Location = new System.Drawing.Point(116, 564);
            this.EntradasEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EntradasEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.EntradasEditar.Name = "EntradasEditar";
            this.EntradasEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EntradasEditar.Size = new System.Drawing.Size(88, 36);
            this.EntradasEditar.TabIndex = 1;
            this.EntradasEditar.Text = "Agregar";
            this.EntradasEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EntradasEditar.UseAccentColor = false;
            this.EntradasEditar.UseVisualStyleBackColor = true;
            this.EntradasEditar.Click += new System.EventHandler(this.EntradasEditar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Agregar Usuario";
            // 
            // panel_editarUsuarios
            // 
            this.panel_editarUsuarios.Controls.Add(this.opciones);
            this.panel_editarUsuarios.Controls.Add(this.bl_tiporol);
            this.panel_editarUsuarios.Controls.Add(this.Contra);
            this.panel_editarUsuarios.Controls.Add(this.User);
            this.panel_editarUsuarios.Controls.Add(this.BasuraBT);
            this.panel_editarUsuarios.Controls.Add(this.SalidasBuscar);
            this.panel_editarUsuarios.Controls.Add(this.Editarbt);
            this.panel_editarUsuarios.Controls.Add(this.label3);
            this.panel_editarUsuarios.Location = new System.Drawing.Point(835, 99);
            this.panel_editarUsuarios.Name = "panel_editarUsuarios";
            this.panel_editarUsuarios.Size = new System.Drawing.Size(314, 606);
            this.panel_editarUsuarios.TabIndex = 23;
            // 
            // BasuraBT
            // 
            this.BasuraBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BasuraBT.Image = ((System.Drawing.Image)(resources.GetObject("BasuraBT.Image")));
            this.BasuraBT.Location = new System.Drawing.Point(263, 550);
            this.BasuraBT.Name = "BasuraBT";
            this.BasuraBT.Size = new System.Drawing.Size(48, 50);
            this.BasuraBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BasuraBT.TabIndex = 12;
            this.BasuraBT.TabStop = false;
            this.BasuraBT.Click += new System.EventHandler(this.BasuraBT_Click);
            // 
            // SalidasBuscar
            // 
            this.SalidasBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalidasBuscar.Image = ((System.Drawing.Image)(resources.GetObject("SalidasBuscar.Image")));
            this.SalidasBuscar.Location = new System.Drawing.Point(261, 3);
            this.SalidasBuscar.Name = "SalidasBuscar";
            this.SalidasBuscar.Size = new System.Drawing.Size(53, 50);
            this.SalidasBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SalidasBuscar.TabIndex = 4;
            this.SalidasBuscar.TabStop = false;
            this.SalidasBuscar.Click += new System.EventHandler(this.SalidasBuscar_Click);
            // 
            // Editarbt
            // 
            this.Editarbt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Editarbt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Editarbt.Depth = 0;
            this.Editarbt.HighEmphasis = true;
            this.Editarbt.Icon = null;
            this.Editarbt.Location = new System.Drawing.Point(132, 564);
            this.Editarbt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Editarbt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Editarbt.Name = "Editarbt";
            this.Editarbt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Editarbt.Size = new System.Drawing.Size(71, 36);
            this.Editarbt.TabIndex = 2;
            this.Editarbt.Text = "Editar";
            this.Editarbt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Editarbt.UseAccentColor = false;
            this.Editarbt.UseVisualStyleBackColor = true;
            this.Editarbt.Click += new System.EventHandler(this.Editarbt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Editar Usuarios";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // User
            // 
            this.User.AnimateReadOnly = false;
            this.User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User.Depth = 0;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.User.Hint = "Nombre de Usuario";
            this.User.LeadingIcon = null;
            this.User.Location = new System.Drawing.Point(60, 68);
            this.User.MaxLength = 50;
            this.User.MouseState = MaterialSkin.MouseState.OUT;
            this.User.Multiline = false;
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(221, 50);
            this.User.TabIndex = 16;
            this.User.Text = "";
            this.User.TrailingIcon = null;
            // 
            // Contra
            // 
            this.Contra.AnimateReadOnly = false;
            this.Contra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contra.Depth = 0;
            this.Contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Contra.Hint = "Contraseña";
            this.Contra.LeadingIcon = null;
            this.Contra.Location = new System.Drawing.Point(60, 163);
            this.Contra.MaxLength = 50;
            this.Contra.MouseState = MaterialSkin.MouseState.OUT;
            this.Contra.Multiline = false;
            this.Contra.Name = "Contra";
            this.Contra.Size = new System.Drawing.Size(221, 50);
            this.Contra.TabIndex = 16;
            this.Contra.Text = "";
            this.Contra.TrailingIcon = null;
            // 
            // bl_tiporol
            // 
            this.bl_tiporol.AutoSize = true;
            this.bl_tiporol.Location = new System.Drawing.Point(57, 338);
            this.bl_tiporol.Name = "bl_tiporol";
            this.bl_tiporol.Size = new System.Drawing.Size(78, 16);
            this.bl_tiporol.TabIndex = 16;
            this.bl_tiporol.Text = "Tipo de Rol";
            // 
            // opciones
            // 
            this.opciones.AutoResize = false;
            this.opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.opciones.Depth = 0;
            this.opciones.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.opciones.DropDownHeight = 174;
            this.opciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.opciones.DropDownWidth = 121;
            this.opciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.opciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.opciones.FormattingEnabled = true;
            this.opciones.IntegralHeight = false;
            this.opciones.ItemHeight = 43;
            this.opciones.Items.AddRange(new object[] {
            "NORMAL",
            "ADMINISTRADOR"});
            this.opciones.Location = new System.Drawing.Point(60, 376);
            this.opciones.MaxDropDownItems = 4;
            this.opciones.MouseState = MaterialSkin.MouseState.OUT;
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(221, 49);
            this.opciones.StartIndex = 0;
            this.opciones.TabIndex = 16;
            // 
            // UserControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_editarUsuarios);
            this.Controls.Add(this.panel_AgregarUsuarios);
            this.Name = "UserControl5";
            this.Size = new System.Drawing.Size(1437, 733);
            this.Load += new System.EventHandler(this.UserControl5_Load);
            this.panel_AgregarUsuarios.ResumeLayout(false);
            this.panel_AgregarUsuarios.PerformLayout();
            this.panel_editarUsuarios.ResumeLayout(false);
            this.panel_editarUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BasuraBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalidasBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_AgregarUsuarios;
        private MaterialSkin.Controls.MaterialTextBox tb_username;
        private MaterialSkin.Controls.MaterialButton EntradasEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox tb_repetir_password;
        private MaterialSkin.Controls.MaterialTextBox tb_password;
        private MaterialSkin.Controls.MaterialComboBox tipo_de_rol;
        private System.Windows.Forms.Panel panel_editarUsuarios;
        private System.Windows.Forms.PictureBox BasuraBT;
        private System.Windows.Forms.PictureBox SalidasBuscar;
        private MaterialSkin.Controls.MaterialButton Editarbt;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox User;
        private MaterialSkin.Controls.MaterialComboBox opciones;
        private System.Windows.Forms.Label bl_tiporol;
        private MaterialSkin.Controls.MaterialTextBox Contra;
    }
}
