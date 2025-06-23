using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        /// <summary>
        /// Faz a pessoa se apresentar com o nome e a idade
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é  {Nome},\nmuito prazer em conhecê-lo! Tenho {Idade} anos!");
        }

    }
}