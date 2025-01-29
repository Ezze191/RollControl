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

namespace Inventario
{
    public partial class screen_login : Form
    {
        

        public screen_login()
        {
            InitializeComponent();

        }

        private void screen_login_Load(object sender, EventArgs e)
        {
            try
            {
                /*
                connect.EstablecerConexion();
                txt_oline.ForeColor = Color.Green;
                connect.CerrarConexion();
                */
                using(MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    txt_oline.ForeColor = Color.Green;
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
            if(tb_username.Text == string.Empty || tb_password.Text == string.Empty)
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

        private void login(string user, string pass)
        {
                try
                {
                    using (MysqlConnector connect = new MysqlConnector())
                    {
                        connect.EstablecerConexion();

                        string query = "SELECT username FROM users WHERE username = @user AND pass = @pass";

                        using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                        {
                            cmd.Parameters.AddWithValue("@user", user);
                            cmd.Parameters.AddWithValue("@pass", pass);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
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
    }
}
