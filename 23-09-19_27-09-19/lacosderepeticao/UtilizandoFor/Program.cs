using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "Farias Gabriel";
            var countFind = 0;

            Console.WriteLine("Encontre a palavra até 3 caracteres:");
            var palavra = Console.ReadLine();

            for (int i = 0; i < (nome.Length -2); i++) 
            {

                var palavraParacomparar = nome[i].ToString() +
                                          nome[i + 1].ToString() +
                                          nome[i + 2].ToString();

                if (palavra == palavraParacomparar)
                    countFind++;
            }

            Console.WriteLine($"quantidade total de '{palavra}' {countFind}");

        Console.ReadKey();
        }
    }
}
