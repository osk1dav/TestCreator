using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCreator.Utils;

namespace TestCreator.Numeracion
{
    public partial class Formulario : Form
    {
        private readonly BotonSiNo mantenerOriginalNumeracionNDP = new BotonSiNo();
        private readonly BotonSiNo mantenerOriginalEspaciadoNDP = new BotonSiNo();
        private readonly BotonSiNo mantenerOriginalNumeracionNDO = new BotonSiNo();
        private readonly BotonSiNo mantenerOriginalColumnasNDO = new BotonSiNo();
        private readonly BotonSiNo mantenerOriginalEspaciadoNDO = new BotonSiNo();

        public Formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            comboNumeroNumeracionNDP.SelectedIndex = 0;
            comboNumeroNumeracionNDO.SelectedIndex = 4;
            comboInterlineadoEspaciadoNDO.SelectedIndex = 0;
            comboInterlineadoEspaciadoNDP.SelectedIndex = 0;
        }

        private void PictureMantenerOriginalNumeracionNDP_MouseDown(object sender, MouseEventArgs e)
        {
            mantenerOriginalNumeracionNDP.Interruptor(pictureMantenerOriginalNumeracionNDP);
        }

        private void PictureMantenerOriginalEspaciadoNDP_MouseDown(object sender, MouseEventArgs e)
        {
            mantenerOriginalEspaciadoNDP.Interruptor(pictureMantenerOriginalEspaciadoNDP);
        }

        private void PictureMantenerOriginalNumeracionNDO_MouseDown(object sender, MouseEventArgs e)
        {
            mantenerOriginalNumeracionNDO.Interruptor(pictureMantenerOriginalNumeracionNDO);
        }

        private void PictureMantenerOriginalColumnasNDO_MouseDown(object sender, MouseEventArgs e)
        {
            mantenerOriginalColumnasNDO.Interruptor(pictureMantenerOriginalColumnasNDO);
        }

        private void PictureMantenerOriginalEspaciadoNDO_MouseDown(object sender, MouseEventArgs e)
        {
            mantenerOriginalEspaciadoNDO.Interruptor(pictureMantenerOriginalEspaciadoNDO);
        }
    }
}
