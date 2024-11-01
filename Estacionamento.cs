using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormacaoNetDioConsole
{
    class Estacionamento
    {
        public decimal PrecoInicial { get; set; }
        public decimal PrecoPorHora { get; set; }
        public List<string> Veiculo { get; set; } = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public void AdiconarVeiculo()
        {
            //string placa = "";
            Console.Write("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine();
            Veiculo.Add(placa);
        }

        public void RemoverVeiculo()
        {
           
            Console.Write("Digite a placa do veículo para remover: ");
            string placa = Console.ReadLine();

            if (Veiculo.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                int horas = Convert.ToInt32(Console.ReadLine());
                
                decimal valorTotal = (PrecoPorHora * horas) + PrecoInicial;

                Veiculo.Remove(placa);

                Console.WriteLine($"O veículo de placa {placa} foi removido e o preco total é de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine($"Veículo {placa} não encontrado");
            }

        }
        public void ListarVeiculos()
        {
            if (Veiculo.Any())
            {
                Console.WriteLine("Os veículos estacionados são: ");
                foreach (var placa in Veiculo)
                {
                    Console.WriteLine($" {placa}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }

        }
    }
}
