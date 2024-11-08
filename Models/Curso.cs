using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormacaoNetDioConsole.Models
{
    class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public Curso()
        {

        }
        public Curso(string nome)
        {
            Nome = nome;
        }
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            // Metodo remover é possível retornando um tipo. Nesse caso, um boleano
            return Alunos.Remove(aluno);
        }
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            Console.WriteLine();
            foreach (Pessoa nomes in Alunos)
            {
                Console.WriteLine(nomes.NomeCompleto);
            }

            for(int i = 0; i < Alunos.Count; i++)
            {
                //string texto = "Nº " + i + " - " + Alunos[i].NomeCompleto;
                string texto = $"Nº {i + 1} - {Alunos[i].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }

    }
}
