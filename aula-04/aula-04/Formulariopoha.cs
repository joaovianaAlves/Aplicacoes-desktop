using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_04
{
    public partial class Formulariopoha : Form
    {
        public Formulariopoha()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(); // instanciando a classe

            //Atribuido as propriedades da classe Aluno

            aluno.Nome = InputNome.Text;
            aluno.Ra = InputRa.Text;
            aluno.P1 = float.Parse(InputP1.Text);
            aluno.P2 = float.Parse(InputP2.Text);

            aluno.Calcular();

            InputMedia.Text = aluno.Media.ToString();
        }

        private void Formulariopoha_Load(object sender, EventArgs e)
        { 
            Media.Visible = false;
        }

        private void Media_Click(object sender, EventArgs e)
        {

        }
    }
}
