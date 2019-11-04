using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestCreator.Properties.Resources;

namespace TestCreator.Clases
{
    public class Interruptores
    {
        public bool boolIdentificarExamenes { get ; set; }
        public bool boolMantenerOriginalNumeracionPreguntas { get ; set; }
        public bool boolMantenerOriginalEspaciadoPreguntas { get ; set; }
        public bool boolMantenerOriginalNumeracionRespuestas { get ; set; }
        public bool boolMantenerOriginalEspaciadoRespuestas { get ; set; }
        public bool boolMantenerOriginalColumnasRespuestas { get ; set; }
        public bool boolImprimirComentariosPresentacionSolucion { get ; set; }
        public Image botonSiConTexto { get; private set; }
        public Image botonNoConTexto { get; private set; }



        public Interruptores()
        {
            boolIdentificarExamenes = true;
            boolMantenerOriginalNumeracionPreguntas = true;
            boolMantenerOriginalEspaciadoPreguntas = true;
            boolMantenerOriginalNumeracionRespuestas = true;
            boolMantenerOriginalEspaciadoRespuestas = true;
            boolMantenerOriginalColumnasRespuestas = true;
            boolImprimirComentariosPresentacionSolucion = true;
            botonSiConTexto = icons8_alternar_encendido_text_si_96;
            botonNoConTexto = icons8_alternar_apagado_text_no_96;


        }
    }
}
