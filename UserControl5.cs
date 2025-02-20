using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Vml;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClosedXML.Excel.XLPredefinedFormat;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventario
{
    public partial class UserControl5 : UserControl
    {
        string newuser = "";
        string username = "";
        string password = "";
        int tipo;
        public UserControl5()
        {
            InitializeComponent();
        }

        private void EntradasEditar_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == string.Empty || tb_password.Text == string.Empty || tb_repetir_password.Text == string.Empty)
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else if (tb_password.Text != tb_repetir_password.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            else
            {
                username = tb_username.Text;
                password = tb_password.Text;
                if (tipo_de_rol.Text == "NORMAL")
                {
                    tipo = 0;
                }
                else
                {
                    tipo = 1;
                }

                //checar si ya existe
                checarExistenciaDeUsuario();

            }
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {
            //forzar colores
            panel_AgregarUsuarios.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            panel_editarUsuarios.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");


            desabilitarOpciones();
        }

        private void desabilitarOpciones()
        {
            Contra.Visible = false;
            bl_tiporol.Visible = false;
            opciones.Visible = false;
            Editarbt.Visible = false;
            BasuraBT.Visible = false;
        }

        private void habilitarOpciones()
        {
            Contra.Visible = true;
            bl_tiporol.Visible = true;
            opciones.Visible = true;
            Editarbt.Visible = true;
            BasuraBT.Visible = true;
        }

        private void checarExistenciaDeUsuario()
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "SELECT *FROM users WHERE username = @user AND pass = @pass";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("EL USUARIO YA EXISTE");
                            }
                            else
                            {
                                //registrar usuario
                                registrarUsuario();
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

        private void registrarUsuario()
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "INSERT INTO users(username, pass, tipo) VALUES(@user, @pass, @tipo)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", password);
                        cmd.Parameters.AddWithValue("@tipo", tipo);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("USUARIO REGISTRADO");

                        tb_username.Text = string.Empty;
                        tb_password.Text = string.Empty;
                        tb_repetir_password.Text = string.Empty;
                    }
                } // Aquí se cierra automáticamente la conexión con Dispose()
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
            }
        }

        private void tipo_de_rol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SalidasBuscar_Click(object sender, EventArgs e)
        {
            username = User.Text;
            //buscar si existe el usuario
            BuscarUsuarioyObtenerDatos(username);

        }
        private void BuscarUsuarioyObtenerDatos(string user)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "SELECT *FROM users WHERE username = @user";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@user", user);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                habilitarOpciones();
                                User.Text = reader.GetString("username");
                                Contra.Text = reader.GetString("pass");

                                username = reader.GetString("username");

                                if (reader.GetInt32("tipo") == 0)
                                {
                                    opciones.Text = "NORMAL";
                                }
                                else
                                {
                                    opciones.Text = "ADMINISTRADOR";
                                }
                            }
                            else
                            {
                                MessageBox.Show("EL USUARIO NO EXISTE");
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

        private void Editarbt_Click(object sender, EventArgs e)
        {
            if(User.Text == string.Empty || Contra.Text == string.Empty)
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                newuser = User.Text;
                password = Contra.Text;
                if (opciones.Text == "NORMAL")
                {
                    tipo = 0;
                }
                else
                {
                    tipo = 1;
                }
                editarUsuario(username);
            }
        }
        private void editarUsuario(string user)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    // Consulta SQL corregida
                    string query = "UPDATE users SET username = @username, pass = @password, tipo = @tipo WHERE username = @user";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@username", newuser);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@tipo", tipo);


                        // Ejecutar el comando de actualización
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Verificar si se actualizó alguna fila
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario actualizado correctamente.");
                            desabilitarOpciones();
                            User.Text = string.Empty;
                        }
                        
                    }
                } // Aquí se cierra automáticamente la conexión con Dispose()
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
            }
        }

        private void BasuraBT_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ESTAS SEGURO DE ELIMINAR EL USUARIO?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //eliminar usuario
                EliminarUsuario(User.Text);
            }

           
        }

        private void EliminarUsuario(string user)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    // Consulta SQL corregida
                    string query = "DELETE FROM users WHERE username = @user";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@user", user);

                        // Ejecutar el comando de actualización
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Verificar si se actualizó alguna fila
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario Eliminado Correctamente.");
                            desabilitarOpciones();
                            User.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("EL USUARIO NO EXISTE");
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
