using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using FormacaoNetDioConsole.Models;
using Newtonsoft.Json;

namespace FormacaoNetDioConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Formação .Net DIO 2024");
            Console.WriteLine("**********************");


            List<Pessoa2> hospedes = new List<Pessoa2>();

            Pessoa2 p1 = new Pessoa2(nome: "Hóspede 1");
            Pessoa2 p2 = new Pessoa2(nome: "Hóspede 2");

            hospedes.Add(p1);
            hospedes.Add(p2);

            Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

            Reserva reserva = new Reserva(diasReservados: 5);
            reserva.CadastraSuite(suite);
            reserva.CadastrarHospedes(hospedes);

            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");













            //bool? querReceberEmail = null;

            //if(querReceberEmail.HasValue && querReceberEmail.Value)
            //{
            //    Console.WriteLine("Usuário optou por receber email");
            //}
            //else
            //{
            //    Console.WriteLine("Usuário optou por não receber email");
            //}



            //// Deserealizando Json => Objeto

            //string path = @"E:\FormacaoNetDioConsole\FormacaoNetDioConsole\FormacaoNetDioConsole\Arquivos\ListaVendas.json";

            //string listaVenda = File.ReadAllText(path);

            //List<Venda> lista = JsonConvert.DeserializeObject<List<Venda>>(listaVenda);

            //foreach (Venda item in lista)
            //{
            //    Console.WriteLine($"Id {item.Id}, Produto: {item.Produto}, Preço: {item.Preco}, Data de Venda: {item.DataVenda.ToString("dd/MM/yyy HH:mm")}");
            //}

            //// Serealizando Objeto => Json

            //DateTime dataAtual = DateTime.Now;

            //List<Venda> listaVendas = new List<Venda>();

            //Venda v1 = new Venda(1, "Caneta", 5.50m, dataAtual);
            //Venda v2 = new Venda(2, "Lapís", 3.50m, dataAtual);
            //Console.WriteLine($"Id: {v1.Id}\nProduto: {v1.Produto}\nPreco: {v1.Preco:c}");

            //listaVendas.Add(v1);
            //listaVendas.Add(v2);

            // Serializando o arquivo para .json
            //string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

            //// Salvando o arquivo serealizado

            //string path = @"E:\FormacaoNetDioConsole\FormacaoNetDioConsole\FormacaoNetDioConsole\Arquivos\ListaVendas.json";

            //File.WriteAllText(path, serializado);

            //Console.WriteLine(serializado);


            // Formatando valores monetários


            //Dictionary<string, string> estados = new Dictionary<string, string>();
            //estados.Add("PE", "Pernanbuco");
            //estados.Add("SP", "São Paulo");

            //foreach(KeyValuePair<string, string> estado in estados)
            //{
            //    Console.WriteLine($"Chave: {estado.Key} - Valor: {estado.Value}");
            //}

            //estados.Remove("SP");
            //estados["PE"] = "Pernanbuco - Valor alterado";

            //Console.WriteLine("Resultado após alteração: ");

            //foreach (KeyValuePair<string, string> estado in estados)
            //{
            //    Console.WriteLine($"Chave: {estado.Key} - Valor: {estado.Value}");
            //}

            //if (estados.ContainsKey("AL"))
            //{
            //    Console.WriteLine("Valor já existente");
            //}
            //else
            //{
            //    estados.Add("AL", "Alagoas");
            //}

            //foreach (KeyValuePair<string, string> estado in estados)
            //{
            //    Console.WriteLine($"Chave: {estado.Key} - Valor: {estado.Value}");
            //}


            //try
            //{
            //    string path = @"E:\FormacaoNetDioConsole\FormacaoNetDioConsole\FormacaoNetDioConsole\Arquivos\Leitura.txt";

            //    string[] leitura = File.ReadAllLines(path);

            //    foreach (string arquivo in leitura)
            //    {
            //        Console.WriteLine(arquivo);
            //    }
            //}
            //catch (ArgumentException e )
            //{
            //    throw new ArgumentException("Arquivo não pode ser encontrado. Detalhes " + e.Message);
            //}
            //catch (Exception e)
            //{
            //    throw new Exception(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Chegou até aqui.");
            //}

            //decimal valorMonetario = 1582.65M;
            //DateTime dataAtual = DateTime.Now;
            //Console.WriteLine($"Valor: {valorMonetario:C}\nData/Hora: {dataAtual}");


            //int numero1 = 10;
            //int numero2 = 20;

            //int resultado = numero1 + numero2;

            //Console.WriteLine(resultado);



            //Pessoa p1 = new Pessoa();
            //p1.Nome = "Márcio";
            //p1.Sobrenome = "Rodrigo";
            //p1.Idade = 46;

            //Pessoa p2 = new Pessoa
            //{
            //    Nome = "Jouze",
            //    Sobrenome = "Katy",
            //    Idade = 46
            //};

            //Pessoa p3 = new Pessoa("Neymar", "Gato");

            //Curso cursodeIngles = new Curso();
            //cursodeIngles.Nome = "Inglês";
            //cursodeIngles.Alunos = new List<Pessoa>();

            //cursodeIngles.AdicionarAluno(p1);
            //cursodeIngles.AdicionarAluno(p2);
            //cursodeIngles.AdicionarAluno(p3);

            //cursodeIngles.ListarAlunos();

        }
    }
}
