﻿using MaterialSkin;
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
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;


namespace Inventario
{
    public partial class screen_home : MaterialForm
    {
        private bool sidebarExpanded;
        private Timer timer;

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
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
            //pb salidas
            pictureBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
            pictureBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
            //pbuser
            pb_user.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
            //lbuser
            lb_name.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
            pictureBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
            pictureBox4.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            pb_tool.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");


        }

        private void LoadUserControl(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }


        private void screen_home_Load(object sender, EventArgs e)
        {
            if(user_info.tipo == 0)
            {
                panel2.Visible = false;
                pb_tool.Visible = false;
            }
            

            lb_name.Text = user_info.Username;
        }




        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //cambiar color para saber que esta seleccioando
            pictureBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#8999F3");
            LoadUserControl(new UserControl1());
        }

        private void pb_user_Click(object sender, EventArgs e)
        {
            screen_home home = new screen_home();
            home.Show();
            this.Hide();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            //cambia de color
            pictureBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#374491");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            //cambia al color original
            pictureBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
        }

        private void pb_user_MouseEnter(object sender, EventArgs e)
        {
            pb_user.BackColor = System.Drawing.ColorTranslator.FromHtml("#374491");
        }

        private void pb_user_MouseLeave(object sender, EventArgs e)
        {
            pb_user.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#374491");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl2());
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#374491");
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = System.Drawing.ColorTranslator.FromHtml("#374491");
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ESTAS SEGURO DE CERRAR SESION?", "LOG OUT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                screen_login login = new screen_login();
                login.Show();
                this.Hide();
            }
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl3());
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            user_info.checarstatus();
            if(user_info.status == "open")
            {
                MessageBox.Show("El inventario ya esta abierto");
            }
            else
            {
                abrirInventario();
            }
        }
        private void abrirInventario()
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "update cerrarAbrir_inventario set status = 'open'";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            MessageBox.Show("Inventario Abierto");
                        }
                    }
                } // Aquí se cierra automáticamente la conexión con Dispose()
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
            }
        }
        private void cerrarInventario()
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "update cerrarAbrir_inventario set status = 'close'";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            MessageBox.Show("Inventario Cerrado");
                        }
                    }
                } 
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            user_info.checarstatus();
            if (user_info.status == "close")
            {
                MessageBox.Show("El inventario ya esta cerrado");
            }
            else
            {
                cerrarInventario();
            }
        }

        private void pb_tool_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl4());
        }

        private void pb_tool_MouseEnter(object sender, EventArgs e)
        {
            pb_tool.BackColor = System.Drawing.ColorTranslator.FromHtml("#374491");
            
        }

        private void pb_tool_MouseLeave(object sender, EventArgs e)
        {
            pb_tool.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
        }
    }
}
