using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.Models;

namespace Hotel.Models
{
    public class Reserva
    {
        public Reserva() { }
        public Reserva(List<Pessoa> Hospedes, Suite suite, int DiasReservados)
        {
            this.DiasReservados = DiasReservados;
            this.suite = suite;
            this.Hospedes = Hospedes;
        }

        public List<Pessoa> Hospedes = new List<Pessoa>();
        public Suite suite;
        public int DiasReservados { get; set; }

        public decimal DescontoPercentual = 10;



        public void CadastrarHospede(List<Pessoa> hospedes)
        {
            if (this.suite != null && hospedes != null && hospedes.Count > this.suite.Capacidade)
            {

                Console.WriteLine($"Não é possível cadastrar a quantidade informada de hóspedes ({hospedes.Count} pessoas) na suíte {suite.TipoSuite}.");

                throw new ArgumentOutOfRangeException();
            }
            else
            {
                this.Hospedes = hospedes;
            }
        }

        public void CadastrarSuite(Suite suite)
        {

            if (suite != null && this.Hospedes != null && this.Hospedes.Count > suite.Capacidade)
            {

                Console.WriteLine($"Não é possível cadastrar a suíte {suite.TipoSuite} para a quantidade informada de hóspedes.");

                throw new ArgumentOutOfRangeException();

            }
            else
            {
                this.suite = suite;
            }

        }

        public int ObterQuantidadeDeHospedes()
        {
            return this.Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if (this.DiasReservados < 10)
            {
                return (this.DiasReservados * this.suite.ValorDiaria);

            }
            else
            {
                return (this.DiasReservados * this.suite.ValorDiaria) * (1 - DescontoPercentual / 100);

            }

        }

    }
}