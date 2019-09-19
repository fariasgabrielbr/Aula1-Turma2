using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using amigosFixo.model;

namespace amigosFixo
{
    class Program
    {
        static void Main(string[] args)
        {

            var meusAmigxs =new List<Amigx>();
            
            meusAmigxs.Add(new Amigx() {
                Nome = "Eduardo",
                TempoAmizade = 5
            });

            meusAmigxs.Add(new Amigx()

            {
                Nome = "Leonardo",
                TempoAmizade = 3

            });

            meusAmigxs.Add(new Amigx
                ()
            {
                Nome = "Will",
                TempoAmizade = 6
            });

            meusAmigxs.ForEach(Amigx => Console.WriteLine($"nome: {Amigx.Nome} tempo de amizade: { Amigx.TempoAmizade}"));

            Console.ReadKey();


        }
    }



}       
