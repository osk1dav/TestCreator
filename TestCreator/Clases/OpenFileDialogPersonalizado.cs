using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCreator
{
     public class OpenFileDialogPersonalizado
    {
        public static OpenFileDialog PersonalizadoWord(string directorioInicial, string titulo)
        {
            var ofd = new OpenFileDialog()
            {
                InitialDirectory = directorioInicial,
                RestoreDirectory = true,
                Title = titulo,
                DefaultExt = "docx",
                Filter = "Archivo de Word (*.docx)|*.docx|All files (*.*)|*.*",
                FilterIndex = 1,
                CheckFileExists = true,
                CheckPathExists = true,
            };
            return ofd;
        }
    }
}
