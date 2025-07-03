using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace EadAula03
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double ValorDoTrabalho { get; set; }
        public double HorasTrabalhadas { get; set; }

        public Funcionario(string nome, double valorDoTrabalho, double orasTrabalhadas)
        {
            Nome = nome;
            ValorDoTrabalho = valorDoTrabalho;
            HorasTrabalhadas = orasTrabalhadas;
        }

        public virtual double CalcularSalario()
        {
            return ValorDoTrabalho * HorasTrabalhadas;
        }

        public virtual void Exibirdados()
        {
            Console.WriteLine($"Nome{Nome}");
            Console.WriteLine($"Valor por hora: {ValorDoTrabalho} horas trabalhadas");
            Console.WriteLine($"Carga de Trabalho: {HorasTrabalhadas} horas mensais");
            Console.WriteLine($"Salario: {CalcularSalario().ToString("N2")} reais");
        }
    }
}