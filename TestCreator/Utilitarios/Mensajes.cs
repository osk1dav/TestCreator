using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCreator.Utilitarios
{
    public static class Mensajes
    {
        public static string LimpiarBusqueda { get; private set; } = "Limpiar busqueda";
        public static string AbrirBancoPreguntas { get; private set; } = "Abrir banco de preguntas";
        public static string AbrirPlantillaPreguntas { get; private set; } = "Abrir plantilla de examen";
        public static string RutaInicial { get; private set; } = @"D:\Demos\";
        public static string FilterSetWord { get; private set; } = "Archivo de Word (*.docx)|*.docx|All files (*.*)|*.*";
        public static string ArchivoDeWordNoExisteTitle { get; private set; } = "Archivo seleccionado no existe";
        public static string ArchivoDeWordSinFormatoPreguntasTitle { get; private set; } = "Archivo de Word sin formato de preguntas";
        public static string NoExistenDatosParaEstructurarTitle { get; private set; } = "No existen datos para estructurar";
        public static string NoExistenElementosListaTitle { get; private set; } = "No existen elementos en la lista";
        public static string ValorElegidoAlto { get; private set; } = "Valor elegido supera el valor total permitido";
        public static string ErrorDeArchivo { get; private set; } = "Error de archivo";
        public static string Advertencia { get; private set; } = "Advertencia";
        public static string AbrirArchivoGenerado { get; private set; } = "Desea abrir el archivo generado";
        public static string ArchivoGeneradoCorrectamenteTitle { get; private set; } = "Archivo generado correctamente";


        public static void ArchivoDeWordSinFormatoPreguntas()
        {
            MessageBox.Show(ArchivoDeWordSinFormatoPreguntasTitle, ErrorDeArchivo, MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public static void ArchivoDeWordNoExiste()
        {
            MessageBox.Show(ArchivoDeWordNoExisteTitle, ErrorDeArchivo, MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public static void NoExistenDatosParaEstructurar()
        {
            MessageBox.Show(NoExistenDatosParaEstructurarTitle, Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void NoExistenElementosLista()
        {
            MessageBox.Show(NoExistenElementosListaTitle, Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void ValorElegidoMasAltoQueElTotal()
        {
            MessageBox.Show(ValorElegidoAlto, Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
