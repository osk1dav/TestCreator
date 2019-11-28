﻿using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using TestCreator.Clases;
using TestCreator.Utilitarios;
using static TestCreator.Properties.Resources;

namespace TestCreator
{
    public partial class FormPrincipal : Form
    {
        private CultureInfo cultureInfo = new CultureInfo("es-EC");

        private TiposNivel TipoNiveles { get; set; }
        private BloqueCuestionario bloqueCuestionario = new BloqueCuestionario();
        private Interruptores interruptor = new Interruptores();

        private List<string> listaRutaBancoDePreguntas = new List<string>();
        private string rutaBancoPreguntas = "";
        private List<string> listaPlantillaExamen = new List<string>();

        private List<string> listadoClasificacion = new List<string>();
        private List<string> listaClasificacion = new List<string>();
        private List<string> listadoNiveles = new List<string>();
        private Dictionary<string, string> diccionarioNiveles = new Dictionary<string, string>();
        private List<string> listadoClasificacionNiveles = new List<string>();
        private List<BloqueCuestionario> listaBloqueCuestionario = new List<BloqueCuestionario>();
        private int ArraySizeKeyClasificacion = 0;

        
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
            listaBloqueCuestionario = new List<BloqueCuestionario>();
            listaClasificacion = new List<string>();

            listadoClasificacion = new List<string>();
            listadoNiveles = new List<string>();
            listadoClasificacionNiveles = new List<string>();
            diccionarioNiveles = new Dictionary<string, string>();
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
            const string resultPath = @"D:\Demos\Resultado.docx";
            using (WordprocessingDocument document = WordprocessingDocument.Create(resultPath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = document.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());
                foreach (var item in listaBloqueCuestionario)
                {
                    Paragraph para = body.AppendChild(new Paragraph());
                    Run run = para.AppendChild(new Run());
                    run.AppendChild(new Text(item.Pregunta.InnerText));
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
                    listaClasificacion = listaBloqueCuestionario.SelectMany(bloque => bloque.Clase.Keys.Select(clase => clase)).ToList();
                    GetListaClasificacion();

                    if (listaContenidoGeneralDePreguntas.Count > 0)
                    {
                        listadoClasificacion = ClasificacionPreguntas(listaContenidoGeneralDePreguntas);
                        listadoNiveles = NivelesPreguntas(listaContenidoGeneralDePreguntas);

                        if (TipoNiveles == TiposNivel.Clases)
                        {
                            foreach (var itemNivel in listadoNiveles)
                            {
                                string cadenaListado = "";
                                string[] nivelArray = itemNivel.Split(',');
                                int clasificacionConteo = 0;
                                foreach (var itemClasificacion in listadoClasificacion)
                                {
                                    if (clasificacionConteo == 0)
                                    {
                                        cadenaListado += $"{itemClasificacion} - {nivelArray[clasificacionConteo]}";
                                    }
                                    else
                                    {
                                        cadenaListado += $", {itemClasificacion} - {nivelArray[clasificacionConteo]}";
                                    }
                                    clasificacionConteo++;
                                }
                                listadoClasificacionNiveles.Add(cadenaListado);
                            }
                        }

                        if (TipoNiveles == TiposNivel.Preguntas)
                        {
                            foreach (var itemNivel in listadoNiveles)
                            {
                                listadoClasificacionNiveles.Add(itemNivel.Trim(' '));
                            }
                        }
                    }
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Mensajes.ArchivoDeWordNoExiste();
            }
        }

        #region Minimizado

        private void GetListaClasificacion()
        {
            foreach (var item in listaClasificacion.Distinct())
            {
                listBoxClasificacion.Items.Add(item);
            }
        }

        private List<string> ClasificacionPreguntas(IEnumerable<OpenXmlElement> paragraphs)
        {
            var output = new List<string>();
            paragraphs.ToList<OpenXmlElement>().ForEach(p =>
            {
                if (TipoNiveles == TiposNivel.Clases)
                {
                    if (p.InnerText.ToLower(cultureInfo).StartsWith(@"clas = [", StringComparison.CurrentCulture) && output.Count < 1) // Nueva Pregunta
                    {
                        string[] listaTemp = p.InnerText.Remove(p.InnerText.IndexOf("]", StringComparison.CurrentCulture)).Substring(8).Split(',');
                        ArraySizeKeyClasificacion = listaTemp.Length;
                        foreach (var item in listaTemp)
                        {
                            output.Add(item.Trim(' '));
                        }
                    }
                }
                else if (TipoNiveles == TiposNivel.Preguntas)
                {
                    if (output.Count < 1)
                    {
                        output.Add(TipoNiveles.ToString());
                    }
                }

            });

            return output;
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

        private List<string> NivelesPreguntas(IEnumerable<OpenXmlElement> paragraphs)
        {
            var output = new List<string>();
            string contenido = "";
            if (TipoNiveles == TiposNivel.Clases)
            {
                paragraphs.ToList<OpenXmlElement>().ForEach(p =>
                {
                    if (p.InnerText.ToLower(cultureInfo).StartsWith(@"clas = ", StringComparison.CurrentCulture) && !p.InnerText.ToLower(cultureInfo).StartsWith(@"clas = [", StringComparison.CurrentCulture)) // Nueva pregunta para Tipo de Clasificación
                    {
                        contenido = p.InnerText.Trim(' ').Substring(7);
                        if (contenido.Contains("%")) contenido = contenido.Remove(contenido.IndexOf("%", StringComparison.CurrentCulture));
                        string[] arrayTemp = contenido.Split(',');
                        int arrayTempSize = 0;
                        foreach (var contenidoListaTemp in arrayTemp)
                        {
                            if (contenidoListaTemp.Trim(' ').Length > 0) arrayTempSize++;
                        }
                        if (ArraySizeKeyClasificacion == arrayTempSize)
                        {
                            output.Add(contenido.Trim(' '));
                        }
                    }
                });
            }
            if (TipoNiveles == TiposNivel.Preguntas)
            {
                paragraphs.ToList<OpenXmlElement>().ForEach(p =>
                {
                    if (p.InnerText.StartsWith(@"#", StringComparison.CurrentCulture)) // Nueva pregunta para Tipo Preguntas
                    {
                        contenido = p.InnerText.Trim(' ');
                        if (contenido.Contains("%")) contenido = contenido.Remove(contenido.IndexOf("%", StringComparison.CurrentCulture));
                        if (contenido.Length > 1) output.Add(contenido);
                    }
                });
            }
            return output;
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
        #endregion

        private void GetListadoNiveles()
        {
            var listadoNivelesList = new List<string>();
            listBoxNiveles.Items.Clear();
            if (TipoNiveles == TiposNivel.Clases)
            {
                foreach (var item in listadoClasificacionNiveles)
                {
                    string descripcionItem = "";
                    int conteoDescripcion = 0;
                    for (int i = 0; i < listBoxElegir.Items.Count; i++)
                    {
                        string[] arrayClasificacionTemp = item.Split(',');
                        for (int j = 0; j < arrayClasificacionTemp.Length; j++)
                        {
                            if (arrayClasificacionTemp[j].Contains(listBoxElegir.Items[i].ToString()))
                            {
                                int tamanioClasificacion = listBoxElegir.Items[i].ToString().Length;
                                if (conteoDescripcion == 0)
                                {
                                    descripcionItem += $"{arrayClasificacionTemp[j].Substring(tamanioClasificacion + 3).Trim(' ')}";
                                }
                                else
                                {
                                    descripcionItem += $" - {arrayClasificacionTemp[j].Substring(tamanioClasificacion + 3).Trim(' ')}";
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
                    foreach (var item in listadoClasificacionNiveles)
                    {
                        listadoNivelesList.Add(item.Substring(1));
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
            dataGridViewEstructura.Rows.Clear();
            if (listBoxNiveles.Items.Count > 0)
            {
                if (TipoNiveles == TiposNivel.Clases)
                {
                    int contador = 0;
                    foreach (var item in listBoxNiveles.Items)
                    {
                        dataGridViewEstructura.Rows.Insert(contador, ++contador, item, "", "", "Orden original", "Orden original");
                    }

                }

                if (TipoNiveles == TiposNivel.Preguntas)
                {
                    dataGridViewEstructura.Rows.Insert(0, 1, TiposNivel.Preguntas.ToString(), listBoxNiveles.Items.Count, "", "Orden original", "Orden original");
                }
            }
            else 
                Mensajes.NoExistenDatosParaEstructurar();
        }
    }
}