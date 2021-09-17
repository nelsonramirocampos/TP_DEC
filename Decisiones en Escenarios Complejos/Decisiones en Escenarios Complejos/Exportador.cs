using ClosedXML.Excel;
using System;
using System.Data;
using System.Windows.Forms;


namespace Decisiones_en_Escenarios_Complejos
{
    class Exportador
    {
        //public static String RUTA_ARCHIVO = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


        internal static void exportarExcel(DataGridView dgv_grilla, DataGridView dgv_pesos, DataGridView dgv_resultado)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var workbook = new XLWorkbook();
                        var worksheet = workbook.Worksheets.Add("Resultado Final");


                        /* ******* GRILLA PRINCIPAL ******* */
                        cabecera(4, 5, dgv_grilla, worksheet);
                        vertical(5, "E", dgv_grilla, worksheet);
                        criterios(5, 5, true, dgv_grilla, worksheet); //Nombre de los criterios
                        celdas(5, 5, dgv_grilla, worksheet);
                        mensaje("F2", "Matriz Original", worksheet);


                        /* ******* GRILLA PESO ******* */
                        cabecera(13, 5, dgv_pesos, worksheet);
                        criterios(14, 5, false, dgv_pesos, worksheet); //Primera fila
                        vertical(14, "E", dgv_pesos, worksheet);
                        mensaje("F11", "Matriz Pesos", worksheet);

                        /* ******* GRILLA RESULTADO ******* */
                        cabecera(4, 12, dgv_resultado, worksheet);
                        criterios(5, 12, false, dgv_resultado, worksheet);
                        vertical(5, "L", dgv_resultado, worksheet);
                        celdas(5, 12, dgv_resultado, worksheet);
                        mensaje("L2", "Matriz Resultado", worksheet);

                        //Guardado
                        workbook.SaveAs(sfd.FileName);

                        //Mensaje avisando que se guardar correctamente
                        MessageBox.Show("El archivo se exporto correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Mensaje Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private static void mensaje(string desde, string mensaje, IXLWorksheet worksheet)
        {
            worksheet.Cell(desde).Value = mensaje;
            worksheet.Cell(desde).Style.Font.Bold = true; //Letra negrita
        }


        private static void criterios(int fila_fija, int columna_inicial, Boolean isBold, DataGridView dgv_grilla, IXLWorksheet worksheet)
        {
            for (int j = 0; j < dgv_grilla.Columns.Count; j++)
            {
                string nombre_criterio = "";
                if (dgv_grilla[j, 0].Value != null)
                {
                    nombre_criterio = dgv_grilla[j, 0].Value.ToString();
                }

                worksheet.Cell(fila_fija, j + columna_inicial).Value = nombre_criterio;

                if (nombre_criterio != "")
                {
                    worksheet.Cell(fila_fija, j + columna_inicial).Style.Font.Bold = isBold; //Letra negrita
                    worksheet.Cell(fila_fija, j + columna_inicial).Style.Font.FontFamilyNumbering = XLFontFamilyNumberingValues.Script; //Tipo de letra
                }                

                worksheet.Cell(fila_fija, j + columna_inicial).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);//Centrada

                //Recuadro
                worksheet.Cell(fila_fija, j + columna_inicial).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(fila_fija, j + columna_inicial).Style.Border.InsideBorder = XLBorderStyleValues.Dotted;
                worksheet.Cell(fila_fija, j + columna_inicial).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(fila_fija, j + columna_inicial).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(fila_fija, j + columna_inicial).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(fila_fija, j + columna_inicial).Style.Border.TopBorder = XLBorderStyleValues.Thin;

                worksheet.Cell(fila_fija, j + columna_inicial).DataType = XLDataType.Text;
            }
        }

        private static void celdas(int fila_inicial, int columna_inicial, DataGridView dgv_grilla, IXLWorksheet worksheet)
        {
            //Valores de la celdas
            for (int i = 1; i < dgv_grilla.Rows.Count; i++)
            {
                for (int j = 1; j < dgv_grilla.Columns.Count; j++)
                {
                    string valor = "";
                    if (dgv_grilla[j, i].Value != null)
                    {
                        valor = "'" + dgv_grilla[j, i].Value.ToString();
                    }

                    worksheet.Cell(i + fila_inicial, j + columna_inicial).Value = valor;

                    worksheet.Cell(i + fila_inicial, j + columna_inicial).Style.Font.FontFamilyNumbering = XLFontFamilyNumberingValues.Script; //Tipo de letra
                    worksheet.Cell(i + fila_inicial, j + columna_inicial).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center); //Centrado

                    // Borde cuadrado
                    worksheet.Cell(i + fila_inicial, j + columna_inicial).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(i + fila_inicial, j + columna_inicial).Style.Border.InsideBorder = XLBorderStyleValues.Dotted;
                    worksheet.Cell(i + fila_inicial, j + columna_inicial).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(i + fila_inicial, j + columna_inicial).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(i + fila_inicial, j + columna_inicial).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(i + fila_inicial, j + columna_inicial).Style.Border.TopBorder = XLBorderStyleValues.Thin;

                    worksheet.Cell(i + fila_inicial, j + columna_inicial).DataType = XLDataType.Text;

                }
            }

        }

        private static void vertical(int fila_inicial, string columna_fija, DataGridView dgv_grilla, IXLWorksheet worksheet)
        {
            //Nombre de las decisiones
            for (int i = 0; i < dgv_grilla.Rows.Count; i++)
            {
                string nombre_decision = "";
                if (dgv_grilla[0, i].Value != null)
                {
                    nombre_decision = dgv_grilla[0, i].Value.ToString();
                }

                worksheet.Cell(columna_fija + (i + fila_inicial)).Value = nombre_decision;

                if (nombre_decision != "")
                {
                    worksheet.Cell(columna_fija + (i + fila_inicial)).Style.Font.Bold = true; //Letra negrita
                    worksheet.Cell(columna_fija + (i + fila_inicial)).Style.Font.FontFamilyNumbering = XLFontFamilyNumberingValues.Script; //Tipo de letra

                    worksheet.Cell(columna_fija + (i + fila_inicial)).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center); //Centrado

                    //Borde cuadrado
                    worksheet.Cell(columna_fija + (i + fila_inicial)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(columna_fija + (i + fila_inicial)).Style.Border.InsideBorder = XLBorderStyleValues.Dotted;
                    worksheet.Cell(columna_fija + (i + fila_inicial)).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(columna_fija + (i + fila_inicial)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(columna_fija + (i + fila_inicial)).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(columna_fija + (i + fila_inicial)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                }

                worksheet.Cell(columna_fija + (i + fila_inicial)).DataType = XLDataType.Text;
            }
        }

        private static void cabecera(int fila_fija, int columna_inicial, DataGridView dgv_grilla, IXLWorksheet worksheet)
        {
            //Nombre de las columnas de la tabla
            for (int j = 0; j < dgv_grilla.Columns.Count; j++)
            {
                string nombre_columna = dgv_grilla.Columns[j].HeaderText;

                worksheet.Cell(fila_fija, j + columna_inicial).Value = nombre_columna;


                if (nombre_columna != "")
                {
                    worksheet.Cell(fila_fija, j + columna_inicial).Style.Fill.BackgroundColor = XLColor.FromTheme(XLThemeColor.Accent1, 0.5); //Color de relleno
                    worksheet.Cell(fila_fija, j + columna_inicial).Style.Font.Italic = true; //Cursiva
                    worksheet.Cell(fila_fija, j + columna_inicial).Style.Font.FontFamilyNumbering = XLFontFamilyNumberingValues.Script; //Tipo de letra

                    worksheet.Cell(fila_fija, j + columna_inicial).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center); //Centrado

                    //Borde cuadrado
                    worksheet.Cell(fila_fija, j + columna_inicial).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(fila_fija, j + columna_inicial).Style.Border.InsideBorder = XLBorderStyleValues.Dotted;
                    worksheet.Cell(fila_fija, j + columna_inicial).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(fila_fija, j + columna_inicial).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(fila_fija, j + columna_inicial).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(fila_fija, j + columna_inicial).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                }

                worksheet.Cell(fila_fija, j + columna_inicial).DataType = XLDataType.Text;
            }

        }
    }
}
