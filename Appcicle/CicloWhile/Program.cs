using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitappText();

            String nome = string.Empty;
            int idade = 0;

            while (AskToContinue() == 1)
            {
                Pergunta1();
                askToName();
            }

          Console.WriteLine($"Diga as tuas informações: Nome{askToName} e idade {Pergunta1} ")
            

        }


        private static void Pergunta1()
        {
            Console.WriteLine("Informe a tua idade");
            var idade = int.Parse ( Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("Tu já é de maior, bora rachar um golêêê pra a gente tomar!!");

            }
            else

            {
                Console.WriteLine(" Tu é de menor, ta querendo que eu beba o que, chá... de cadeia?");
                Console.WriteLine("Vou ligar pra tua mãe pivete");


            }
        }

        //void é um metódo que não retorna a nada,apenas mostra o conteúdo
        /// <summary>
        /// Metodo para mostrar o texto inicial do sistema alone
        /// </summary>
        // Metodo para realizar a pergunta
        // Returns retorna o valor que foi inserido

        private static void ShowInitappText()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Seja bem vindo meu consagrado!");
            Console.WriteLine("******************************");



        }
        private static int AskToContinue()

        private static string askToName;
           /// Metodo para perguntar o nome
           ///Retorna o nome informado
        
            // 2 comandos que realizam uma resposta sem precisar confirmar com o uso do enter: 
            // User Experience e User Interface; permite o aplicativo ficar mais intuitivo.

            //Parse passa o valores informados para int,double,boolean, entre outros;
            //ReadKey aguarda uma única ação do teclado
            //KeyChar Identifica a letra do teclado acionada
            Console.WriteLine("Vamos conversar migu? Sin(1) Naum (2)");
            return int.Parse(Console.ReadKey().KeyChar.ToString());
            
        }
    }
}
