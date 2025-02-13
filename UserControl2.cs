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

                    string query = "SELECT * FROM inventario_final WHERE NUMERO = @numero";

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

                                if (salidas.PESO > pesoanterior) {
                                    MessageBox.Show("EL PESO DE SALIDA DEBE SER MENOR AL PESO QUE ESTA INGRESADO");
                                }
                                else
                                {
                                    llenartabla_salidas();
                                    restarAlInventario();
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

        private void restarAlInventario()
        {
            try {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    string query = "UPDATE inventario_final SET PESO = PESO - @peso, TOTAL = TOTAL - @resta WHERE NUMERO = @numero";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@peso", salidas.PESO);
                        cmd.Parameters.AddWithValue("@resta", restar);
                        cmd.Parameters.AddWithValue("@numero", salidas.NUMERO);
                        cmd.ExecuteNonQuery();
                        
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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Guardar archivo PDF";
                    saveFileDialog.FileName = "Salidas.pdf";

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
    }
}
