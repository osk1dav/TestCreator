using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCreator.Utils
{
    public static class FormatoNumeracion
    {
        public static void NumeracionResultante(TextBox textAntes, ComboBox comboTipoNumeracion, TextBox textDespues, Label labelResultante)
        {
            if (textAntes != null && comboTipoNumeracion != null && textDespues != null && labelResultante != null)
            {
                if (comboTipoNumeracion.Text == "Ninguna")
                {
                    labelResultante.Text = "";
                    textAntes.Enabled = false;
                    textDespues.Enabled = false;
                }
                else
                {
                    labelResultante.Text = textAntes.Text + comboTipoNumeracion.Text + textDespues.Text;
                    textAntes.Enabled = true;
                    textDespues.Enabled = true;
                }
            }
        }
    }
}
