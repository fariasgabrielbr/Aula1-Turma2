using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o seu nome:" +
                "");

            var nome = Console.ReadLine();

            Console.WriteLine ($@"Bem,vindo {nome}, hoje eu vou te contar uma história; Era uma vez uma vaca chamada Gregória e ela morreu, este é o fim da história.
                        Aperte qualquer botão para sair");

            Console.ReadKey();


        }
    }
}
