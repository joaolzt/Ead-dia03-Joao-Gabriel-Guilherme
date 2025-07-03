using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace EadAula03
{
    public class Salario : Funcionario
    {
        public Salario(String nome, double valorDoTrabalho, double horasTrabalhadas) : base(nome, valorDoTrabalho, horasTrabalhadas)
        {

        }
        public override void Exibirdados()
        {
            Console.WriteLine($"Salario {CalcularSalario().ToString("N2")} reais");
        }
    }
}