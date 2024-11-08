using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormacaoNetDioConsole.Models
{
    class Reserva
    {
        public List<Pessoa2> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa2> hospedes)
        {

            if(Suite != null && Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade da suíte é insuficiente para o número de hóspedes.");
            }

        }
        public void CadastraSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            return Hospedes?.Count ?? 0;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * (Suite?.ValorDiaria ?? 0);

            if(DiasReservados >= 10)
            {
                valor *= 0.90m;
            }

            return valor;
        }


    }
}
