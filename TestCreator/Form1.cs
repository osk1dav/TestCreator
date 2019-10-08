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
            var ofdAbrirBancoPreguntas = OpenFileDialogPersonalizado.PersonalizadoWord("C:\'Demos\'", "Abrir banco de preguntas"); // Configuracion inicial del ofdAbrirBancoPreguntas
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
                var blocks = GrupoClasificacionGeneralDePreguntas2(paragraphs); // Get a List of Question blocks
                bloqueGeneral = blocks.ConvertAll<List<OpenXmlElement>>(g => g.ConvertAll<OpenXmlElement>(p => (OpenXmlElement)p.CloneNode(true))); // Deep Clone

                listadoClasificacion = ClasificacionGeneralDePreguntas(paragraphs);
                listadoNiveles = ClasificacionDePreguntas2(blocks[0]);
                
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
                foreach (var itemClasificacion in listadoClasificacion)
                {
                    listBoxClasificacion.Items.Add(itemClasificacion.Value);
                }

            }
        }

        private void ButtonGenerarExamen_Click(object sender, EventArgs e) { }

        private Dictionary<int, string> ClasificacionGeneralDePreguntas(IEnumerable<OpenXmlElement> paragraphs)
        {
            Dictionary<int, string> output = new Dictionary<int, string>();
            paragraphs.ToList<OpenXmlElement>().ForEach(p =>
            {
                if (p.InnerText.ToLower().StartsWith(@"clas = [") && output.Count < 1) // New Pregunta
                {
                    string[] listaTemp = p.InnerText.Trim(' ').Remove(p.InnerText.IndexOf("]")).Substring(8).Split(',');
                    ArraySizeClasificacion = listaTemp.Length;
                    int indexTemp = 0;
                    foreach (var item in listaTemp)
                    {
                        output.Add(indexTemp, item.Trim(' '));
                        indexTemp++;
                    }
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

        private Dictionary<int, string> ClasificacionDePreguntas2(IEnumerable<OpenXmlElement> paragraphs)
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

        static List<List<OpenXmlElement>> GrupoClasificacionGeneralDePreguntas2(IEnumerable<Paragraph> paragraphs)
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
            if (group.Count > 0) // Add last group if exists
            {
                output.Add(group);
                group = new List<OpenXmlElement>();
            }
            return output;
        }
        static List<List<Paragraph>> GrupoClasificacionGeneralDePreguntas(IEnumerable<Paragraph> paragraphs, string textoClasificacionGeneral)
        {
            List<List<Paragraph>> output = new List<List<Paragraph>>();
            List<Paragraph> group = new List<Paragraph>();
            paragraphs.ToList<Paragraph>().ForEach(p =>
            {
                if (p.InnerText.StartsWith($"Clas = [{textoClasificacionGeneral}]") && group.Count >= 0) // Nuevo Grupo de Clasificacion General
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



        private void MetodoClasificacion()
        {
            try
            {
                listBoxElegir.Items.Add(listBoxClasificacion.SelectedItem);
                listBoxClasificacion.Items.Remove(listBoxClasificacion.SelectedItem);
                listBoxClasificacion.Sorted = true;
                listBoxElegir.Sorted = true;
                ListadoNiveles();
            }
            catch (System.ArgumentNullException)
            {
                MessageBox.Show("Selecciona un elemento de la lista");
            }
        }
        private void MetodoDesclasificacion()
        {
            try
            {
                listBoxClasificacion.Items.Add(listBoxElegir.SelectedItem);
                listBoxElegir.Items.Remove(listBoxElegir.SelectedItem);
                listBoxClasificacion.Sorted = true;
                listBoxElegir.Sorted = true;
                ListadoNiveles();
            }
            catch (System.ArgumentNullException)
            {
                MessageBox.Show("Selecciona un elemento de la lista");
            }
        }

        private void ListadoNiveles()
        {
            List<string> listadoNivelesList = new List<string>();
            listBoxNiveles.Items.Clear();
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
            foreach (var nivel in listadoNivelesList.Distinct())
            {
                listBoxNiveles.Items.Add(nivel);
            }
            
        }
        private void ButtonClasificacionItemElegir_Click(object sender, EventArgs e)
        {
            MetodoClasificacion();

        }


        private void ListBoxClasificacion_DoubleClick(object sender, EventArgs e)
        {
            MetodoClasificacion();
        }

        private void ButtonClasificacionItemQuitar_Click(object sender, EventArgs e)
        {
            MetodoDesclasificacion();
        }

        private void ListBoxElegir_DoubleClick(object sender, EventArgs e)
        {
            MetodoDesclasificacion();
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
            var ofdAbrirPlantillaExamen = OpenFileDialogPersonalizado.PersonalizadoWord("C:\'Demos\'", "Abrir plantilla de examen");

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
