using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Inventario
{
    public partial class screen_login : MaterialForm
    {

        public screen_login()
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
        }
        private void screen_login_Load(object sender, EventArgs e)
        {

            Panel panelFondo = new Panel
            {
                Dock = DockStyle.Fill,

            };

            panelFondo.AutoScroll = true;

            // Mover todos los controles existentes dentro del panel
            while (Controls.Count > 0)
            {
                Control ctrl = Controls[0];
                Controls.Remove(ctrl);
                panelFondo.Controls.Add(ctrl);
            }

            // Agregar el panel al formulario
            Controls.Add(panelFondo);


            //forzar colores
            pictureBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#666666");
            

            try
            {
                using(MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    if (connect.ObtenerConexion().State == ConnectionState.Open)
                    {
                        txt_oline.ForeColor = Color.Green;
                    }
                    else
                    {
                        txt_oline.ForeColor = Color.Red;
                    }   
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Error al conectar a la base de datos :" + err);
            }

        }

        private void lb_login_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void login(string user, string pass)
        {
                try
                {
                    using (MysqlConnector connect = new MysqlConnector())
                    {
                        connect.EstablecerConexion();

                        string query = "SELECT username, tipo FROM users WHERE username = @user AND pass = @pass";

                        using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                        {
                            cmd.Parameters.AddWithValue("@user", user);
                            cmd.Parameters.AddWithValue("@pass", pass);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                int numero = reader.GetInt32("tipo");

                                user_info.Username = user;
                                user_info.Password = pass;
                                user_info.tipo = numero;



                                screen_home home = new screen_home();
                                home.Show();
                                this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("CREDENCIALES INCORRECTAS");
                                }
                            }
                        }
                    } // Aquí se cierra automáticamente la conexión con Dispose()
                }
                catch (Exception err)
                {
                    MessageBox.Show("ERROR: " + err.Message);
                }
            
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == string.Empty || tb_password.Text == string.Empty)
            {
                MessageBox.Show("Tienes que llenar los datos requeridos");
            }
            else
            {
                String username = tb_username.Text;
                String password = tb_password.Text;
                login(username, password);


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
