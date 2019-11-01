using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCreator
{
    class BloqueCuestionario
    {
        public string Pregunta { get; set; }
        public string Comentario { get; set; }
        public List<string> Opciones { get; set; }
        public List<string> Respuestas { get; set; }

    }
}
