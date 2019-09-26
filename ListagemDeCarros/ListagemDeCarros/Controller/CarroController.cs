using ListagemDeCarros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Controller
{ 
    public class CarroController
    {
        SpecsContext specsContext = new SpecsContext();
        public List <Specs> GetSpecs ()
        {
            return specsContext.ListaDeSpecs;
        }
    }
}
