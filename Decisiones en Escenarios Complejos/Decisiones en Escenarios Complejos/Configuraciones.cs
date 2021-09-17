using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisiones_en_Escenarios_Complejos
{
    public partial class Configuraciones : Form
    {
        public Configuraciones()
        {
            InitializeComponent();

            txt_cantidad_decimales.Text = Configuracion.getCantidadDecimales().ToString();
        }

        private void Configuraciones_Load(object sender, EventArgs e)
        {

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            Configuracion.setCantidadDecimales(Convert.ToInt16(txt_cantidad_decimales.Text));

            this.Close();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
