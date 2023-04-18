using bll;

namespace CEP
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void lblCEP_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaCep consultaCep = new ConsultaCep();
            cep Cep = consultaCep.Consultar(InputCep.Text);

            OutputCidade.Text = $"{Cep.Logradouro}";
            OutPutEndereço.Text = $"{Cep.Localidade} / {Cep.Uf}";
            OutPutBairro.Text = $"{Cep.Bairro}";
        }
    }
}