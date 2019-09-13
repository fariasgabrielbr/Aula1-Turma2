using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome:" +
                           "");



            var nome = Console.ReadLine();
            if (nome == "jair bolsonaro") Console.WriteLine($"Você não é bem vindo, vai tomar no c# {nome}");
            else Console.WriteLine($"Seja bem vindo {nome} ");

            Console.ReadKey();

        }
    }
}
