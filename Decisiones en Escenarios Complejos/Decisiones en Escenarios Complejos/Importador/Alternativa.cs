using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisiones_en_Escenarios_Complejos.Importador
{
    public class Alternativa
    {
        private string alternativa_nueva;
        private List<double> valores;

        public Alternativa(string alternativa_nueva, List<double> valores)
        {
            this.alternativa_nueva = alternativa_nueva;
            this.valores = valores;
        }

        public string Alternativa_nueva { get => alternativa_nueva; set => alternativa_nueva = value; }
        public List<double> Valores { get => valores; set => valores = value; }

        public void agregar_valor(double v)
        {
            this.valores.Add(v);
        }
    }
}
