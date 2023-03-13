using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp___130323
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calc_Click(object sender, EventArgs e)
        {
            Empregado empregado = new Empregado();

            empregado.Nome = Nome.Text;
            empregado.Cpf = Cpf.Text;
            empregado.Dtrab = int.Parse(inputDtrab.Text);
            empregado.Vdia = double.Parse(inputVdia.Text);
            
            empregado.CalcularSalarioBase();
            empregado.CalcularIR();
            empregado.CalcularSalarioLiquido();
            
            outputSbase.Text = empregado.SalarioBase.ToString();
            outputIR.Text = empregado.ValorIR.ToString();
            outputSliquido.Text = empregado.SalarioLiquido.ToString();
        }

        private void IR_Click(object sender, EventArgs e)
        {

        }

        private void sBase_Click(object sender, EventArgs e)
        {

        }

        private void inputNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            inputCpf.BorderStyle = ;

        }
    }
}
