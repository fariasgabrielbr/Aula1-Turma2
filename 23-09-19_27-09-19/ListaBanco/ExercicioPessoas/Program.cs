using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            var listadePessoa = new List<Pessoa>();

            listadePessoa.Add(new Pessoa()
            {
                Id = 1,
                Nome = "Spears",
                DataNascimento = DateTime.Parse("07/11/2004"),
                Carteira = 846.96

            });
            listadePessoa.Add(new Pessoa()
            {

                Id = 2,
                Nome = "Swanson",
                DataNascimento = DateTime.Parse("20/06/2003"),
                Carteira = 233.09

            });
            listadePessoa.Add(new Pessoa()
            {
                Id = 3,
                Nome = "Gay",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 911.92


            });

            listadePessoa.OrderBy(x => x.Nome).ToList<Pessoa>().
               ForEach(i =>
               Console.WriteLine($" Nome: {i.Nome}"));
            Console.WriteLine("-----------------------------");

            Console.ReadKey();

            listadePessoa.OrderByDescending(x => x.DataNascimento).ToList<Pessoa>().
                ForEach(i =>
                Console.WriteLine($"Data de nascimento: {i.DataNascimento}"));
            Console.WriteLine("------------------------------");

            Console.ReadKey();


            listadePessoa.FindAll(x => x.Carteira > 500).ForEach(i =>
         Console.WriteLine($"Carteira: {i.Carteira}"));
            Console.WriteLine("-------------------------------");
            Console.ReadKey();

        }
    }
}
