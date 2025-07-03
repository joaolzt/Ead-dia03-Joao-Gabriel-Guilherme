using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace EadAula03
{
    public class HorasTrabalhadas : Funcionario
    {
        public HorasTrabalhadas(string nome, double valorDoTrabalho, double horasTrabalhadas) : base(nome, valorDoTrabalho, horasTrabalhadas)
        {

        }

        public override void Exibirdados()
        {
            Console.WriteLine($"Horas trabalhadas: {HorasTrabalhadas} horas");
        }
    }
}