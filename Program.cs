using System;
using System.Collections.Generic;
using System.Globalization;
using FormacaoNetDioConsole.Models;

namespace FormacaoNetDioConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Formação .Net DIO 2024");
            Console.WriteLine("**********************");


            Console.WriteLine("Seja bem vindo ao sistema de estacionamento");
            Console.Write("Digite o preco inicial: ");
            decimal precoInicial = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Informe o preço por hora: ");
            decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());

            Estacionamento carro = new Estacionamento(precoInicial, precoPorHora);

            string opcao = string.Empty;
            bool exibirMenu = true;


            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção: ");                
                Console.WriteLine("1 = Cadastrar veículo");
                Console.WriteLine("2 = Remover veículo");
                Console.WriteLine("3 = Listar veículo");
                Console.WriteLine("4 = Encerrar veículo");
                opcao = Console.ReadLine();

                switch (opcao) 
                {
                    case "1":
                        carro.AdiconarVeiculo();
                        break;
                    case "2":
                        carro.RemoverVeiculo();
                        break;
                    case "3":
                        carro.ListarVeiculos();
                        break;
                    case "4":
                        exibirMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();

            }

            Console.WriteLine("O programa se encerrou");

          
        }
    }
}
