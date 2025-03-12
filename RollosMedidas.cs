using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    public static class RollosMedidas
    {
        private static List<string> tiposRollo = new List<string> { "71.0 CMs", "76.0 CMs", "38.0 CMs" };
        public static void AgregarMedida(string medida)
        {
            tiposRollo.Add(medida);
        }

        public static string[] ObtenerMedidas()
        {
            return tiposRollo.ToArray();
        }
    }
}
