using ListagemDeCervejas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        CervejaContext cervejaContext = new CervejaContext();
        public List<Cerveja> GetCerveja()
        {
            return cervejaContext.ListaDeCerveja;
        }

        public void addCerveja(Cerveja cerveja)
        {
            cervejaContext.ListaDeCerveja.Add(cerveja);
        }

    }


}
