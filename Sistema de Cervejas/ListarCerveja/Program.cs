using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;

namespace ListarCerveja
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            cervejaController.addCerveja(new Cerveja() { Id = 6,Nome  = "Stella Artois", Litros = 310, Alcool =  6, Valor = 6.80   });

            cervejaController.GetCerveja().ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} Litros: {i.Litros}ml  Teor Alcoolico: {i.Alcool}% Preço: R$ {i.Valor} "));
            Console.ReadKey();

            
        





        }
    }
}
