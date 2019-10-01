using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var primeiroTexto = "Oi meu nome Farias e logo eu Farias tenho vontade de codar muito porque eu Farias gosto de codar durante a minha vida";
            primeiroTexto = primeiroTexto.Replace("Farias", "1").Replace("codar", "2");

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contém:{primeiroTexto.Length} caracteres.");
            Console.ReadKey();



        }
    }
}
