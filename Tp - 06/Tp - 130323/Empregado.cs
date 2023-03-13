using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp___130323
{
    internal class Empregado
    {

        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public int Dtrab { get; set; }

        public double Vdia { get; set; }

        public double SalarioBase { get; private set; }

        public double SalarioLiquido { get; private set; }

        public double ValorIR { get; private set; }


        public void CalcularSalarioBase()
        {
            SalarioBase = (Dtrab * Vdia);
        }

        public void CalcularSalarioLiquido()
        {
            SalarioLiquido = (SalarioBase - ValorIR);
        }

        public void CalcularIR()
        {
            if(SalarioBase <= 1903.98){
               ValorIR = SalarioBase * 0;
            }else if(SalarioBase <= 2826.65)
            {
                ValorIR = SalarioBase * (7.5 / 100);
            }else if (SalarioBase <= 3751.05)
            {
                ValorIR = SalarioBase * (15 / 100);
            }
            else
            {
                ValorIR = SalarioBase * (22.50 / 100);
            }
        }


    }
}
