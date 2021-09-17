using Decisiones_en_Escenarios_Complejos.Topsis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                    if (pattern.IsMatch(grilla[columna, 0].Value.ToString()) == false)
                    {
                        return false;
                    }
                }
            

            return true;
        }

        private bool validarNumeros(DataGridView grilla)
        {
            Regex pattern = new Regex(@"^[1-9]\d*(\,\d+)?$"); //Numeros y Numeros con coma


            for (int fila = 1; fila < grilla.Rows.Count; fila++)
            {
                for (int columna = 1; columna < grilla.Columns.Count; columna++)
                {
                    if (pattern.IsMatch(grilla[columna, fila].Value.ToString()) == false)
                    {
                        return false;
                    }                 
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

        private void Dgv_matriz_KeyDown(object sender, KeyEventArgs e)
        {
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
    }
}
