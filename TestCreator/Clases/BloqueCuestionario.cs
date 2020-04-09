using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;

namespace TestCreator.Clases
{
    public class BloqueCuestionario
    {
        public string UniqueId { get; set; } = Guid.NewGuid().ToString();
        public Dictionary<string, string> Clase { get; private set; } = new Dictionary<string, string>();
        public OpenXmlElement Pregunta { get; set; }
        public List<string> Comentario { get; private set; } = new List<string>();
        public List<OpenXmlElement> Opciones { get; private set; } = new List<OpenXmlElement>();
        public List<OpenXmlElement> Respuestas { get; private set; } = new List<OpenXmlElement>();

    }
}
