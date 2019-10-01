using Exercicios.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualizacao
{
    class Program
    {
        static void Main(string[] args)
        {
            MarcasController marcasController = new MarcasController();
            marcasController.listar().ForEach(x => Console.WriteLine ($"Id: {x.Id} Carro: {x.Carro} Valor:{x. Valor} Quantidade:{x.Quantidade} Data: {x.Data} "));
            Console.ReadKey();
            Console.WriteLine("Relatorio por mês");
            var meselecionado = Console.ReadKey();
            

        }
    }
}
