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

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
            llenartabla();


            //forzar colores
            panel_opciones.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            panel_filtrar.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            panel_pornumeros.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void llenartabla()
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();
                    string query = "select * from  t_entradas";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                       using(MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;

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
                            tx_dinero.Text = sumaTOTAL.ToString("N2");
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
                    string query = "SELECT * FROM t_entradas WHERE NUMERO = '" + nu + "'";
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



        private void tb_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string nuevamedida = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nueva medida", "Nueva medida", "0");

            if (!string.IsNullOrWhiteSpace(nuevamedida)) {
                combo_medidas.Items.Add(nuevamedida);
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
                //guardas los datos para enviarloa a la base de datos
                user = user_info.Username;
                fecha = dtpFECHA.Value.ToString("yyyy-MM-dd");
                numero = tb_numero.Text;
                peso = Convert.ToDouble(tb_peso.Text);
                tipo = combo_medidas.SelectedItem.ToString();
                costo_porkilo = costo_kilo.SelectedItem.ToString();
                convert_costokilo = Convert.ToDouble(costo_porkilo);
                total = peso * convert_costokilo;
                
                //chechar si ya existe en el invetario
                checarSiexisteEnInventario();

                using (MysqlConnector connect = new MysqlConnector())
                {
                    try
                    {
                        connect.EstablecerConexion();
                        string query = "INSERT INTO t_entradas (USUARIO , FECHA, NUMERO, PESO , TIPO , COSTOKILO, TOTAL) VALUES (@user, @fecha, @numero, @peso , @tipo ,@convert_costokilo, @total )";
                        using(MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                        {
                            cmd.Parameters.AddWithValue("@user", user);
                            cmd.Parameters.AddWithValue("@fecha", fecha);
                            cmd.Parameters.AddWithValue("@numero", numero);
                            cmd.Parameters.AddWithValue("@peso", peso);
                            cmd.Parameters.AddWithValue("@tipo", tipo);
                            cmd.Parameters.AddWithValue("@convert_costokilo", convert_costokilo);
                            cmd.Parameters.AddWithValue("@total", total);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Entrada registrada correctamente");
                            llenartabla();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    
                }

                   
            }

            
        }

        private void checarSiexisteEnInventario()
        {
            try {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "SELECT NUMERO FROM inventario_final WHERE NUMERO = @number AND TIPO = @tipo";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@number", numero);
                        cmd.Parameters.AddWithValue("@tipo", tipo);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //actualizar
                                actualizarinventario();
                            }
                            else
                            {
                                //agregarlo al inventario
                                agregaralinventario();
                            }
                            
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void actualizarinventario()
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "UPDATE inventario_final SET PESO = PESO + @peso, TOTAL = TOTAL + @total WHERE NUMERO = @numero";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@peso", peso);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.Parameters.AddWithValue("@numero", numero);
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void agregaralinventario()
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "INSERT INTO inventario_final (FECHA, NUMERO, PESO , TIPO , COSTOKILO, TOTAL) VALUES (@fecha, @numero, @peso , @tipo ,@convert_costokilo, @total )";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@fecha", fecha);
                        cmd.Parameters.AddWithValue("@numero", numero);
                        cmd.Parameters.AddWithValue("@peso", peso);
                        cmd.Parameters.AddWithValue("@tipo", tipo);
                        cmd.Parameters.AddWithValue("@convert_costokilo", convert_costokilo);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
    }
}
