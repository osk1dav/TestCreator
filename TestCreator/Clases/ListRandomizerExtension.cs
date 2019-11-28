using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCreator.Clases
{
    /**
     * This class Extends the List<T> Generic to allow shuffling using Fisher-Yates shuffle
     * */
    public static class ListRandomizerExtension
    {
        public static void Shuffle<T>(this IList<T> list, Random rnd)
        {
            if (list != null && rnd != null)
            {
                for (var i = 0; i < list.Count - 1; i++)
                {
                    list.Swap(i, rnd.Next(i, list.Count));
                }
            }
            
        }

        public static void Swap<T>(this IList<T> list, int i, int j)
        {
            if (list != null)
            {
                var temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }
    }
}
