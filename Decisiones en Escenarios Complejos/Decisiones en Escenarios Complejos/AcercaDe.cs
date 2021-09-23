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
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        private void AcercaDe_Load(object sender, EventArgs e)
        {
            lbl_integrantes.Text = "Integrantes:" + Environment.NewLine +
                                      "Campos, Nelson Ramiro    -   Leg.: 58816" + "    -   nelsonramirocampos@gmail.com" +Environment.NewLine +
                                      "Cruz, Karen Yanina       -   Leg.: 61539" + "    -   karenyanina.cruz@gmail.com" + Environment.NewLine +
                                      "Gricel, Garcia Piñas     -   Leg.: 50885" + "    -   gricelgarcia11@gmail.com" + Environment.NewLine +
                                      "Mazzotta, Gabriela Inés  -   Leg.: 44062" + "    -   mazzottaines@gmail.com" + Environment.NewLine +
                                      "Orellana, Héctor         -   Leg.: 44516" + "    -   orellafe@gmail.com";

            lbl_docentes.Text = "Docentes:" + Environment.NewLine +
                                  "Rustán, Silvina (Adjunto)" + Environment.NewLine +
                                  "Gualpa, Mariano Martín (JTP)";
        }
    }
}
