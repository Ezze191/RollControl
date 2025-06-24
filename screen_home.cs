using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic;


namespace Inventario
{
    public partial class screen_home : MaterialForm
    {
        private bool sidebarExpanded;
        private Timer timer;

        private void BtnHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Home Clicked!");
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings Clicked!");
        }

        public screen_home()
        {
            InitializeComponent();
            // Create MaterialSkin manager
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; // or DARK


            // Color scheme
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue500, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
                );

            //colores forzados
            //barra lateral
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
            //pb salidas
            pictureBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
            pictureBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
            //pbuser
            pb_user.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
            //lbuser
            lb_name.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
            pictureBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
            pictureBox4.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");
            pb_tool.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
            pictureBox6.BackColor = System.Drawing.ColorTranslator.FromHtml("#524F4F");

        }

        private void LoadUserControl(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }


        private void screen_home_Load(object sender, EventArgs e)
        {
            panel1.AutoScroll = true;
            panelFondo.AutoScroll = true;

            loadFecha();
            CargarDatosGrafica();

            if (user_info.tipo == 0)
            {
                panel2.Visible = false;
                pb_tool.Visible = false;

                //mover los botones para que se vean mejor
                pictureBox3.Location = new Point(0,500);
                pictureBox2.Location = new Point(0, 330);

            }

            lb_name.Text = user_info.Username;

            user_info.checarstatus();

            if (user_info.status == "open")
            {
                
                MessageBox.Show("ADVERTENCIA : EL INVENTARIO ESTA ABIERTO A LA FECHA : " + checarFecha());
            }
            

        }

        private string checarFecha()
        {
            string fechaEnElInventario = "";
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


                                fechaEnElInventario = $"{mes}/{anio}"; // Formato de fecha: mes/año
                                

                            }
                        }
                    }
                } // Aquí se cierra automáticamente la conexión con Dispose()
               
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
            }

            return fechaEnElInventario;

        }

        private void loadFecha()
        {
            timer = new Timer(); // Asegura que el Timer esté instanciado
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();

            fechalabel.Text = DateTime.Now.ToString("d ' ' MMMM ' ' yyyy        HH:mm:ss");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            fechalabel.Text = DateTime.Now.ToString("d ' ' MMMM ' ' yyyy        HH:mm:ss");
        }
        private void CargarDatosGrafica()
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    if (connect.ObtenerConexion().State != ConnectionState.Open)
                    {
                        MessageBox.Show("Error: La conexión a la base de datos no está abierta.");
                        return;
                    }

                    string query = @"
                SELECT 
                    (SELECT COUNT(*) FROM t_entradas WHERE DATE(FECHA) = CURDATE()) AS total_entradas,
                    (SELECT COUNT(*) FROM t_salidas WHERE DATE(FECHA_DE_SALIDA) = CURDATE()) AS total_salidas;
            ";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int totalEntradas = reader.GetInt32("total_entradas");
                                int totalSalidas = reader.GetInt32("total_salidas");

                                chart1.Series.Clear();
                                Series series = new Series("Movimientos")
                                {
                                    ChartType = SeriesChartType.Column
                                };

                                // Agregar datos con colores personalizados
                                series.Points.AddXY("Entradas", totalEntradas);
                                series.Points[0].Color = System.Drawing.ColorTranslator.FromHtml("#2196f3");

                                series.Points.AddXY("Salidas", totalSalidas);
                                series.Points[1].Color = System.Drawing.ColorTranslator.FromHtml("#1976d2");

                                chart1.Series.Add(series);

                                // Hacer fondo transparente
                                chart1.BackColor = System.Drawing.Color.Transparent;
                                chart1.ChartAreas[0].BackColor = System.Drawing.Color.Transparent;
                                chart1.Legends[0].BackColor = System.Drawing.Color.Transparent;

                                chart1.Invalidate();
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron datos.");
                            }
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //cambiar color para saber que esta seleccioando
            pictureBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#8999F3");
            LoadUserControl(new UserControl1());
        }

        private void pb_user_Click(object sender, EventArgs e)
        {
            screen_home home = new screen_home();
            home.Show();
            this.Hide();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            //cambia de color
            pictureBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#374491");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            //cambia al color original
            pictureBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
        }

        private void pb_user_MouseEnter(object sender, EventArgs e)
        {
            pb_user.BackColor = System.Drawing.ColorTranslator.FromHtml("#374491");
        }

        private void pb_user_MouseLeave(object sender, EventArgs e)
        {
            pb_user.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#374491");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl2());
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#374491");
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = System.Drawing.ColorTranslator.FromHtml("#374491");
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ESTAS SEGURO DE CERRAR SESION?", "LOG OUT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                screen_login login = new screen_login();
                login.Show();
                this.Hide();
            }
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl3());
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            user_info.checarstatus();
            if(user_info.status == "open")
            {
                MessageBox.Show("El inventario ya esta abierto");
            }
            else
            {
                // Pedir el mes
                string mesInput = Interaction.InputBox("Ingrese el número de mes (1-12):", "Seleccionar Mes", DateTime.Now.Month.ToString());
                if (!int.TryParse(mesInput, out int nuevoMes) || nuevoMes < 1 || nuevoMes > 12)
                {
                    MessageBox.Show("Mes inválido. Debe ingresar un número entre 1 y 12.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Pedir el año
                string anioInput = Interaction.InputBox("Ingrese el año:", "Seleccionar Año", DateTime.Now.Year.ToString());
                if (!int.TryParse(anioInput, out int nuevoAnio) || nuevoAnio < 2000 || nuevoAnio > 2100)
                {
                    MessageBox.Show("Año inválido. Debe ingresar un año válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirmar selección
                DialogResult confirmacion = MessageBox.Show($"¿Desea cambiar al mes {nuevoMes} del año {nuevoAnio}?",
                                                            "Confirmar cambio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    CambiarMesEnBD(nuevoMes, nuevoAnio);
                    abrirInventario();
                }
                
            }
        }
        private void abrirInventario()
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "update cerrarAbrir_inventario set status = 'open'";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            MessageBox.Show("Inventario Abierto");
                        }
                    }
                } // Aquí se cierra automáticamente la conexión con Dispose()
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
            }
        }

        private void CambiarMesEnBD(int nuevoMes, int nuevoAnio)
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "UPDATE configuracionDate SET mes = @mes, anio = @anio WHERE id = 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@mes", nuevoMes);
                        cmd.Parameters.AddWithValue("@anio", nuevoAnio);
                        cmd.ExecuteNonQuery();
                    }
                } 
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
            }
        }
        private void cerrarInventario()
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "update cerrarAbrir_inventario set status = 'close'";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            MessageBox.Show("Inventario Cerrado");
                        }
                    }
                } 
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            user_info.checarstatus();
            if (user_info.status == "close")
            {
                MessageBox.Show("El inventario ya esta cerrado");
            }
            else
            {
                cerrarInventario();
            }
        }

        private void pb_tool_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl4());
        }

        private void pb_tool_MouseEnter(object sender, EventArgs e)
        {
            pb_tool.BackColor = System.Drawing.ColorTranslator.FromHtml("#374491");
            
        }

        private void pb_tool_MouseLeave(object sender, EventArgs e)
        {
            pb_tool.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b377a");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl5());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
