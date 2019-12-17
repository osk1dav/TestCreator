using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using TestCreator.Clases;
using TestCreator.Utilitarios;
using static TestCreator.Properties.Resources;

namespace TestCreator
{
    public partial class FormPrincipal : Form, IContract
    {
        private CultureInfo cultureInfo = new CultureInfo("es-EC");
        private TiposNivel TipoNiveles { get; set; }
        public OrdenRegistros OrdenRegistroForm { get; set; } = new OrdenRegistros();
        private BloqueCuestionario bloqueCuestionario = new BloqueCuestionario();
        private Interruptores interruptor = new Interruptores();

        private string rutaBancoPreguntas = "";
        private int columnaSeleccionada { get; set; }
        private List<string> listaRutaBancoDePreguntas = new List<string>();
        private List<string> listaPlantillaExamen = new List<string>();

        private List<BloqueCuestionario> listaBloqueCuestionario = new List<BloqueCuestionario>();

        public FormPrincipal()
        {
            InitializeComponent();
            InicializarInterruptores();
            InicializarComboBoxs();
            InicializarToolTips();
        }

        #region Parametros

        private void InicializarToolTips()
        {
            using (ToolTip toolTipMenuEmergente = new ToolTip())
            {
                toolTipMenuEmergente.SetToolTip(pictureBoxMenuEmergente, Mensajes.LimpiarBusqueda);
                toolTipMenuEmergente.SetToolTip(pictureBoxMenuEmergentePlantilla, Mensajes.LimpiarBusqueda);
            }
        }

        private void InicializarInterruptores()
        {
            pictureBoxMantenerOriginalEspaciadoPreguntas.Image = interruptor.boolMantenerOriginalEspaciadoPreguntas ? interruptor.botonSiConTexto : interruptor.botonNoConTexto;
            pictureBoxImprimirComentariosPresentacionSolucion.Image = interruptor.boolImprimirComentariosPresentacionSolucion ? interruptor.botonSiConTexto : interruptor.botonNoConTexto;
            pictureBoxMantenerOriginalColumnasRespuestas.Image = interruptor.boolMantenerOriginalColumnasRespuestas ? interruptor.botonSiConTexto : interruptor.botonNoConTexto;
            pictureBoxMantenerOriginalEspaciadoRespuestas.Image = interruptor.boolMantenerOriginalEspaciadoRespuestas ? interruptor.botonSiConTexto : interruptor.botonNoConTexto;
            pictureBoxMantenerOriginalNumeracionRespuestas.Image = interruptor.boolMantenerOriginalNumeracionRespuestas ? interruptor.botonSiConTexto : interruptor.botonNoConTexto;
            pictureBoxMantenerOriginalNumeracionPreguntas.Image = interruptor.boolMantenerOriginalNumeracionPreguntas ? interruptor.botonSiConTexto : interruptor.botonNoConTexto;
            pictureBoxIdentificarExamenes.Image = interruptor.boolIdentificarExamenes ? interruptor.botonSiConTexto : interruptor.botonNoConTexto;
        }
        private void InicializarComboBoxs()
        {
            comboBoxNumeroNumeracionPreguntas.SelectedIndex = 0;
            comboBoxNumeroNumeracionRespuestas.SelectedIndex = 4;
            comboBoxInterlineadoEspaciadoPreguntas.SelectedIndex = 5;
            comboBoxInterlineadoEspaciadoRespuestas.SelectedIndex = 5;
        }

        private void InicializarListBoxs()
        {
            listBoxClasificacion.Items.Clear();
            listBoxElegir.Items.Clear();
            listBoxNiveles.Items.Clear();
            listBoxExcluir.Items.Clear();
            dataGridViewEstructura.Rows.Clear();
        }

        private void InicializarLists()
        {
            bloqueCuestionario = new BloqueCuestionario();
            listaBloqueCuestionario.Clear();
        }
        #endregion

        #region Formulario Principal
        private void PictureBoxAyuda_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxAyuda.Image = icons8_ayuda_64;
        }

        private void PictureBoxAyuda_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxAyuda.Image = icons8_ayuda_64_white;
        }

        private OpenFileDialog RutaOpenFileDialog(string directorioInicial, string titulo)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = directorioInicial;
                ofd.RestoreDirectory = true;
                ofd.Title = titulo;
                ofd.DefaultExt = "docx";
                ofd.Filter = Mensajes.FilterSetWord;
                ofd.FilterIndex = 1;
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;

                return ofd;
            };
        }

        #endregion

        #region Pestaña Estructura
        private void ButtonAbrirBancoPreguntas_Click(object sender, EventArgs e)
        {
            InicializarListBoxs();
            var ofdAbrirBancoPreguntas = RutaOpenFileDialog(Mensajes.RutaInicial, Mensajes.AbrirBancoPreguntas); // Configuracion inicial del ofdAbrirBancoPreguntas
            if (ofdAbrirBancoPreguntas.ShowDialog() == DialogResult.OK)
            {
                comboBoxRutaBancoPreguntas.Items.Clear(); // Reseteamos comboBoxRutaBancoPreguntas
                listaRutaBancoDePreguntas.Add(ofdAbrirBancoPreguntas.FileName); //Agregamos a List elementos seleccionados
                foreach (var item in listaRutaBancoDePreguntas.Distinct()) //Agregamos items a comboBoxRutaBancoPreguntas filtrando elementos duplicados con Distinct()
                {
                    comboBoxRutaBancoPreguntas.Items.Add(item);
                }
                comboBoxRutaBancoPreguntas.Text = ofdAbrirBancoPreguntas.FileName;
            }
            rutaBancoPreguntas = comboBoxRutaBancoPreguntas.Text;
        }

        private void comboBoxRutaBancoPreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            rutaBancoPreguntas = comboBoxRutaBancoPreguntas.Text;
            CargarContenidoListboxs();
        }

        private void ButtonGenerarExamen_Click(object sender, EventArgs e)
        {
            GenerarExamen((int)numericUpDownExamenes.Value, (int)numericUpDownCopias.Value);
        }

        private void GenerarExamen(int cantidadExamenes = 1, int cantidadCopias = 1)
        {
            string resultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString(cultureInfo) + "\\Test.docx";
            using (WordprocessingDocument document = WordprocessingDocument.Create(resultPath, WordprocessingDocumentType.Document))
            {
                var listaBloqueCuestionarioCopy = new List<BloqueCuestionario>();
                listaBloqueCuestionarioCopy = listaBloqueCuestionario;
                MainDocumentPart mainPart = document.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());
                int contadorNumberingId = 0;
                for (int i = 0; i < cantidadExamenes; i++)
                {
                    Random rnd = new Random((int)DateTime.Now.Ticks);
                    listaBloqueCuestionarioCopy.Shuffle(rnd);

                    for (int j = 0; j < cantidadCopias; j++)
                    {
                        contadorNumberingId++;
                        foreach (var item in listaBloqueCuestionarioCopy)
                        {

                            ParagraphProperties paragraphProperties = new ParagraphProperties();
                            ParagraphStyleId paragraphStyleId = new ParagraphStyleId() { Val = "ListParagraph" };
                            NumberingProperties numberingProperties = new NumberingProperties();
                            NumberingLevelReference numberingLevelReference = new NumberingLevelReference() { Val = 0 };
                            NumberingId numberingId = new NumberingId() { Val = contadorNumberingId }; //Val is 1, 2, 3 etc based on your numberingid in your numbering element
                            NumberingFormat numberingFormat = new NumberingFormat() { Val = NumberFormatValues.UpperLetter };

                            numberingProperties.Append(numberingLevelReference);
                            numberingProperties.Append(numberingFormat);
                            numberingProperties.Append(numberingId);
                            paragraphProperties.Append(paragraphStyleId);
                            paragraphProperties.Append(numberingProperties);


                            Paragraph para = body.AppendChild(new Paragraph());
                            para.Append(paragraphProperties);
                            Run run = para.AppendChild(new Run());
                            run.AppendChild(new Text(item.Pregunta.InnerText));

                        }
                        if (j < cantidadCopias - 1)
                        {
                            Paragraph para1 = body.AppendChild(new Paragraph());
                            Run run1 = para1.AppendChild(new Run());
                            run1.AppendChild(new Break() { Type = BreakValues.Page });
                        }

                    }
                }
            }
        }

        private void CargarContenidoListboxs()
        {
            InicializarListBoxs();
            InicializarLists();
            try
            {
                using (WordprocessingDocument document = WordprocessingDocument.CreateFromTemplate(rutaBancoPreguntas))
                {
                    var body = document.MainDocumentPart.Document.Body;
                    var parrafos = body.Elements<Paragraph>();
                    var listaContenidoGeneralDePreguntas = ContenidoGeneralDePreguntas(parrafos); // Get a List of Question blocks
                                                                                                  //bloqueGeneral = blocks.ConvertAll<List<OpenXmlElement>>(g => g.ConvertAll<OpenXmlElement>(p => (OpenXmlElement)p.CloneNode(true))); // Deep Clone
                    listaBloqueCuestionario = ClasificacionNivelPreguntas(listaContenidoGeneralDePreguntas);
                    OptimizarListaBloqueCuestionario();
                    GetListaClasificacion();
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Mensajes.ArchivoDeWordNoExiste();
            }
        }

        private void OptimizarListaBloqueCuestionario()
        {
            var listTempBC = new List<BloqueCuestionario>();
            foreach (var bloque in listaBloqueCuestionario)
            {
                if (bloque.Pregunta.InnerText.Trim(' ').Length > 1)
                {
                    listTempBC.Add(bloque);
                }
            }
            listaBloqueCuestionario.Clear();
            listaBloqueCuestionario = listTempBC;
        }

        private void GetListaClasificacion()
        {
            var listaClasificacion = new List<string>();
            listaClasificacion = listaBloqueCuestionario.SelectMany(bloque => bloque.Clase.Keys.Select(clase => clase)).ToList();
            foreach (var item in listaClasificacion.Distinct())
            {
                listBoxClasificacion.Items.Add(item);
            }
        }

        private List<BloqueCuestionario> ClasificacionNivelPreguntas(IEnumerable<OpenXmlElement> paragraphs)
        {
            var listaSalida = new List<BloqueCuestionario>();
            var keyClase = new List<string>();
            var valueClase = new List<string>();
            int SizeKeyClasificacion = 0;
            int SizeValueClasificacion = 0;
            paragraphs.ToList<OpenXmlElement>().ForEach(p =>
            {
                if (TipoNiveles == TiposNivel.Clases)
                {
                    if (p.InnerText.ToLower(cultureInfo).StartsWith(@"clas = [", StringComparison.CurrentCulture)) // Nueva Pregunta
                    {
                        keyClase.AddRange(p.InnerText.Remove(p.InnerText.IndexOf("]", StringComparison.CurrentCulture)).Substring(8).Split(','));
                        SizeKeyClasificacion = keyClase.Count;
                    }
                    else if (p.InnerText.ToLower(cultureInfo).StartsWith(@"clas = ", StringComparison.CurrentCulture)) // Nueva pregunta para Tipo de Clasificación
                    {
                        valueClase = new List<string>();
                        SizeValueClasificacion = 0;
                        string contenido = p.InnerText.Trim(' ').Substring(7);
                        if (contenido.Contains("%")) contenido = contenido.Remove(contenido.IndexOf("%", StringComparison.CurrentCulture));
                        valueClase.AddRange(contenido.Split(','));
                        foreach (var value in valueClase)
                        {
                            if (value.Trim(' ').Length > 0)
                            {
                                SizeValueClasificacion++;
                            }
                        }
                    }

                    if (p.InnerText.StartsWith(@"#", StringComparison.CurrentCulture))
                    {
                        if (SizeKeyClasificacion == SizeValueClasificacion)
                        {
                            if (bloqueCuestionario.Pregunta != null)
                            {
                                listaSalida.Add(bloqueCuestionario);
                            }
                            bloqueCuestionario = new BloqueCuestionario();
                            for (int i = 0; i < SizeKeyClasificacion; i++)
                            {
                                bloqueCuestionario.Clase.Add(keyClase[i].Trim(' '), valueClase[i].Trim(' '));
                            }
                            bloqueCuestionario.Pregunta = p;
                        }
                    }

                    if (p.InnerText.StartsWith(@"%%", StringComparison.CurrentCulture))
                    {
                        bloqueCuestionario.Comentario.Add(p.InnerText);
                    }

                    if (p.InnerText.StartsWith(@"&", StringComparison.CurrentCulture))
                    {
                        bloqueCuestionario.Opciones.Add(p);
                    }

                    if (p.InnerText.StartsWith(@"&&", StringComparison.CurrentCulture))
                    {
                        bloqueCuestionario.Respuestas.Add(p);
                    }
                }
                else if (TipoNiveles == TiposNivel.Preguntas)
                {
                    if (p.InnerText.StartsWith(@"#", StringComparison.CurrentCulture))
                    {
                        if (bloqueCuestionario.Pregunta != null)
                        {
                            listaSalida.Add(bloqueCuestionario);
                        }
                        bloqueCuestionario = new BloqueCuestionario();
                        bloqueCuestionario.Clase.Add(TiposNivel.Preguntas.ToString(), TiposNivel.Preguntas.ToString());
                        bloqueCuestionario.Pregunta = p;
                    }

                    if (p.InnerText.StartsWith(@"%%", StringComparison.CurrentCulture))
                    {
                        bloqueCuestionario.Comentario.Add(p.InnerText);
                    }

                    if (p.InnerText.StartsWith(@"&", StringComparison.CurrentCulture))
                    {
                        bloqueCuestionario.Opciones.Add(p);
                    }

                    if (p.InnerText.StartsWith(@"&&", StringComparison.CurrentCulture))
                    {
                        bloqueCuestionario.Respuestas.Add(p);
                    }
                }
            });


            if (bloqueCuestionario.Pregunta != null)
            {
                listaSalida.Add(bloqueCuestionario);
            }

            return listaSalida;
        }

        private List<OpenXmlElement> ContenidoGeneralDePreguntas(IEnumerable<Paragraph> paragraphs)
        {
            var listaSalida = new List<List<OpenXmlElement>>();
            var grupoParrafos = new List<OpenXmlElement>();
            int conteoClases = 0;
            TipoNiveles = TiposNivel.SinFormato;
            paragraphs.ToList<OpenXmlElement>().ForEach(p =>
            {
                if (p.InnerText.ToLower(cultureInfo).StartsWith(@"clas = [", StringComparison.CurrentCulture)) // Nueva Clasificacion
                {
                    TipoNiveles = TiposNivel.Clases;
                    conteoClases++;
                }
                if (conteoClases == 1)
                {
                    grupoParrafos.Add(p);
                }
            });
            if (TipoNiveles == TiposNivel.SinFormato)
            {
                paragraphs.ToList<OpenXmlElement>().ForEach(p =>
                {
                    if (p.InnerText.StartsWith(@"#", StringComparison.CurrentCulture)) // Nueva Pregunta
                    {
                        TipoNiveles = TiposNivel.Preguntas;
                        grupoParrafos.Add(p);
                    }
                });
            }
            if (TipoNiveles == TiposNivel.SinFormato)
            {
                grupoParrafos = new List<OpenXmlElement>();
                Mensajes.ArchivoDeWordSinFormatoPreguntas();
            }
            return grupoParrafos;
        }

        private void MetodoClasificacion(ListBox listBoxPrincipal, ListBox listBoxSecundario)
        {
            if (listBoxPrincipal.Items.Count > 0)
            {
                var listadoSeleccionado = new List<string>();
                foreach (object itemSeleccionado in listBoxPrincipal.SelectedItems)
                {
                    listadoSeleccionado.Add(itemSeleccionado.ToString());
                }

                foreach (var item in listadoSeleccionado)
                {
                    listBoxSecundario.Items.Add(item);
                    listBoxPrincipal.Items.Remove(item);
                }
            }
            else
            {
                Mensajes.NoExistenElementosLista();
            }
        }
        private void MetodoClasificacion(ListBox listBoxPrincipal, ListBox listBoxSecundario, ListBox listBoxALimpiar)
        {
            if (listBoxPrincipal.Items.Count > 0)
            {
                var listadoSeleccionado = new List<string>();
                foreach (object itemSeleccionado in listBoxPrincipal.SelectedItems)
                {
                    listadoSeleccionado.Add(itemSeleccionado.ToString());
                }

                foreach (var item in listadoSeleccionado)
                {
                    listBoxSecundario.Items.Add(item);
                    listBoxPrincipal.Items.Remove(item);
                }
                listBoxALimpiar.Items.Clear();
            }
            else
            {
                Mensajes.NoExistenElementosLista();
            }
        }

        private void MetodoMoverItemLista(ListBox listBox, int direccion)
        {
            if (listBox.SelectedItem == null || listBox.SelectedIndex < 0) // Checking selected item
                return; // No selected item - nothing to do

            int newIndex = listBox.SelectedIndex + direccion; // Calculate new index using move direction
            if (newIndex < 0 || newIndex >= listBox.Items.Count) // Checking bounds of the range
                return; // Index out of range - nothing to do

            object selected = listBox.SelectedItem;
            listBox.Items.Remove(selected); // Removing removable element
            listBox.Items.Insert(newIndex, selected); // Insert it in new position
            listBox.SetSelected(newIndex, true); // Restore selection
        }

        private void MetodoClasificacionTodo(ListBox listBoxPrincipal, ListBox listBoxSecundario, ListBox listBoxALimpiar)
        {
            listBoxSecundario.Items.AddRange(listBoxPrincipal.Items);
            listBoxPrincipal.Items.Clear();
            listBoxALimpiar.Items.Clear();
        }

        private void GetListadoNiveles()
        {
            var listadoNivelesList = new List<string>();
            listBoxNiveles.Items.Clear();
            if (TipoNiveles == TiposNivel.Clases)
            {
                foreach (var bloque in listaBloqueCuestionario)
                {
                    string descripcionItem = "";
                    int conteoDescripcion = 0;
                    foreach (var clase in bloque.Clase)
                    {
                        for (int i = 0; i < listBoxElegir.Items.Count; i++)
                        {
                            if (clase.Key.Contains(listBoxElegir.Items[i].ToString()))
                            {
                                if (conteoDescripcion == 0)
                                {
                                    descripcionItem += $"{clase.Value}";
                                }
                                else
                                {
                                    descripcionItem += $" - {clase.Value}";
                                }
                                conteoDescripcion++;
                            }
                        }
                    }
                    listadoNivelesList.Add(descripcionItem);
                }
            }

            if (TipoNiveles == TiposNivel.Preguntas)
            {
                for (int i = 0; i < listBoxElegir.Items.Count; i++)
                {
                    foreach (var bloque in listaBloqueCuestionario)
                    {
                        listadoNivelesList.Add(bloque.Pregunta.InnerText.Substring(1).Trim(' '));
                    }
                }
            }

            foreach (var nivel in listadoNivelesList.Distinct())
            {
                listBoxNiveles.Items.Add(nivel);
            }

        }

        private void ButtonClasificacionItemElegir_Click(object sender, EventArgs e)
        {
            MetodoClasificacion(listBoxClasificacion, listBoxElegir, listBoxExcluir);
            GetListadoNiveles();
        }


        private void ListBoxClasificacion_DoubleClick(object sender, EventArgs e)
        {
            MetodoClasificacion(listBoxClasificacion, listBoxElegir, listBoxExcluir);
            GetListadoNiveles();
        }

        private void ButtonClasificacionItemQuitar_Click(object sender, EventArgs e)
        {
            MetodoClasificacion(listBoxElegir, listBoxClasificacion, listBoxExcluir);
            GetListadoNiveles();
        }

        private void ListBoxElegir_DoubleClick(object sender, EventArgs e)
        {
            MetodoClasificacion(listBoxElegir, listBoxClasificacion, listBoxExcluir);
            GetListadoNiveles();
        }

        private void PictureBoxMenuEmergente_Click(object sender, EventArgs e)
        {
            listaRutaBancoDePreguntas.Clear(); // Limpieza de List listaBancoPreguntas
            // Limpieza de comboBoxRutaBancoPreguntas
            comboBoxRutaBancoPreguntas.Items.Clear();
            comboBoxRutaBancoPreguntas.ResetText();
            // Limpieza de ListBoxs e inicializacion de Listas
            InicializarListBoxs();

        }

        private void PictureBoxMenuEmergente_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxMenuEmergente.Image = icons8_eliminar_columna_500; // Cambio de color para simular boton del pictureBoxMenuEmergente
        }

        private void PictureBoxMenuEmergente_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxMenuEmergente.Image = icons8_eliminar_columna_500_cian; // Cambio de color para simular boton del pictureBoxMenuEmergente
        }

        #endregion

        #region Pestaña Cantidad
        private void PictureBoxIdentificarExamenes_MouseDown(object sender, MouseEventArgs e)
        {
            interruptor.boolIdentificarExamenes = !interruptor.boolIdentificarExamenes;
            pictureBoxIdentificarExamenes.Image = interruptor.boolIdentificarExamenes ? interruptor.botonSiConTexto : interruptor.botonNoConTexto;
        }
        #endregion

        #region Pestaña Numeracion

        private void TextoLabelEnBaseNumeracion(TextBox textBoxAntes, ComboBox comboBoxTipoNumeracion, TextBox textBoxDespues, Label labelTexto)
        {
            if (comboBoxTipoNumeracion.Text == "Ninguna")
            {
                labelTexto.Text = "";
            }
            else
            {
                labelTexto.Text = textBoxAntes.Text.Trim(' ') + comboBoxTipoNumeracion.Text + textBoxDespues.Text.Trim(' ');
            }
        }
        private void PictureBoxMantenerOriginalEspaciadoPreguntas_MouseDown(object sender, MouseEventArgs e)
        {
            interruptor.boolMantenerOriginalEspaciadoPreguntas = !interruptor.boolMantenerOriginalEspaciadoPreguntas;
            pictureBoxMantenerOriginalEspaciadoPreguntas.Image = interruptor.boolMantenerOriginalEspaciadoPreguntas ? interruptor.botonSiConTexto : interruptor.botonNoConTexto;
        }

        private void PictureBoxMantenerOriginalColumnasRespuestas_MouseDown(object sender, MouseEventArgs e)
        {
            interruptor.boolMantenerOriginalColumnasRespuestas = !interruptor.boolMantenerOriginalColumnasRespuestas;
            pictureBoxMantenerOriginalColumnasRespuestas.Image = interruptor.boolMantenerOriginalColumnasRespuestas ? interruptor.botonSiConTexto : interruptor.botonNoConTexto;
        }

        private void PictureBoxMantenerOriginalEspaciadoRespuestas_MouseDown(object sender, MouseEventArgs e)
        {
            interruptor.boolMantenerOriginalEspaciadoRespuestas = !interruptor.boolMantenerOriginalEspaciadoRespuestas;
            pictureBoxMantenerOriginalEspaciadoRespuestas.Image = interruptor.boolMantenerOriginalEspaciadoRespuestas ? interruptor.botonSiConTexto : interruptor.botonNoConTexto;
        }

        private void PictureBoxMantenerOriginalNumeracionRespuestas_MouseDown(object sender, MouseEventArgs e)
        {
            interruptor.boolMantenerOriginalNumeracionRespuestas = !interruptor.boolMantenerOriginalNumeracionRespuestas;
            pictureBoxMantenerOriginalNumeracionRespuestas.Image = interruptor.boolMantenerOriginalNumeracionRespuestas ? interruptor.botonSiConTexto : interruptor.botonNoConTexto;
        }

        private void buttonClasificacionItemElegirTodo_Click(object sender, EventArgs e)
        {
            MetodoClasificacionTodo(listBoxClasificacion, listBoxElegir, listBoxExcluir);
            GetListadoNiveles();
        }

        private void buttonClasificacionItemQuitarTodo_Click(object sender, EventArgs e)
        {
            MetodoClasificacionTodo(listBoxElegir, listBoxClasificacion, listBoxExcluir);
            GetListadoNiveles();
        }

        private void buttonNivelesExcluir_Click(object sender, EventArgs e)
        {
            MetodoClasificacion(listBoxNiveles, listBoxExcluir);
        }

        private void buttonNivelesIncluir_Click(object sender, EventArgs e)
        {
            MetodoClasificacion(listBoxExcluir, listBoxNiveles);
        }

        private void buttonNivelesSubir_Click(object sender, EventArgs e)
        {
            MetodoMoverItemLista(listBoxNiveles, -1);
        }

        private void buttonNivelesBajar_Click(object sender, EventArgs e)
        {
            MetodoMoverItemLista(listBoxNiveles, 1);
        }

        private void listBoxNiveles_DoubleClick(object sender, EventArgs e)
        {
            MetodoClasificacion(listBoxNiveles, listBoxExcluir);
        }

        private void listBoxExcluir_DoubleClick(object sender, EventArgs e)
        {
            MetodoClasificacion(listBoxExcluir, listBoxNiveles);
        }

        private void textBoxAntesNumeracionPreguntas_TextChanged(object sender, EventArgs e)
        {
            TextoLabelEnBaseNumeracion(textBoxAntesNumeracionPreguntas, comboBoxNumeroNumeracionPreguntas, textBoxDespuesNumeracionPreguntas, labelNumeracionResultadoNumeracionPreguntas);
        }

        private void comboBoxNumeroNumeracionPreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextoLabelEnBaseNumeracion(textBoxAntesNumeracionPreguntas, comboBoxNumeroNumeracionPreguntas, textBoxDespuesNumeracionPreguntas, labelNumeracionResultadoNumeracionPreguntas);
        }

        private void textBoxDespuesNumeracionPreguntas_TextChanged(object sender, EventArgs e)
        {
            TextoLabelEnBaseNumeracion(textBoxAntesNumeracionPreguntas, comboBoxNumeroNumeracionPreguntas, textBoxDespuesNumeracionPreguntas, labelNumeracionResultadoNumeracionPreguntas);
        }

        private void textBoxAntesNumeracionRespuestas_TextChanged(object sender, EventArgs e)
        {
            TextoLabelEnBaseNumeracion(textBoxAntesNumeracionRespuestas, comboBoxNumeroNumeracionRespuestas, textBoxDespuesNumeracionRespuestas, labelNumeracionResultadoNumeracionRespuestas);
        }

        private void comboBoxNumeroNumeracionRespuestas_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextoLabelEnBaseNumeracion(textBoxAntesNumeracionRespuestas, comboBoxNumeroNumeracionRespuestas, textBoxDespuesNumeracionRespuestas, labelNumeracionResultadoNumeracionRespuestas);
        }

        private void textBoxDespuesNumeracionRespuestas_TextChanged(object sender, EventArgs e)
        {
            TextoLabelEnBaseNumeracion(textBoxAntesNumeracionRespuestas, comboBoxNumeroNumeracionRespuestas, textBoxDespuesNumeracionRespuestas, labelNumeracionResultadoNumeracionRespuestas);
        }

        private void PictureBoxMantenerOriginalNumeracionPreguntas_MouseDown(object sender, MouseEventArgs e)
        {
            interruptor.boolMantenerOriginalNumeracionPreguntas = !interruptor.boolMantenerOriginalNumeracionPreguntas;
            pictureBoxMantenerOriginalNumeracionPreguntas.Image = interruptor.boolMantenerOriginalNumeracionPreguntas ? interruptor.botonSiConTexto : interruptor.botonNoConTexto;

        }
        #endregion

        #region Pestaña Solucion
        private void PictureBoxImprimirComentariosPresentacionSolucion_MouseDown(object sender, MouseEventArgs e)
        {
            interruptor.boolImprimirComentariosPresentacionSolucion = !interruptor.boolImprimirComentariosPresentacionSolucion;
            pictureBoxImprimirComentariosPresentacionSolucion.Image = interruptor.boolImprimirComentariosPresentacionSolucion ? interruptor.botonSiConTexto : interruptor.botonNoConTexto;
        }

        #endregion

        #region Pestaña Examen
        private void ButtonAbrirPlantillaExamen_Click(object sender, EventArgs e)
        {
            // Configuracion inicial del ofdAbrirPlantillaExamen
            var ofdAbrirPlantillaExamen = RutaOpenFileDialog(Mensajes.RutaInicial, Mensajes.AbrirPlantillaPreguntas);

            if (ofdAbrirPlantillaExamen.ShowDialog() == DialogResult.OK)
            {
                // Reseteamos comboBoxRutaBancoPreguntas
                comboBoxRutaPlantillaExamen.Items.Clear();
                //Agregamos a List elementos seleccionados
                listaPlantillaExamen.Add(ofdAbrirPlantillaExamen.FileName);
                //Agregamos items a comboBoxRutaBancoPreguntas filtrando elementos duplicados
                foreach (var item in listaPlantillaExamen.Distinct())
                {
                    comboBoxRutaPlantillaExamen.Items.Add(item);
                }
                comboBoxRutaPlantillaExamen.Text = ofdAbrirPlantillaExamen.FileName;
                //
            }
        }



        private void PictureBoxMenuEmergentePlantilla_Click(object sender, EventArgs e)
        {
            // Limpieza de List listaPlantillaExamen
            listaPlantillaExamen.Clear();
            // Limpieza de comboBoxRutaPlantillaExamen
            comboBoxRutaPlantillaExamen.Items.Clear();
            comboBoxRutaPlantillaExamen.ResetText();
            //
        }

        private void PictureBoxMenuEmergentePlantilla_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxMenuEmergentePlantilla.Image = icons8_eliminar_columna_500; // Cambio de color para simular boton del pictureBoxMenuEmergente
        }

        private void PictureBoxMenuEmergentePlantilla_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxMenuEmergentePlantilla.Image = icons8_eliminar_columna_500_cian; // Cambio de color para simular boton del pictureBoxMenuEmergente
        }

        #endregion

        private void buttonEstructurarPreguntasElegidas_Click(object sender, EventArgs e)
        {
            CargarDatosDatagridview();
            totalesCabaceraDatagridview();

        }

        private void totalesCabaceraDatagridview()
        {
            int totalPreguntas = 0;
            int totalElegidas = 0;
            for (int i = 0; i < dataGridViewEstructura.Rows.Count; i++)
            {
                totalPreguntas += Convert.ToInt32(dataGridViewEstructura.Rows[i].Cells[2].Value, cultureInfo);
                totalElegidas += Convert.ToInt32(dataGridViewEstructura.Rows[i].Cells[3].Value, cultureInfo);
            }
            dataGridViewEstructura.Columns[2].HeaderText = $"Total ({totalPreguntas.ToString(cultureInfo)})";
            dataGridViewEstructura.Columns[3].HeaderText = $"Elegir ({totalElegidas.ToString(cultureInfo)})";
        }

        private void CargarDatosDatagridview()
        {
            dataGridViewEstructura.Rows.Clear();
            if (listBoxNiveles.Items.Count > 0)
            {
                if (TipoNiveles == TiposNivel.Clases)
                {
                    int contador = 0;
                    foreach (var item in listBoxNiveles.Items)
                    {
                        string[] claseValue = item.ToString().Split('-');
                        int contadorItem = 0;
                        foreach (var bloque in listaBloqueCuestionario)
                        {
                            int contadorBloque = 0;
                            foreach (var clase in bloque.Clase)
                            {
                                for (int i = 0; i < claseValue.Length; i++)
                                {
                                    if (clase.Value == claseValue[i].Trim(' '))
                                    {
                                        contadorBloque++;
                                    }
                                }
                            }
                            if (contadorBloque == claseValue.Length)
                            {
                                contadorItem++;
                            }
                        }

                        dataGridViewEstructura.Rows.Insert(contador, ++contador, item, contadorItem, contadorItem, "Azar", "Azar");
                    }

                }

                if (TipoNiveles == TiposNivel.Preguntas)
                {
                    dataGridViewEstructura.Rows.Insert(0, 1, TiposNivel.Preguntas.ToString(), listBoxNiveles.Items.Count, listBoxNiveles.Items.Count, "Azar", "Azar");
                }
            }
            else
            {
                Mensajes.NoExistenDatosParaEstructurar();
            }
        }

        private void dataGridViewEstructura_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridViewEstructura.CurrentCell.ColumnIndex == 3)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dataGridViewEstructura_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(dataGridViewEstructura_KeyPress);
                }
            }
        }

        private void dataGridViewEstructura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridViewEstructura.CurrentCell.ColumnIndex == 3)
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

        private void dataGridViewEstructura_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(dataGridViewEstructura.CurrentRow.Cells[3].Value.ToString(), cultureInfo) > Convert.ToInt32(dataGridViewEstructura.CurrentRow.Cells[2].Value.ToString(), cultureInfo))
            {
                Mensajes.ValorElegidoMasAltoQueElTotal();
                dataGridViewEstructura.CurrentRow.Cells[3].Value = dataGridViewEstructura.CurrentRow.Cells[2].Value;
            }
            totalesCabaceraDatagridview();
        }

        private void formularioOrdenRegistro(int columna, DataGridView dataGridView, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView.Rows.Count > 0 && e.ColumnIndex == columna)
            {
                int ix = Left + dataGridView.GetCellDisplayRectangle(columna, dataGridView.CurrentRow.Index, false).Right + dataGridView.Location.X + 19;
                int iy = Top + dataGridView.GetCellDisplayRectangle(columna, dataGridView.CurrentRow.Index, false).Top + +dataGridView.Location.Y;
                OrdenRegistroForm.contrato = this;
                OrdenRegistroForm.Show();
                OrdenRegistroForm.Location = new Point(ix, iy);
            }

        }
        public void Orden(string texto)
        {
            for (int i = 0; i < dataGridViewEstructura.Rows.Count; i++)
            {
                dataGridViewEstructura.Rows[i].Cells[columnaSeleccionada].Value = texto;
            }
        }

        private void dataGridViewEstructura_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            columnaSeleccionada = e.ColumnIndex;
            formularioOrdenRegistro(4, dataGridViewEstructura, e);
            formularioOrdenRegistro(5, dataGridViewEstructura, e);

        }

        private void dataGridViewEstructura_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                columnaSeleccionada = e.ColumnIndex;
                dataGridViewEstructura.EndEdit();
                formularioOrdenRegistro(4, dataGridViewEstructura, e);
                formularioOrdenRegistro(5, dataGridViewEstructura, e);

            }
        }

        private void numericUpDownExamenes_ValueChanged(object sender, EventArgs e)
        {
            CalculoTotalCuestionarios();
        }

        private void numericUpDownCopias_ValueChanged(object sender, EventArgs e)
        {
            CalculoTotalCuestionarios();
        }
        private void CalculoTotalCuestionarios()
        {
            int totalExCo = (int)numericUpDownExamenes.Value * (int)numericUpDownCopias.Value;
            labelTotalExamanesCopias.Text = $"Total de exámenes ({numericUpDownExamenes.Value}) y copias ({numericUpDownCopias.Value}) = {totalExCo}";
        }
    }
}