using DocumentFormat.OpenXml.Office2013.Word;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClosedXML.Excel.XLPredefinedFormat;
using DateTime = System.DateTime;


namespace Inventario
{
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void UserControl4_Load(object sender, EventArgs e)
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


            //filtrar colores
            panel_entrada.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            panel_salidas.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");

            EntradasUsuario.Visible = false;
            EntradasFecha.Visible = false;
            EntradasPeso.Visible = false;
            EntradasTipo.Visible = false;
            EntradasCostoKilo.Visible = false;
            EntradasTotal.Visible = false;
            EntradasStatus.Visible = false;
            EntradasEditar.Visible = false;
            EntradasBasura.Visible = false;
            label4.Visible = false;
            

            SalidasUsuario.Visible = false;
            SalidasFecha.Visible = false;
            SalidasPeso.Visible = false;
            SalidasTipo.Visible = false;
            SalidasCostoKilo.Visible = false;
            SalidasTotal.Visible = false;
            SalidasEditar.Visible = false;
            SalidasBasura.Visible = false;
            SalidasFechDesalida.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void BuscarEntradas(string Numero)
        {
            //buscar si el numero existe
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "SELECT * FROM t_entradas WHERE NUMERO = @numero";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@numero", Numero);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                EntradasUsuario.Visible = true;
                                EntradasFecha.Visible = true;
                                EntradasPeso.Visible = true;
                                EntradasTipo.Visible = true;
                                EntradasCostoKilo.Visible = true;
                                EntradasTotal.Visible = true;
                                EntradasStatus.Visible = true;
                                EntradasEditar.Visible = true;
                                EntradasBasura.Visible = true;
                                label4.Visible = true;

                                //reasignar valores a texboxes
                                EntradasUsuario.Text = reader["USUARIO"].ToString();
                                EntradasFecha.Text = reader["FECHA"].ToString();
                                EntradasPeso.Text = reader["PESO"].ToString();
                                EntradasTipo.Text = reader["TIPO"].ToString();
                                EntradasCostoKilo.Text = reader["COSTOKILO"].ToString();
                                EntradasTotal.Text = reader["TOTAL"].ToString();
                                EntradasStatus.Text = reader["STATUS"].ToString();

                                

                            }
                            else
                            {
                                MessageBox.Show("No se encontró el número");
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

        private void BuscarSalidas(string Numero)
        {
            //buscar si el numero existe
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "SELECT * FROM t_salidas WHERE NUMERO = @numero";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@numero", Numero);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SalidasUsuario.Visible = true;
                                SalidasFecha.Visible = true;
                                SalidasPeso.Visible = true;
                                SalidasTipo.Visible = true;
                                SalidasCostoKilo.Visible = true;
                                SalidasTotal.Visible = true;
                                SalidasEditar.Visible = true;
                                SalidasBasura.Visible = true;
                                SalidasFechDesalida.Visible = true;
                                label5.Visible = true;
                                label6.Visible = true;

                                //reasignar valores a texboxes
                                SalidasUsuario.Text = reader["USUARIO"].ToString();
                                SalidasFecha.Text = reader["FECHA_DE_ENTRADA"].ToString();
                                SalidasPeso.Text = reader["PESO_DE_SALIDA"].ToString();
                                SalidasTipo.Text = reader["TIPO"].ToString();
                                SalidasCostoKilo.Text = reader["COSTOKILO"].ToString();
                                SalidasTotal.Text = reader["TOTAL"].ToString();
                                SalidasFechDesalida.Text = reader["FECHA_DE_SALIDA"].ToString();

                            }
                            else
                            {
                                MessageBox.Show("No se encontró el número");
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

        private void actualizarEnInventario()
        {
            string Numero = EntradasNumero.Text;
            string Usuario = EntradasUsuario.Text;
            string Fecha = EntradasFecha.Value.ToString("yyyy-MM-dd");
            double Peso = Convert.ToDouble(EntradasPeso.Text);
            string Tipo = EntradasTipo.Text;
            double CostoKilo = Convert.ToDouble(EntradasCostoKilo.Text);
            double Total = Convert.ToDouble(EntradasTotal.Text);
            string Status = EntradasStatus.Text;

            // Buscar si el número existe
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    // Consulta SQL corregida
                    string query = "UPDATE inventario_inicial SET FECHA = @Fecha, PESO = @Peso, TIPO = @Tipo, COSTOKILO = @CostoKilo, TOTAL = @Total WHERE NUMERO = @Numero";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@Numero", Numero);
                        cmd.Parameters.AddWithValue("@Fecha", Fecha);
                        cmd.Parameters.AddWithValue("@Peso", Peso);
                        cmd.Parameters.AddWithValue("@Tipo", Tipo);
                        cmd.Parameters.AddWithValue("@CostoKilo", CostoKilo);
                        cmd.Parameters.AddWithValue("@Total", Total);

                        // Ejecutar el comando de actualización
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Verificar si se actualizó alguna fila
                        if (rowsAffected > 0)
                        {
                            EntradasNumero.Text = string.Empty;
                        }
                        else
                        {
                           
                        }
                    }
                } // Aquí se cierra automáticamente la conexión con Dispose()
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
            }

        }

        private void eliminarEntradas(string Numero)
        {
            try
            {

                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "DELETE FROM t_entradas WHERE NUMERO = @numero";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@numero", Numero);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            //eliminar del inventario
                            EliminarDelInventario(Numero);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
            }

        }

        private void EliminarSalidas(string Numero)
        {
            try
            {

                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "DELETE FROM t_salidas WHERE NUMERO = @numero";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@numero", Numero);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            MessageBox.Show("Salida Eliminada");
                            SalidasUsuario.Visible = false;
                            SalidasFecha.Visible = false;
                            SalidasPeso.Visible = false;
                            SalidasTipo.Visible = false;
                            SalidasCostoKilo.Visible = false;
                            SalidasTotal.Visible = false;
                            SalidasEditar.Visible = false;
                            SalidasBasura.Visible = false;
                            SalidasFechDesalida.Visible = false;
                            label5.Visible = false;
                            label6.Visible = false;
                            SalidasNumero.Text = string.Empty;
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
            }
        }

        private void EliminarDelInventario(string Numero)
        {
            try
            {

                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "DELETE FROM inventario_inicial WHERE NUMERO = @numero";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@numero", Numero);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            MessageBox.Show("ENTRADA ELIMINADA");

                            EntradasUsuario.Visible = false;
                            EntradasFecha.Visible = false;
                            EntradasPeso.Visible = false;
                            EntradasTipo.Visible = false;
                            EntradasCostoKilo.Visible = false;
                            EntradasTotal.Visible = false;
                            EntradasStatus.Visible = false;
                            EntradasEditar.Visible = false;
                            EntradasBasura.Visible = false;
                            label4.Visible = false;
                            EntradasNumero.Text = string.Empty;


                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
            }
        }

        private void editarEntradas()
        {
            string Numero = EntradasNumero.Text;
            string Usuario = EntradasUsuario.Text;
            string Fecha = EntradasFecha.Value.ToString("yyyy-MM-dd");
            double Peso = Convert.ToDouble(EntradasPeso.Text);
            string Tipo = EntradasTipo.Text;
            double CostoKilo = Convert.ToDouble(EntradasCostoKilo.Text);
            double Total = Convert.ToDouble(EntradasTotal.Text);
            string Status = EntradasStatus.Text;

            // Buscar si el número existe
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    // Consulta SQL corregida
                    string query = "UPDATE t_entradas SET USUARIO = @Usuario, FECHA = @Fecha, PESO = @Peso, TIPO = @Tipo, COSTOKILO = @CostoKilo, TOTAL = @Total, STATUS = @Status WHERE NUMERO = @Numero";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@Numero", Numero);
                        cmd.Parameters.AddWithValue("@Usuario", Usuario);
                        cmd.Parameters.AddWithValue("@Fecha", Fecha);
                        cmd.Parameters.AddWithValue("@Peso", Peso);
                        cmd.Parameters.AddWithValue("@Tipo", Tipo);
                        cmd.Parameters.AddWithValue("@CostoKilo", CostoKilo);
                        cmd.Parameters.AddWithValue("@Total", Total);
                        cmd.Parameters.AddWithValue("@Status", Status);

                        // Ejecutar el comando de actualización
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Verificar si se actualizó alguna fila
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Entrada editada");
                            EntradasUsuario.Visible = false;
                            EntradasFecha.Visible = false;
                            EntradasPeso.Visible = false;
                            EntradasTipo.Visible = false;
                            EntradasCostoKilo.Visible = false;
                            EntradasTotal.Visible = false;
                            EntradasStatus.Visible = false;
                            EntradasEditar.Visible = false;
                            EntradasBasura.Visible = false;
                            label4.Visible = false;

                            actualizarEnInventario();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ninguna entrada con ese número.");
                        }
                    }
                } // Aquí se cierra automáticamente la conexión con Dispose()
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
            }
        }

        private void editarSalida()
        {
            string Numero = SalidasNumero.Text;
            string Usuario = SalidasUsuario.Text;
            string Fecha = SalidasFecha.Value.ToString("yyyy-MM-dd");
            double Peso = Convert.ToDouble(SalidasPeso.Text);
            string Tipo = SalidasTipo.Text;
            double CostoKilo = Convert.ToDouble(SalidasCostoKilo.Text);
            double Total = Convert.ToDouble(SalidasTotal.Text);
            string fecha_de_salida = SalidasFechDesalida.Value.ToString("yyyy-MM-dd");

            // Buscar si el número existe
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    // Consulta SQL corregida
                    string query = "UPDATE t_salidas SET USUARIO = @Usuario, FECHA_DE_ENTRADA = @Fecha, PESO_DE_SALIDA = @Peso, TIPO = @Tipo, COSTOKILO = @CostoKilo, TOTAL = @Total, FECHA_DE_SALIDA = @FECHA_DE_SALIDA WHERE NUMERO = @Numero";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@Numero", Numero);
                        cmd.Parameters.AddWithValue("@Usuario", Usuario);
                        cmd.Parameters.AddWithValue("@Fecha", Fecha);
                        cmd.Parameters.AddWithValue("@Peso", Peso);
                        cmd.Parameters.AddWithValue("@Tipo", Tipo);
                        cmd.Parameters.AddWithValue("@CostoKilo", CostoKilo);
                        cmd.Parameters.AddWithValue("@Total", Total);
                        cmd.Parameters.AddWithValue("@FECHA_DE_SALIDA", fecha_de_salida);

                        // Ejecutar el comando de actualización
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Verificar si se actualizó alguna fila
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Salida editada");
                            SalidasUsuario.Visible = false;
                            SalidasFecha.Visible = false;
                            SalidasPeso.Visible = false;
                            SalidasTipo.Visible = false;
                            SalidasCostoKilo.Visible = false;
                            SalidasTotal.Visible = false;
                            SalidasEditar.Visible = false;
                            SalidasBasura.Visible = false;
                            SalidasFechDesalida.Visible = false;
                            label5.Visible = false;
                            label6.Visible = false;
                            SalidasNumero.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ninguna salida con ese número.");
                        }
                    }
                } // Aquí se cierra automáticamente la conexión con Dispose()
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
            }
        }

        private void EntradasBuscar_Click(object sender, EventArgs e)
        {
            BuscarEntradas(EntradasNumero.Text);
        }

        private void EntradasEditar_Click(object sender, EventArgs e)
        {
            editarEntradas();
        }

        private void EntradasBasura_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ESTAS SEGURO DE ELIMINAR LA ENTRADA?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                eliminarEntradas(EntradasNumero.Text);
            }
            
        }

        private void SalidasBuscar_Click(object sender, EventArgs e)
        {
            BuscarSalidas(SalidasNumero.Text);
        }

        private void SalidasEditar_Click(object sender, EventArgs e)
        {
            editarSalida();
        }

        private void SalidasBasura_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ESTAS SEGURO DE ELIMINAR LA SALIDA?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                EliminarSalidas(SalidasNumero.Text);
            }
        }
    }
}
