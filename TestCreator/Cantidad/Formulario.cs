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

namespace TestCreator.Cantidad
{
    public partial class Formulario : Form
    {
        private readonly BotonSiNo identificarExamenesIDE = new BotonSiNo();
        public Formulario()
        {
            InitializeComponent();
        }

        private void numericExamenesCDE_ValueChanged(object sender, EventArgs e)
        {
            CalculoTotalCuestionarios();
            PosicionCantidadExamenes();
        }
        private void numericCopiasCDE_ValueChanged(object sender, EventArgs e)
        {
            CalculoTotalCuestionarios();
        }
        private void CalculoTotalCuestionarios()
        {
            int totalExamanesCopias = (int)numericExamenesCDE.Value * (int)numericCopiasCDE.Value;
            labelTotalExamanesCopiasCDE.Text = $"Total de exámenes ({numericExamenesCDE.Value}) y copias ({numericCopiasCDE.Value}) = {totalExamanesCopias}";
        }

        private void PosicionCantidadExamenes()
        {
            if (numericExamenesCDE.Value > 1)
            {
                radioCualquierPreguntaCDE.Visible = true;
                radioNuevasPreguntasCDE.Visible = true;
                groupCopiasCDE.Location = new Point(23, 95);
            }
            else
            {
                radioCualquierPreguntaCDE.Visible = false;
                radioNuevasPreguntasCDE.Visible = false;
                groupCopiasCDE.Location = new Point(23, 49);
            }
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            CalculoTotalCuestionarios();
            PosicionCantidadExamenes();
        }

        private void PictureboxIdentificarExamenesIDE_MouseDown(object sender, MouseEventArgs e)
        {
            identificarExamenesIDE.Interruptor(pictureboxIdentificarExamenesIDE);
        }
    }
}
