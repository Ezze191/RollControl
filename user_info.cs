using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public static class user_info
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        /*este numero se refiere a los permisos de administrador que va tener si
         * el numero es 1 significa que es administrador y si es 0 significa que es usuario
        */
        public static int tipo { get; set; }

        public static  string status { get; set; }

        public static void checarstatus()
        {
            try
            {
                using (MysqlConnector connect = new MysqlConnector())
                {
                    connect.EstablecerConexion();

                    string query = "SELECT status FROM cerrarAbrir_inventario";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect.ObtenerConexion()))
                    {

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user_info.status = reader.GetString("status");
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
    }
}
