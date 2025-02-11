namespace Inventario
{
    partial class screen_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(screen_login));
            this.txt_oline = new System.Windows.Forms.Label();
            this.bt_login = new MaterialSkin.Controls.MaterialButton();
            this.tb_username = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_password = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_oline
            // 
            this.txt_oline.AutoSize = true;
            this.txt_oline.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_oline.ForeColor = System.Drawing.Color.Red;
            this.txt_oline.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_oline.Location = new System.Drawing.Point(748, 761);
            this.txt_oline.Name = "txt_oline";
            this.txt_oline.Size = new System.Drawing.Size(132, 54);
            this.txt_oline.TabIndex = 6;
            this.txt_oline.Text = "Oline";
            // 
            // bt_login
            // 
            this.bt_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_login.Depth = 0;
            this.bt_login.HighEmphasis = true;
            this.bt_login.Icon = null;
            this.bt_login.Location = new System.Drawing.Point(887, 710);
            this.bt_login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_login.Name = "bt_login";
            this.bt_login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_login.Size = new System.Drawing.Size(128, 36);
            this.bt_login.TabIndex = 9;
            this.bt_login.Text = "Iniciar Sesion";
            this.bt_login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_login.UseAccentColor = false;
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // tb_username
            // 
            this.tb_username.AnimateReadOnly = false;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Depth = 0;
            this.tb_username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_username.Hint = "Usuario";
            this.tb_username.LeadingIcon = null;
            this.tb_username.Location = new System.Drawing.Point(864, 450);
            this.tb_username.MaxLength = 50;
            this.tb_username.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_username.Multiline = false;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(221, 50);
            this.tb_username.TabIndex = 10;
            this.tb_username.Text = "";
            this.tb_username.TrailingIcon = null;
            // 
            // tb_password
            // 
            this.tb_password.AnimateReadOnly = false;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Depth = 0;
            this.tb_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_password.Hint = "Contraseña";
            this.tb_password.LeadingIcon = null;
            this.tb_password.Location = new System.Drawing.Point(864, 589);
            this.tb_password.MaxLength = 50;
            this.tb_password.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_password.Multiline = false;
            this.tb_password.Name = "tb_password";
            this.tb_password.Password = true;
            this.tb_password.Size = new System.Drawing.Size(221, 50);
            this.tb_password.TabIndex = 11;
            this.tb_password.Text = "";
            this.tb_password.TrailingIcon = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(739, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 623);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(834, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 235);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // screen_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 980);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.txt_oline);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "screen_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.screen_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_oline;
        private MaterialSkin.Controls.MaterialButton bt_login;
        private MaterialSkin.Controls.MaterialTextBox tb_username;
        private MaterialSkin.Controls.MaterialTextBox tb_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        
    }
}

