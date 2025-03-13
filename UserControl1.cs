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
using Microsoft.VisualBasic;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MaterialSkin.Controls;
using System.Runtime.Remoting.Contexts;
using ClosedXML.Excel;



namespace Inventario
{
    public partial class UserControl1 : UserControl
    {
        

        private DataTable dt;

        string user = "";
        string fecha = "";
        string numero = "";
        double peso = 0;
        string tipo = "";
        string costo_porkilo = "";
        double convert_costokilo = 0;
        double total = 0;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void CargarComboDeRollos()
        {
            string[] tiposRollo = RollosMedidas.ObtenerMedidas();
            combo_medidas.Items.Clear();
            combo_medidas.Items.AddRange(tiposRollo);
        }

        private void AligRight()
        {
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                dataGridView1.Columns["PESO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns["COSTOKILO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns["TOTAL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            

            llenartabla();
            user_info.checarstatus();

            if (user_info.status == "close")
            {
                cerrarInvenrario();


            }
            else if (user_info.status == "open")
            {
                abrirInventario();
            }

            //forzar colores
            panel_opciones.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            panel_filtrar.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            panel_pornumeros.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
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
            // Restablecer MinDate y MaxDate a sus valores predeterminados
            dtpFECHA.MinDate = DateTimePicker.MinimumDateTime;
            dtpFECHA.MaxDate = DateTimePicker.MaximumDateTime;
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
                    string query = "select * from  t_entradas WHERE MONTH(FECHA) = MONTH(curdate())";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                       using(MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;

                            dataGridView1.Columns["COSTOKILO"].DefaultCellStyle.Format = "C2"; // "C" es Currency (moneda)
                            dataGridView1.Columns["TOTAL"].DefaultCellStyle.Format = "C2";

                            //suma
                            double sumaPESO = 0;
                            double sumaTOTAL = 0;

                            foreach(DataRow row in dt.Rows)
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
                            tx_dinero.Text = "$ " + sumaTOTAL.ToString("N2");
                            lb_total_rollos.Text = dt.Rows.Count.ToString();

                            DatosCount.T_ENTRADAS_PESO = sumaPESO.ToString("N2");
                            DatosCount.T_ENTRADAS_DINERO = "$ " + sumaTOTAL.ToString("N2");
                            DatosCount.T_ENTRADAS_ROLLOS = dt.Rows.Count.ToString();
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            AligRight();
        }

        private void tablafiltrada_fehca(string fi , string fn)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    string query = "SELECT * FROM t_entradas WHERE FECHA >= '" + fi + "' AND FECHA <= '" + fn + "'";
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
                            tx_dinero.Text = "$ " + sumaTOTAL.ToString("N2");
                            lb_total_rollos.Text = dt.Rows.Count.ToString();

                            DatosCount.T_ENTRADAS_PESO = sumaPESO.ToString("N2");
                            DatosCount.T_ENTRADAS_DINERO = "$ " + sumaTOTAL.ToString("N2");
                            DatosCount.T_ENTRADAS_ROLLOS = dt.Rows.Count.ToString();
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
                    string query = "SELECT * FROM t_entradas WHERE NUMERO = '" + nu + "'";
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
                            tx_dinero.Text = "$ " + sumaTOTAL.ToString("N2");
                            lb_total_rollos.Text = dt.Rows.Count.ToString();

                            DatosCount.T_ENTRADAS_PESO = sumaPESO.ToString("N2");
                            DatosCount.T_ENTRADAS_DINERO = "$ " + sumaTOTAL.ToString("N2");
                            DatosCount.T_ENTRADAS_ROLLOS = dt.Rows.Count.ToString();
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



        private void tb_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string nuevamedida = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nueva medida", "Nueva medida", "Ejemplo : 76.0 CMs");

            if (!string.IsNullOrWhiteSpace(nuevamedida)) {
                combo_medidas.Items.Add(nuevamedida);
                materialComboBox1.Items.Add(nuevamedida);
                RollosMedidas.AgregarMedida(nuevamedida);
                MessageBox.Show("Medida agregada correctamente");
            }
            else
            {
                MessageBox.Show("No se ingreso ninguna medida");
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if(tb_numero.Text == string.Empty || tb_peso.Text == string.Empty || combo_medidas.SelectedItem == null || costo_kilo.SelectedItem == null )
            {
                MessageBox.Show("Faltan datos por llenar");
                
            }
            else
            {
                //chear si el numero existe en la tabla de entradas
                if(dtpFECHA.Value.Month == DateTime.Now.Month && dtpFECHA.Value.Year == DateTime.Now.Year)
                {
                    checarSiexiste(tb_numero.Text);
                }
                else {
                    //si no es el mismo mes lo va poner en meses_guardados pero primero checa si existe
                    mesesGuardadosSiExiste(tb_numero.Text);
                }
                
            }
 
        }

        private void mesesGuardadosSiExiste(string number)
        {
             try
             {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "SELECT NUMERO FROM inventarios_guardados WHERE NUMERO = @number";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@number", number);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("EL NUMERO YA EXISTE EN EL MES " + dtpFECHA.Value.Month );
                            }
                            else
                            {
                                //si no lo agrega a inventario_guardados
                                GuardarEnInventarioGuardados();
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


        private void GuardarEnInventarioGuardados()
        {
            //guardas los datos para enviarloa a la base de datos
            fecha = dtpFECHA.Value.ToString("yyyy-MM-dd");
            numero = tb_numero.Text;
            peso = Convert.ToDouble(tb_peso.Text);
            tipo = combo_medidas.SelectedItem.ToString();
            costo_porkilo = costo_kilo.SelectedItem.ToString();
            convert_costokilo = Convert.ToDouble(costo_porkilo);
            total = peso * convert_costokilo;

            using (MysqlConnector connect = new MysqlConnector())
            {
                try
                {
                    connect.EstablecerConexion();
                    string query = "INSERT INTO inventarios_guardados (FECHA, NUMERO, PESO , TIPO , COSTOKILO, TOTAL, MES_GUARDADO) VALUES (@fecha, @numero, @peso , @tipo ,@convert_costokilo, @total, @MES_GUARDADO)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@fecha", fecha);
                        cmd.Parameters.AddWithValue("@numero", numero);
                        cmd.Parameters.AddWithValue("@peso", peso);
                        cmd.Parameters.AddWithValue("@tipo", tipo);
                        cmd.Parameters.AddWithValue("@convert_costokilo", convert_costokilo);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.Parameters.AddWithValue("@MES_GUARDADO", fecha);
                        cmd.ExecuteNonQuery();
                        llenartablaEntradas();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }


        private void checarSiexiste(string numero)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "SELECT NUMERO FROM t_entradas WHERE NUMERO = @number";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@number", numero);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               MessageBox.Show("Numero ya existe en Entradas");
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

        private void llenartablaEntradas()
        {
            //guardas los datos para enviarloa a la base de datos
            user = user_info.Username;
            fecha = dtpFECHA.Value.ToString("yyyy-MM-dd");
            numero = tb_numero.Text;
            peso = Convert.ToDouble(tb_peso.Text);
            tipo = combo_medidas.SelectedItem.ToString();
            costo_porkilo = costo_kilo.SelectedItem.ToString();
            convert_costokilo = Convert.ToDouble(costo_porkilo);
            total = peso * convert_costokilo;

            using (MysqlConnector connect = new MysqlConnector())
            {
                try
                {
                    connect.EstablecerConexion();
                    string query = "INSERT INTO t_entradas (USUARIO , FECHA, NUMERO, PESO , TIPO , COSTOKILO, TOTAL, STATUS) VALUES (@user, @fecha, @numero, @peso , @tipo ,@convert_costokilo, @total, @status )";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@fecha", fecha);
                        cmd.Parameters.AddWithValue("@numero", numero);
                        cmd.Parameters.AddWithValue("@peso", peso);
                        cmd.Parameters.AddWithValue("@tipo", tipo);
                        cmd.Parameters.AddWithValue("@convert_costokilo", convert_costokilo);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.Parameters.AddWithValue("@status", "active");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Entrada registrada correctamente");
                        llenartabla();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }

        }
        private void llenartablaIventarioInicial()
        {
            //guardas los datos para enviarloa a la base de datos
            fecha = dtpFECHA.Value.ToString("yyyy-MM-dd");
            numero = tb_numero.Text;
            peso = Convert.ToDouble(tb_peso.Text);
            tipo = combo_medidas.SelectedItem.ToString();
            costo_porkilo = costo_kilo.SelectedItem.ToString();
            convert_costokilo = Convert.ToDouble(costo_porkilo);
            total = peso * convert_costokilo;

            using (MysqlConnector connect = new MysqlConnector())
            {
                try
                {
                    connect.EstablecerConexion();
                    string query = "INSERT INTO inventario_inicial (FECHA, NUMERO, PESO , TIPO , COSTOKILO, TOTAL) VALUES (@fecha, @numero, @peso , @tipo ,@convert_costokilo, @total )";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@fecha", fecha);
                        cmd.Parameters.AddWithValue("@numero", numero);
                        cmd.Parameters.AddWithValue("@peso", peso);
                        cmd.Parameters.AddWithValue("@tipo", tipo);
                        cmd.Parameters.AddWithValue("@convert_costokilo", convert_costokilo);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.ExecuteNonQuery();

                        clearText();
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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

                    string query = "SELECT NUMERO FROM inventario_inicial WHERE NUMERO = @number";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@number", numero);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Numero ya existe en el Inventario Inicial");
                            }
                            else
                            {
                                llenartablaEntradas();
                                llenartablaIventarioInicial();
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

        

       

        private void bt_costo_kilo_Click(object sender, EventArgs e)
        {
            string nuevo_costo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo costo por kilo", "Nuevo costo", "0");

            if (!string.IsNullOrWhiteSpace(nuevo_costo))
            {
                costo_kilo.Items.Add(nuevo_costo);
                materialComboBox2.Items.Add(nuevo_costo);
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

        private void bt_aply_Click(object sender, EventArgs e)
        {
            string fechaINICIO = dp_fecha_inicio.Value.ToString("yyyy-MM-dd");
            string fechaFIN = dp_fecha_fin.Value.ToString("yyyy-MM-dd");

            tablafiltrada_fehca(fechaINICIO,fechaFIN);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            llenartabla();
        }

        private void dtpFECHA_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if(tb_buscarNumero.Text !=string.Empty)
            {
                string numero = tb_buscarNumero.Text;
                tablafiltrada_numero(numero);
            }
            else
            {
                MessageBox.Show("Ingrese un numero para buscar");
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
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
                        var columnName = dgv.Columns[i].HeaderText;
                        var cellValue = row.Cells[i].Value ?? DBNull.Value;

                        // Concatenar el símbolo de "$" a las columnas "COSTOKILO" y "TOTAL"
                        if (columnName == "COSTOKILO" || columnName == "TOTAL")
                        {
                            if (cellValue != DBNull.Value)
                            {
                                cellValue = "$" + cellValue.ToString();
                            }
                        }

                        dr[i] = cellValue;
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
                        var ws = wb.Worksheets.Add(dt, "ENTRADAS");
                        ws.Columns().AdjustToContents(); // Ajustar ancho de columnas

                        //alineamiento a la derecha
                        string[] columnasNumericas = { "PESO", "COSTOKILO", "TOTAL" };
                        foreach (string colName in columnasNumericas)
                        {
                            if (dt.Columns.Contains(colName))
                            {
                                int colIndex = dt.Columns.IndexOf(colName) + 1; // Índice en Excel es 1-based
                                ws.Column(colIndex).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                            }
                        }

                        int lastRow = dt.Rows.Count + 1;

                        // Obtener los índices de las columnas "PESO" y "TOTAL"
                        int columnaPesoIndex = dt.Columns.IndexOf("PESO") + 1; // El índice en Excel es 1-based
                        int columnaTotalIndex = dt.Columns.IndexOf("TOTAL") + 1;

                        // Agregar un renglón en blanco
                        int textoRow = lastRow + 2;

                        // Agregar los textos en la misma fila debajo de las columnas correspondientes
                        ws.Cell(textoRow, columnaPesoIndex).Value = "TOTAL PESO: " + DatosCount.T_ENTRADAS_PESO;
                        ws.Cell(textoRow, columnaTotalIndex).Value = "TOTAL DINERO: " + DatosCount.T_ENTRADAS_DINERO;
                        ws.Cell(textoRow, 1).Value = "TOTAL ROLLOS: " + DatosCount.T_ENTRADAS_ROLLOS;

                        // Formatear las columnas COSTOKILO y TOTAL con el signo de pesos
                        if (dt.Columns.Contains("COSTOKILO"))
                        {
                            var columnaCosto = ws.Column(dt.Columns.IndexOf("COSTOKILO") + 1);
                            columnaCosto.Style.NumberFormat.Format = "$ #,##0.00"; // Formato de moneda
                        }

                        if (dt.Columns.Contains("TOTAL"))
                        {
                            var columnaTotal = ws.Column(dt.Columns.IndexOf("TOTAL") + 1);
                            columnaTotal.Style.NumberFormat.Format = "$ #,##0.00"; // Formato de moneda
                        }

                        wb.SaveAs(sfd.FileName);
                        MessageBox.Show("Datos exportados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }


        private void filtrarpormedida(string medida)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    string query = "SELECT * FROM t_entradas WHERE TIPO = '" + medida + "'";
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
                            tx_dinero.Text = "$ " +  sumaTOTAL.ToString("N2");
                            lb_total_rollos.Text = dt.Rows.Count.ToString();

                            DatosCount.T_ENTRADAS_PESO = sumaPESO.ToString("N2");
                            DatosCount.T_ENTRADAS_DINERO = "$ " + sumaTOTAL.ToString("N2");
                            DatosCount.T_ENTRADAS_ROLLOS = dt.Rows.Count.ToString();
                        }

                    }
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void filtrarporkilo(string kilo)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    string query = "SELECT * FROM t_entradas WHERE COSTOKILO = '" + kilo + "'";
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
                            tx_dinero.Text = "$ " +  sumaTOTAL.ToString("N2");
                            lb_total_rollos.Text = dt.Rows.Count.ToString();

                            DatosCount.T_ENTRADAS_PESO = sumaPESO.ToString("N2");
                            DatosCount.T_ENTRADAS_DINERO = "$ " + sumaTOTAL.ToString("N2");
                            DatosCount.T_ENTRADAS_ROLLOS = dt.Rows.Count.ToString();
                        }

                    }
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dp_fecha_inicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tx_dinero_Click(object sender, EventArgs e)
        {

        }

        private void tx_peso_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            string medida = materialComboBox1.SelectedItem.ToString();
            filtrarpormedida(medida);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string kilo = materialComboBox2.SelectedItem.ToString();
            filtrarporkilo(kilo);
        }
    }
}
