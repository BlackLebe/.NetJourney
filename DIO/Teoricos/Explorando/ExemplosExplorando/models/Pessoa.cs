using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }

        public Pessoa(string nome, string sobrenome)
        {

        }

        private string _nome;
        private int _idade;
        public string Nome
        {

            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }
        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }

                _idade = value;
            }
        }
        
        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public void Informacoes()
        {
            Console.Clear();

            Console.Write("Insira o seu nome: ");
            Nome = Console.ReadLine();

            Console.Write("Insira o seu sobrenome: ");
            Sobrenome = Console.ReadLine();

            Console.Write("Insira a sua idade: ");
            Idade = Convert.ToInt32(Console.ReadLine());
        }
        public void Apresentar()
        {
            Console.Write($"Olá, meu nome é {NomeCompleto}, tenho {Idade} anos");
        }
    }
}