using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_04
{
    public class Aluno
    {

        public string Nome { get; set; } = string.Empty;
        public string Ra { get; set; } = string.Empty;
        
        public float P1 { get; set; }
        public float P2 { get; set; }
        public float Media { get; private set; }

        public void Calcular()
        {
            Media = (P1 + P2 * 2) / 3;
        }

    }
}
