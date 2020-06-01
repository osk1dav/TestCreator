using System;
using System.Collections.Generic;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCreator.Utils;
using System.Diagnostics;
using System.Globalization;
using TestCreator.Clases;

namespace TestCreator
{
    public partial class Main : Form
    {
        private CultureInfo CultureInfo { get; set; } = new CultureInfo("es-EC");
        private int NumericExamenesCDEValue { get; set; }
        private int NumericCopiasCDEValue { get; set; }
        private readonly Estructura.Formulario formularioEstructura = new Estructura.Formulario();
        private readonly Cantidad.Formulario formularioCantidad = new Cantidad.Formulario();
        private readonly Numeracion.Formulario formularioNumeracion = new Numeracion.Formulario();
        private readonly Solucion.Formulario formularioSolucion = new Solucion.Formulario();
        private readonly Examen.Formulario formularioExamen = new Examen.Formulario();

        public Main()
        {
            InitializeComponent();
            MostrarFormulario(formularioEstructura);
        }
        private void MostrarFormulario(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.Parent = container.Panel2;
            formulario.Show();
            formulario.BringToFront();
        }

        private void ButtonEstructura_Click(object sender, EventArgs e)
        {
            MostrarFormulario(formularioEstructura);
        }

        private void ButtonCantidad_Click(object sender, EventArgs e)
        {
            MostrarFormulario(formularioCantidad);
        }

        private void ButtonNumeracion_Click(object sender, EventArgs e)
        {
            MostrarFormulario(formularioNumeracion);
        }

        private void ButtonSolucion_Click(object sender, EventArgs e)
        {
            MostrarFormulario(formularioSolucion);
        }

        private void ButtonExamen_Click(object sender, EventArgs e)
        {
            MostrarFormulario(formularioExamen);
        }

        private void ButtonGenerarExamen_Click(object sender, EventArgs e)
        {
            if (formularioCantidad.NumericExamenesCDEValue > 0)
            {
                GenerarExamen(formularioCantidad.NumericExamenesCDEValue, formularioCantidad.NumericCopiasCDEValue);
            } else
            {
                GenerarExamen();
            }
        }

        private void GenerarExamen(int cantidadExamenes = 1, int cantidadCopias = 1)
        {

            string resultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString(CultureInfo) + "\\Test.docx";
            using (WordprocessingDocument document = WordprocessingDocument.Create(resultPath, WordprocessingDocumentType.Document))
            {
                var diccionarioBloqueCuestionarioCopy = new Dictionary<string, BloqueCuestionario>();
                var listBloqueCuestionarioCopy = new List<BloqueCuestionario>();
                // listaBloqueCuestionarioCopy = listaBloqueCuestionario;
                diccionarioBloqueCuestionarioCopy = formularioEstructura.DiccionarioBloqueCuestionarioEstructurado;
                listBloqueCuestionarioCopy = diccionarioBloqueCuestionarioCopy.Values.ToList();
                MainDocumentPart mainPart = document.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());
                int contadorNumberingId = 0;
                for (int i = 0; i < cantidadExamenes; i++)
                {
                    if (true)
                    {
                        Random rnd = new Random((int)DateTime.Now.Ticks);

                        listBloqueCuestionarioCopy.Shuffle(rnd);
                    }

                    for (int j = 0; j < cantidadCopias; j++)
                    {
                        if (i > 0 || j > 0) { InsertarSaltoDePagina(body); }
                        contadorNumberingId++;
                        foreach (var item in diccionarioBloqueCuestionarioCopy.Values)
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
                            run.AppendChild(new Text(item.Pregunta.InnerText.Substring(1).Trim(' ')));
                        }
                    }
                }
            }
            if (formularioEstructura.DiccionarioBloqueCuestionarioEstructurado.Count > 0)
            {
                if (MessageBox.Show(Mensajes.AbrirArchivoGenerado + "\n" + resultPath, Mensajes.ArchivoGeneradoCorrectamenteTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "WINWORD.EXE";
                    startInfo.Arguments = resultPath;
                    Process.Start(startInfo);
                }
            }
            else
            {
                Mensajes.NoExistenDatosParaEstructurar();
            }
        }

        private static void InsertarSaltoDePagina(Body body)
        {
            Paragraph para1 = body.AppendChild(new Paragraph());
            Run run1 = para1.AppendChild(new Run());
            run1.AppendChild(new Break() { Type = BreakValues.Page });
        }

    }
}
