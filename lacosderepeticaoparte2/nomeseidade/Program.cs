using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoList
{
    class Program
    {
        static List<string> minhaListaPulgmatica = new List<String>()
            {
                "Felipe",
                "Irineu",
                "Serilop",
            };
        static void Main(string[] args)
        {

            ListaInformacoes();
            AdicionarItensALista();
            Console.ReadKey();

        }
        /// <summary>
        /// Metodo que adiciona um item a lista
        /// </summary>
        private static void AdicionarItensALista()
        {
            minhaListaPulgmatica.Add(Console.ReadLine());
        }
        /// <summary>
        /// Metodo que mostra a lista
        /// </summary>
        private static void ListaInformacoes()
        {
            foreach (var item in minhaListaPulgmatica) Console.WriteLine(item);
        }
    }
}

