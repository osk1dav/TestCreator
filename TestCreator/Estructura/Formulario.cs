using System;
using System.Collections.Generic;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TestCreator.Properties.Resources;
using TestCreator.Utils;
using TestCreator.Clases;


namespace TestCreator.Estructura
{
    public partial class Formulario : Form
    {
        private CultureInfo CultureInfo { get; set; } = new CultureInfo("es-EC");
        private TiposNivel TipoNiveles { get; set; }
        private List<string> ListadoDeRutas { get; set; } = new List<string>();
        private string RutaBancoPreguntas { get; set; }
        private BloqueCuestionario BloqueCuestionario { get; set; } = new BloqueCuestionario();
        private List<BloqueCuestionario> ListaBloqueCuestionario { get; set; } = new List<BloqueCuestionario>();

        public Formulario()
        {
            InitializeComponent();
        }
        private void LimpiarListboxsYDatagridviews()
        {
            listClasificacion.Items.Clear();
            listElegir.Items.Clear();
            listNiveles.Items.Clear();
            listExcluir.Items.Clear();
            dataEstructura.Rows.Clear();
        }

        private void PictureLimpiarRuta_Click(object sender, EventArgs e)
        {
            comboRuta.Items.Clear();
            comboRuta.ResetText();
            ListadoDeRutas.Clear();
            LimpiarListboxsYDatagridviews();
        }

        private void PictureLimpiarRuta_MouseDown(object sender, MouseEventArgs e)
        {
            pictureLimpiarRuta.Image = icons8_eliminar_columna_500;
        }

        private void PictureLimpiarRuta_MouseUp(object sender, MouseEventArgs e)
        {
            pictureLimpiarRuta.Image = icons8_eliminar_columna_500_cian;
        }

        private void ButtonAbrirBancoPreguntas_Click(object sender, EventArgs e)
        {
            LimpiarListboxsYDatagridviews();
            RutaOFD.Titulo = "Abrir banco de preguntas";
            var ofdAbrirBancoPreguntas = RutaOFD.RutaOpenFileDialog();
            if (ofdAbrirBancoPreguntas.ShowDialog() == DialogResult.OK)
            {
                comboRuta.Items.Clear();
                ListadoDeRutas.Add(ofdAbrirBancoPreguntas.FileName);
                foreach (var item in ListadoDeRutas.Distinct())
                {
                    comboRuta.Items.Add(item);
                }
                comboRuta.Text = ofdAbrirBancoPreguntas.FileName;
            }
            RutaBancoPreguntas = comboRuta.Text;
        }

        private void ComboRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            RutaBancoPreguntas = comboRuta.Text;
            LimpiarListboxsYDatagridviews();
            CargaDeDatos.CargarContenidoListboxs(RutaBancoPreguntas);
            ListaBloqueCuestionario = CargaDeDatos.ListaBloqueCuestionario;
            TipoNiveles = CargaDeDatos.TipoNiveles;
            EstablecerListClasificacion();
        }

        private void EstablecerListClasificacion()
        {
            var listaClasificacion = new List<string>();
            listaClasificacion = ListaBloqueCuestionario.SelectMany(bloque => bloque.Clase.Keys.Select(clase => clase)).ToList();
            foreach (var item in listaClasificacion.Distinct())
            {
                listClasificacion.Items.Add(item);
            }
        }

        private void ButtonClasificacionItemElegirTodo_Click(object sender, EventArgs e)
        {
            ClasificacionDatos.MetodoClasificacionTodo(listClasificacion, listElegir, listExcluir);
            ClasificacionDatos.ObtenerListadoNiveles(listNiveles, listElegir, ListaBloqueCuestionario, TipoNiveles);
        }

        private void ButtonClasificacionItemElegir_Click(object sender, EventArgs e)
        {
            ClasificacionDatos.MetodoClasificacion(listClasificacion, listElegir, listExcluir);
            ClasificacionDatos.ObtenerListadoNiveles(listNiveles, listElegir, ListaBloqueCuestionario, TipoNiveles);
        }

        private void ButtonClasificacionItemQuitar_Click(object sender, EventArgs e)
        {
            ClasificacionDatos.MetodoClasificacion(listElegir, listClasificacion, listExcluir);
            ClasificacionDatos.ObtenerListadoNiveles(listNiveles, listElegir, ListaBloqueCuestionario, TipoNiveles);
        }

        private void ButtonClasificacionItemQuitarTodo_Click(object sender, EventArgs e)
        {
            ClasificacionDatos.MetodoClasificacionTodo(listElegir, listClasificacion, listExcluir);
            ClasificacionDatos.ObtenerListadoNiveles(listNiveles, listElegir, ListaBloqueCuestionario, TipoNiveles);
        }
    }
}
