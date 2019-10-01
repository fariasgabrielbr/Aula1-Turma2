using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
   public class CervejaContext
    {
        public List<Cerveja> ListaDeCerveja { get; set; }
        public CervejaContext ()
        {
            ListaDeCerveja = new List<Cerveja>();
            ListaDeCerveja.Add(new Cerveja()
            {
                Id = 1,
                Nome = "Caracu",
                Litros = 350,
                Alcool = 5,
                Valor = 3.79,
            });
            ListaDeCerveja.Add(new Cerveja()
            {
                Id = 2,
                Nome = "Polar",
                Litros = 1000,
                Alcool = 5,
                Valor = 6.69,
            });
            ListaDeCerveja.Add(new Cerveja()
            {
                Id = 3,
                Nome = "Leffe",
                Litros = 330,
                Alcool = 7,
                Valor = 12.00,
            });
            ListaDeCerveja.Add(new Cerveja()
            {
                Id = 4,
                Nome = "Walls",
                Litros = 375,
                Alcool = 9,
                Valor = 19.90,
            });
            ListaDeCerveja.Add(new Cerveja()
            {
                Id = 5,
                Nome = "Goose",
                Litros = 355,
                Alcool = 6,
                Valor = 16.90,
            });
        }
    }
}
