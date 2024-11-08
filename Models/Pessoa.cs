using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormacaoNetDioConsole
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome
        {
            //get  => _nome.ToUpper(); // Sintaxe utilizada substituindo o return que Body explession 
            get
            {
                return _nome.ToUpper();
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }

        public Pessoa() { }

        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string Apresentar()
        {
            return $"Nome: {NomeCompleto}\nIdade: {Idade} anos.";
        }
    }
}
