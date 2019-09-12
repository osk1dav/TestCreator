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
        //

        private void InicializarInterruptores()
        {
            boolIdentificarExamenes = true;
            boolMantenerOriginalNumeracionPreguntas = true;
            boolMantenerOriginalEspaciadoPreguntas = true;
            boolMantenerOriginalNumeracionRespuestas = true;
            boolMantenerOriginalEspaciadoRespuestas = true;
            boolMantenerOriginalColumnasRespuestas = true;
            boolImprimirComentariosPresentacionSolucion = true;

            pictureBoxMantenerOriginalEspaciadoPreguntas.Image = boolMantenerOriginalEspaciadoPreguntas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;
            pictureBoxImprimirComentariosPresentacionSolucion.Image = boolImprimirComentariosPresentacionSolucion ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;
            pictureBoxMantenerOriginalColumnasRespuestas.Image = boolMantenerOriginalColumnasRespuestas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;
            pictureBoxMantenerOriginalEspaciadoRespuestas.Image = boolMantenerOriginalEspaciadoRespuestas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;
            pictureBoxMantenerOriginalNumeracionRespuestas.Image = boolMantenerOriginalNumeracionRespuestas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;
            pictureBoxMantenerOriginalNumeracionPreguntas.Image = boolMantenerOriginalNumeracionPreguntas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;
            pictureBoxIdentificarExamenes.Image = boolIdentificarExamenes ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;

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
            OpenFileDialog ofdAbrirBancoPreguntas = new OpenFileDialog()
            {
                InitialDirectory = @"C:\Demos\",
                RestoreDirectory = true,
                Title = "Abrir banco de preguntas",
                DefaultExt = "docx",
                Filter = "Archivo de Word (*.docx)|*.docx|All files (*.*)|*.*",
                FilterIndex = 1,
                CheckFileExists = true,
                CheckPathExists = true
            };

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
                //
            }

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
            pictureBoxIdentificarExamenes.Image = boolIdentificarExamenes ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;

        }
        #endregion

        #region Pestaña Numeracion
        private void PictureBoxMantenerOriginalEspaciadoPreguntas_MouseDown(object sender, MouseEventArgs e)
        {
            boolMantenerOriginalEspaciadoPreguntas = !boolMantenerOriginalEspaciadoPreguntas;
            pictureBoxMantenerOriginalEspaciadoPreguntas.Image = boolMantenerOriginalEspaciadoPreguntas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;

        }

        private void PictureBoxMantenerOriginalColumnasRespuestas_MouseDown(object sender, MouseEventArgs e)
        {
            boolMantenerOriginalColumnasRespuestas = !boolMantenerOriginalColumnasRespuestas;
            pictureBoxMantenerOriginalColumnasRespuestas.Image = boolMantenerOriginalColumnasRespuestas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;

        }

        private void PictureBoxMantenerOriginalEspaciadoRespuestas_MouseDown(object sender, MouseEventArgs e)
        {
            boolMantenerOriginalEspaciadoRespuestas = !boolMantenerOriginalEspaciadoRespuestas;
            pictureBoxMantenerOriginalEspaciadoRespuestas.Image = boolMantenerOriginalEspaciadoRespuestas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;

        }

        private void PictureBoxMantenerOriginalNumeracionRespuestas_MouseDown(object sender, MouseEventArgs e)
        {
            boolMantenerOriginalNumeracionRespuestas = !boolMantenerOriginalNumeracionRespuestas;
            pictureBoxMantenerOriginalNumeracionRespuestas.Image = boolMantenerOriginalNumeracionRespuestas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;

        }

        private void PictureBoxMantenerOriginalNumeracionPreguntas_MouseDown(object sender, MouseEventArgs e)
        {
            boolMantenerOriginalNumeracionPreguntas = !boolMantenerOriginalNumeracionPreguntas;
            pictureBoxMantenerOriginalNumeracionPreguntas.Image = boolMantenerOriginalNumeracionPreguntas ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;

        }
        #endregion

        #region Pestaña Solucion
        private void PictureBoxImprimirComentariosPresentacionSolucion_MouseDown(object sender, MouseEventArgs e)
        {
            boolImprimirComentariosPresentacionSolucion = !boolImprimirComentariosPresentacionSolucion;
            pictureBoxImprimirComentariosPresentacionSolucion.Image = boolImprimirComentariosPresentacionSolucion ? TestCreator.Properties.Resources.icons8_alternar_encendido_text_si_96 : TestCreator.Properties.Resources.icons8_alternar_apagado_text_no_96;

        }

        #endregion

        #region Pestaña Examen
        private void ButtonAbrirPlantillaExamen_Click(object sender, EventArgs e)
        {
            // Configuracion inicial del ofdAbrirBancoPreguntas
            OpenFileDialog ofdAbrirPlantillaExamen = new OpenFileDialog()
            {
                InitialDirectory = @"C:\Demos\",
                RestoreDirectory = true,
                Title = "Abrir plantilla de examen",
                DefaultExt = "docx",
                Filter = "Archivo de Word (*.docx)|*.docx|All files (*.*)|*.*",
                FilterIndex = 1,
                CheckFileExists = true,
                CheckPathExists = true
            };
            //

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
