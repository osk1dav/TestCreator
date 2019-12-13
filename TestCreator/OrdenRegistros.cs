using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCreator
{
    public partial class OrdenRegistros : Form
    {
        private Point oNewPoint = new Point();
        private int xP { get; set; }
        private int yP { get; set; }
        public IContract contrato { get; set; } 
        public OrdenRegistros()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (radioButtonAzar.Checked)
            {
                contrato.Orden(radioButtonAzar.Text);
            }
            if (radioButtonAscendente.Checked)
            {
                contrato.Orden(radioButtonAscendente.Text);
            }
            if (radioButtonDescendente.Checked)
            {
                contrato.Orden(radioButtonDescendente.Text);
            }
            if (radioButtonOrdenOriginal.Checked)
            {
                contrato.Orden(radioButtonOrdenOriginal.Text);
            }


            Hide();
        }

        private void OrdenRegistros_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                oNewPoint = MousePosition;
                oNewPoint.X -= xP;
                oNewPoint.Y -= yP;
                Location = oNewPoint;
            }
        }

        private void OrdenRegistros_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                xP = MousePosition.X - Location.X;
                yP = MousePosition.Y - Location.Y;
            }
        }

        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                xP = MousePosition.X - Location.X;
                yP = MousePosition.Y - Location.Y;
            }
        }

        private void labelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                oNewPoint = MousePosition;
                oNewPoint.X -= xP;
                oNewPoint.Y -= yP;
                Location = oNewPoint;
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
