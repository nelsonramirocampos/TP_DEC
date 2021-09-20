using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisiones_en_Escenarios_Complejos.Importador
{
    public class Criterio
    {
        private string nombre_criterio;
        private string tipo_criterio;

        public Criterio(string nombre_criterio, string tipo_criterio)
        {
            this.Nombre_criterio = nombre_criterio;
            this.Tipo_criterio = tipo_criterio;
        }

        public string Nombre_criterio { get => nombre_criterio; set => nombre_criterio = value; }
        public string Tipo_criterio { get => tipo_criterio; set => tipo_criterio = value; }
    }
}
