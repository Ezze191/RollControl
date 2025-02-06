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
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
            llenartabla();


            //forzar colores
            panel_opciones.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
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
                       using(MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }

                    }
                }
            }
            catch(Exception ex)
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
                string user = user_info.Username;
                string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                string numero = tb_numero.Text;
                double peso = Convert.ToDouble(tb_peso.Text);
                string tipo = combo_medidas.SelectedItem.ToString();
                string costo_porkilo = costo_kilo.SelectedItem.ToString();
                double convert_costokilo = Convert.ToDouble(costo_porkilo);
                double total = peso * convert_costokilo;
                string fecha_de_salida = dtpFECHA.Value.ToString("yyyy-MM-dd");


                using (MysqlConnector connect = new MysqlConnector())
                {
                    try
                    {
                        connect.EstablecerConexion();
                        string query = "INSERT INTO t_salidas (USUARIO , FECHA, NUMERO, PESO , TIPO , COSTOKILO, TOTAL, FECHA_DE_SALIDA) VALUES (@user, @fecha, @numero, @peso , @tipo ,@convert_costokilo, @total , @fecha_de_salida)";
                        using(MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                        {
                            cmd.Parameters.AddWithValue("@user", user);
                            cmd.Parameters.AddWithValue("@fecha", fecha);
                            cmd.Parameters.AddWithValue("@numero", numero);
                            cmd.Parameters.AddWithValue("@peso", peso);
                            cmd.Parameters.AddWithValue("@tipo", tipo);
                            cmd.Parameters.AddWithValue("@convert_costokilo", convert_costokilo);
                            cmd.Parameters.AddWithValue("@total", total);
                            cmd.Parameters.AddWithValue("@fecha_de_salida", fecha_de_salida);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Salida registrada correctamente");
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
    }
}
