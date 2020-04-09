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
    public partial class Main : Form
    {
        private Estructura.Formulario formularioEstructura = new Estructura.Formulario();
        private Cantidad.Formulario formularioCantidad = new Cantidad.Formulario();
        private Numeracion.Formulario formularioNumeracion = new Numeracion.Formulario();
        private Solucion.Formulario formularioSolucion = new Solucion.Formulario();
        private Examen.Formulario formularioExamen = new Examen.Formulario();

        public Main()
        {
            InitializeComponent();
        }
        private void MostrarFormulario(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.Parent = container.Panel2;
            formulario.Show();
            formulario.BringToFront();
        }

        private void buttonEstructura_Click(object sender, EventArgs e)
        {
            MostrarFormulario(formularioEstructura);
        }

        private void buttonCantidad_Click(object sender, EventArgs e)
        {
            MostrarFormulario(formularioCantidad);
        }

        private void buttonNumeracion_Click(object sender, EventArgs e)
        {
            MostrarFormulario(formularioNumeracion);
        }

        private void buttonSolucion_Click(object sender, EventArgs e)
        {
            MostrarFormulario(formularioSolucion);
        }

        private void buttonExamen_Click(object sender, EventArgs e)
        {
            MostrarFormulario(formularioExamen);
        }
    }
}
