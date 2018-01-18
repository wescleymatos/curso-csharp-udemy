using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = {3, 9, 4, 6, 20, 10, 60, 90, 80, 50};

            var listaFiltrada1 = lista.Where(x => x > 10).OrderBy(x => x);
            var listaFiltrada2 = from a in lista where a < 10 orderby a select a;

            foreach (var item in listaFiltrada1)
            {
                Console.WriteLine(item);
            }

            foreach (var item in listaFiltrada2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
