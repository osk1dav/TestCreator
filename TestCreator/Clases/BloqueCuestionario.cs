using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCreator.Clases
{
    public class BloqueCuestionario
    {
        public Dictionary<string, string> Clase { get; private set; } = new Dictionary<string, string>();
        public string Pregunta { get; set; }
        public List<string> Comentario { get; private set; } = new List<string>();
        public List<OpenXmlElement> Opciones { get; private set; } = new List<OpenXmlElement>();
        public List<OpenXmlElement> Respuestas { get; private set; } = new List<OpenXmlElement>();
        
    }
}
