using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Model
{
    public class MarcasContext
    {
        public List<Marcas> listaDeMarcas = null;
        public MarcasContext()
        {
            listaDeMarcas = new List<Marcas>() {
             new Marcas()
            {
                Id = 1,
                Carro = "Risus Company",
                Valor = 7.200,
                Quantidade = 18,
                Data = DateTime.Parse("29/01/2019")
            }
            ,
            new Marcas()
            {
                Id = 2,
                Carro = "Risus Associates",
                Valor = 9.961,
                Quantidade = 4,
                Data = DateTime.Parse("10/02/2019")
            },
             new Marcas()
             {
                 Id = 3,
                 Carro = "Et Libero Proin Foundation",
                 Valor = 8.710,
                 Quantidade = 17,
                 Data = DateTime.Parse("24/01/2019")
             },
             new Marcas()
             {
                 Id = 4,
                 Carro = "Cursus Et Ltd",
                 Valor = 9.010,
                 Quantidade = 17,
                 Data = DateTime.Parse("26/10/2019")

             },
             new Marcas()
             {
                 Id = 5,
                 Carro = "Odio Etiam Ligula Company",
                 Valor = 5.245,
                 Quantidade = 8,
                 Data = DateTime.Parse("16/02/2019")
             }
           };
        }
    }
}
