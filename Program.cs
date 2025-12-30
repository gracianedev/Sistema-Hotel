using System;
using System.Linq.Expressions;
using Hotel.Models;

// Dados de teste

internal class Program
{
    private static void Main(string[] args)
    {
        // Declaração de variáveis
        string opcao = "";
        string tipoSuite;
        string capacidade;
        bool controle = true;
        int capacidadeMax;
        string diaria;
        decimal valorDiaria;
        Dictionary<string, Suite> SuitesCadastradas = new Dictionary<string, Suite>();
        Dictionary<string, Reserva> ReservasCadastradas = new Dictionary<string, Reserva>();
        string hospedeNome;
        string hospedeSobrenome;
        string resposta;
        int qtdeDias;
        string nomeCompleto;


        // Menu inicial

        do
        {
            Console.WriteLine(">>> Escolha a opção desejada: <<<\n");
            Console.WriteLine(
                 "1 - Cadastrar Suíte \n"
                + "2 - Criar Nova Reserva \n"
                + "3 - Consultar Reserva \n"
                + "4 - Sair \n"
            );

            opcao = Console.ReadLine();


            switch (opcao)
            {
                case "1":
                    Console.WriteLine("\n--- Cadastrar Suíte ---\n\n");
                    do
                    {
                        Console.WriteLine("Tipo de suíte:");
                        tipoSuite = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(tipoSuite));

                    do
                    {
                        controle = true;
                        Console.WriteLine("Capacidade (número máximo de hóspedes): ");
                        capacidade = Console.ReadLine();
                        if (int.TryParse(capacidade, out capacidadeMax))
                        {
                            controle = false;
                        }
                    } while (controle);

                    do
                    {
                        controle = true;
                        Console.WriteLine("Valor da diária (R$): ");
                        diaria = Console.ReadLine();
                        if (decimal.TryParse(diaria, out valorDiaria))
                        {
                            controle = false;
                        }
                    } while (controle);

                    if (SuitesCadastradas.ContainsKey(tipoSuite))
                        {
                            Console.WriteLine($"\n* * * * Erro: Já existe uma suíte chamada '{tipoSuite}'. * * * *\n");
                        }
                        else
                        {
                            Suite novaSuite = new Suite(tipoSuite, capacidadeMax, valorDiaria);
                            SuitesCadastradas.Add(tipoSuite, novaSuite);
                            Console.WriteLine("\n* * * Suíte Cadastrada com sucesso! * * *\n");
                            opcao = "";
                        }
                      
                    break;

                case "2":
                    Console.WriteLine("\n--- Cadastrar Nova Reserva ---\n");
                    controle = true;
                    List<Pessoa> hospedes = new List<Pessoa> ();
                    Reserva novaReserva = new Reserva();
                    do {
                    Console.WriteLine("\nInforme o primeiro nome do hóspede: ");
                    hospedeNome = Console.ReadLine();
                    Console.WriteLine("Informe o sobrenome do hóspede: ");
                    hospedeSobrenome = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(hospedeNome) && !string.IsNullOrWhiteSpace(hospedeSobrenome))
                        {
                            Pessoa novaPessoa = new Pessoa(hospedeNome, hospedeSobrenome);
                            hospedes.Add(novaPessoa);
                            Console.WriteLine($"\n* * * Hóspede {novaPessoa.Nome} {novaPessoa.Sobrenome} cadastrado com sucesso! * * *\n");

                        } else
                        {
                            Console.WriteLine("\n* * * * Hóspede não cadastrado. O preenchimento dos campos nome e sobrenome é obrigatório. * * * *\n");
                        }

                    Console.WriteLine("Deseja cadastrar mais hóspedes nesssa reserva? ( S / N ) ");
                    resposta = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(resposta) || resposta.ToUpper() != "S")
                        {
                            controle = false;
                        }
                        else
                        {
                            controle = true;
                        }
                    } while (controle);
                    novaReserva.CadastrarHospede(hospedes);

                    controle = true;
                    do {
                    Console.WriteLine("Informe o número de dias da reserva: ");
                    resposta = Console.ReadLine();
                    if (int.TryParse(resposta, out qtdeDias))
                        {
                            controle = false;
                            novaReserva.DiasReservados = qtdeDias;
                        }
                        else
                        {                    
                            Console.WriteLine("\n* * * * Valor inválido! * * * *\n");

                        }

                    } while(controle);

                        Console.WriteLine("Informe o tipo de suíte: ");
                        tipoSuite = Console.ReadLine();
                        if (SuitesCadastradas.ContainsKey(tipoSuite))
                    {
                        Suite suiteSelecionada = SuitesCadastradas[tipoSuite];
                        novaReserva.CadastrarSuite(suiteSelecionada);
                        ReservasCadastradas.Add($"{hospedeNome} {hospedeSobrenome}", novaReserva);
                        Console.WriteLine("\n* * * Reserva cadastrada com sucesso! * * *");
                        Console.WriteLine("\nDados:\n\nHóspedes - ");
                        foreach (Pessoa p in hospedes)
                        {
                            Console.WriteLine($"{p.Nome} {p.Sobrenome}" );
                        }
                        Console.WriteLine($"\nTotal de dias reservados - {novaReserva.DiasReservados} \n");
                        Console.WriteLine($"Tipo de suíte - {suiteSelecionada.TipoSuite} \n\nValor da suíte (por dia) - {suiteSelecionada.ValorDiaria}");
                        Console.WriteLine($"\nValor total da reserva R$ - {novaReserva.CalcularValorDiaria()}\n\n");
                    } else
                    {
                        Console.WriteLine("\n* * * * Suíte não encontrada! * * * *\n");
                     
                    }


                    break;


                case "3":
                    Console.WriteLine("\n--- Consultar Reserva ---\n\n");
                    Console.WriteLine("Informe o nome e o sobrenome do hóspede:");
                    nomeCompleto = Console.ReadLine();
                    if (ReservasCadastradas.ContainsKey(nomeCompleto)){
                        Reserva reservaEncontrada = ReservasCadastradas[nomeCompleto];
                     Console.WriteLine($"\nNúmero de hóspedes - {reservaEncontrada.ObterQuantidadeDeHospedes()} \n");
                     Console.WriteLine("Hóspedes -\n");
                     foreach (Pessoa p in reservaEncontrada.Hospedes)
                        {
                            Console.WriteLine($"{p.Nome} {p.Sobrenome} \n");
                        }
                        Console.WriteLine($"Total de dias reservados - {reservaEncontrada.DiasReservados} \n");
                        Console.WriteLine($"\nTipo de suíte - {reservaEncontrada.suite.TipoSuite} \nValor da suíte (por dia) - {reservaEncontrada.suite.ValorDiaria}");
                        Console.WriteLine($"\nValor total da reserva R$ - {reservaEncontrada.CalcularValorDiaria()}\n\n");
                    } else
                    {
                        Console.WriteLine("\n* * * * Reserva não encontrada! * * * *\n");
                     
                    }

                    break;

                case "4":
                    Console.WriteLine("");
                    break;

                default:
                    Console.WriteLine("\n\n||||| Opção inválida. |||||\n\n");
                    opcao = "";
                    break;
            }


        } while (opcao != "4");


    }
}