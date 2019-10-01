using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicios.Model;

namespace Exercicios.Controller
{
    public class MarcasController
    {

        MarcasContext contextDB = new MarcasContext();

        public List<Marcas> listar()
        {
            return contextDB.listaDeMarcas;
        }
        public List<Marcas> RelatorioMes(int mes)
        {
            return contextDB.listaDeMarcas.FindAll (x => x.Data.Month==mes) ;
        }
            
    }
}
