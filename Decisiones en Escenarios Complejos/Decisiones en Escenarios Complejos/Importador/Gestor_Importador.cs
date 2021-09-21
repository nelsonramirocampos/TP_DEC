using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisiones_en_Escenarios_Complejos.Importador
{
    public class Gestor_Importador
    {
        private List<Alternativa> alternativas;
        private List<Criterio> criterios;
        private List<double> pesos;

        public Gestor_Importador()
        {
            this.Alternativas = new List<Alternativa>();
            this.Criterios = new List<Criterio>();
            this.Pesos = new List<double>();
        }

        public List<Alternativa> Alternativas { get => alternativas; set => alternativas = value; }
        public List<Criterio> Criterios { get => criterios; set => criterios = value; }
        public List<double> Pesos { get => pesos; set => pesos = value; }

        public void agregarAlternativa(string alternativa_nueva, List<double> valores)
        {
            this.Alternativas.Add(new Alternativa(alternativa_nueva, valores));
        }

        public void agregarCriterio(string nombre_criterio, string tipo_criterio)
        {
            this.Criterios.Add(new Criterio(nombre_criterio, tipo_criterio));
        }

        public void cargar_import(DataGridView grilla, DataGridView dgv_pesos)
        {
            grilla.Rows.Clear();
            grilla.Columns.Clear();

            grilla.Columns.Add("", "");
            grilla.Rows.Add("");


            for (int i = 0; i < this.Criterios.Count-1; i++)
            {
                grilla.Columns.Add("c" + i, this.Criterios[i].Tipo_criterio);
                grilla[i + 1, 0].Value = this.Criterios[i].Nombre_criterio;
            }


            for (int i = 0; i < this.Alternativas.Count-2; i++)
            {
                grilla.Rows.Add(this.Alternativas[i].Alternativa_nueva);

                for (int j = 0; j < this.Alternativas[i].Valores.Count; j++)
                {
                    grilla[j+1, i+1].Value = this.Alternativas[i].Valores[j];
                }
            }


            for (int i = 0; i < this.pesos.Count; i++)
            {
                dgv_pesos.Columns.Add("c" + this.Criterios[i].Nombre_criterio, this.Criterios[i].Nombre_criterio);
                dgv_pesos[i + 1, 0].Value = this.pesos[i];
            }


            Estilo.estilo_matriz(grilla);
            Estilo.estilo_matriz_peso(dgv_pesos);
        }

        internal void agregarPeso(double peso)
        {
            this.pesos.Add(peso);
        }
    }
}
