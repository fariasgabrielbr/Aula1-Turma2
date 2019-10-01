using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o seu nome:" + "");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe a sua idade:" + "");

            var idade = int.Parse(Console.ReadLine());

            if (idade <= 18) Console.WriteLine($"Calma jovi {nome} tudo ao seu tempo, logo você terá 18 anos de idade.");

            else Console.WriteLine($"Seja bem vindo {nome}");

            Console.ReadKey();


        }
    }
}