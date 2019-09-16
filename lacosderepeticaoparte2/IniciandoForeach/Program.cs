using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)

            
        {
            Console.WriteLine("infome o seu nome:");
           
            var texto = @"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleção;e;vamos;colocar;isto;{seunome};para;depois;usar;com;o;replace";

            Console.WriteLine("informe a palavra que deseja buscar:");
            var buscaPalavra = Console.ReadLine();

            var conteudoSplit = texto.Split(';');

            foreach (var item in conteudoSplit)
            {
               // Console.WriteLine(item);

                if (buscaPalavra == item)
                    Console.WriteLine("Achou a palavra"); 
            }

            Console.ReadKey();

            {

            }

        }
    }
}
