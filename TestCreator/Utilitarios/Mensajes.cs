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
        public static void ArchivoDeWordSinFormatoPreguntas()
        {
            MessageBox.Show("Archivo de Word sin formato de preguntas","Error de archivo",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public static void NoExistenDatosParaEstructurar()
        {
            MessageBox.Show("No existen datos para estructurar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
