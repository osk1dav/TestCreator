using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
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
        // Bloques de Grupos de Parrafos segun su clasificacion General
        List<List<Paragraph>> bloqueGeneral;
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
            // Configuracion inicial del ofdAbrirBancoPreguntas
            var ofdAbrirBancoPreguntas = OpenFileDialogPersonalizado.PersonalizadoWord("C:\'Demos\'", "Abrir banco de preguntas");
            
            if (ofdAbrirBancoPreguntas.ShowDialog() == DialogResult.OK)
            {
                // Reseteamos comboBoxRutaBancoPreguntas
                comboBoxRutaBancoPreguntas.Items.Clear();
                //Agregamos a List elementos seleccionados
                listaBancoPreguntas.Add(ofdAbrirBancoPreguntas.FileName);
                //Agregamos items a comboBoxRutaBancoPreguntas filtrando elementos duplicados
                foreach (var item in listaBancoPreguntas.Distinct())
                {
                    comboBoxRutaBancoPreguntas.Items.Add(item);
                }
                comboBoxRutaBancoPreguntas.Text = ofdAbrirBancoPreguntas.FileName;
            }
            string templatePath = comboBoxRutaBancoPreguntas.Text;
            
            
            //List<List<Paragraph>> blocksCopy;


            using (WordprocessingDocument document = WordprocessingDocument.CreateFromTemplate(templatePath))
            {
                var body = document.MainDocumentPart.Document.Body;
                var paragraphs = body.Elements<Paragraph>();

                foreach (var item in ClasificacionGeneralDePreguntas(paragraphs))
                {
                    listBoxClasificacion.Items.Add(item);
                }
                var blocks = GrupoClasificacionGeneralDePreguntas(paragraphs); // Get a List of Question blocks
                bloqueGeneral = blocks.ConvertAll<List<Paragraph>>(g => g.ConvertAll<Paragraph>(p => (Paragraph)p.CloneNode(true))); // Deep Clone

                

            }
        }

        private void ButtonGenerarExamen_Click(object sender, EventArgs e)
        {
            string templatePath = comboBoxRutaBancoPreguntas.Text;
            const string resultPath = @"C:\Demos\PruebaResultado.docx";
            List<List<Paragraph>> blocksCopy;
            using (WordprocessingDocument document = WordprocessingDocument.CreateFromTemplate(templatePath))
            {
                var body = document.MainDocumentPart.Document.Body;
                var paragraphs = body.Elements<Paragraph>();

                foreach (var item in ClasificacionGeneralDePreguntas(paragraphs))
                {
                    listBoxClasificacion.Items.Add(item);
                }

                var blocks = GroupParagraphs(paragraphs); // Get a List of Question blocks
                blocksCopy = blocks.ConvertAll<List<Paragraph>>(g => g.ConvertAll<Paragraph>(p => (Paragraph)p.CloneNode(true))); // Deep Clone
                Random rnd = new Random((int)DateTime.Now.Ticks); // Initialize PRNG with Ticks
                blocksCopy.Shuffle(rnd);
                body.RemoveAllChildren();

                for (var i = 0; i < blocksCopy.Count; i++)
                {

                    ReplaceTexts(blocksCopy[i]);
                    for (var j = 0; j < blocksCopy[i].Count; j++)
                    {
                        body.AppendChild<Paragraph>(blocksCopy[i][j]); // Add paragraph from the reordered list  
                    }
                }

                // Save result document, not modifying the template
                document.SaveAs(resultPath);

            }
        }

        /**
         * This function replaces tokens with Text in a group of paragraphs
         * */
        static void ReplaceTexts(IEnumerable<Paragraph> paragraphs)
        {
            var texts = paragraphs.SelectMany(p => p.Elements<Run>()).SelectMany(r => r.Elements<Text>());

            foreach (Text text in texts)
            {

                switch (text.Text)
                {
                    case "#":
                        text.Text = "PREGUNTA - ";
                        break;
                    case "&":
                        text.Text = "OPCION - ";
                        break;
                    case "&&":
                        text.Text = "RESPUESTA - ";
                        break;
                    case "%%":
                        text.Text = "COMENTARIO -";
                        break;
                }
            }
        }
        
        static List<string> ClasificacionDePreguntas(IEnumerable<Paragraph> paragraphs)
        {
           
            List<string> output = new List<string>();
            char[] charsToTrim = { ' ', ']' };
            string contenido = "";
            paragraphs.ToList<Paragraph>().ForEach(p =>
            {
                if (p.InnerText.StartsWith(@"Clas = ") && !p.InnerText.StartsWith(@"Clas = [")) // New Pregunta
                {
                    contenido = p.InnerText.Trim(charsToTrim);
                    contenido = p.InnerText.Substring(7);
                    output.Add(contenido);
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
            paragraphs.ToList<Paragraph>().ForEach(p => {
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
            paragraphs.ToList<Paragraph>().ForEach(p => {
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
        static List<List<Paragraph>> GrupoClasificacionGeneralDePreguntas(IEnumerable<Paragraph> paragraphs, string textoClasificacionGeneral)
        {
            List<List<Paragraph>> output = new List<List<Paragraph>>();
            List<Paragraph> group = new List<Paragraph>();
            paragraphs.ToList<Paragraph>().ForEach(p => {
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

        static List<string> ClasificacionGeneralDePreguntas(IEnumerable<Paragraph> paragraphs)
        {

            List<string> output = new List<string>();
            char[] charsToTrim = { ' ', ']' };
            string contenido = "";
            paragraphs.ToList<Paragraph>().ForEach(p =>
            {
                if (p.InnerText.StartsWith(@"Clas = [")) // New Pregunta
                {
                    contenido = p.InnerText.Trim(charsToTrim);
                    contenido = contenido.Substring(8);
                    output.Add(contenido);
                }
            });
            return output;
        }

        private void MetodoClasificacion()
        {
            try
            {
                listBoxElegir.Items.Add(listBoxClasificacion.SelectedItem);
                listBoxClasificacion.Items.Remove(listBoxClasificacion.SelectedItem);
                List<string> lista;
                lista = ClasificacionDePreguntas(bloqueGeneral[1]);
                foreach (var item in ClasificacionDePreguntas(bloqueGeneral[1]))
                {
                    lista.Add(item);
                }
                listBoxNiveles.Items.Clear();
                foreach (var item in lista.Distinct())
                {
                    listBoxNiveles.Items.Add(item);
                }
                    
   
                
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

            }
            catch (System.ArgumentNullException)
            {
                MessageBox.Show("Selecciona un elemento de la lista");
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
