using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisiones_en_Escenarios_Complejos.Topsis
{
    public partial class frm_topsis : Form
    {
        private DataGridView dgv_copia = new DataGridView();

        private Topsis topsis;
        private Ingreso frm_ingreso;
        

        public frm_topsis(Ingreso ingreso, DataGridView matriz, DataGridView pesos, Int64 p)
        {
            InitializeComponent();

            this.frm_ingreso = ingreso;

            this.topsis = new Topsis(p);
            topsis.Dgv_matriz_original = matriz;
            topsis.Dgv_pesos_original = pesos;

            Utilidad.copiar(matriz, dgv_matriz);
            Utilidad.copiar(pesos, dgv_pesos);


            Estilo.estilo_matriz(dgv_matriz);
            Estilo.estilo_matriz_peso(dgv_pesos);
        }

        private void copiar(DataGridView origen, DataGridView destino)
        {
            //clona las columnas
            foreach (DataGridViewColumn column in origen.Columns)
            {
                destino.Columns.Add((DataGridViewColumn) column.Clone());
            }

            //Clona las filas
            for (int fila = 0; fila < origen.Rows.Count; fila++)
            {
                DataGridViewRow row = origen.Rows[fila];
                destino.Rows.Add(row.Cells[0].Value);

                //Clona los valores de cada columna y fila
                for (int columna = 0; columna < origen.Columns.Count; columna++)
                {
                    destino[columna, fila].Value = origen[columna, fila].Value;
                }
            }
        }

        private void Btn_normalizar_Click(object sender, EventArgs e)
        {
            if (this.topsis.Dgv_matriz_normalizada.Rows.Count != 0)
            {
                this.topsis.cargarNormalizada(dgv_matriz);
                return;
            }

            //**** Normalizacion de la matriz ****
            //1- La pre normalizamos
            this.topsis.preNormalizarCoeficientes(dgv_matriz);

            //2- Finalizamos la normalizacion
            this.topsis.normalizarCoeficientes(dgv_matriz);


            //**** Normalizacion de los pesos ****            
            this.topsis.normalizarPesos(dgv_pesos);


            btn_identificar_solucion.Enabled = true;
        }

        

        private void Btn_identificar_solucion_Click(object sender, EventArgs e)
        {
            if (this.topsis.Dgv_matriz_solucion.Rows.Count != 0)
            {
                this.topsis.cargarSolucion(dgv_matriz);
                return;
            }


            this.topsis.identificarSolucion(dgv_matriz);

            btn_calcular_distancia_a_mas.Enabled = true;
        }


        private void Btn_calcular_distancia_a_mas_Click(object sender, EventArgs e)
        {
            if (this.topsis.Dgv_matriz_a_mas.Rows.Count != 0)
            {
                this.topsis.cargarDistanciaAMas(dgv_matriz);
                return;
            }

            this.topsis.calcularDistanciaAMas(dgv_matriz);

            btn_calcular_distancia_a_menos.Enabled = true;
        }


        private void Btn_calcular_distancia_a_menos_Click(object sender, EventArgs e)
        {
            if (this.topsis.Dgv_matriz_a_menos.Rows.Count != 0)
            {
                this.topsis.cargarDistanciaAMenos(dgv_matriz);
                return;
            }

            this.topsis.calcularDistanciaAMenos(dgv_matriz);

            btn_ordenar_resultado.Enabled = true;
        }

        private void Btn_ordenar_resultado_Click(object sender, EventArgs e)
        {
            if (this.topsis.Dgv_resultado.Rows.Count != 0 || this.topsis.Dgv_matriz_final.Rows.Count != 0)
            {
                this.topsis.cargarResultado(dgv_matriz, dgv_resultado);
                return;
            }

            this.topsis.calcularResultadoFinal(dgv_matriz, dgv_resultado);

            Estilo.estilo_resultado(dgv_resultado);

            btn_exportar.Enabled = true;
        }

        private void Frm_topsis_Load(object sender, EventArgs e)
        {

        }

        private void Frm_topsis_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_ingreso.Visible = true;
        }

        private void Btn_exportar_Click(object sender, EventArgs e)
        {
            Exportador.exportarExcel(this.topsis.Dgv_matriz_final, this.topsis.Dgv_pesos_normalizada, this.topsis.Dgv_resultado);
        }
    }
}
