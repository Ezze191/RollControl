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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using ClosedXML.Excel;
using System.Reflection.Emit;


namespace Inventario
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
            //forzar colores
            panel_filtrar.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
           
            

        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            // Establece el rango de fechas permitidas al año actual
            DateTimePicker dateTimePicker = new DateTimePicker();
            DateTime today = DateTime.Today;
            DateTime firstDayOfYear = new DateTime(today.Year, 1, 1);
            DateTime lastDayOfYear = new DateTime(today.Year, 12, 31);

            dtpMesSeleccionado.Format = DateTimePickerFormat.Custom;
            dtpMesSeleccionado.CustomFormat = "MMMM yyyy"; // Muestra solo el mes y el año
            dtpMesSeleccionado.ShowUpDown = true; // Quita el calendario desplegable

            dtpMesSeleccionado.MinDate = firstDayOfYear;
            dtpMesSeleccionado.MaxDate = lastDayOfYear;


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
                    string query = "SELECT * \r\nFROM inventario_inicial\r\nWHERE (MONTH(FECHA) = MONTH(CURDATE()) AND YEAR(FECHA) = YEAR(CURDATE()))\r\n   OR (MONTH(FECHA) = MONTH(DATE_SUB(CURDATE(), INTERVAL 1 MONTH)) \r\n       AND YEAR(FECHA) = YEAR(DATE_SUB(CURDATE(), INTERVAL 1 MONTH)))";
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

                            DatosCount.T_INVENTARIO_PESO = sumaPESO.ToString("N2");
                            DatosCount.T_INVENTARIO_DINERO = sumaTOTAL.ToString("N2");
                            DatosCount.T_INVENTARIO_ROLLOS = dt.Rows.Count.ToString();
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

                            DatosCount.T_INVENTARIO_PESO = sumaPESO.ToString("N2");
                            DatosCount.T_INVENTARIO_DINERO = sumaTOTAL.ToString("N2");
                            DatosCount.T_INVENTARIO_ROLLOS = dt.Rows.Count.ToString();
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

                            DatosCount.T_INVENTARIO_PESO = sumaPESO.ToString("N2");
                            DatosCount.T_INVENTARIO_DINERO = sumaTOTAL.ToString("N2");
                            DatosCount.T_INVENTARIO_ROLLOS = dt.Rows.Count.ToString();
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
            seleccioanrInventarioSeleccionado();
            
        }

        private void seleccioanrInventarioSeleccionado()
        {
            try
            {
                
                int mesSeleccionado = dtpMesSeleccionado.Value.Month;
                int anioSeleccionado = dtpMesSeleccionado.Value.Year;

                int mesAnterior = mesSeleccionado == 1 ? 12 : mesSeleccionado - 1; // Si es enero, el mes anterior es diciembre
                int anioAnterior = mesSeleccionado == 1 ? anioSeleccionado - 1 : anioSeleccionado; // Si es enero, restar un año


                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    string query = @"
            SELECT * 
            FROM inventario_inicial
            WHERE (MONTH(FECHA) = @mesSeleccionado AND YEAR(FECHA) = @anioSeleccionado)
               OR (MONTH(FECHA) = @mesAnterior AND YEAR(FECHA) = @anioAnterior);";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@mesSeleccionado", mesSeleccionado);
                        cmd.Parameters.AddWithValue("@anioSeleccionado", anioSeleccionado);
                        cmd.Parameters.AddWithValue("@mesAnterior", mesAnterior);
                        cmd.Parameters.AddWithValue("@anioAnterior", anioAnterior);

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

                            DatosCount.T_INVENTARIO_PESO = sumaPESO.ToString("N2");
                            DatosCount.T_INVENTARIO_DINERO = sumaTOTAL.ToString("N2");
                            DatosCount.T_INVENTARIO_ROLLOS = dt.Rows.Count.ToString();
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
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
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

                            DatosCount.T_INVENTARIO_PESO = sumaPESO.ToString("N2");
                            DatosCount.T_INVENTARIO_DINERO = sumaTOTAL.ToString("N2");
                            DatosCount.T_INVENTARIO_ROLLOS = dt.Rows.Count.ToString();
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

                            DatosCount.T_INVENTARIO_PESO = sumaPESO.ToString("N2");
                            DatosCount.T_INVENTARIO_DINERO = sumaTOTAL.ToString("N2");
                            DatosCount.T_INVENTARIO_ROLLOS = dt.Rows.Count.ToString();
                        }

                    }
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Guardar archivo PDF";
                    saveFileDialog.FileName = "Inventario.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Crear un documento PDF
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                        pdfDoc.Open();

                        

                        // Añadir contenido al documento
                        PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            pdfTable.AddCell(cell);
                        }

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(cell.Value?.ToString());
                            }
                        }

                        pdfDoc.Add(pdfTable);

                        //Agregar labels de total peso y total dinero al pdf
                        pdfDoc.Add(new Paragraph("Total Peso: " + tx_peso.Text));
                        pdfDoc.Add(new Paragraph("Total Dinero: " + tx_dinero.Text));

                        //ruta de la imagen
                        string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "RollControlLogo.png");

                        // Agregar imagen
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imagePath);
                        img.ScaleToFit(70f, 60f); // Ajusta el tamaño de la imagen
                        img.Alignment = Element.ALIGN_CENTER; // Centra la imagen
                        pdfDoc.Add(img);


                        pdfDoc.Close();
                        MessageBox.Show("PDF Guardado Correctamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }
        

        private void dtpMesSeleccionado_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            int mesSeleccionado = dtpMesSeleccionado.Value.Month;
            int añoSeleccionado = dtpMesSeleccionado.Value.Year;

            try
            {
                using (MysqlConnector connect = new MysqlConnector()) // Tu conexión a MySQL
                {
                    connect.EstablecerConexion();

                    // Obtener datos de las tablas t_entradas y t_salidas con parámetros
                    DataTable dtEntradas = ObtenerDatos("SELECT * FROM t_entradas WHERE MONTH(FECHA) = @mes AND YEAR(FECHA) = @anio", connect, mesSeleccionado, añoSeleccionado);
                    DataTable dtSalidas = ObtenerDatos("SELECT * FROM t_salidas WHERE MONTH(FECHA_DE_SALIDA) = @mes AND YEAR(FECHA_DE_SALIDA) = @anio", connect, mesSeleccionado, añoSeleccionado);

                    // Obtener datos desde dataGridView1
                    DataTable dtDesdeDataGrid = ObtenerDesdeDataGridView(dataGridView1);

                    // Guardar en archivo Excel
                    GuardarExcel(dtEntradas, dtSalidas, dtDesdeDataGrid);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private DataTable ObtenerDatos(string query, MysqlConnector connect, int mes, int anio)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@mes", mes);
                    cmd.Parameters.AddWithValue("@anio", anio);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message);
            }
            return dt;
        }

        private DataTable ObtenerDesdeDataGridView(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            // Crear columnas en el DataTable según las columnas del DataGridView
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                dt.Columns.Add(column.HeaderText);
            }

            // Llenar el DataTable con los datos del DataGridView
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

        private void GuardarExcel(DataTable dtEntradas, DataTable dtSalidas, DataTable dtDesdeDataGrid)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Files|*.xlsx", Title = "Guardar Excel" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        if (dtEntradas.Rows.Count > 0)
                        {
                            var wsEntradas = wb.Worksheets.Add(dtEntradas, "Entradas");
                            FormatearMoneda(wsEntradas, dtEntradas);
                            wsEntradas.Columns().AdjustToContents(); // 🔹 Ajustar ancho de columnas
                        }

                        if (dtSalidas.Rows.Count > 0)
                        {
                            var wsSalidas = wb.Worksheets.Add(dtSalidas, "Salidas");
                            FormatearMoneda(wsSalidas, dtSalidas);
                            wsSalidas.Columns().AdjustToContents(); // 🔹 Ajustar ancho de columnas

                            // Agregar contenido de labels debajo de la tabla
                            var lastRowSalidas = dtSalidas.Rows.Count + 2; // Dos filas debajo de la tabla
                            wsSalidas.Cell(lastRowSalidas, 1).Value = "TOTAL DINERO : $ " + DatosCount.T_SALIDAS_DINERO; 
                            wsSalidas.Cell(lastRowSalidas + 1, 1).Value = "TOTAL PESO: " + DatosCount.T_SALIDAS_PESO; 
                            wsSalidas.Cell(lastRowSalidas + 2, 1).Value = "TOTAL ROLLOS :" + DatosCount.T_SALIDAS_ROLLOS; 
                        }

                        if (dtDesdeDataGrid.Rows.Count > 0)
                        {
                            var wsDataGrid = wb.Worksheets.Add(dtDesdeDataGrid, "Inventario Final");
                            FormatearMoneda(wsDataGrid, dtDesdeDataGrid);
                            wsDataGrid.Columns().AdjustToContents(); // 🔹 Ajustar ancho de columnas
                        }

                        // Guardar el archivo
                        wb.SaveAs(sfd.FileName);
                        MessageBox.Show("Datos exportados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        // Método para aplicar formato de moneda a las columnas COSTOKILO y TOTAL
        private void FormatearMoneda(IXLWorksheet ws, DataTable dt)
        {
            int colCostoKilo = dt.Columns.Contains("COSTOKILO") ? dt.Columns["COSTOKILO"].Ordinal + 1 : -1;
            int colTotal = dt.Columns.Contains("TOTAL") ? dt.Columns["TOTAL"].Ordinal + 1 : -1;

            if (colCostoKilo > 0)
            {
                ws.Column(colCostoKilo).Style.NumberFormat.Format = "$#,##0.00";
            }

            if (colTotal > 0)
            {
                ws.Column(colTotal).Style.NumberFormat.Format = "$#,##0.00";
            }

            ws.Columns().AdjustToContents(); // 🔹 Ajustar ancho de todas las columnas
        }


    }
}
