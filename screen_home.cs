using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;


namespace Inventario
{
    public partial class screen_home : MaterialForm
    {
        private Panel sidebar;

        private void BtnHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Home Clicked!");
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings Clicked!");
        }



        public screen_home()
        {
            InitializeComponent();
            // Create MaterialSkin manager
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; // or DARK

            // Color scheme
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue500, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
                );

            //colores forzados
            //barra lateral
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#3f51b5");
            //pb salidas
            pictureBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#3f51b5");
            //pbuser
            pb_user.BackColor = System.Drawing.ColorTranslator.FromHtml("#5C6ED0");


        }

        private void LoadUserControl(UserControl uc)
        { 
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }


        private void screen_home_Load(object sender, EventArgs e)
        {
            lb_name.Text = user_info.Username;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
           LoadUserControl(new UserControl1());
        }
    }
}
