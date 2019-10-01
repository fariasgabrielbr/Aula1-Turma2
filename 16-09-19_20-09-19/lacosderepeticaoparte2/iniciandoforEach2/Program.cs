using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciandoforEach2
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary> metodo busca com split e informando o nome
            // private static void iniciandoforEach2();
            /// </summary> metodo de busca com split e informando o nome
            //  private static void ForeachcomSplit();

            ForeachWithSplitList();

        }

        private static void ForeachWithSplitList()
        {
            var conteudo = "nome:Elora,idade:21;nome:Giomar,idade:75;nome:Eusebio,idade:29";

            var informationList = conteudo.Split(';');
            Console.WriteLine("Usários cadastrados no sistema");

            foreach (var item in informationList)
            {
                Console.WriteLine(item.Split(',')[0]);

            }
            Console.WriteLine("Informe um nome do sistema:");
            var nomeBusca = Console.ReadLine();
            foreach (var item in informationList)
            {
                var informacoesSplit = item.Split(',');
                var nome = informacoesSplit[0].Split(':')[1];
                var idade = informacoesSplit[1].Split(':')[1];

                if (nome == nomeBusca)
                {
                    Console.WriteLine($" {nome} está com {idade} anos de idade");
                }
            }
            Console.ReadKey();
        }
    }
}
