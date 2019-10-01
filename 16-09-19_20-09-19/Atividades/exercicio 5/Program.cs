using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe uma palavra");
            var palavra = Console.ReadLine();
            var tamanhoPalavra = palavra.Length;
            var primeiraletra = palavra[0];
            var ultimaletra = palavra[tamanhoPalavra - 1];
            // Posições das palavras começam em 0, então para se encontrar a última,basta
            // você utilizar a variavel -1
            Console.WriteLine($"a primeira palavra é {primeiraletra}, e a última é {ultimaletra}");
            Console.ReadKey();

        }
    }
}
