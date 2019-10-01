using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cadastroComListagem.Model;

namespace cadastroComListagem
{
    class Program
    {
        static void Main(string[] args)
        {
            var cadastrarPessoa = new List<Pessoa>();

            Console.WriteLine("Preencha os dados abaixo");
            Console.WriteLine("Informe o seu nome");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe a sua idade");
            var idade =int.Parse(Console.ReadLine());
            Console.WriteLine("Você é do sexo Feminino ou Masculino?");
            var sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Informe a sua altura");
            var altura = double.Parse(Console.ReadLine());
            cadastrarPessoa.Add(new Pessoa()
            {
                Nome = nome,
                Idade = idade,
                Sexo = sexo,
                Altura = altura,

            }); ;

            cadastrarPessoa.ForEach(cadastro => Console.WriteLine($"Nome:{cadastro.Nome} Idade: {cadastro.Idade} Sexo: {cadastro.Sexo} Altura {cadastro.Altura}"));

            Console.ReadKey();
            
        }
    }
}
