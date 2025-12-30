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



        // Menu inicial

        do
        {
            Console.WriteLine("Escolha a opção desejada:");
            Console.WriteLine(
                 "1 - Cadastrar Suíte \n"
                + "2 - Criar Nova Reserva \n"
                + "3 - Cadastrar Hóspedes \n"
                + "4 - Consultar Reserva \n"
                + "5 - Sair \n"
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
                            Console.WriteLine($"\n* * * Erro: Já existe uma suíte chamada '{tipoSuite}'. * * *\n");
                        }
                        else
                        {
                            Suite novaSuite = new Suite(tipoSuite, capacidadeMax, valorDiaria);
                            SuitesCadastradas.Add(tipoSuite, novaSuite);
                            Console.WriteLine("* * * Suíte Cadastrada com sucesso! * * *");
                            opcao = "";
                        }
                      
                    break;

                case "2":
                    Console.WriteLine("");
                    break;

                case "3":
                    Console.WriteLine("");
                    break;

                case "4":
                    Console.WriteLine("");
                    break;

                case "5":
                    Console.WriteLine("");
                    break;

                default:
                    Console.WriteLine("||||| Opção inválida. |||||");
                    opcao = "";
                    break;
            }


        } while (opcao != "5");


    }
}