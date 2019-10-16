using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TestCreator
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
            InicializarInterruptores();
            // Mensaje alterno para pictureBoxMenuEmergente 
            var toolTipMenuEmergente = new ToolTip();
            toolTipMenuEmergente.SetToolTip(pictureBoxMenuEmergente, "Limpiar busqueda");

           
        }

        #region Codigo ejemplo
        /// <summary>
        /// Crear un documento nuevo en el mismo directorio del Filepath
        /// </summary>
        /// <example>
        //string fullPath = ofdAbrirBancoPreguntas.FileName;
        //string fileName = ofdAbrirBancoPreguntas.SafeFileName;
        //string path = fullPath.Replace(fileName, "New.docx");

        //using (WordprocessingDocument wordDocument =
        //WordprocessingDocument.Create(path, WordprocessingDocumentType.Document))
        //{
        //    // Add a main document part. 
        //    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

        //    // Create the document structure and add some text.
        //    mainPart.Document = new Document();
        //    Body body = mainPart.Document.AppendChild(new Body());
        //    Paragraph para = body.AppendChild(new Paragraph());
        //    Run run = para.AppendChild(new Run());
        //    run.AppendChild(new Text("Create text in body - CreateWordprocessingDocument"));
        //} 
        /// </example>
        #endregion

        #region Parametros
        // Simulacion de interruptor para botones si o no
        private bool boolIdentificarExamenes, boolMantenerOriginalNumeracionPreguntas, boolMantenerOriginalEspaciadoPreguntas, boolMantenerOriginalNumeracionRespuestas, boolMantenerOriginalEspaciadoRespuestas, boolMantenerOriginalColumnasRespuestas, boolImprimirComentariosPresentacionSolucion;
        // Listados para comboboxs
        private List<string> listaBancoPreguntas = new List<string>();
        private List<string> listaPlantillaExamen = new List<string>();
        private Dictionary<int, string> listadoClasificacion = new Dictionary<int, string>();
        private Dictionary<int, string> listadoNiveles = new Dictionary<int, string>();
        private string tipoNiveles = "";
        private List<string> listadoClasificacionNiveles = new List<string>();
        private int ArraySizeClasificacion = 0;
        // Bloques de Grupos de Parrafos segun su clasificacion General
        List<List<OpenXmlElement>> bloqueGeneral;
        // Imagenes tipo boton con Texto Si y No
        Image botonSiConTexto = TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96;
        Image botonNoConTexto = TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;

        private void InicializarInterruptores()
        {
            boolIdentificarExamenes = true;
            boolMantenerOriginalNumeracionPreguntas = true;
            boolMantenerOriginalEspaciadoPreguntas = true;
            boolMantenerOriginalNumeracionRespuestas = true;
            boolMantenerOriginalEspaciadoRespuestas = true;
            boolMantenerOriginalColumnasRespuestas = true;
            boolImprimirComentariosPresentacionSolucion = true;

            pictureBoxMantenerOriginalEspaciadoPreguntas.Image = boolMantenerOriginalEspaciadoPreguntas ? botonSiConTexto : botonNoConTexto;
            pictureBoxImprimirComentariosPresentacionSolucion.Image = boolImprimirComentariosPresentacionSolucion ? botonSiConTexto : botonNoConTexto;
            pictureBoxMantenerOriginalColumnasRespuestas.Image = boolMantenerOriginalColumnasRespuestas ? botonSiConTexto : botonNoConTexto;
            pictureBoxMantenerOriginalEspaciadoRespuestas.Image = boolMantenerOriginalEspaciadoRespuestas ? botonSiConTexto : botonNoConTexto;
            pictureBoxMantenerOriginalNumeracionRespuestas.Image = boolMantenerOriginalNumeracionRespuestas ? botonSiConTexto : botonNoConTexto;
            pictureBoxMantenerOriginalNumeracionPreguntas.Image = boolMantenerOriginalNumeracionPreguntas ? botonSiConTexto : botonNoConTexto;
            pictureBoxIdentificarExamenes.Image = boolIdentificarExamenes ? botonSiConTexto : botonNoConTexto;

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
            listadoClasificacion = new Dictionary<int, string>();
            listadoNiveles = new Dictionary<int, string>();
            listadoClasificacionNiveles = new List<string>();
        }
        #endregion

        #region Formulario Principal
        private void PictureBoxAyuda_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxAyuda.Image = TestCreator.Properties.Resources.icons8_ayuda_64;
        }

        private void PictureBoxAyuda_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxAyuda.Image = TestCreator.Properties.Resources.icons8_ayuda_64_white;
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
                foreach (var item in listaBancoPreguntas.Distinct()) //Agregamos items a comboBoxRutaBancoPreguntas filtrando elementos duplicados
                {
                    comboBoxRutaBancoPreguntas.Items.Add(item);
                }
                comboBoxRutaBancoPreguntas.Text = ofdAbrirBancoPreguntas.FileName;
            }
            string templatePath = comboBoxRutaBancoPreguntas.Text;

            using (WordprocessingDocument document = WordprocessingDocument.CreateFromTemplate(templatePath))
            {
                var body = document.MainDocumentPart.Document.Body;
                var paragraphs = body.Elements<Paragraph>();
                var blocks = GrupoGeneralDePreguntas(paragraphs); // Get a List of Question blocks
                bloqueGeneral = blocks.ConvertAll<List<OpenXmlElement>>(g => g.ConvertAll<OpenXmlElement>(p => (OpenXmlElement)p.CloneNode(true))); // Deep Clone

                listadoClasificacion = ClasificacionGeneralDePreguntas(blocks[0]);
                foreach (var itemClasificacion in listadoClasificacion)
                {
                    //listBoxClasificacion.Items.Add(itemClasificacion.Value);
                    listBoxClasificacion.Items.Insert(itemClasificacion.Key, itemClasificacion.Value);
                }

                listadoNiveles = NivelesPreguntas(blocks[0]);

                if (tipoNiveles == "clases")
                {
                    foreach (var itemNivel in listadoNiveles)
                    {
                        string cadenaListado = "";
                        string[] nivelArray = itemNivel.Value.Split(',');
                        int clasificacionConteo = 0;
                        foreach (var itemClasificacion in listadoClasificacion)
                        {
                            if (clasificacionConteo == 0)
                            {
                                cadenaListado += $"{itemClasificacion.Value} - {nivelArray[clasificacionConteo]}";
                            }
                            else
                            {
                                cadenaListado += $", {itemClasificacion.Value} - {nivelArray[clasificacionConteo]}";
                            }
                            clasificacionConteo++;
                        }

                        listadoClasificacionNiveles.Add(cadenaListado);
                    }
                }
                if (tipoNiveles == "preguntas")
                {
                    foreach (var itemNivel in listadoNiveles)
                    {
                        listadoClasificacionNiveles.Add(itemNivel.Value.Trim(' '));
                    }
                }



            }
        }

        private void ButtonGenerarExamen_Click(object sender, EventArgs e) { }

        private Dictionary<int, string> ClasificacionGeneralDePreguntas(IEnumerable<OpenXmlElement> paragraphs)
        {
            Dictionary<int, string> output = new Dictionary<int, string>();
            tipoNiveles = "";
            int indexTemp = 0;
            paragraphs.ToList<OpenXmlElement>().ForEach(p =>
            {
                if (p.InnerText.ToLower().StartsWith(@"clas = [") && output.Count < 1) // New Pregunta
                {
                    tipoNiveles = "clases";
                    string[] listaTemp = p.InnerText.Trim(' ').Remove(p.InnerText.IndexOf("]")).Substring(8).Split(',');
                    ArraySizeClasificacion = listaTemp.Length;
                    foreach (var item in listaTemp)
                    {
                        output.Add(indexTemp, item.Trim(' '));
                        indexTemp++;
                    }
                }
            });
            paragraphs.ToList<OpenXmlElement>().ForEach(p =>
            {
                if (p.InnerText.StartsWith(@"#") && output.Count < 1 && tipoNiveles != "clases") // New Pregunta
                {
                    tipoNiveles = "preguntas";
                    output.Add(indexTemp, "Preguntas");
                    indexTemp++;
                }
            });

            return output;
        }

        
        private Dictionary<int, string> ClasificacionDePreguntas(IEnumerable<OpenXmlElement> paragraphs)
        {
            Dictionary<int, string> output = new Dictionary<int, string>();
            string contenido = "";
            int indexTemp = 0;
            paragraphs.ToList<OpenXmlElement>().ForEach(p =>
            {
                if (p.InnerText.ToLower().StartsWith(@"clas = [") && output.Count < 1) // New Pregunta
                {
                }

                if (p.InnerText.ToLower().StartsWith(@"clas = ") && !p.InnerText.ToLower().StartsWith(@"clas = [")) // New Pregunta
                {
                    contenido = p.InnerText.Trim(' ').Substring(7);
                    if (contenido.Contains("%"))
                    {
                        contenido = contenido.Remove(contenido.IndexOf("%"));
                    }
                    string[] listaTemp = contenido.Split(',');
                    if (listaTemp.Length == ArraySizeClasificacion)
                    {
                        output.Add(indexTemp, contenido.Trim(' '));
                        indexTemp++;
                    }

                }
                
            });
            return output;
        }

        private Dictionary<int, string> NivelesPreguntas(IEnumerable<OpenXmlElement> paragraphs)
        {
            Dictionary<int, string> output = new Dictionary<int, string>();
            string contenido = "";
            int indexTemp = 0;

            if (tipoNiveles == "clases")
            {
                paragraphs.ToList<OpenXmlElement>().ForEach(p =>
                {
                    if (p.InnerText.ToLower().StartsWith(@"clas = ") && !p.InnerText.ToLower().StartsWith(@"clas = [")) // New Pregunta
                    {
                        contenido = p.InnerText.Trim(' ').Substring(7);
                        if (contenido.Contains("%"))
                        {
                            contenido = contenido.Remove(contenido.IndexOf("%"));
                        }
                        string[] listaTemp = contenido.Split(',');
                        int listaTempSize = 0;
                        foreach (var itemC in listaTemp)
                        {
                            if (itemC.Trim(' ') != "")
                            {
                                listaTempSize++;
                            }
                        }
                        if (listaTempSize == ArraySizeClasificacion)
                        {
                            output.Add(indexTemp, contenido.Trim(' '));
                            indexTemp++;
                        }

                    }

                });
            }
            if (tipoNiveles == "preguntas")
            {
                paragraphs.ToList<OpenXmlElement>().ForEach(p =>
                {
                    if (p.InnerText.StartsWith(@"#")) // New Pregunta
                    {
                        contenido = p.InnerText.Trim(' ');
                        if (contenido.Contains("%"))
                        {
                            contenido = contenido.Remove(contenido.IndexOf("%"));
                        }
                        if (contenido.Length > 1)
                        {
                            output.Add(indexTemp, contenido);
                            indexTemp++;
                        }
                    }

                });
            }
            return output;
        }
        static List<string> ListadoDePreguntas(IEnumerable<Paragraph> paragraphs)
        {
            List<string> output = new List<string>();
            paragraphs.ToList<Paragraph>().ForEach(p =>
            {
                if (p.InnerText.StartsWith("#")) // New Pregunta
                {
                    output.Add(p.InnerText);
                }
            });
            return output;
        }
        /**
         * This function iterates over all paragrpahs and groups them into question blocks
         * */
        static List<List<Paragraph>> GroupParagraphs(IEnumerable<Paragraph> paragraphs)
        {
            List<List<Paragraph>> output = new List<List<Paragraph>>();
            List<Paragraph> group = new List<Paragraph>();
            paragraphs.ToList<Paragraph>().ForEach(p =>
            {
                if (p.InnerText.StartsWith("#") && group.Count >= 0) // New Pregunta
                {
                    output.Add(group);
                    group = new List<Paragraph>();
                }
                group.Add(p);
            });
            if (group.Count > 0) // Add last group if exists
            {
                output.Add(group);
                group = new List<Paragraph>();
            }
            return output;
        }
        static List<List<Paragraph>> GrupoClasificacionGeneralDePreguntas(IEnumerable<Paragraph> paragraphs)
        {
            List<List<Paragraph>> output = new List<List<Paragraph>>();
            List<Paragraph> group = new List<Paragraph>();
            paragraphs.ToList<Paragraph>().ForEach(p =>
            {
                if (p.InnerText.StartsWith(@"Clas = [") && group.Count >= 0) // Nuevo Grupo de Clasificacion General
                {
                    output.Add(group);
                    group = new List<Paragraph>();
                }
                group.Add(p);
            });
            if (group.Count > 0) // Add last group if exists
            {
                output.Add(group);
                group = new List<Paragraph>();
            }
            return output;
        }

        static List<List<OpenXmlElement>> GrupoGeneralDePreguntas(IEnumerable<Paragraph> paragraphs)
        {
            List<List<OpenXmlElement>> output = new List<List<OpenXmlElement>>();
            List<OpenXmlElement> group = new List<OpenXmlElement>();
            int conteoClases = 0;
            string conteoDescripcion = "";
            paragraphs.ToList<OpenXmlElement>().ForEach(p =>
            {
                if (p.InnerText.ToLower().StartsWith(@"clas = [")) // New Pregunta
                {
                    conteoDescripcion = "clases";
                    conteoClases++;
                }
               
                if (conteoDescripcion == "clases" && conteoClases == 1)
                {
                    group.Add(p);
                }
            });
            if (conteoDescripcion != "clases")
            {
                paragraphs.ToList<OpenXmlElement>().ForEach(p =>
                {
                    if (p.InnerText.StartsWith(@"#") && conteoClases == 0) // New Pregunta
                    {
                        conteoDescripcion = "parrafos";
                        conteoClases++;
                    }
                    if (conteoDescripcion == "parrafos" && conteoClases == 1)
                    {
                        group.Add(p);
                    }
                });
            }
            if (group.Count > 0) // Add last group if exists
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
                MessageBox.Show("No existen elementos en la lista");
                
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
                MessageBox.Show("No existen elementos en la lista");

            }
        }

        private void MetodoMoverItemLista(ListBox listBox, int direccion) 
        {
            // Checking selected item
            if (listBox.SelectedItem == null || listBox.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = listBox.SelectedIndex + direccion;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listBox.Items.Count)
                return; // Index out of range - nothing to do

            object selected = listBox.SelectedItem;

            // Removing removable element
            listBox.Items.Remove(selected);
            // Insert it in new position
            listBox.Items.Insert(newIndex, selected);
            // Restore selection
            listBox.SetSelected(newIndex, true);
        }
    

        private void MetodoClasificacionTodo(ListBox listBoxPrincipal, ListBox listBoxSecundario, ListBox listBoxALimpiar) {

            listBoxSecundario.Items.AddRange(listBoxPrincipal.Items);
            listBoxPrincipal.Items.Clear();
            listBoxALimpiar.Items.Clear();
        }
                
        private void ListadoNiveles()
        {
            List<string> listadoNivelesList = new List<string>();
            listBoxNiveles.Items.Clear();
            if (tipoNiveles == "clases")
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

            if (tipoNiveles == "preguntas")
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
            // Limpieza de List listaBancoPreguntas
            listaBancoPreguntas.Clear();
            // Limpieza de comboBoxRutaBancoPreguntas
            comboBoxRutaBancoPreguntas.Items.Clear();
            comboBoxRutaBancoPreguntas.ResetText();
            //
        }

        private void PictureBoxMenuEmergente_MouseDown(object sender, MouseEventArgs e)
        {
            // Cambio de color para simular boton del pictureBoxMenuEmergente
            pictureBoxMenuEmergente.Image = TestCreator.Properties.Resources.icons8_eliminar_columna_500;
            //
        }

        private void PictureBoxMenuEmergente_MouseUp(object sender, MouseEventArgs e)
        {
            // Cambio de color para simular boton del pictureBoxMenuEmergente
            pictureBoxMenuEmergente.Image = TestCreator.Properties.Resources.icons8_eliminar_columna_500_cian;
            //
        }

        #endregion

        #region Pestaña Cantidad
        private void PictureBoxIdentificarExamenes_MouseDown(object sender, MouseEventArgs e)
        {
            boolIdentificarExamenes = !boolIdentificarExamenes;
            pictureBoxIdentificarExamenes.Image = boolIdentificarExamenes ? botonSiConTexto : botonNoConTexto;

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
            boolMantenerOriginalEspaciadoPreguntas = !boolMantenerOriginalEspaciadoPreguntas;
            pictureBoxMantenerOriginalEspaciadoPreguntas.Image = boolMantenerOriginalEspaciadoPreguntas ? botonSiConTexto : botonNoConTexto;

        }

        private void PictureBoxMantenerOriginalColumnasRespuestas_MouseDown(object sender, MouseEventArgs e)
        {
            boolMantenerOriginalColumnasRespuestas = !boolMantenerOriginalColumnasRespuestas;
            pictureBoxMantenerOriginalColumnasRespuestas.Image = boolMantenerOriginalColumnasRespuestas ? botonSiConTexto : botonNoConTexto;

        }

        private void PictureBoxMantenerOriginalEspaciadoRespuestas_MouseDown(object sender, MouseEventArgs e)
        {
            boolMantenerOriginalEspaciadoRespuestas = !boolMantenerOriginalEspaciadoRespuestas;
            pictureBoxMantenerOriginalEspaciadoRespuestas.Image = boolMantenerOriginalEspaciadoRespuestas ? botonSiConTexto : botonNoConTexto;

        }

        private void PictureBoxMantenerOriginalNumeracionRespuestas_MouseDown(object sender, MouseEventArgs e)
        {
            boolMantenerOriginalNumeracionRespuestas = !boolMantenerOriginalNumeracionRespuestas;
            pictureBoxMantenerOriginalNumeracionRespuestas.Image = boolMantenerOriginalNumeracionRespuestas ? botonSiConTexto : botonNoConTexto;

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
            boolMantenerOriginalNumeracionPreguntas = !boolMantenerOriginalNumeracionPreguntas;
            pictureBoxMantenerOriginalNumeracionPreguntas.Image = boolMantenerOriginalNumeracionPreguntas ? botonSiConTexto : botonNoConTexto;

        }
        #endregion

        #region Pestaña Solucion
        private void PictureBoxImprimirComentariosPresentacionSolucion_MouseDown(object sender, MouseEventArgs e)
        {
            boolImprimirComentariosPresentacionSolucion = !boolImprimirComentariosPresentacionSolucion;
            pictureBoxImprimirComentariosPresentacionSolucion.Image = boolImprimirComentariosPresentacionSolucion ? botonSiConTexto : botonNoConTexto;

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
            // Cambio de color para simular boton del pictureBoxMenuEmergente
            pictureBoxMenuEmergentePlantilla.Image = TestCreator.Properties.Resources.icons8_eliminar_columna_500;
            //
        }

        private void PictureBoxMenuEmergentePlantilla_MouseUp(object sender, MouseEventArgs e)
        {
            // Cambio de color para simular boton del pictureBoxMenuEmergente
            pictureBoxMenuEmergentePlantilla.Image = TestCreator.Properties.Resources.icons8_eliminar_columna_500_cian;
            //
        }

        #endregion


        

    }
}
