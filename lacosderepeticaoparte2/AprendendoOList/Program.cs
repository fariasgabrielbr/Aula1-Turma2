using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoOList
{
    class Program
    {
        static void Main(string[] args);
        
          private static List<string> minhaListaPulgmatica = new List<string>()
            {
                "Felipe",
                "Irineu",
                "Serilop"
            };

            static void Main (string[] args)
            {
                ListaInformacoes();

                Console.ReadKey();
            }

            private static void ListaInformacoes()
            {
            foreach (var item in minhaListaPulgmatica)
                Console.WriteLine(item);

            
            }
        }
    }

