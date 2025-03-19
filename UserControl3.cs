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
        int mesSeleccionado = DateTime.Now.Month;
        int anioSeleccionado = DateTime.Now.Year;
        public UserControl3()
        {
            InitializeComponent();
            //forzar colores
            panel_filtrar.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            panel3.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
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
                dataGridView1.Columns["PESO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns["COSTOKILO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns["TOTAL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void UserControl3_Load(object sender, EventArgs e)
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
            // Establece el rango de fechas permitidas al año actual
            DateTimePicker dateTimePicker = new DateTimePicker();
            DateTime today = DateTime.Today;


            dtpMesSeleccionado.Format = DateTimePickerFormat.Custom;
            dtpMesSeleccionado.CustomFormat = "MMMM yyyy"; // Muestra solo el mes y el año
            dtpMesSeleccionado.ShowUpDown = true; // Quita el calendario desplegable


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
                    string query = "SELECT * FROM inventario_inicial";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;

                            dataGridView1.Columns["COSTOKILO"].DefaultCellStyle.Format = "C2"; // "C" es Currency (moneda)
                            dataGridView1.Columns["TOTAL"].DefaultCellStyle.Format = "C2";

                            // suma
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
                            // asignar los valores a los labels
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
            AligRight();
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
            AligRight();
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
            AligRight();
        }

        private void bt_aply_Click(object sender, EventArgs e)
        {
            seleccioanrInventarioSeleccionado();

        }

        private void seleccioanrInventarioSeleccionado()
        {

            MessageBox.Show("FECHA SELECCIOANDA");
            llenarTablaConFiltro();

        }


        private void llenarTablaConFiltro()
        {
            mesSeleccionado = dtpMesSeleccionado.Value.Month;
            anioSeleccionado = dtpMesSeleccionado.Value.Year;

            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    string query = $"SELECT * FROM inventarios_guardados WHERE MONTH(MES_GUARDADO) = {mesSeleccionado} AND YEAR(MES_GUARDADO) = {anioSeleccionado}";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;

                            dataGridView1.Columns["COSTOKILO"].DefaultCellStyle.Format = "C2"; // "C" es Currency (moneda)
                            dataGridView1.Columns["TOTAL"].DefaultCellStyle.Format = "C2";

                            // suma
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
                            // asignar los valores a los labels
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
            AligRight();
        }

        private void filtrarpormedida(string medida)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    string query = "SELECT * FROM inventario_final WHERE TIPO = '" + medida + "'";
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
            AligRight();

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
            AligRight();

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
            try
            {
                using (MysqlConnector connect = new MysqlConnector()) // Tu conexión a MySQL
                {
                    connect.EstablecerConexion();

                    // Obtener datos de las tablas t_entradas y t_salidas
                    string queryEntradas = $"SELECT * FROM t_entradas WHERE MONTH(FECHA) = {mesSeleccionado} AND YEAR(FECHA) = {anioSeleccionado}";
                    DataTable dtEntradas = ObtenerDatos(queryEntradas, connect);

                    string querySalidas = $"SELECT * FROM t_salidas WHERE MONTH(FECHA_DE_SALIDA) = {mesSeleccionado} AND YEAR(FECHA_DE_SALIDA) = {anioSeleccionado}";
                    DataTable dtSalidas = ObtenerDatos(querySalidas, connect);

                    // Obtener datos desde dataGridView1
                    DataTable dtDesdeDataGrid = ObtenerDesdeDataGridView(dataGridView1);

                    // Aplicar formato de moneda al DataGridView
                    FormatearMonedaDataGridView(dataGridView1);

                    // Guardar en archivo Excel
                    GuardarExcel(dtEntradas, dtSalidas, dtDesdeDataGrid);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private DataTable ObtenerDatos(string query, MysqlConnector connect)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
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

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                dt.Columns.Add(column.HeaderText);
            }

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
                        // Filtrar y procesar datos por tipo de rollo
                        ProcesarDatosPorTipoRollo(wb, dtEntradas, "Entradas", "PESO");
                        ProcesarDatosPorTipoRollo(wb, dtSalidas, "Salidas", "PESO_DE_SALIDA");
                        ProcesarDatosPorTipoRollo(wb, dtDesdeDataGrid, "Inventario Final", "PESO");

                        // Verificar que al menos una hoja se haya agregado
                        if (wb.Worksheets.Count == 0)
                        {
                            MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Guardar el archivo
                        wb.SaveAs(sfd.FileName);
                        MessageBox.Show("Datos exportados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void ProcesarDatosPorTipoRollo(XLWorkbook wb, DataTable dt, string sheetBaseName, string pesoColumnName)
        {
            var tiposRollo = RollosMedidas.ObtenerMedidas();

            foreach (var tipoRollo in tiposRollo)
            {
                var filasFiltradas = dt.AsEnumerable().Where(row => row.Field<string>("TIPO") == tipoRollo);
                if (filasFiltradas.Any())
                {
                    var dtFiltrado = filasFiltradas.CopyToDataTable();
                    var sheetName = $"{sheetBaseName} - {tipoRollo}";
                    ProcesarHoja(wb, dtFiltrado, sheetName, pesoColumnName);
                }
            }
        }

        // Función para procesar cada hoja de Excel
        private void ProcesarHoja(XLWorkbook wb, DataTable dt, string sheetName, string pesoColumnName)
        {
            if (dt.Rows.Count > 0)
            {
                var ws = wb.Worksheets.Add(dt, sheetName);

                // Formatear las columnas específicas con el signo de pesos "$"
                foreach (var row in ws.RangeUsed().RowsUsed().Skip(1)) // Omitir la fila de encabezados
                {
                    if (dt.Columns.Contains("TOTAL"))
                        row.Cell(dt.Columns["TOTAL"].Ordinal + 1).Value = "$" + row.Cell(dt.Columns["TOTAL"].Ordinal + 1).Value.ToString();
                    if (dt.Columns.Contains("COSTOKILO"))
                        row.Cell(dt.Columns["COSTOKILO"].Ordinal + 1).Value = "$" + row.Cell(dt.Columns["COSTOKILO"].Ordinal + 1).Value.ToString();
                }

                ws.Columns().AdjustToContents();

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


                // Ajustar el ancho de la columna "COSTOKILO"
                if (dt.Columns.Contains("COSTOKILO"))
                {
                    ws.Column(dt.Columns.IndexOf("COSTOKILO") + 1).Width = 20; // Ajusta el ancho según sea necesario
                }

                // Calcular totales
                decimal totalDinero = dt.AsEnumerable().Sum(row => row["TOTAL"] != DBNull.Value ? Convert.ToDecimal(row["TOTAL"]) : 0);
                decimal totalPeso = dt.AsEnumerable().Sum(row => row[pesoColumnName] != DBNull.Value ? Convert.ToDecimal(row[pesoColumnName]) : 0);
                int totalRollos = dt.Rows.Count;

                // Obtener los índices de las columnas "TOTAL" y "PESO"
                int columnaTotalIndex = dt.Columns.IndexOf("TOTAL") + 1; // El índice en Excel es 1-based
                int columnaPesoIndex = dt.Columns.IndexOf(pesoColumnName) + 1;

                // Escribir los totales en el archivo Excel con un renglón en blanco
                var lastRow = dt.Rows.Count + 3;
                ws.Cell(lastRow, columnaTotalIndex).Value = "TOTAL DINERO: $" + totalDinero;
                ws.Cell(lastRow, columnaPesoIndex).Value = "TOTAL PESO: " + totalPeso;
                ws.Cell(lastRow, 1).Value = "TOTAL ROLLOS: " + totalRollos;
            }
        }

        private void FormatearMonedaDataGridView(DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Name == "COSTOKILO" || column.Name == "TOTAL")
                {
                    column.DefaultCellStyle.Format = "C2";
                }
            }
        }
        private void bt_cancel_Click_1(object sender, EventArgs e)
        {
            mesSeleccionado = DateTime.Now.Month;
            anioSeleccionado = DateTime.Now.Year;
            llenartabla();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (tb_buscarNumero.Text == string.Empty)
            {
                MessageBox.Show("LOS DATOS NO PUEDEN ESTAR VACIOS");
            }
            else
            {
                try
                {
                    string number = tb_buscarNumero.Text;
                    using (MysqlConnector connect = new MysqlConnector()) // Tu conexión a MySQL
                    {
                        connect.EstablecerConexion();

                        // Obtener datos de las tablas t_entradas y t_salidas
                        string queryEntradas = $"SELECT * FROM t_entradas WHERE NUMERO = {number}";
                        DataTable dtEntradas = ObtenerDatos(queryEntradas, connect);

                        string querySalidas = $"SELECT * FROM t_salidas WHERE NUMERO = {number}";
                        DataTable dtSalidas = ObtenerDatos(querySalidas, connect);

                        // Obtener datos desde dataGridView1
                        string queryInventario = $"SELECT * FROM inventario_inicial WHERE NUMERO = {number}";
                        DataTable dtInventario = ObtenerDatos(queryInventario, connect);



                        // Guardar en archivo Excel
                        GuardarExcel(dtEntradas, dtSalidas, dtInventario);

                        tb_buscarNumero.Text = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }




        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string fechaINICIO = dp_fecha_inicio.Value.ToString("yyyy-MM-dd");
            string fechaFIN = dp_fecha_fin.Value.ToString("yyyy-MM-dd");

            try
            {

                using (MysqlConnector connect = new MysqlConnector()) // Tu conexión a MySQL
                {
                    connect.EstablecerConexion();

                    // Obtener datos de las tablas t_entradas y t_salidas
                    string queryEntradas = $"SELECT * FROM t_entradas WHERE FECHA >= '{fechaINICIO}' AND FECHA <= '{fechaFIN}'";
                    DataTable dtEntradas = ObtenerDatos(queryEntradas, connect);

                    string querySalidas = $"SELECT * FROM t_salidas WHERE FECHA_DE_SALIDA >= '{fechaINICIO}' AND FECHA_DE_SALIDA <= '{fechaFIN}'";
                    DataTable dtSalidas = ObtenerDatos(querySalidas, connect);

                    // Obtener datos desde dataGridView1
                    string queryInventario = $"SELECT * FROM inventario_inicial WHERE FECHA >= '{fechaINICIO}' AND FECHA <= '{fechaFIN}'";
                    DataTable dtInventario = ObtenerDatos(queryInventario, connect);



                    // Guardar en archivo Excel
                    GuardarExcel(dtEntradas, dtSalidas, dtInventario);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string medida = materialComboBox1.Text;
            try
            {

                using (MysqlConnector connect = new MysqlConnector()) // Tu conexión a MySQL
                {
                    connect.EstablecerConexion();

                    // Obtener datos de las tablas t_entradas y t_salidas
                    string queryEntradas = "SELECT * FROM t_entradas WHERE TIPO = '" + medida + "';";
                    DataTable dtEntradas = ObtenerDatos(queryEntradas, connect);

                    string querySalidas = "SELECT * FROM t_salidas WHERE TIPO = '" + medida + "';";
                    DataTable dtSalidas = ObtenerDatos(querySalidas, connect);

                    // Obtener datos desde dataGridView1
                    string queryInventario = "SELECT * FROM inventario_inicial WHERE TIPO = '" + medida + "';";
                    DataTable dtInventario = ObtenerDatos(queryInventario, connect);



                    // Guardar en archivo Excel
                    GuardarExcel(dtEntradas, dtSalidas, dtInventario);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string costokilo = materialComboBox2.Text;
            try
            {

                using (MysqlConnector connect = new MysqlConnector()) // Tu conexión a MySQL
                {
                    connect.EstablecerConexion();

                    // Obtener datos de las tablas t_entradas y t_salidas
                    string queryEntradas = $"SELECT * FROM t_entradas WHERE COSTOKILO = '{costokilo}'";
                    DataTable dtEntradas = ObtenerDatos(queryEntradas, connect);

                    string querySalidas = $"SELECT * FROM t_salidas WHERE COSTOKILO = '{costokilo}'";
                    DataTable dtSalidas = ObtenerDatos(querySalidas, connect);

                    // Obtener datos desde dataGridView1
                    string queryInventario = $"SELECT * FROM inventario_inicial WHERE COSTOKILO = '{costokilo}'";
                    DataTable dtInventario = ObtenerDatos(queryInventario, connect);

                    // Guardar en archivo Excel
                    GuardarExcel(dtEntradas, dtSalidas, dtInventario);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
    }
}