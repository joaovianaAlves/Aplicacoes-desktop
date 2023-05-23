using DAL;
namespace DemoCrud2

{
    public partial class Form1 : Form
    {
        private Repositorio repositorio;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repositorio = new Repositorio();
            bsAgenda.DataSource = repositorio;
        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_crud_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmDetalhe frm = new FrmDetalhe();
            frm.agenda 
        }
    }
}