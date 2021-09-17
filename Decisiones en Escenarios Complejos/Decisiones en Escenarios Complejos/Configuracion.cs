using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisiones_en_Escenarios_Complejos
{
    public class Configuracion
    {
        private static int CANTIDAD_DECIMAL = 4;

        public static void setCantidadDecimales(int cantidad)
        {
            CANTIDAD_DECIMAL = cantidad;
        }

        public static int getCantidadDecimales()
        {
            return CANTIDAD_DECIMAL;
        }

    }
}
