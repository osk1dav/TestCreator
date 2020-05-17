using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCreator.Utils
{
    public static class RutaOFD
    {
        public static string DirectorioInicial { get; set; } = @"D:\Demos\";
        public static string Titulo { get; set; } = "Abrir banco de preguntas";

        public static OpenFileDialog RutaOpenFileDialog()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = DirectorioInicial;
                ofd.RestoreDirectory = true;
                ofd.Title = Titulo;
                ofd.DefaultExt = "docx";
                ofd.Filter = "Archivo de Word (*.docx)|*.docx|All files (*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;

                return ofd;
            };
        }
    }
}
