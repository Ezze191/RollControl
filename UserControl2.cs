using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class UserControl2 : UserControl
    {
        table_salidas salidas = new table_salidas();
       
        public UserControl2()
        {
            InitializeComponent();
            //forzar colores
            panel_opciones.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            panel_filtrar.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            panel_pornumeros.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            llenartabla();
        }

        private void llenartabla()
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    string query = "select * from  t_salidas";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;

                            //suma
                            double sumaPESO = 0;
                            double sumaTOTAL = 0;

                            foreach (DataRow row in dt.Rows)
                            {
                                if (row["PESO_DE_SALIDA"] != DBNull.Value)
                                {
                                    double valorPESO;
                                    if (double.TryParse(row["PESO_DE_SALIDA"].ToString(), out valorPESO))
                                    {
                                        sumaPESO += valorPESO;
                                    }
                                }
                                if (row["TOTAL"] != DBNull.Value)
                                {
                                    double valorTOTAL;
                                    if (double.TryParse(row["TOTAL"].ToString(), out valorTOTAL))
                                    {
                                        sumaTOTAL += valorTOTAL;
                                    }
                                }
                            }
                            //asiganos los valores a los labels
                            tx_peso.Text = sumaPESO.ToString("N2");
                            tx_dinero.Text = sumaTOTAL.ToString("N2");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if(tb_numero.Text == string.Empty || tb_peso.Text == string.Empty)
            {
                MessageBox.Show("DEBES LLENAR LOS CAMPOS REQUERIDOS");
            }
            else
            {
                string nu = tb_numero.Text;
                buscarnumero(nu);
            }
            
        }

        private void buscarnumero(string numero)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "SELECT * FROM t_entradas WHERE NUMERO = @numero";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@numero", numero);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                salidas.usuario = user_info.Username;
                                salidas.NUMERO = reader.GetString("NUMERO");
                                salidas.FECHA_DE_ENTRADA = reader.GetDateTime("FECHA");
                                salidas.PESO = Double.Parse(tb_peso.Text);
                                salidas.TIPO = reader.GetString("TIPO");
                                salidas.COSTOKILO = reader.GetDouble("COSTOKILO");
                                salidas.TOTAL = reader.GetDouble("TOTAL");
                                salidas.FECHA_DE_SALIDA = dtpFECHA.Value.ToString("yyyy-MM-dd");

                                double pesoanterior = reader.GetDouble("PESO");

                                if (salidas.PESO > pesoanterior) {
                                    MessageBox.Show("EL PESO DE SALIDA DEBE SER MENOR AL PESO QUE ESTA INGRESADO");
                                }
                                else
                                {
                                    llenartabla_salidas();
                                }

                            }
                            else
                            {
                                MessageBox.Show("NUMERO NO ENCONTRADO");
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
        private void llenartabla_salidas()
        {
            using (MysqlConnector connect = new MysqlConnector())
            {
                try
                {
                    connect.EstablecerConexion();
                    string query = "INSERT INTO t_salidas (USUARIO, FECHA_DE_ENTRADA, NUMERO, PESO_DE_SALIDA , TIPO , COSTOKILO, TOTAL, FECHA_DE_SALIDA) VALUES (@user, @fecha, @numero, @peso , @tipo ,@costokilo, @total,@fecha_de_salida)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@user",salidas.usuario);
                        cmd.Parameters.AddWithValue("@fecha", salidas.FECHA_DE_ENTRADA);
                        cmd.Parameters.AddWithValue("@numero", salidas.NUMERO);
                        cmd.Parameters.AddWithValue("@peso", salidas.PESO);
                        cmd.Parameters.AddWithValue("@tipo", salidas.TIPO);
                        cmd.Parameters.AddWithValue("@costokilo", salidas.COSTOKILO);
                        cmd.Parameters.AddWithValue("@total", salidas.TOTAL);
                        cmd.Parameters.AddWithValue("@fecha_de_salida", salidas.FECHA_DE_SALIDA);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Salida registrada correctamente");
                        llenartabla();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }

        }

        private void bt_aply_Click(object sender, EventArgs e)
        {
            string fechaINICIO = dp_fecha_inicio.Value.ToString("yyyy-MM-dd");
            string fechaFIN = dp_fecha_fin.Value.ToString("yyyy-MM-dd");

            tablafiltrada_fehca(fechaINICIO, fechaFIN);
        }

        private void tablafiltrada_fehca(string fi, string fn)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    string query = "SELECT * FROM t_salidas WHERE FECHA_DE_SALIDA >= '" + fi + "' AND FECHA_DE_SALIDA <= '" + fn + "'";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;

                            //suma
                            double sumaPESO = 0;
                            double sumaTOTAL = 0;

                            foreach (DataRow row in dt.Rows)
                            {
                                if (row["PESO_DE_SALIDA"] != DBNull.Value)
                                {
                                    double valorPESO;
                                    if (double.TryParse(row["PESO_DE_SALIDA"].ToString(), out valorPESO))
                                    {
                                        sumaPESO += valorPESO;
                                    }
                                }
                                if (row["TOTAL"] != DBNull.Value)
                                {
                                    double valorTOTAL;
                                    if (double.TryParse(row["TOTAL"].ToString(), out valorTOTAL))
                                    {
                                        sumaTOTAL += valorTOTAL;
                                    }
                                }
                            }
                            //asiganos los valores a los labels
                            tx_peso.Text = sumaPESO.ToString("N2");
                            tx_dinero.Text = sumaTOTAL.ToString("N2");
                        }

                    }
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tablafiltrada_numero(string nu)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    string query = "SELECT * FROM t_salidas WHERE NUMERO = '" + nu + "'";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;

                            //suma
                            double sumaPESO = 0;
                            double sumaTOTAL = 0;

                            foreach (DataRow row in dt.Rows)
                            {
                                if (row["PESO_DE_SALIDA"] != DBNull.Value)
                                {
                                    double valorPESO;
                                    if (double.TryParse(row["PESO_DE_SALIDA"].ToString(), out valorPESO))
                                    {
                                        sumaPESO += valorPESO;
                                    }
                                }
                                if (row["TOTAL"] != DBNull.Value)
                                {
                                    double valorTOTAL;
                                    if (double.TryParse(row["TOTAL"].ToString(), out valorTOTAL))
                                    {
                                        sumaTOTAL += valorTOTAL;
                                    }
                                }
                            }
                            //asiganos los valores a los labels
                            tx_peso.Text = sumaPESO.ToString("N2");
                            tx_dinero.Text = sumaTOTAL.ToString("N2");
                        }

                    }
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (tb_buscarNumero.Text != string.Empty)
            {
                string numero = tb_buscarNumero.Text;
                tablafiltrada_numero(numero);
            }
            else
            {
                MessageBox.Show("Ingrese un numero para buscar");
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            llenartabla();
        }
    }
}
