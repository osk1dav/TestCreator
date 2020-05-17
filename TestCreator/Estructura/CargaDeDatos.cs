using System;
using System.Collections.Generic;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Globalization;
using System.Linq;
using TestCreator.Clases;
using TestCreator.Utils;

namespace TestCreator.Estructura
{
    public static class CargaDeDatos
    {
        private static CultureInfo CultureInfo { get; set; } = new CultureInfo("es-EC");
        public static TiposNivel TipoNiveles { get; set; }
        public static BloqueCuestionario BloqueCuestionario { get; set; } = new BloqueCuestionario();
        public static List<BloqueCuestionario> ListaBloqueCuestionario { get; private set; } = new List<BloqueCuestionario>();


        public static void CargarContenidoListboxs(string rutaBancoPreguntas)
        {
            BloqueCuestionario = new BloqueCuestionario();
            ListaBloqueCuestionario.Clear();
            try
            {
                using (WordprocessingDocument document = WordprocessingDocument.CreateFromTemplate(rutaBancoPreguntas))
                {
                    var body = document.MainDocumentPart.Document.Body;
                    var parrafos = body.Elements<Paragraph>();
                    var listaXTipoDeNivel = ObtenerListaXTipoDeNivel(parrafos);
                    ListaBloqueCuestionario = ObtenerListaBloqueCuestionario(listaXTipoDeNivel);
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Mensajes.ArchivoDeWordNoExiste();
            }

        }

        private static List<OpenXmlElement> ObtenerListaXTipoDeNivel(IEnumerable<Paragraph> paragraphs)
        {
            var grupoParrafos = new List<OpenXmlElement>();
            int conteoClases = 0;
            int conteoPreguntas = 0;
            TipoNiveles = TiposNivel.SinFormato;
            paragraphs.ToList<OpenXmlElement>().ForEach(p =>
            {
                if (p.InnerText.ToLower(CultureInfo).StartsWith(@"clas = [", StringComparison.CurrentCulture)) // Busqueda de Clasificacion General
                {
                    conteoClases++;
                }
                if (conteoClases == 1) // Se valida que solo se registre una sola Clasificacion General
                {
                    TipoNiveles = TiposNivel.Clases;
                    grupoParrafos.Add(p);
                }
            });
            if (TipoNiveles == TiposNivel.SinFormato)
            {
                paragraphs.ToList<OpenXmlElement>().ForEach(p =>
                {
                    if (p.InnerText.StartsWith(@"#", StringComparison.CurrentCulture)) // Busqueda de Preguntas cuando no se registra Clasificacion General
                    {
                        conteoPreguntas++;
                        grupoParrafos.Add(p); // Se agrega las preguntas al grupo de parrafos
                    }
                    if (conteoPreguntas == 1)
                    {
                        TipoNiveles = TiposNivel.Preguntas;
                    }
                });
            }
            if (TipoNiveles == TiposNivel.SinFormato)
            {
                grupoParrafos = new List<OpenXmlElement>();
                Mensajes.ArchivoDeWordSinFormatoPreguntas();
            }
            return grupoParrafos;
        }

        private static List<BloqueCuestionario> ObtenerListaBloqueCuestionario(IEnumerable<OpenXmlElement> paragraphs)
        {
            var listaSalida = new List<BloqueCuestionario>();
            var keyClase = new List<string>();
            var valueClase = new List<string>();
            int SizeKeyClasificacion = 0;
            int SizeValueClasificacion = 0;
            paragraphs.ToList<OpenXmlElement>().ForEach(p =>
            {
                if (TipoNiveles == TiposNivel.Clases)
                {
                    if (p.InnerText.ToLower(CultureInfo).StartsWith(@"clas = [", StringComparison.CurrentCulture))
                    {
                        keyClase.AddRange(p.InnerText.Remove(p.InnerText.IndexOf("]", StringComparison.CurrentCulture)).Substring(8).Split(','));
                        SizeKeyClasificacion = keyClase.Count;
                    }
                    else if (p.InnerText.ToLower(CultureInfo).StartsWith(@"clas = ", StringComparison.CurrentCulture))
                    {
                        valueClase = new List<string>();
                        SizeValueClasificacion = 0;
                        string contenido = p.InnerText.Trim(' ').Substring(7);
                        if (contenido.Contains("%")) contenido = contenido.Remove(contenido.IndexOf("%", StringComparison.CurrentCulture));
                        valueClase.AddRange(contenido.Split(','));
                        foreach (var value in valueClase)
                        {
                            if (value.Trim(' ').Length > 0)
                            {
                                SizeValueClasificacion++;
                            }
                        }
                    }

                    if (p.InnerText.StartsWith(@"#", StringComparison.CurrentCulture))
                    {
                        if (SizeKeyClasificacion == SizeValueClasificacion)
                        {
                            if (BloqueCuestionario.Pregunta != null)
                            {
                                listaSalida.Add(BloqueCuestionario);
                            }
                            BloqueCuestionario = new BloqueCuestionario();
                            for (int i = 0; i < SizeKeyClasificacion; i++)
                            {
                                BloqueCuestionario.Clase.Add(keyClase[i].Trim(' '), valueClase[i].Trim(' '));
                            }
                            BloqueCuestionario.Pregunta = p;
                        }
                    }

                    if (p.InnerText.StartsWith(@"%%", StringComparison.CurrentCulture)) { BloqueCuestionario.Comentario.Add(p.InnerText); }
                    if (p.InnerText.StartsWith(@"&", StringComparison.CurrentCulture)) { BloqueCuestionario.Opciones.Add(p); }
                    if (p.InnerText.StartsWith(@"&&", StringComparison.CurrentCulture)) { BloqueCuestionario.Respuestas.Add(p); }
                }
                else if (TipoNiveles == TiposNivel.Preguntas)
                {
                    if (p.InnerText.StartsWith(@"#", StringComparison.CurrentCulture))
                    {
                        if (BloqueCuestionario.Pregunta != null)
                        {
                            listaSalida.Add(BloqueCuestionario);
                        }
                        BloqueCuestionario = new BloqueCuestionario();
                        BloqueCuestionario.Clase.Add(TiposNivel.Preguntas.ToString(), TiposNivel.Preguntas.ToString());
                        BloqueCuestionario.Pregunta = p;
                    }

                    if (p.InnerText.StartsWith(@"%%", StringComparison.CurrentCulture)) { BloqueCuestionario.Comentario.Add(p.InnerText); }
                    if (p.InnerText.StartsWith(@"&", StringComparison.CurrentCulture)) { BloqueCuestionario.Opciones.Add(p); }
                    if (p.InnerText.StartsWith(@"&&", StringComparison.CurrentCulture)) { BloqueCuestionario.Respuestas.Add(p); }
                }
            });

            if (BloqueCuestionario.Pregunta != null) { listaSalida.Add(BloqueCuestionario); }

            /*
            Depurar Lista de Preguntas - Inicio
            */
            var lista = new List<BloqueCuestionario>();
            foreach (var bloque in listaSalida)
            {
                if (bloque.Pregunta.InnerText.Trim(' ').Length > 1) { lista.Add(bloque); }
            }
            listaSalida.Clear();
            listaSalida = lista;
            /*
            Depurar Lista de Preguntas - Fin
            */

            return listaSalida;
        }


    }
}
