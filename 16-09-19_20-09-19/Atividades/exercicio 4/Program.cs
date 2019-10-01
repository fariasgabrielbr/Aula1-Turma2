using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um texto:");
            var texto = Console.ReadLine();
            // texto.Length
            Console.WriteLine($"Você tem um total de {texto.Length} caracteres ");
            Console.ReadKey();

        }
    }
}
