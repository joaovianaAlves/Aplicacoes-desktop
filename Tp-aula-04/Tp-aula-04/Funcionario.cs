using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_aula_04
{
    internal class Funcionario
    {
        public string Cpf { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
    
        public float ValorHora { get; set; }

        public float HorasTrabalhadas { get; set; }
        public float Salario { get; private set; }


        public void CalcularSalario()
        {
            Salario = ValorHora * HorasTrabalhadas;
        }
    }
}
