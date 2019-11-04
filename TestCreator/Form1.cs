using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestCreator.Clases;
using static TestCreator.Properties.Resources;

namespace TestCreator
{
    public partial class FormPrincipal : Form
    {
        private Interruptores interruptor = new Interruptores();
        private List<string> listaBancoPreguntas = new List<string>();
        private List<string> listaPlantillaExamen = new List<string>();
        private List<string> listadoClasificacion = new List<string>();
        private List<string> listadoNiveles = new List<string>();
        private List<string> listadoClasificacionNiveles = new List<string>();
        //private List<List<OpenXmlElement>> bloqueGeneral;
        public TipoNiveles TipoNiveles { get; set; }
        private int ArraySizeClasificacion = 0;
        //private string tipoDeNiveles = "";
        private string templatePath = "";

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
            var toolTipMenuEmergente = new ToolTip();
            toolTipMenuEmergente.SetToolTip(pictureBoxMenuEmergente, "Limpiar busqueda");
            toolTipMenuEmergente.SetToolTip(pictureBoxMenuEmergentePlantilla, "Limpiar busqueda");
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

        private void InicializarListBoxContents()
        {
            listBoxClasificacion.Items.Clear();
            listBoxElegir.Items.Clear();
            listBoxNiveles.Items.Clear();
            listBoxExcluir.Items.Clear();
            listadoClasificacion = new List<string>();
            listadoNiveles = new List<string>();
            listadoClasificacionNiveles = new List<string>();
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

        #endregion

        #region Pestaña Estructura
        private void ButtonAbrirBancoPreguntas_Click(object sender, EventArgs e)
        {
            InicializarListBoxContents();
            var ofdAbrirBancoPreguntas = OpenFileDialogPersonalizado.PersonalizadoWord("D:\'Demos\'", "Abrir banco de preguntas"); // Configuracion inicial del ofdAbrirBancoPreguntas
            if (ofdAbrirBancoPreguntas.ShowDialog() == DialogResult.OK)
            {
                comboBoxRutaBancoPreguntas.Items.Clear(); // Reseteamos comboBoxRutaBancoPreguntas
                listaBancoPreguntas.Add(ofdAbrirBancoPreguntas.FileName); //Agregamos a List elementos seleccionados
                foreach (var item in listaBancoPreguntas.Distinct()) //Agregamos items a comboBoxRutaBancoPreguntas filtrando elementos duplicados con Distinct()
                {
                    comboBoxRutaBancoPreguntas.Items.Add(item); 
                }
                comboBoxRutaBancoPreguntas.Text = ofdAbrirBancoPreguntas.FileName;
            }
            templatePath = comboBoxRutaBancoPreguntas.Text;
        }

        private void comboBoxRutaBancoPreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            InicializarListBoxContents(); // Limpiamos todos los listados y Listbox's
            templatePath = comboBoxRutaBancoPreguntas.Text; 
            CargarListboxMedianteTemplate();
        }

        private void ButtonGenerarExamen_Click(object sender, EventArgs e) { }

        private void CargarListboxMedianteTemplate(){
            using (WordprocessingDocument document = WordprocessingDocument.CreateFromTemplate(templatePath))
            {
                var body = document.MainDocumentPart.Document.Body;
                var paragraphs = body.Elements<Paragraph>();
                var blocks = GrupoGeneralDePreguntas(paragraphs); // Get a List of Question blocks
                //bloqueGeneral = blocks.ConvertAll<List<OpenXmlElement>>(g => g.ConvertAll<OpenXmlElement>(p => (OpenXmlElement)p.CloneNode(true))); // Deep Clone
                if (blocks.Count >0)
                {
                    listadoClasificacion = ClasificacionGeneralDePreguntas(blocks[0]);
                    foreach (var itemClasificacion in listadoClasificacion){ listBoxClasificacion.Items.Add(itemClasificacion); }
                    listadoNiveles = NivelesPreguntas(blocks[0]);
                    if (TipoNiveles == TipoNiveles.Clases)
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
                    if (TipoNiveles == TipoNiveles.Preguntas)
                    {
                        foreach (var itemNivel in listadoNiveles) { listadoClasificacionNiveles.Add(itemNivel.Trim(' '));  }
                    }
                    if (TipoNiveles == TipoNiveles.SinFormato)
                    {
                        MessageBox.Show("Archivo de Word sin formato de preguntas establecido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Archivo de Word incorrecto.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private List<string> ClasificacionGeneralDePreguntas(IEnumerable<OpenXmlElement> paragraphs)
        {
            List<string> output = new List<string>();
            TipoNiveles = TipoNiveles.SinFormato;
            paragraphs.ToList<OpenXmlElement>().ForEach(p =>
            {
                if (p.InnerText.ToLower().StartsWith(@"clas = [") && output.Count < 1) // Nueva Pregunta
                {
                    TipoNiveles = TipoNiveles.Clases;
                    string[] listaTemp = p.InnerText.Remove(p.InnerText.IndexOf("]")).Substring(8).Split(',');
                    ArraySizeClasificacion = listaTemp.Length;
                    foreach (var item in listaTemp) output.Add(item.Trim(' '));
                }
            });
            paragraphs.ToList<OpenXmlElement>().ForEach(p =>
            {
                if (p.InnerText.StartsWith(@"#") && output.Count < 1 && TipoNiveles == TipoNiveles.SinFormato) // Nueva Pregunta
                {
                    TipoNiveles = TipoNiveles.Preguntas;
                    output.Add(TipoNiveles.ToString());
                }
            });
            return output;
        }

        private List<string> NivelesPreguntas(IEnumerable<OpenXmlElement> paragraphs)
        {
            List<string> output = new List<string>();
            string contenido = "";
            if (TipoNiveles == TipoNiveles.Clases)
            {
                paragraphs.ToList<OpenXmlElement>().ForEach(p =>
                {
                    if (p.InnerText.ToLower().StartsWith(@"clas = ") && !p.InnerText.ToLower().StartsWith(@"clas = [")) // Nueva pregunta para Tipo de Clasificación
                    {
                        contenido = p.InnerText.Trim(' ').Substring(7);
                        if (contenido.Contains("%")) contenido = contenido.Remove(contenido.IndexOf("%"));
                        string[] arrayTemp = contenido.Split(',');
                        int arrayTempSize = 0;
                        foreach (var contenidoListaTemp in arrayTemp)
                        {
                            if (contenidoListaTemp.Trim(' ') != "") arrayTempSize++;
                        }
                        if (ArraySizeClasificacion == arrayTempSize)
                        {
                            output.Add(contenido.Trim(' '));
                        }
                    }
                });
            }
            if (TipoNiveles == TipoNiveles.Preguntas)
            {
                paragraphs.ToList<OpenXmlElement>().ForEach(p =>
                {
                    if (p.InnerText.StartsWith(@"#")) // Nueva pregunta para Tipo Preguntas
                    {
                        contenido = p.InnerText.Trim(' ');
                        if (contenido.Contains("%")) contenido = contenido.Remove(contenido.IndexOf("%"));
                        if (contenido.Length > 1) output.Add( contenido);
                    }
                });
            }
            return output;
        }
        
        private List<List<OpenXmlElement>> GrupoGeneralDePreguntas(IEnumerable<Paragraph> paragraphs)
        {
            List<List<OpenXmlElement>> output = new List<List<OpenXmlElement>>();
            List<OpenXmlElement> group = new List<OpenXmlElement>();
            int conteoClases = 0;
            TipoNiveles = TipoNiveles.SinFormato;
            paragraphs.ToList<OpenXmlElement>().ForEach(p =>
            {
                if (p.InnerText.ToLower().StartsWith(@"clas = [")) // Nueva Clasificacion
                {
                    TipoNiveles = TipoNiveles.Clases;
                    conteoClases++;
                }

                if (TipoNiveles == TipoNiveles.Clases && conteoClases == 1)
                {
                    group.Add(p);
                }
            });
            if (TipoNiveles == TipoNiveles.SinFormato)
            {
                paragraphs.ToList<OpenXmlElement>().ForEach(p =>
                {
                    if (p.InnerText.StartsWith(@"#") && conteoClases == 0) // Nueva Pregunta
                    {
                        TipoNiveles = TipoNiveles.Preguntas;
                        conteoClases++;
                    }
                    if (TipoNiveles == TipoNiveles.Preguntas && conteoClases == 1)
                    {
                        group.Add(p);
                    }
                });
            }

            if (group.Count > 0) // Agregar grupo de preguntas al Bloque General de preguntas
            {
                output.Add(group);
                group = new List<OpenXmlElement>();
            }
            return output;
        }


        private void MetodoClasificacion(ListBox listBoxPrincipal, ListBox listBoxSecundario)
        {
            if (listBoxPrincipal.Items.Count > 0)
            {
                List<string> listadoSeleccionado = new List<string>();
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
                MessageBox.Show("No existen elementos en la lista","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
            }
        }
        private void MetodoClasificacion(ListBox listBoxPrincipal, ListBox listBoxSecundario, ListBox listBoxALimpiar)
        {
            if (listBoxPrincipal.Items.Count > 0)
            {
                List<string> listadoSeleccionado = new List<string>();
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
                MessageBox.Show("No existen elementos en la lista","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
                
        private void ListadoNiveles()
        {
            List<string> listadoNivelesList = new List<string>();
            listBoxNiveles.Items.Clear();
            if (TipoNiveles == TipoNiveles.Clases)
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

            if (TipoNiveles == TipoNiveles.Preguntas)
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
            ListadoNiveles();
        }


        private void ListBoxClasificacion_DoubleClick(object sender, EventArgs e)
        {
            MetodoClasificacion(listBoxClasificacion, listBoxElegir, listBoxExcluir);
            ListadoNiveles();
        }

        private void ButtonClasificacionItemQuitar_Click(object sender, EventArgs e)
        {
            MetodoClasificacion(listBoxElegir, listBoxClasificacion, listBoxExcluir);
            ListadoNiveles();
        }

        private void ListBoxElegir_DoubleClick(object sender, EventArgs e)
        {
            MetodoClasificacion(listBoxElegir, listBoxClasificacion, listBoxExcluir);
            ListadoNiveles();
        }


        private void PictureBoxMenuEmergente_Click(object sender, EventArgs e)
        {
            listaBancoPreguntas.Clear(); // Limpieza de List listaBancoPreguntas
            // Limpieza de comboBoxRutaBancoPreguntas
            comboBoxRutaBancoPreguntas.Items.Clear();
            comboBoxRutaBancoPreguntas.ResetText();
            // Limpieza de ListBoxs e inicializacion de Listas
            InicializarListBoxContents();
            
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
            ListadoNiveles();
        }

        private void buttonClasificacionItemQuitarTodo_Click(object sender, EventArgs e)
        {
            MetodoClasificacionTodo(listBoxElegir, listBoxClasificacion, listBoxExcluir);
            ListadoNiveles();
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
            var ofdAbrirPlantillaExamen = OpenFileDialogPersonalizado.PersonalizadoWord("D:\'Demos\'", "Abrir plantilla de examen");

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
                int contador = 0;
                foreach (var item in listBoxNiveles.Items)
                {
                    dataGridViewEstructura.Rows.Insert(contador, ++contador, item, "", "", "Orden original", "Orden original");
                }

            }
            else MessageBox.Show("No existen datos para estructurar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

