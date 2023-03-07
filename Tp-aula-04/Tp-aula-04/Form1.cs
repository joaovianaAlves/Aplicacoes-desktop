using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_aula_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();

            func.Cpf = inputCpf.Text;
            func.Nome = inputNome.Text;
            func.ValorHora = float.Parse(inputVh.Text);
            func.HorasTrabalhadas = float.Parse(inputHT.Text);

            func.CalcularSalario();
            inputSalario.Text = func.Salario.ToString();
        }
    }
}
