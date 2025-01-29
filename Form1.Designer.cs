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
            this.lb_login = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_oline = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_login.Location = new System.Drawing.Point(850, 288);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(217, 69);
            this.lb_login.TabIndex = 0;
            this.lb_login.Text = "LOGIN";
            this.lb_login.Click += new System.EventHandler(this.lb_login_Click);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(826, 501);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(300, 22);
            this.tb_username.TabIndex = 1;
            this.tb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_username.TextChanged += new System.EventHandler(this.tb_username_TextChanged);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(826, 754);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(300, 22);
            this.tb_password.TabIndex = 2;
            this.tb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(922, 832);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Inicar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(883, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "USUARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(882, 700);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_oline
            // 
            this.txt_oline.AutoSize = true;
            this.txt_oline.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_oline.ForeColor = System.Drawing.Color.Red;
            this.txt_oline.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_oline.Location = new System.Drawing.Point(12, 917);
            this.txt_oline.Name = "txt_oline";
            this.txt_oline.Size = new System.Drawing.Size(132, 54);
            this.txt_oline.TabIndex = 6;
            this.txt_oline.Text = "Oline";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(679, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(683, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(769, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(425, 807);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // screen_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 980);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_oline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.pictureBox2);
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

        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_oline;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

