using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Random rdm = new Random();

            for (int i = 0; i < 10; i++)
            {
                int valorGeradoAleatoriamente = rdm.Next(100);
                numeros.Add(valorGeradoAleatoriamente);
          

            }
            Console.ReadLine();


        }
    }
}
