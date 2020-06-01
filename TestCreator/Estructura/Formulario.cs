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
    public partial class Formulario : Form, IContract
    {
        private CultureInfo CultureInfo { get; set; } = new CultureInfo("es-EC");
        private TiposNivel TipoNiveles { get; set; }
        private List<string> ListadoDeRutas { get; set; } = new List<string>();
        private string RutaBancoPreguntas { get; set; }
        public BloqueCuestionario BloqueCuestionario { get; set; } = new BloqueCuestionario();
        public List<BloqueCuestionario> ListaBloqueCuestionario { get; set; } = new List<BloqueCuestionario>();
        public Dictionary<string, BloqueCuestionario> DiccionarioBloqueCuestionarioEstructurado { get; set; } = new Dictionary<string, BloqueCuestionario>();
        public OrdenRegistros OrdenRegistroForm { get; set; } = new OrdenRegistros();
        private int ColumnaSeleccionada { get; set; }

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

        private void ListClasificacion_DoubleClick(object sender, EventArgs e)
        {
            ClasificacionDatos.MetodoClasificacion(listClasificacion, listElegir, listExcluir);
            ClasificacionDatos.ObtenerListadoNiveles(listNiveles, listElegir, ListaBloqueCuestionario, TipoNiveles);
        }

        private void ListElegir_DoubleClick(object sender, EventArgs e)
        {
            ClasificacionDatos.MetodoClasificacion(listElegir, listClasificacion, listExcluir);
            ClasificacionDatos.ObtenerListadoNiveles(listNiveles, listElegir, ListaBloqueCuestionario, TipoNiveles);
        }

        private void ButtonNivelesExcluir_Click(object sender, EventArgs e)
        {
            ClasificacionDatos.MetodoClasificacion(listNiveles, listExcluir);
        }

        private void ButtonNivelesIncluir_Click(object sender, EventArgs e)
        {
            ClasificacionDatos.MetodoClasificacion(listExcluir, listNiveles);
        }

        private void ListNiveles_DoubleClick(object sender, EventArgs e)
        {
            ClasificacionDatos.MetodoClasificacion(listNiveles, listExcluir);
        }

        private void ListExcluir_DoubleClick(object sender, EventArgs e)
        {
            ClasificacionDatos.MetodoClasificacion(listExcluir, listNiveles);
        }

        private void ButtonNivelesSubir_Click(object sender, EventArgs e)
        {
            ClasificacionDatos.MetodoMoverItemLista(listNiveles, -1);
        }

        private void ButtonNivelesBajar_Click(object sender, EventArgs e)
        {
            ClasificacionDatos.MetodoMoverItemLista(listNiveles, 1);
        }

        private void ButtonEstructurarPreguntasElegidas_Click(object sender, EventArgs e)
        {
            CargaDeDatos.CargarContenidoDatagridview(dataEstructura, listNiveles);
            DiccionarioBloqueCuestionarioEstructurado = CargaDeDatos.DiccionarioBloqueCuestionarioEstructurado;
            TotalesCabaceraDatagridview();
        }

        private void TotalesCabaceraDatagridview()
        {
            int totalPreguntas = 0;
            int totalElegidas = 0;
            for (int i = 0; i < dataEstructura.Rows.Count; i++)
            {
                totalPreguntas += Convert.ToInt32(dataEstructura.Rows[i].Cells[2].Value, CultureInfo);
                totalElegidas += Convert.ToInt32(dataEstructura.Rows[i].Cells[3].Value, CultureInfo);
            }
            dataEstructura.Columns[2].HeaderText = $"Total ({totalPreguntas.ToString(CultureInfo)})";
            dataEstructura.Columns[3].HeaderText = $"Elegir ({totalElegidas.ToString(CultureInfo)})";
        }

        private void FormularioOrdenRegistro(int columna, DataGridView dataGridView, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView.Rows.Count > 0 && e.ColumnIndex == columna)
            {
                int ix = Left + dataGridView.GetCellDisplayRectangle(columna, dataGridView.CurrentRow.Index, false).Right + dataGridView.Location.X + 19;
                int iy = Top + dataGridView.GetCellDisplayRectangle(columna, dataGridView.CurrentRow.Index, false).Top + +dataGridView.Location.Y;
                OrdenRegistroForm.Contrato = this;
                OrdenRegistroForm.Show();
                OrdenRegistroForm.Location = new Point(ix, iy);
            }

        }

        public void Orden(string texto)
        {
            for (int i = 0; i < dataEstructura.Rows.Count; i++)
            {
                dataEstructura.Rows[i].Cells[ColumnaSeleccionada].Value = texto;
            }
        }

        private void DataEstructura_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ColumnaSeleccionada = e.ColumnIndex;
                dataEstructura.EndEdit();
                FormularioOrdenRegistro(4, dataEstructura, e);
                FormularioOrdenRegistro(5, dataEstructura, e);

            }
        }

        private void DataEstructura_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ColumnaSeleccionada = e.ColumnIndex;
            dataEstructura.EndEdit();
            FormularioOrdenRegistro(4, dataEstructura, e);
            FormularioOrdenRegistro(5, dataEstructura, e);
        }

        private void DataEstructura_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(dataEstructura.CurrentRow.Cells[3].Value.ToString(), CultureInfo) > Convert.ToInt32(dataEstructura.CurrentRow.Cells[2].Value.ToString(), CultureInfo))
            {
                Mensajes.ValorElegidoMasAltoQueElTotal();
                dataEstructura.CurrentRow.Cells[3].Value = dataEstructura.CurrentRow.Cells[2].Value;
            }
            TotalesCabaceraDatagridview();
        }

        private void DataEstructura_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataEstructura.CurrentCell.ColumnIndex == 3)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(DataEstructura_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(DataEstructura_KeyPress);
                }
            }
        }

        private void DataEstructura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataEstructura.CurrentCell.ColumnIndex == 3)
            {
                if (e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}
