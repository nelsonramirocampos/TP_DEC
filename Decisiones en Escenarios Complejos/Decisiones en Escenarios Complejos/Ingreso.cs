using CsvHelper;
using CsvHelper.Configuration;
using Decisiones_en_Escenarios_Complejos.Importador;
using Decisiones_en_Escenarios_Complejos.Topsis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisiones_en_Escenarios_Complejos
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            cb_tipo_criterio.Items.Add(Constantes.CRITERIO_MAX);
            cb_tipo_criterio.Items.Add(Constantes.CRITERIO_MIN);
            cb_tipo_criterio.SelectedIndex = 0;

            cb_metodo.Items.Add(Constantes.METODO_TOPSIS);
            cb_metodo.SelectedIndex = 0;

            dgv_matriz.Columns.Add("", "");
            dgv_matriz.Rows.Add();
            dgv_matriz.Rows[0].Visible = false;
            dgv_matriz.Rows[0].ReadOnly = true;
            dgv_matriz.Columns[0].ReadOnly = true;

            dgv_pesos.Columns.Add("", "");
            dgv_pesos.Rows.Add("Peso");
            dgv_pesos.Rows[0].Visible = true;
            dgv_pesos.Rows[0].Cells[0].ReadOnly = true;



            Estilo.estilo_matriz(dgv_matriz);
            Estilo.estilo_matriz_peso(dgv_pesos);
        }

        private void Btn_agregar_alternativa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nombre_alternativa.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la alternativa");
                return;
            }

            string nombre_alternativa = txt_nombre_alternativa.Text;

            dgv_matriz.Rows[0].Visible = true;
            dgv_matriz.Rows.Add(nombre_alternativa);


            txt_nombre_alternativa.Text = string.Empty;
            txt_nombre_alternativa.Focus();
        }

        private void Btn_agregar_criterio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nombre_criterio.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del criterio");
                return;
            }

            string nombre_criterio = txt_nombre_criterio.Text;
            string tipo_criterio = cb_tipo_criterio.Text;

            dgv_matriz.Columns.Add("cCriterio" + dgv_matriz.Columns.Count, tipo_criterio);
            dgv_matriz.Rows[0].Cells[dgv_matriz.Columns.Count - 1].Value = nombre_criterio;

            dgv_pesos.Columns.Add("cCriterio" + dgv_pesos, nombre_criterio);

            txt_nombre_criterio.Text = string.Empty;
            txt_nombre_criterio.Focus();
        }

        private void Btn_continuar_metodo_Click(object sender, EventArgs e)
        {
            if (dgv_matriz.Rows.Count <= 2 || dgv_matriz.Columns.Count <= 2)
            {
                MessageBox.Show("Se deben ingresar como mínimo 2 o mas Alternativas y/o Criterios");
                return;
            }

            if (validarNumeros(dgv_matriz) == false)
            {
                MessageBox.Show("Los valos de criterio deben ser numericos", "Mensaje Error");
                return;
            }

            if (validarNumerosPesos(dgv_pesos) == false)
            {
                MessageBox.Show("Los pesos deben ser numericos", "Mensaje Error");
                return;
            }


            this.Visible = false;

            if (cb_metodo.Text == Constantes.METODO_TOPSIS)
            {
                frm_topsis t = new frm_topsis(this, dgv_matriz, dgv_pesos);
                t.Show();
            }
        }

        private bool validarNumerosPesos(DataGridView grilla)
        {
            Regex pattern = new Regex(@"^[1-9]\d*(\,\d+)?$"); //Numeros y Numeros con coma


            for (int columna = 1; columna < grilla.Columns.Count; columna++)
                {
                    //if (pattern.IsMatch(grilla[columna, 0].Value.ToString()) == false)
                    //{
                    //    return false;
                    //}
                }
            

            return true;
        }

        private bool validarNumeros(DataGridView grilla)
        {
            Regex pattern = new Regex(@"^[1-9]\d*(\,\d+)?$"); //Numeros y Numeros con coma


            for (int fila = 2; fila < grilla.Rows.Count; fila++)
            {
                for (int columna = 1; columna < grilla.Columns.Count; columna++)
                {
                    //if (pattern.IsMatch(grilla[columna, fila].Value.ToString()) == false)
                    //{
                    //    return false;
                    //}                 
                }
            }

            return true;
        }

        private void ConfiguraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Configuraciones()).ShowDialog();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            dgv_matriz.Rows.Clear();
            dgv_matriz.Columns.Clear();

            dgv_pesos.Rows.Clear();
            dgv_pesos.Columns.Clear();

            dgv_matriz.Columns.Add("", "");
            dgv_matriz.Rows.Add();
            dgv_matriz.Rows[0].Visible = false;
            dgv_matriz.Rows[0].ReadOnly = true;
            dgv_matriz.Columns[0].ReadOnly = true;


            dgv_pesos.Columns.Add("", "");
            dgv_pesos.Rows.Add("Peso");
            dgv_pesos.Rows[0].Visible = true;
            dgv_pesos.Rows[0].Cells[0].ReadOnly = true;


            Estilo.estilo_matriz(dgv_matriz);
            Estilo.estilo_matriz_peso(dgv_pesos);
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AcercaDe()).ShowDialog();
        }

        private void Txt_nombre_alternativa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
            {
                if (string.IsNullOrWhiteSpace(txt_nombre_alternativa.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre de la alternativa");
                    return;
                }

                string nombre_alternativa = txt_nombre_alternativa.Text;

                dgv_matriz.Rows[0].Visible = true;
                dgv_matriz.Rows.Add(nombre_alternativa);


                txt_nombre_alternativa.Text = string.Empty;
                txt_nombre_alternativa.Focus();

            }
        }

        private void Txt_nombre_criterio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrWhiteSpace(txt_nombre_criterio.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre del criterio");
                    return;
                }

                string nombre_criterio = txt_nombre_criterio.Text;
                string tipo_criterio = cb_tipo_criterio.Text;

                dgv_matriz.Columns.Add("cCriterio" + dgv_matriz.Columns.Count, tipo_criterio);
                dgv_matriz.Rows[0].Cells[dgv_matriz.Columns.Count - 1].Value = nombre_criterio;

                dgv_pesos.Columns.Add("cCriterio" + dgv_pesos, nombre_criterio);

                txt_nombre_criterio.Text = string.Empty;
                txt_nombre_criterio.Focus();
            }
        }

        
        private void cargarEjemplo()
        {
            

            //Columna de las alternativas
            List<string> alternativa = new List<string>() { "", "A1", "A2", "A3", "A4", "A5", "A6" };
            for (int fila = 0; fila < alternativa.Count; fila++)
            {
                dgv_matriz.Rows.Add(alternativa[fila].ToString());
            }


            List<List<string>> criterio = new List<List<string>>() {
                new List<string>() {"MIN", "MAX", "MAX", "MAX", "MAX", "MAX" },
                new List<string>() { "X1", "X2", "X3", "X4", "X5", "X6" }
            };

            //Columna con MAX/MIN
            for (int columna = 0; columna < criterio[0].Count; columna++)
            {
                dgv_matriz.Columns.Add("C" + columna, criterio[0][columna].ToString());
            }

            //Fila con los Criterios
            for (int columna = 0; columna < criterio[1].Count; columna++)
            {
                dgv_matriz[columna + 1, 1].Value = criterio[1][columna].ToString();
            }

            //Columna con las alternativas en pesos
            for (int columna = 0; columna < criterio[0].Count; columna++)
            {
                dgv_pesos.Columns.Add("Cpeso" + columna, criterio[1][columna].ToString());
            }


            //Pesos
            List<double> W = new List<double>() {
                0.17051, 0.17512, 0.15668, 0.16590, 0.15668, 0.17512
            };
            for (int columna = 0; columna < W.Count; columna++)
            {
                dgv_pesos[columna + 1, 0].Value = W[columna].ToString();
            }



            //Valores de la matriz
            List<List<double>> tabla = new List<List<double>>()
            {
                new List<double>() {8500, 90,  1.4, 5.2, 7,   6.2},
                new List<double>() {4750, 85,  1.3, 5.4, 6.2, 5.8},
                new List<double>() {6300, 105, 0.9, 4.2, 6.4, 5  },
                new List<double>() {4800, 95,  1.3, 6.4, 4.8, 6.6},
                new List<double>() {7200, 98,  1.6, 7,   5.6, 6.8},
                new List<double>() {9400, 93,  1.9, 8.4, 5,   7  }
            };

            for (int i = 0; i < tabla.Count; i++)
            {
                for (int j = 0; j < tabla[i].Count; j++)
                {
                    dgv_matriz[j + 1, i + 2].Value = tabla[i][j];
                }
            }


            dgv_matriz.Rows.RemoveAt(0);
        }


        private void CargarEjemploToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_pesos.Rows.Clear();
            dgv_pesos.Columns.Clear();

            dgv_matriz.Columns.Add("", "");
            dgv_matriz.Rows.Add();
            dgv_matriz.Rows[0].Visible = false;
            dgv_matriz.Rows[0].ReadOnly = true;
            dgv_matriz.Columns[0].ReadOnly = true;


            dgv_pesos.Columns.Add("", "");
            dgv_pesos.Rows.Add("Peso");
            dgv_pesos.Rows[0].Visible = true;
            dgv_pesos.Rows[0].Cells[0].ReadOnly = true;


            Estilo.estilo_matriz(dgv_matriz);
            Estilo.estilo_matriz_peso(dgv_pesos);


            cargarEjemplo();
        }

        private void ImportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool criterio = true;
            bool alternativa = true;

            Gestor_Importador gestor = new Gestor_Importador();


            var reader = new StreamReader(File.OpenRead(@"D:\Ejemplo.csv"));

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var value = line.Split(';');

                if (criterio) //Si es un criterio, tiene dos valores TIPO y NOMBRE
                {
                    var tipo_criterio = line.Split(';');

                    line = reader.ReadLine();
                    var nombre_criterio = line.Split(';');

                    for (int i = 0; i < tipo_criterio.Length; i++)
                    {
                        gestor.agregarCriterio(nombre_criterio[i].ToString().ToUpper(), tipo_criterio[i].ToString().ToUpper());
                    }

                    criterio = false; //Ya se termino de leer los criterios
                }
                else if (value[0].ToString().Trim().ToUpper().Equals("W"))
                {
                    for (int i = 1; i < value.Length; i++)
                    {
                        double peso;

                        if (Double.TryParse(Convert.ToString(value[i]).Trim(), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out peso))
                        {
                            gestor.agregarPeso(peso);
                        }
                    }
                }
                else if(alternativa) //Para las demas filas ALTERNATIVA + Valor
                {
                    var nombre_alternativas = line.Split(';');
                    string nombre_alt = "";
                    List<double> valores = new List<double>();

                    foreach (var v in nombre_alternativas)
                    {
                        double retNum;

                        if (Double.TryParse(Convert.ToString(v).Trim(), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum)) 
                        {
                            valores.Add(retNum);
                        }
                        else
                        {
                            nombre_alt = v.ToString().Trim().ToUpper();
                        }
                    }

                    gestor.agregarAlternativa(nombre_alt, valores);
                }
            }

            gestor.cargar_import(dgv_matriz, dgv_pesos);


        }

        private void Dgv_matriz_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar) || e.KeyChar == ',')
                    e.Handled = false;
                else
                    e.Handled = true;
        }

        private void Dgv_matriz_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;

            if (txt != null)

            {

                txt.KeyPress -= new KeyPressEventHandler(Dgv_matriz_KeyPress);

                txt.KeyPress += new KeyPressEventHandler(Dgv_matriz_KeyPress);

            }
        }

        private void Dgv_pesos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar) || e.KeyChar == ',')
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void Dgv_pesos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;

            if (txt != null)
            {
                txt.KeyPress -= new KeyPressEventHandler(Dgv_pesos_KeyPress);

                txt.KeyPress += new KeyPressEventHandler(Dgv_pesos_KeyPress);
            }
        }
    }
}
