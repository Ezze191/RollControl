using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public class EliminarDatos
    {
        public string FechaInicio;
        public string FechaFin;

        public void EliminarEnEntradas()
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "DELETE FROM t_entradas WHERE FECHA >= '" + FechaInicio + "' AND FECHA <= '" + FechaFin + "'";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               // MessageBox.Show("DATOS ELIMINADOS DE ENTRADAS");
                            }
                            else
                            {
                                //MessageBox.Show("NO HAY DATOS PARA ELIMIANR DE LA TABLA ENTRADAS");

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
        public void EliminarEnSalidas()
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "DELETE FROM t_salidas WHERE FECHA_DE_ENTRADA >= '" + FechaInicio + "' AND FECHA_DE_ENTRADA <= '" + FechaFin + "'";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               // MessageBox.Show("DATOS ELIMINADOS DE SALIDAS");
                            }
                            else
                            {
                               // MessageBox.Show("NO HAY DATOS PARA ELIMIANR DE LA TABLA SALIDAS");

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
        public void EliminarEnInventario()
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "DELETE FROM inventario_final WHERE FECHA >= '" + FechaInicio + "' AND FECHA <= '" + FechaFin + "'";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               // MessageBox.Show("DATOS ELIMINADOS DE INVENTARIO");
                            }
                            else
                            {
                               // MessageBox.Show("NO HAY DATOS PARA ELIMIANR DE LA TABLA INVENTARIO");

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
    }
}
