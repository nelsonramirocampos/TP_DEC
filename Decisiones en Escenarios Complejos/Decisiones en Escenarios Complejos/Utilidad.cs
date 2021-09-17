using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisiones_en_Escenarios_Complejos
{
    class Utilidad
    {
        /*
         * Realiza una copia de una grilla y la retorna
         */
        public static DataGridView copia_grilla(DataGridView original)
        {
            DataGridView copia = new DataGridView();

            //Clona las columnas
            foreach (DataGridViewColumn column in original.Columns)
            {
                copia.Columns.Add((DataGridViewColumn)column.Clone());
            }

            //Clona las filas
            for (int fila = 0; fila < original.Rows.Count; fila++)
            {
                DataGridViewRow row = original.Rows[fila];
                copia.Rows.Add(row.Cells[0].Value);

                //Clona los valores de cada columna y fila
                for (int columna = 0; columna < original.Columns.Count; columna++)
                {
                    copia[columna, fila].Value = original[columna, fila].Value;
                }
            }

            return copia;
        }


        /*
         * Realiza una copia de una grilla a otra.
         */
        public static void copiar(DataGridView origen, DataGridView destino)
        {
            //clona las columnas
            foreach (DataGridViewColumn column in origen.Columns)
            {
                destino.Columns.Add((DataGridViewColumn)column.Clone());
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

            destino.Columns[0].ReadOnly = true;
            destino.Rows[0].ReadOnly = true;
        }



        public static DataGridViewRow clonarFilaCompleta(DataGridViewRow row)
        {
            DataGridViewRow clonedRow = (DataGridViewRow)row.Clone();
            for (Int32 index = 0; index < row.Cells.Count; index++)
            {
                clonedRow.Cells[index].Value = row.Cells[index].Value;
            }
            return clonedRow;
        }


        public static Double redondear(double nro)
        {
            return Math.Round(nro, Configuracion.getCantidadDecimales());
        }


    }
}
