// See https://aka.ms/new-console-template for more information

using System;
using System.Text.Json;
using EadAula03;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            int opcao = 0;

            while (opcao != 5)
            {
                Console.WriteLine("1 - Adicionar funcionário");
                Console.WriteLine("2 - Ver funcionários");
                Console.WriteLine("3 - Ver salário");
                Console.WriteLine("4 - Ver horas trabalhadas");
                Console.WriteLine("5 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Coloque o nome do funcionário:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Coloque o valor do trabalho:");
                        double valorDoTrabalho = double.Parse(Console.ReadLine());
                        Console.WriteLine("coloque as horas trabalhadas:");
                        double horasTrabalhadas = double.Parse(Console.ReadLine());
                        funcionarios.Add(new Funcionario
                        (nome,
                        valorDoTrabalho,
                         horasTrabalhadas
                        ));
                        break;
                    case 2:
                        Console.WriteLine(" Funcionarios:");
                        foreach (var funcionario in funcionarios)
                        {
                            Console.WriteLine($"\n Nome: {funcionario.Nome}");
                        }
                        break;
                    case 3:
                        Console.WriteLine(" Salario:");
                        foreach (var funcionario in funcionarios)
                        {
                            Console.WriteLine($"\n O funcionario {funcionario.Nome}, salario: {funcionario.CalcularSalario().ToString("N2")} reais");
                        }
                        break;
                    case 4:
                        Console.WriteLine(" Horas Trabalhadas:");
                        foreach (var funcionario in funcionarios)
                        {
                            Console.WriteLine($"\n Funcionario {funcionario.Nome}, horas Trabalhadas: {funcionario.HorasTrabalhadas} horas");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Encerrando");
                        break;
                }
            }
            string json = JsonSerializer.Serialize(funcionarios, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine(json);
        }
    }
}
