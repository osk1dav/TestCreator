using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCreator.Clases;
using TestCreator.Utils;

namespace TestCreator.Estructura
{
    public static class ClasificacionDatos
    {
        public static void MetodoClasificacionTodo(ListBox listBoxPrincipal, ListBox listBoxSecundario, ListBox listBoxALimpiar)
        {
            if (listBoxPrincipal != null && listBoxSecundario != null && listBoxALimpiar != null)
            {
                listBoxSecundario.Items.AddRange(listBoxPrincipal.Items);
                listBoxPrincipal.Items.Clear();
                listBoxALimpiar.Items.Clear();
            }
        }

        public static void ObtenerListadoNiveles(ListBox listBoxNiveles, ListBox listBoxElegir, List<BloqueCuestionario> listaBloqueCuestionario, TiposNivel tipoNiveles)
        {
            if (listBoxNiveles != null && listBoxElegir != null && listaBloqueCuestionario != null)
            {
                var listadoNivelesList = new List<string>();
                listBoxNiveles.Items.Clear();
                if (tipoNiveles == TiposNivel.Clases)
                {
                    foreach (var bloque in listaBloqueCuestionario)
                    {
                        string descripcionItem = "";
                        int conteoDescripcion = 0;
                        foreach (var clase in bloque.Clase)
                        {
                            for (int i = 0; i < listBoxElegir.Items.Count; i++)
                            {
                                if (clase.Key.Contains(listBoxElegir.Items[i].ToString()))
                                {
                                    if (conteoDescripcion == 0)
                                    {
                                        descripcionItem += $"{clase.Value}";
                                    }
                                    else
                                    {
                                        descripcionItem += $" - {clase.Value}";
                                    }
                                    conteoDescripcion++;
                                }
                            }
                        }
                        listadoNivelesList.Add(descripcionItem);
                    }
                }

                if (tipoNiveles == TiposNivel.Preguntas)
                {
                    for (int i = 0; i < listBoxElegir.Items.Count; i++)
                    {
                        foreach (var bloque in listaBloqueCuestionario)
                        {
                            listadoNivelesList.Add(bloque.Pregunta.InnerText.Substring(1).Trim(' '));
                        }
                    }
                }

                foreach (var nivel in listadoNivelesList.Distinct())
                {
                    listBoxNiveles.Items.Add(nivel);
                }
            }

        }

        public static void MetodoClasificacion(ListBox listBoxPrincipal, ListBox listBoxSecundario, ListBox listBoxALimpiar)
        {
            if (listBoxPrincipal != null && listBoxSecundario != null && listBoxALimpiar != null)
            {
                if (listBoxPrincipal.Items.Count > 0)
                {
                    var listadoSeleccionado = new List<string>();
                    foreach (object itemSeleccionado in listBoxPrincipal.SelectedItems)
                    {
                        listadoSeleccionado.Add(itemSeleccionado.ToString());
                    }

                    foreach (var item in listadoSeleccionado)
                    {
                        listBoxSecundario.Items.Add(item);
                        listBoxPrincipal.Items.Remove(item);
                    }
                    listBoxALimpiar.Items.Clear();
                }
                else
                {
                    Mensajes.NoExistenElementosLista();
                }
                
            }
        }

    }
}
