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
        public Dictionary<string, string> Clase { get; set; } = new Dictionary<string, string>();
        public string Pregunta { get; set; }
        public List<string> Comentario { get; set; } = new List<string>();
        public List<OpenXmlElement> Opciones { get; set; } = new List<OpenXmlElement>();
        public List<OpenXmlElement> Respuestas { get; set; } = new List<OpenXmlElement>();
        
    }
}
