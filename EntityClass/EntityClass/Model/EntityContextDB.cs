using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    class EntityContextDB :
        DbContext //Classe pronta que contem todos os processos
        // de conexão com o banco de dados listagem de tabelas
        // seleção das informações

    {
        public DbSet // Palavra reservada para o Entity que indica
            //que vamos definir uma tabela do nosso banco de dados
            <Pessoa> //Aqui definimos nossa tabala pessoa
            //ou seja especificamos qual de nossas classes será 
            //uma referência de uma tabela no banco de dados
            //ela vai ao banco com o nome que definimos em nossa classe
            listaDePessoas { get; set; } //nesta parte liberamos nossa tabela
        //para acessar
    }
}

