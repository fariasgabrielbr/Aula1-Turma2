using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 
namespace Listar
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                static CarrosController Controller = new CarrosController();

                static void Main(string[] args)
                {
                    Controller.GetCarros()
                        .ForEach(i => Console.WriteLine($"{i.Id} {i.Marca} {i.Modelo}"));

                    Console.ReadLine();
                }



            }
        }
    }
}
