using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestCreator.Estructura
{
    public partial class OrdenRegistros : Form
    {
        private Point oNewPoint = new Point();
        private int XP { get; set; }
        private int YP { get; set; }
        public IContract Contrato { get; set; }
        public OrdenRegistros()
        {
            InitializeComponent();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (radioButtonAzar.Checked)
            {
                Contrato.Orden(radioButtonAzar.Text);
            }
            if (radioButtonAscendente.Checked)
            {
                Contrato.Orden(radioButtonAscendente.Text);
            }
            if (radioButtonDescendente.Checked)
            {
                Contrato.Orden(radioButtonDescendente.Text);
            }
            if (radioButtonOrdenOriginal.Checked)
            {
                Contrato.Orden(radioButtonOrdenOriginal.Text);
            }


            Hide();
        }

        private void OrdenRegistros_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                oNewPoint = MousePosition;
                oNewPoint.X -= XP;
                oNewPoint.Y -= YP;
                Location = oNewPoint;
            }
        }

        private void OrdenRegistros_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                XP = MousePosition.X - Location.X;
                YP = MousePosition.Y - Location.Y;
            }
        }

        private void LabelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                XP = MousePosition.X - Location.X;
                YP = MousePosition.Y - Location.Y;
            }
        }

        private void LabelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                oNewPoint = MousePosition;
                oNewPoint.X -= XP;
                oNewPoint.Y -= YP;
                Location = oNewPoint;
            }
        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
