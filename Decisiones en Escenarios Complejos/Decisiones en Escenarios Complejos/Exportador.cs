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
                        mensaje("F2", "Matriz Original con distancia S+ y S-", worksheet);


                        /* ******* GRILLA PESO ******* */
                        int fila_peso = dgv_grilla.Rows.Count + 10;
                        cabecera(fila_peso - 1, 5, dgv_pesos, worksheet);
                        criterios(fila_peso, 5, false, dgv_pesos, worksheet); //Primera fila
                        vertical(fila_peso, "E", dgv_pesos, worksheet);
                        mensaje("F" + (fila_peso - 3), "Matriz Pesos Normalizados", worksheet);


                        /* ******* GRILLA RESULTADO ******* */
                        int columna_resultado = dgv_grilla.Rows.Count + 9;
                        cabecera(5, columna_resultado, dgv_resultado, worksheet);
                        criterios(6, columna_resultado, false, dgv_resultado, worksheet);
                        vertical(6,  letra_columna(columna_resultado), dgv_resultado, worksheet);
                        celdas(6, columna_resultado, dgv_resultado, worksheet);
                        mensaje(letra_columna(columna_resultado) + "3", "Matriz Resultado", worksheet);

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


        private static string letra_columna(int nro_columna)
        {
            string letra;
            switch (nro_columna)
            {
                case 1:
                    letra = "A";
                    break;

                case 2:
                    letra = "B";
                    break;

                case 3:
                    letra = "C";
                    break;
                case 4:
                    letra = "D";
                    break;
                case 5:
                    letra = "E";
                    break;
                case 6:
                    letra = "F";
                    break;
                case 7:
                    letra = "G";
                    break;
                case 8:
                    letra = "H";
                    break;
                case 9:
                    letra = "I";
                    break;
                case 10:
                    letra = "J";
                    break;
                case 11:
                    letra = "K";
                    break;
                case 12:
                    letra = "L";
                    break;

                case 13:
                    letra = "M";
                    break;

                case 14:
                    letra = "N";
                    break;


                case 15:
                    letra = "O";
                    break;


                case 16:
                    letra = "P";
                    break;


                case 17:
                    letra = "Q";
                    break;

                case 18:
                    letra = "R";
                    break;

                case 19:
                    letra = "S";
                    break;

                case 20:
                    letra = "T";
                    break;

                case 21:
                    letra = "U";
                    break;

                case 22:
                    letra = "V";
                    break;

                case 23:
                    letra = "W";
                    break;

                case 24:
                    letra = "X";
                    break;

                case 25:
                    letra = "Y";
                    break;

                case 26:
                    letra = "Z";
                    break;
                default:
                    letra = "AA";
                    break;
            }

            return letra;
        }
    }
}
