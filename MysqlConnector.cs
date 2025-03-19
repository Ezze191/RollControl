using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventario
{
    internal class MysqlConnector : IDisposable
    {
        private MySqlConnection conexion;
        static string servidor = "192.168.55.131";
        static string bd = "inventario_rollos";
        static string usuario = "admin";
        static string password = "admin";
        static string puerto = "3306";

        private readonly string CodigoConexion = $"server={servidor};port={puerto};user id={usuario};password={password};database={bd};";

        public MysqlConnector()
        {
            conexion = new MySqlConnection(CodigoConexion);
        }
        public void EstablecerConexion()
        {
            try
            {
                if(conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("PROBLEMA EN LA BASE DE DATOS :" + ex.Message);
            }

        }
        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open) { 
                conexion.Close();
            }
        }
        public void Dispose()
        {
            CerrarConexion();
            conexion.Dispose();
        }

        public MySqlConnection ObtenerConexion()
        {
            return conexion;
        }


    }
}
