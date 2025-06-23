using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;


namespace ExemplosExplorando.models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void InformacaoCurso()
        {
            Console.Clear();

            Console.Write("Insira o Nome do curso: ");
            Nome = Console.ReadLine();

            Alunos = new List<Pessoa>();
        }
        public void AdicionarAluno(Pessoa aluno)
        {
            aluno.Informacoes();
            Alunos.Add(aluno);
        }

        public int ObterQtddeAlunosMatriculados()
        {
            int quantidade = Alunos.Count();
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos no curso de: {Nome}");

            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}