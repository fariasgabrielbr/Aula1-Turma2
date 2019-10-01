using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestoDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cestaDeFrutas =new List<Fruta>();

            //Tomate
            cestaDeFrutas.Add (new Fruta()
            {
                Id = 0,
                Nome = "Tomate",
                Cor =  "Vermelho",
                Peso = 212
            });
            //Goiaba
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 1,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95,
            });
            //Manga
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Manga",
                Cor = "Amarela",
                Peso = 300,
            });

            cestaDeFrutas.
                OrderByDescending(x => x.Id).ToList<Fruta>().
                ForEach(i =>
                Console.WriteLine($"Id {i.Id} Nome: {i.Nome}"));

            Console.WriteLine("-------------------------------");

            var filtroCesta = cestaDeFrutas.Where(x => x.Peso > 100).OrderBy(x => x.Nome).ToList<Fruta>();



            filtroCesta.ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome {i.Nome} Peso {i.Peso}"));

            (from frutinha in cestaDeFrutas
            where frutinha.Peso >100
            select frutinha). ToList<Fruta>()
                .ForEach(i => Console.WriteLine($"Fruta escolhida {i.Nome} "));


            Console.ReadKey();


        }
    }
}
