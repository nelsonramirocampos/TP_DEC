using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisiones_en_Escenarios_Complejos.Topsis
{
    class Topsis
    {
        private DataGridView dgv_matriz_original;
        private DataGridView dgv_pesos_original;

        private DataGridView dgv_matriz_pre_normalizada;

        private DataGridView dgv_matriz_normalizada;
        private DataGridView dgv_pesos_normalizada;

        private DataGridView dgv_matriz_solucion;

        private DataGridView dgv_matriz_a_mas;
        private DataGridView dgv_matriz_a_menos;

        private DataGridView dgv_matriz_final;
        private DataGridView dgv_resultado;

        public Topsis()
        {
            this.dgv_matriz_original = new DataGridView();
            this.dgv_pesos_original = new DataGridView();
            this.dgv_matriz_pre_normalizada = new DataGridView();
            this.dgv_matriz_normalizada = new DataGridView();
            this.dgv_pesos_normalizada = new DataGridView();
            this.dgv_matriz_solucion = new DataGridView();
            this.dgv_matriz_a_mas = new DataGridView();
            this.dgv_matriz_a_menos = new DataGridView();
            this.dgv_matriz_final = new DataGridView();
            this.dgv_resultado = new DataGridView();
        }

        public DataGridView Dgv_matriz_original { get => dgv_matriz_original; set => dgv_matriz_original = value; }
        public DataGridView Dgv_pesos_original { get => dgv_pesos_original; set => dgv_pesos_original = value; }
        public DataGridView Dgv_matriz_pre_normalizada { get => dgv_matriz_pre_normalizada; set => dgv_matriz_pre_normalizada = value; }
        public DataGridView Dgv_matriz_normalizada { get => dgv_matriz_normalizada; set => dgv_matriz_normalizada = value; }
        public DataGridView Dgv_pesos_normalizada { get => dgv_pesos_normalizada; set => dgv_pesos_normalizada = value; }

        internal void cargarNormalizada(DataGridView dgv_grilla)
        {
            reset_propiedades(dgv_grilla);
            Utilidad.copiar(dgv_matriz_normalizada, dgv_grilla);
        }

        internal void cargarSolucion(DataGridView dgv_grilla)
        {
            reset_propiedades(dgv_grilla);
            Utilidad.copiar(Dgv_matriz_solucion, dgv_grilla);
        }

        internal void cargarDistanciaAMas(DataGridView dgv_grilla)
        {
            reset_propiedades(dgv_grilla);
            Utilidad.copiar(Dgv_matriz_a_mas, dgv_grilla);
        }

        internal void cargarDistanciaAMenos(DataGridView dgv_grilla)
        {
            reset_propiedades(dgv_grilla);
            Utilidad.copiar(Dgv_matriz_a_menos, dgv_grilla);
        }

        internal void cargarResultado(DataGridView dgv_grilla, DataGridView dgv_res)
        {
            reset_propiedades(dgv_grilla);
            Utilidad.copiar(Dgv_matriz_final, dgv_grilla);

            reset_propiedades(dgv_res);
            Utilidad.copiar(dgv_resultado, dgv_res);
        }

        public DataGridView Dgv_matriz_a_mas { get => dgv_matriz_a_mas; set => dgv_matriz_a_mas = value; }
        public DataGridView Dgv_matriz_a_menos { get => dgv_matriz_a_menos; set => dgv_matriz_a_menos = value; }

        internal void normalizarPesos(DataGridView dgv_pesos)
        {
            reset_propiedades(dgv_pesos_normalizada);

            Utilidad.copiar(dgv_pesos_original, dgv_pesos_normalizada);

            Double suma = 0;
            for (int columna = 1; columna < dgv_pesos_normalizada.Columns.Count; columna++)
            {
                suma = suma + Convert.ToDouble(dgv_pesos_normalizada[columna, 0].Value);
            }

            for (int columna = 1; columna < dgv_pesos_normalizada.Columns.Count; columna++)
            {
                dgv_pesos_normalizada[columna, 0].Value = Utilidad.redondear(Convert.ToDouble(dgv_pesos_normalizada[columna, 0].Value) / suma);
            }

            reset_propiedades(dgv_pesos);
            Utilidad.copiar(dgv_pesos_normalizada, dgv_pesos);

        }

        internal void calcularResultadoFinal(DataGridView dgv_grilla, DataGridView dgv_res)
        {
            reset_propiedades(Dgv_matriz_final);

            Utilidad.copiar(dgv_matriz_original, Dgv_matriz_final);


            this.Dgv_matriz_final.Columns.Add("cSMas", "S+");
            this.Dgv_matriz_final.Columns.Add("cSMenos", "S-");

            for (int indice_fila = 1; indice_fila < dgv_matriz_a_mas.Rows.Count-2; indice_fila++)
            {
                string decision = dgv_matriz_a_mas.Rows[indice_fila].Cells[0].Value.ToString();
                double s_mas = Convert.ToDouble(dgv_matriz_a_mas.Rows[indice_fila].Cells["cRaizAMas"].Value.ToString());
                double s_menos = Convert.ToDouble(dgv_matriz_a_menos.Rows[indice_fila].Cells["cRaizAMenos"].Value.ToString());

                this.Dgv_matriz_final["cSMas", indice_fila].Value = s_mas;
                this.Dgv_matriz_final["cSMenos", indice_fila].Value = s_menos;
            }

            reset_propiedades(dgv_grilla);
            Utilidad.copiar(Dgv_matriz_final, dgv_grilla);




            reset_propiedades(dgv_resultado);

            dgv_resultado.Columns.Add("", "");
            dgv_resultado.Columns.Add("cC", "C*");

            List<Resultado> resultados = new List<Resultado>();

            for (int i = 1; i < Dgv_matriz_final.Rows.Count; i++)
            {
                DataGridViewRow row = Dgv_matriz_final.Rows[i];

                double s_menos = Convert.ToDouble(row.Cells["cSMenos"].Value.ToString());
                double s_mas = Convert.ToDouble(row.Cells["cSMas"].Value.ToString());

                double c = Utilidad.redondear(s_menos / (s_mas + s_menos));

                resultados.Add(new Resultado(row.Cells[0].Value.ToString(), c));

            }



            List<Resultado> resultados_ordenados = resultados.OrderByDescending(r => r.Valor).ToList();

            foreach (Resultado resultado in resultados_ordenados)
            {
                dgv_resultado.Rows.Add(resultado.Decision, resultado.Valor);
            }

            reset_propiedades(dgv_res);
            Utilidad.copiar(dgv_resultado, dgv_res);

        }

        internal void calcularDistanciaAMenos(DataGridView dgv_grilla)
        {
            reset_propiedades(Dgv_matriz_a_menos);

            Utilidad.copiar(dgv_matriz_solucion, Dgv_matriz_a_menos);

            DataGridViewRow alternativa_A_menos = Dgv_matriz_a_menos.Rows[Dgv_matriz_a_menos.Rows.Count - 1]; //Fila con los valores de A-

            //Se recorre por columna
            for (int indice_columna = 1; indice_columna < Dgv_matriz_a_menos.Columns.Count; indice_columna++)
            {
                //Se recorre por fila
                for (int indice_fila = 1; indice_fila < Dgv_matriz_a_menos.Rows.Count - 2; indice_fila++)
                {
                    Double vij = Convert.ToDouble(Dgv_matriz_a_menos[indice_columna, indice_fila].Value); //El valor de la matriz
                    Double vj = Convert.ToDouble(alternativa_A_menos.Cells[indice_columna].Value); //El valor de la alternativa A- segun la columna

                    Dgv_matriz_a_menos[indice_columna, indice_fila].Value = Utilidad.redondear(Math.Pow(Math.Abs(vij - vj), 2));
                }
            }



            //Columna de suma y columna raiz
            Dgv_matriz_a_menos.Columns.Add("cSumaAMenos", "Suma A-");
            Dgv_matriz_a_menos.Columns.Add("cRaizAMenos", "Raiz A-");


            Double suma_fila = 0;

            //Para la columna suma
            for (int indice_fila = 1; indice_fila < Dgv_matriz_a_menos.Rows.Count - 2; indice_fila++)
            {
                for (int indice_columna = 1; indice_columna < Dgv_matriz_a_menos.Columns.Count; indice_columna++)
                {
                    suma_fila = suma_fila + Convert.ToDouble(Dgv_matriz_a_menos[indice_columna, indice_fila].Value);
                }

                Dgv_matriz_a_menos["cSumaAMenos", indice_fila].Value = suma_fila;
                Dgv_matriz_a_menos["cRaizAMenos", indice_fila].Value = Utilidad.redondear(Math.Sqrt(suma_fila));

                suma_fila = 0;
            }

            reset_propiedades(dgv_grilla);
            Utilidad.copiar(Dgv_matriz_a_menos, dgv_grilla);

        }

        internal void calcularDistanciaAMas(DataGridView dgv_grilla)
        {
            reset_propiedades(Dgv_matriz_a_mas);

            Utilidad.copiar(dgv_matriz_solucion, Dgv_matriz_a_mas);

            DataGridViewRow alternativa_A_mas = Dgv_matriz_a_mas.Rows[Dgv_matriz_a_mas.Rows.Count - 2]; //Obtengo la fila A+            


            //Se recorre por columna
            for (int indice_columna = 1; indice_columna < Dgv_matriz_a_mas.Columns.Count; indice_columna++)
            {
                //Se recorre por fila
                for (int indice_fila = 1; indice_fila < Dgv_matriz_a_mas.Rows.Count - 2; indice_fila++)
                {
                    Double vij = Convert.ToDouble(Dgv_matriz_a_mas[indice_columna, indice_fila].Value); //El valor de la matriz
                    Double vj = Convert.ToDouble(alternativa_A_mas.Cells[indice_columna].Value); //El valor de la alternativa A+ segun la columna

                    Dgv_matriz_a_mas[indice_columna, indice_fila].Value = Utilidad.redondear(Math.Pow(Math.Abs(vij - vj), 2));
                }
            }


            //Columna de suma y columna raiz
            Dgv_matriz_a_mas.Columns.Add("cSumaAMas", "Suma A+");
            Dgv_matriz_a_mas.Columns.Add("cRaizAMas", "Raiz A+");


            Double suma_fila = 0;

            //Para la columna suma
            for (int indice_fila = 1; indice_fila < Dgv_matriz_a_mas.Rows.Count - 2; indice_fila++)
            {
                for (int indice_columna = 1; indice_columna < Dgv_matriz_a_mas.Columns.Count; indice_columna++)
                {
                    suma_fila = suma_fila + Convert.ToDouble(Dgv_matriz_a_mas[indice_columna, indice_fila].Value);
                }

                Dgv_matriz_a_mas["cSumaAMas", indice_fila].Value = suma_fila;
                Dgv_matriz_a_mas["cRaizAMas", indice_fila].Value = Utilidad.redondear(Math.Sqrt(suma_fila));

                suma_fila = 0;
            }

            reset_propiedades(dgv_grilla);
            Utilidad.copiar(Dgv_matriz_a_mas, dgv_grilla);
        }

        internal void identificarSolucion(DataGridView dgv_grilla)
        {
            reset_propiedades(dgv_matriz_solucion);

            Utilidad.copiar(dgv_matriz_normalizada, dgv_matriz_solucion);

            dgv_matriz_solucion.Rows.RemoveAt(dgv_matriz_solucion.Rows.Count - 1);
            dgv_matriz_solucion.Rows.RemoveAt(dgv_matriz_solucion.Rows.Count - 1);

            dgv_matriz_solucion.Rows.Add("A+");
            dgv_matriz_solucion.Rows.Add("A-");


            //Se multiplica los coeficientes normalizados por los pesos normalizados
            //Se recorre por columna
            for (int indice_columna = 1; indice_columna < dgv_matriz_solucion.Columns.Count; indice_columna++)
            {
                Double wj = Convert.ToDouble(Dgv_pesos_normalizada[indice_columna, 0].Value);

                //Se recorre por fila
                for (int indice_fila = 1; indice_fila < dgv_matriz_solucion.Rows.Count - 2; indice_fila++)
                {
                    Double coeficiente_normalizado = Utilidad.redondear(Convert.ToDouble(dgv_matriz_solucion[indice_columna, indice_fila].Value)); //El valor de la matriz

                    dgv_matriz_solucion[indice_columna, indice_fila].Value = Utilidad.redondear(coeficiente_normalizado * wj);
                }
            }



            for (int indice_columna = 1; indice_columna < dgv_matriz_solucion.Columns.Count; indice_columna++)
            {
                DataGridViewColumn columna = dgv_matriz_solucion.Columns[indice_columna];

                if (columna.HeaderText == Constantes.CRITERIO_MAX)
                {
                    dgv_matriz_solucion[indice_columna, dgv_matriz_solucion.Rows.Count - 2].Value = obtenerMaximo(indice_columna, dgv_matriz_solucion); //Para la fila A+
                    dgv_matriz_solucion[indice_columna, dgv_matriz_solucion.Rows.Count - 1].Value = obtenerMinimo(indice_columna, dgv_matriz_solucion); //Para la fila A-
                }
                if (columna.HeaderText == Constantes.CRITERIO_MIN)
                {
                    dgv_matriz_solucion[indice_columna, dgv_matriz_solucion.Rows.Count - 2].Value = obtenerMinimo(indice_columna, dgv_matriz_solucion); //Para la fila A-
                    dgv_matriz_solucion[indice_columna, dgv_matriz_solucion.Rows.Count - 1].Value = obtenerMaximo(indice_columna, dgv_matriz_solucion); //Para la fila A+
                }
            }


            reset_propiedades(dgv_grilla);
            Utilidad.copiar(dgv_matriz_solucion, dgv_grilla);

        }

        public DataGridView Dgv_matriz_solucion { get => dgv_matriz_solucion; set => dgv_matriz_solucion = value; }
        public DataGridView Dgv_matriz_final { get => dgv_matriz_final; set => dgv_matriz_final = value; }
        public DataGridView Dgv_resultado { get => dgv_resultado; set => dgv_resultado = value; }

        private void reset_propiedades(DataGridView grilla)
        {
            grilla.Columns.Clear();
            grilla.Rows.Clear();

            grilla.AllowDrop = false;
            grilla.AllowUserToAddRows = false;
            grilla.AllowUserToDeleteRows = false;
            grilla.RowHeadersVisible = false;

            //Estilo.estilo_matriz(grilla);
        }

        public void preNormalizarCoeficientes(DataGridView dgv_grilla)
        {
            reset_propiedades(dgv_matriz_pre_normalizada);

            Utilidad.copiar(dgv_matriz_original, dgv_matriz_pre_normalizada);

            //Se agregar dos filas para ayudar en la visualizacion de los calculos
            Dgv_matriz_pre_normalizada.Rows.Add("Suma Cuadrada");
            Dgv_matriz_pre_normalizada.Rows.Add("Raiz Suma");


            //Obtengo la suma acumulada y la raiz cuadrada de la suma acumulada
            //El recorrido por la matriz sera de columna a filas
            for (int columna = 1; columna < Dgv_matriz_pre_normalizada.Columns.Count; columna++)
            {
                double acumulador_fila = 0;

                //Se recorre cada fila
                for (int fila = 1; fila < Dgv_matriz_pre_normalizada.Rows.Count - 2; fila++)
                {
                    //Se eleva al cuadrado cada elemento de la matriz
                    Dgv_matriz_pre_normalizada[columna, fila].Value = Math.Pow(Convert.ToDouble(Dgv_matriz_pre_normalizada[columna, fila].Value), 2);

                    acumulador_fila = acumulador_fila + Convert.ToDouble(Dgv_matriz_pre_normalizada[columna, fila].Value);
                }

                Dgv_matriz_pre_normalizada[columna, Dgv_matriz_pre_normalizada.Rows.Count - 2].Value = acumulador_fila; //Acumulador por columna
                Dgv_matriz_pre_normalizada[columna, Dgv_matriz_pre_normalizada.Rows.Count - 1].Value = Utilidad.redondear(Math.Sqrt(acumulador_fila)); //Raiz Cuadrada por la suma de la columna
            }

            reset_propiedades(dgv_grilla);
            Utilidad.copiar(dgv_matriz_pre_normalizada, dgv_grilla);
        }

        public void normalizarCoeficientes(DataGridView dgv_grilla)
        {
            reset_propiedades(dgv_matriz_normalizada);

            Utilidad.copiar(dgv_matriz_original, dgv_matriz_normalizada);

            //Se agrega las filas suma cuadrada y raiz suma para su visualizacion y calculos
            DataGridViewRow fila_suma_cuadrada = Utilidad.clonarFilaCompleta(dgv_matriz_pre_normalizada.Rows[dgv_matriz_pre_normalizada.Rows.Count - 2]);
            DataGridViewRow fila_raiz = Utilidad.clonarFilaCompleta(dgv_matriz_pre_normalizada.Rows[dgv_matriz_pre_normalizada.Rows.Count - 1]);

            dgv_matriz_normalizada.Rows.Add(fila_suma_cuadrada); //Fila Suma Cuadrada
            dgv_matriz_normalizada.Rows.Add(fila_raiz); //Fila Raiz Suma Cuadrada

            //El recorrido por la matriz sera de columna a filas para terminar de normalizar
            for (int columna = 1; columna < dgv_matriz_normalizada.Columns.Count; columna++)
            {
                double denominador = Convert.ToDouble(dgv_matriz_normalizada[columna, dgv_matriz_normalizada.Rows.Count - 1].Value);

                //Se recorre cada fila
                for (int fila = 1; fila < dgv_matriz_normalizada.Rows.Count - 2; fila++)
                {
                    double numerador = Convert.ToDouble(dgv_matriz_normalizada[columna, fila].Value);

                    dgv_matriz_normalizada[columna, fila].Value = Utilidad.redondear(numerador / denominador);
                }
            }

            reset_propiedades(dgv_grilla);
            Utilidad.copiar(dgv_matriz_normalizada, dgv_grilla);
        }


        public void generarMatrizFinal()
        {
            this.dgv_matriz_final = new DataGridView();


            //Se agrega las columnas
            foreach (DataGridViewColumn column in dgv_matriz_original.Columns)
            {
                this.dgv_matriz_final.Columns.Add(column);
            }

            this.dgv_matriz_final.Columns.Add("cSMas", "S+");
            this.dgv_matriz_final.Columns.Add("cSMenos", "S-");

            dgv_matriz_a_mas.Rows.Add(this.dgv_matriz_final.Rows[0]);
        }


        private Double obtenerMaximo(int indice_columna, DataGridView dgv_matriz)
        {
            Double max = Double.MinValue;

            for (int indice_fila = 1; indice_fila < dgv_matriz.Rows.Count - 2; indice_fila++)
            {
                if (Convert.ToDouble(dgv_matriz[indice_columna, indice_fila].Value) > max)
                {
                    max = Convert.ToDouble(dgv_matriz[indice_columna, indice_fila].Value);
                }
            }

            return max;
        }


        private Double obtenerMinimo(int indice_columna, DataGridView dgv_matriz)
        {
            Double min = Double.MaxValue;

            for (int indice_fila = 1; indice_fila < dgv_matriz.Rows.Count - 2; indice_fila++)
            {
                if (Convert.ToDouble(dgv_matriz[indice_columna, indice_fila].Value) < min)
                {
                    min = Convert.ToDouble(dgv_matriz[indice_columna, indice_fila].Value);
                }
            }

            return min;
        }

    }
}
