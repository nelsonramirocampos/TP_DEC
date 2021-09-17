using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisiones_en_Escenarios_Complejos
{
    class Estilo
    {

        public static void estilo_matriz(DataGridView grilla)
        {
            //Para la primera columna
            grilla.Columns[0].DefaultCellStyle.Font = new Font("Corbel", 11, FontStyle.Bold);
            

            //Para todas la primera fila de todas las columnas
            grilla.Rows[0].DefaultCellStyle.Font = new Font("Corbel", 11, FontStyle.Bold);

            //Para los valores de las celdas
            grilla.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 11, FontStyle.Italic);
            grilla.DefaultCellStyle.Font = new Font("Corbel", 11, FontStyle.Regular);

            grilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grilla.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public static void estilo_matriz_peso(DataGridView grilla)
        {
            //Para la primera columna
            grilla.Columns[0].DefaultCellStyle.Font = new Font("Corbel", 11, FontStyle.Bold);
            grilla.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //Para los valores de las celdas
            grilla.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 11, FontStyle.Italic);
            grilla.DefaultCellStyle.Font = new Font("Corbel", 11, FontStyle.Regular);


            grilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grilla.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grilla.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 11, FontStyle.Bold);
        }

        public static void estilo_resultado(DataGridView grilla)
        {
            grilla.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 11, FontStyle.Bold);
            grilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grilla.Columns[0].DefaultCellStyle.Font = new Font("Corbel", 11, FontStyle.Bold);
            grilla.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grilla.DefaultCellStyle.Font = new Font("Corbel", 11, FontStyle.Regular);
            grilla.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }

    }
}
