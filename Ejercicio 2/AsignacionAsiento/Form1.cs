using AsignacionAsiento.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignacionAsiento
{
    public partial class AsignarAsientos : Form
    {
        private const int SECCION_FUMAR = 1;
        private const int SECCION_NO_FUMAR = 2;
        private const string MENSAJE_SECCION_LLENA = "Esta sección está llena";
        private const string MENSAJE_PROXIMO_VUELO = "El próximo vuelo sale en 3 horas.";

        private NumeroAsientos avion;
        private object lblBoardingPass;

        public AsignarAsientos()
        {
            InitializeComponent();
            avion = new NumeroAsientos();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            int section = rdbSmoke.Checked ? SECCION_FUMAR : SECCION_NO_FUMAR;
            int seleccionarNum = avion.AsignarAsiento(section);

            if (seleccionarNum == -1)
            {
                seleccionarNum = ManejarSeccionLlena(ref section);
            }

            MostrarResultado(seleccionarNum, section);
        }

        private int ManejarSeccionLlena(ref int section)
        {
            string otraSeccion = (section == SECCION_FUMAR) ? "Area libre de Humo" : "Area para fumar";
            if (MessageBox.Show($"La sección está llena. ¿Le gustaría ser asignado en la sección de {otraSeccion}?",
                MENSAJE_SECCION_LLENA, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                section = (section == SECCION_FUMAR) ? SECCION_NO_FUMAR : SECCION_FUMAR;
                return avion.AsignarAsiento(section);
            }
            return -1;
        }

        private void MostrarResultado(int seleccionarNum, int section)
        {
            if (seleccionarNum != -1)
            {
                string nombreSeccion = (section == SECCION_FUMAR) ? "Area para fumar" : "Area libre de humo";
                lblBoard.Text = $"Asiento asignado: {seleccionarNum}\nSección: {nombreSeccion}";
            }
            else
            {
                lblBoard.Text = MENSAJE_PROXIMO_VUELO;
            }
        }
    }
}
