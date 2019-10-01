using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListagemDeCarros.Model
{
   public class SpecsContext
    {
        public List<Specs> ListaDeSpecs { get; set; }

        public SpecsContext()
        {
            ListaDeSpecs.Add(new Specs() {

               
                Id = 1,
                Marca = "Corvette",
                Modelo = "Chevrollet",
                Ano = 1990,
                Cilindradas = 200, 
                Portas = 2
            });
        }
            
            
           


    }
}
