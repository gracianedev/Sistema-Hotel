using System;
using Hotel.Models;

// Dados de teste

internal class Program
{
    private static void Main(string[] args)
    {
        Suite Suite1 = new Suite("SuiteMaster", 2, 550M);
        Suite Suite2 = new Suite("Deluxe", 4, 330.90M);

        Pessoa pessoa1 = new Pessoa("Carlos", "da Silva");
        Pessoa pessoa2 = new Pessoa("Ana", "Santos");
        Pessoa pessoa3 = new Pessoa("Yuri", "da Silva");
        Pessoa pessoa4 = new Pessoa("Maria", "de Jesus");


        Reserva reserva1 = new Reserva();

                reserva1.CadastrarSuite(Suite1);


        List<Pessoa> HospedesReserva1 = new List<Pessoa>();
        HospedesReserva1.Add(pessoa1);
        HospedesReserva1.Add(pessoa2);
       // HospedesReserva1.Add(pessoa3);



   
        reserva1.CadastrarHospede(HospedesReserva1);
        reserva1.DiasReservados = 12;


        Console.WriteLine($"Valor total da reserva1: {reserva1.CalcularValorDiaria()}");
        Console.WriteLine($"Total de diárias da reserva1: {reserva1.DiasReservados}");
        Console.WriteLine($"Número total de hóspedes da reserva1: {reserva1.ObterQuantidadeDeHospedes()}");
    }
}