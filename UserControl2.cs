using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Inventario
{
    public partial class UserControl2 : UserControl
    {
        table_salidas salidas = new table_salidas();
        double restar = 0;

        public UserControl2()
        {
            
            InitializeComponent();
            //forzar colores
            panel_opciones.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            panel_filtrar.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            panel_pornumeros.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
        }

        private void CargarComboDeRollos()
        {
            string[] tiposRollo = RollosMedidas.ObtenerMedidas();
            materialComboBox1.Items.Clear();
            materialComboBox1.Items.AddRange(tiposRollo);
        }

        private void AligRight()
        {
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                dataGridView1.Columns["PESO_DE_SALIDA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns["COSTOKILO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns["TOTAL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void UserControl2_Load(object sender, EventArgs e)
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



            CargarComboDeRollos();

                 llenartabla();
                 user_info.checarstatus();
            
                if (user_info.status == "close")
                {
                    cerrarInvenrario();
                    

                }
                else if(user_info.status == "open")
                {
                    abrirInventario();
                }

            
        }


        private void cerrarInvenrario()
        {
            //establecer la fecha actual
            DateTime today = DateTime.Today;
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            dtpFECHA.MinDate = firstDayOfMonth;
            dtpFECHA.MaxDate = lastDayOfMonth;
        }

        private void abrirInventario()
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "SELECT mes, anio FROM configuracionDate LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {


                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int mes = reader.GetInt32(0);
                                int anio = reader.GetInt32(1);

                                dtpFECHA.MinDate = new DateTime(anio, mes, 1);
                                dtpFECHA.MaxDate = new DateTime(anio, mes, DateTime.DaysInMonth(anio, mes));

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

        private void clearText()
        {
            tb_numero.Text = string.Empty;
            tb_peso.Text = string.Empty;
        }

        private void llenartabla()
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    string query = "select * from  t_salidas WHERE MONTH(FECHA_DE_SALIDA) = MONTH(curdate())";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;

                            dataGridView1.Columns["COSTOKILO"].DefaultCellStyle.Format = "C2"; // "C" es Currency (moneda)
                            dataGridView1.Columns["TOTAL"].DefaultCellStyle.Format = "C2";

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
                            tx_dinero.Text = "$ " + sumaTOTAL.ToString("N2");
                            lb_total_rollos.Text = dt.Rows.Count.ToString();

                            DatosCount.T_SALIDAS_PESO = sumaPESO.ToString("N2");
                            DatosCount.T_SALIDAS_DINERO = "$ " + sumaTOTAL.ToString("N2");
                            DatosCount.T_SALIDAS_ROLLOS = dt.Rows.Count.ToString();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            AligRight();
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
                if (dtpFECHA.Value.Month == DateTime.Now.Month && dtpFECHA.Value.Year == DateTime.Now.Year)
                {
                    
                    //buscar numero en entradas para ponerlo en el status inactive
                    ChecarSiExisteEnInventarioInicial(nu);
                    //y luego checha en el inventario inicial si existe y lo elimina
                }
                else
                {
                    //eliminar de los inventarios guardados
                    ChecarSiExisteEnGuardado(nu);
                }

            }
            
        }

        

        private void ChecarSiExisteEnInventarioInicial(string numero)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "SELECT *FROM inventario_inicial WHERE NUMERO = @number";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@number", numero);

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
                                salidas.TOTAL = salidas.PESO * salidas.COSTOKILO;
                                salidas.FECHA_DE_SALIDA = dtpFECHA.Value.ToString("yyyy-MM-dd");
                                restar = salidas.COSTOKILO * salidas.PESO;

                                double pesoanterior = reader.GetDouble("PESO");

                                if (salidas.PESO == pesoanterior)
                                {
                                    cambiarStatus(numero);
                                    EliminarDelInvetarioInicial(numero);
                                }
                                else
                                {
                                    MessageBox.Show("EL PESO DE SALIDA DEBE SER IGUAL AL PESO QUE ENTRO");
                                }

                            }
                            else
                            {
                                MessageBox.Show("EL NUMERO NO EXISTE EN EL INVENTARIO");
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



        private void ChecarSiExisteEnGuardado(string numero)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "SELECT *FROM inventarios_guardados WHERE NUMERO = @number";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@number", numero);

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
                                salidas.TOTAL = salidas.PESO * salidas.COSTOKILO;
                                salidas.FECHA_DE_SALIDA = dtpFECHA.Value.ToString("yyyy-MM-dd");
                                restar = salidas.COSTOKILO * salidas.PESO;

                                double pesoanterior = reader.GetDouble("PESO");

                                if (salidas.PESO == pesoanterior)
                                {
                                    EliminarDeGuardados(numero);
                                }
                                else
                                {
                                    MessageBox.Show("EL PESO DE SALIDA DEBE SER IGUAL AL PESO QUE ENTRO");
                                }

                            }
                            else
                            {
                                MessageBox.Show("EL NUMERO NO EXISTE EN EL INVENTARIO");
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



        private void EliminarDelInvetarioInicial(string numero)
        {
            try
            {
               
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "DELETE FROM inventario_inicial WHERE NUMERO = @numero";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@numero", numero);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            llenartabla_salidas();
                            clearText();
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
            }

        }

        private void EliminarDeGuardados(string numero)
        {
            try
            {

                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "DELETE FROM inventarios_guardados WHERE NUMERO = @numero";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@numero", numero);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            llenartabla_salidas();
                            cambiarStatus(numero);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
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
                                salidas.TOTAL = salidas.PESO * salidas.COSTOKILO;
                                salidas.FECHA_DE_SALIDA = dtpFECHA.Value.ToString("yyyy-MM-dd");
                                restar = salidas.COSTOKILO * salidas.PESO;

                                double pesoanterior = reader.GetDouble("PESO");

                                if (salidas.PESO == pesoanterior) {
                                    llenartabla_salidas();
                                    //poner el status en inactive en la tabla de entradas
                                    cambiarStatus(numero);
                                }
                                else
                                {
                                    MessageBox.Show("EL PESO DE SALIDA DEBE SER IGUAL AL PESO QUE ENTRO");
                                }

                            }
                            else
                            {
                                ChecarSiExisteEnInventarioInicial(numero);
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

        private void cambiarStatus(string numero)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "UPDATE t_entradas SET STATUS = 'inactive' WHERE NUMERO = @numero";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@numero", numero);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
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

                            dataGridView1.Columns["COSTOKILO"].DefaultCellStyle.Format = "C2"; // "C" es Currency (moneda)
                            dataGridView1.Columns["TOTAL"].DefaultCellStyle.Format = "C2";

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
                            tx_dinero.Text = "$ " + sumaTOTAL.ToString("N2");
                            lb_total_rollos.Text = dt.Rows.Count.ToString();

                            DatosCount.T_SALIDAS_PESO = sumaPESO.ToString("N2");
                            DatosCount.T_SALIDAS_DINERO = sumaTOTAL.ToString("N2");
                            DatosCount.T_SALIDAS_ROLLOS = dt.Rows.Count.ToString();
                        }

                    }
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            AligRight();
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

                            dataGridView1.Columns["COSTOKILO"].DefaultCellStyle.Format = "C2"; // "C" es Currency (moneda)
                            dataGridView1.Columns["TOTAL"].DefaultCellStyle.Format = "C2";

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
                            tx_dinero.Text = "$ " +  sumaTOTAL.ToString("N2");
                            lb_total_rollos.Text = dt.Rows.Count.ToString();

                            DatosCount.T_SALIDAS_PESO = sumaPESO.ToString("N2");
                            DatosCount.T_SALIDAS_DINERO = sumaTOTAL.ToString("N2");
                            DatosCount.T_SALIDAS_ROLLOS = dt.Rows.Count.ToString();
                        }

                    }
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            AligRight();
        }
        private void filtrarpormedida(string medida)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    string query = "SELECT * FROM t_salidas WHERE TIPO = '" + medida + "'";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;

                            dataGridView1.Columns["COSTOKILO"].DefaultCellStyle.Format = "C2"; // "C" es Currency (moneda)
                            dataGridView1.Columns["TOTAL"].DefaultCellStyle.Format = "C2";

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
                            tx_dinero.Text = "$ " +  sumaTOTAL.ToString("N2");
                            lb_total_rollos.Text = dt.Rows.Count.ToString();

                            DatosCount.T_SALIDAS_PESO = sumaPESO.ToString("N2");
                            DatosCount.T_SALIDAS_DINERO = sumaTOTAL.ToString("N2");
                            DatosCount.T_SALIDAS_ROLLOS = dt.Rows.Count.ToString();
                        }

                    }
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            AligRight();

        }
        private void filtrarporkilo(string kilo)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    string query = "SELECT * FROM t_salidas WHERE COSTOKILO = '" + kilo + "'";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;

                            dataGridView1.Columns["COSTOKILO"].DefaultCellStyle.Format = "C2"; // "C" es Currency (moneda)
                            dataGridView1.Columns["TOTAL"].DefaultCellStyle.Format = "C2";

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
                            tx_dinero.Text = "$ " +  sumaTOTAL.ToString("N2");
                            lb_total_rollos.Text = dt.Rows.Count.ToString();

                            DatosCount.T_SALIDAS_PESO = sumaPESO.ToString("N2");
                            DatosCount.T_SALIDAS_DINERO = sumaTOTAL.ToString("N2");
                            DatosCount.T_SALIDAS_ROLLOS = dt.Rows.Count.ToString();
                        }

                    }
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            AligRight();

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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtDesdeDataGrid = ObtenerDesdeDataGridView(dataGridView1);
                GuardarExcel(dtDesdeDataGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private DataTable ObtenerDesdeDataGridView(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            // Crear columnas en la DataTable según las columnas del DataGridView
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                dt.Columns.Add(column.HeaderText);
            }

            // Llenar la DataTable con los datos del DataGridView
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        dr[i] = row.Cells[i].Value ?? DBNull.Value;
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }

        private void GuardarExcel(DataTable dt)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Files|*.xlsx", Title = "Guardar Excel" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        // Concatenar el símbolo de "$" a las columnas "COSTOKILO" y "TOTAL"
                        foreach (DataRow row in dt.Rows)
                        {
                            if (dt.Columns.Contains("COSTOKILO") && row["COSTOKILO"] != DBNull.Value)
                            {
                                row["COSTOKILO"] = "$" + Convert.ToDecimal(row["COSTOKILO"]).ToString("N2");
                            }

                            if (dt.Columns.Contains("TOTAL") && row["TOTAL"] != DBNull.Value)
                            {
                                row["TOTAL"] = "$" + Convert.ToDecimal(row["TOTAL"]).ToString("N2");
                            }
                        }

                        var ws = wb.Worksheets.Add(dt, "SALIDAS");
                        ws.Columns().AdjustToContents(); // Ajustar ancho de columnas

                        //alineamiento a la derecha
                        string[] columnasNumericas = { "PESO_DE_SALIDA", "COSTOKILO", "TOTAL" };
                        foreach (string colName in columnasNumericas)
                        {
                            if (dt.Columns.Contains(colName))
                            {
                                int colIndex = dt.Columns.IndexOf(colName) + 1; // Índice en Excel es 1-based
                                ws.Column(colIndex).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                            }
                        }

                        int lastRow = dt.Rows.Count + 1;

                        // Obtener los índices de las columnas "PESO_DE_SALIDA" y "TOTAL"
                        int columnaPesoIndex = dt.Columns.IndexOf("PESO_DE_SALIDA") + 1; // El índice en Excel es 1-based
                        int columnaTotalIndex = dt.Columns.IndexOf("TOTAL") + 1;

                        // Agregar un renglón en blanco
                        int textoRow = lastRow + 2;

                        // Agregar los textos en la misma fila debajo de las columnas correspondientes
                        ws.Cell(textoRow, columnaPesoIndex).Value = "TOTAL PESO: " + DatosCount.T_SALIDAS_PESO;
                        ws.Cell(textoRow, columnaTotalIndex).Value = "TOTAL DINERO: " + DatosCount.T_SALIDAS_DINERO;
                        ws.Cell(textoRow, 1).Value = "TOTAL ROLLOS: " + DatosCount.T_SALIDAS_ROLLOS;

                        wb.SaveAs(sfd.FileName);
                        MessageBox.Show("Datos exportados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            string nuevamedida = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nueva medida", "Nueva medida", "Ejemplo : 76.0 CMs");

            if (!string.IsNullOrWhiteSpace(nuevamedida))
            {
                materialComboBox1.Items.Add(nuevamedida);
                MessageBox.Show("Medida agregada correctamente");
            }
            else
            {
                MessageBox.Show("No se ingreso ninguna medida");
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            string nuevo_costo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo costo por kilo", "Nuevo costo", "0");

            if (!string.IsNullOrWhiteSpace(nuevo_costo))
            {
                materialComboBox2.Items.Add(nuevo_costo);
                MessageBox.Show("Costo agregado correctamente");
            }
            else
            {
                MessageBox.Show("No se ingreso ningun costo");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string medida = materialComboBox1.Text;
            filtrarpormedida(medida);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string costokilo = materialComboBox2.Text;
            filtrarporkilo(costokilo);
        }
    }
}
