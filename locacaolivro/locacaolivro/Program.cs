﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locacaolivro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Texto informativo para consultar o livro pelo numero de registro no sistema
            Console.WriteLine("Informe o livro a ser consultado:");
            //Parte do codigo que recebe as informações de registro do livro e colocar na variavel
            //numeroDoLivro para utilizar
            var numeroDoLivro = Console.ReadLine();
            //Aqui realizo a comparação das informações do livro informado com o que tenho disponivel
            // em estoque
            if (numeroDoLivro == "123456")
            {
                //Informo que este livro já está alocado
                Console.WriteLine("Livro Indisponivel");
                Console.ReadKey();
                //Finaliza o metodo
                return;
            }
            else
            {

                Console.WriteLine("Deseja alocar o livro? (1) SIM (2) NÃO");
                var resposta = Console.ReadLine();
                if(resposta == "1")
                {
                    Console.WriteLine("Livro alocado");
                    Console.ReadKey();
                    return;

                }
            }
            Console.ReadKey();
        }
    }
}
