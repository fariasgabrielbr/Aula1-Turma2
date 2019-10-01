using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marcaDeCarroeAno
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachWithSplitList();
        }
        private static void ForeachWithSplitList()
        {
            var conteudo = "carro:porshe,marca:Cayenne,ano:2016;carro:chevrolet,marca:Corvette,ano:1975;Carro:nissan,marca:Leaf,ano:2008";

            var informationList = conteudo.Split(';');
            Console.WriteLine("Sistema de busca de veículos");
            foreach (var item in informationList)
            {
                var contentList = item.Split(',');
            }
            Console.WriteLine("Informe um carro:");
            var nomeBusca = Console.ReadLine();
            foreach (var item in informationList)
            {
                var informacoesSplit = item.Split(',');
                var marca = informacoesSplit[0].Split(':')[1];
                var carro = informacoesSplit[1].Split(':')[1];
                var ano = informacoesSplit[2].Split(':')[1];

                if (marca == nomeBusca)
                {
                    Console.WriteLine($" {carro} é um carro da marca {marca} do ano de {ano} ");
                }
            }
            Console.ReadKey();
        }
    }
}
