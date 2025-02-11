using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
            //forzar colores
            panel_filtrar.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            panel_pornumeros.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
        }

        private void UserControl3_Load(object sender, EventArgs e)
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
                    string query = "select * from  inventario_final";
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
                                if (row["PESO"] != DBNull.Value)
                                {
                                    double valorPESO;
                                    if (double.TryParse(row["PESO"].ToString(), out valorPESO))
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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string nuevamedida = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nueva medida", "Nueva medida", "0");

            if (!string.IsNullOrWhiteSpace(nuevamedida))
            {
                combo_medidas.Items.Add(nuevamedida);
                MessageBox.Show("Medida agregada correctamente");
            }
            else
            {
                MessageBox.Show("No se ingreso ninguna medida");
            }
        }

        private void bt_costo_kilo_Click(object sender, EventArgs e)
        {
            string nuevo_costo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo costo por kilo", "Nuevo costo", "0");

            if (!string.IsNullOrWhiteSpace(nuevo_costo))
            {
                costo_kilo.Items.Add(nuevo_costo);
                MessageBox.Show("Costo agregado correctamente");
            }
            else
            {
                MessageBox.Show("No se ingreso ningun costo");
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            llenartabla();
        }
        private void tablafiltrada_fehca(string fi, string fn)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    string query = "SELECT * FROM inventario_final WHERE FECHA >= '" + fi + "' AND FECHA <= '" + fn + "'";
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
                                if (row["PESO"] != DBNull.Value)
                                {
                                    double valorPESO;
                                    if (double.TryParse(row["PESO"].ToString(), out valorPESO))
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
                    string query = "SELECT * FROM inventario_final WHERE NUMERO = '" + nu + "'";
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
                                if (row["PESO"] != DBNull.Value)
                                {
                                    double valorPESO;
                                    if (double.TryParse(row["PESO"].ToString(), out valorPESO))
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

        private void bt_aply_Click(object sender, EventArgs e)
        {
            string fechaINICIO = dp_fecha_inicio.Value.ToString("yyyy-MM-dd");
            string fechaFIN = dp_fecha_fin.Value.ToString("yyyy-MM-dd");

            tablafiltrada_fehca(fechaINICIO, fechaFIN);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string medida = combo_medidas.SelectedItem.ToString();
        }

        private void filtrarpormedida(string medida)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    string query = "SELECT * FROM inventario_final WHERE TIPO = '"+ medida + "'";
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
                                if (row["PESO"] != DBNull.Value)
                                {
                                    double valorPESO;
                                    if (double.TryParse(row["PESO"].ToString(), out valorPESO))
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string  costokilo = costo_kilo.SelectedItem.ToString();
        }

        private void filtrarporkilo(string kilo)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    string query = "SELECT * FROM inventario_final WHERE COSTOKILO = '" + kilo + "'";
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
                                if (row["PESO"] != DBNull.Value)
                                {
                                    double valorPESO;
                                    if (double.TryParse(row["PESO"].ToString(), out valorPESO))
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
    }
}
