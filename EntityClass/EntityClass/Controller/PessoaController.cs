﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;

namespace EntityClass.Controller
{
    public class PessoaController
    {
        // Realizo minha conexão com o banco de dados
        EntityContextDB contextDB = new EntityContextDB();

        public 
            IQueryable // Aqui temos nossa primeira interface com a classe
                //IQueryable essa classe contem varias funcionalidades
                //prontas para usar igual ao banco de dados com os selects
            <Pessoa> //Definimos o tipo que ira retornar
            GetPessoas() //Damos um nome ao nosso metodo
        {
            return contextDB.listaDePessoas; // retornamos nossa lista de pessoas
        }
        /// <summary>
        /// Metodo para adicionar pessoa no banco de dados
        /// </summary>
        /// <param name="item"></param>
        public void AddPessoa (Pessoa item)
        {
            contextDB. //Nosso banco de dados
                listaDePessoas //Nossa tabela Pessoa
                .Add(item); //Adicionamos o item
            contextDB.SaveChanges(); // Salvamos no banco


        }
    }
}
