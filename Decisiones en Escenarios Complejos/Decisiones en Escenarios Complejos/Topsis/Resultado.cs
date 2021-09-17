using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisiones_en_Escenarios_Complejos.Topsis
{
    class Resultado
    {

        private string decision;
        private double valor;

        public Resultado(string decision, double valor)
        {
            this.Decision = decision;
            this.Valor = valor;
        }

        public string Decision { get => decision; set => decision = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}
