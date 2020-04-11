using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TestCreator.Properties.Resources;

namespace TestCreator.Examen
{
    public partial class Formulario : Form
    {
        private List<string> listadoDeRutas = new List<string>();

        public Formulario()
        {
            InitializeComponent();
        }

        private void PictureLimpiarRuta_Click(object sender, EventArgs e)
        {
            comboRuta.Items.Clear();
            comboRuta.ResetText();
            listadoDeRutas.Clear();
        }

        private void PictureLimpiarRuta_MouseDown(object sender, MouseEventArgs e)
        {
            pictureLimpiarRuta.Image = icons8_eliminar_columna_500;
        }

        private void PictureLimpiarRuta_MouseUp(object sender, MouseEventArgs e)
        {
            pictureLimpiarRuta.Image = icons8_eliminar_columna_500_cian;
        }
    }
}
