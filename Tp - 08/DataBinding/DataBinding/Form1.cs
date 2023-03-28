using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;



namespace DataBinding
{
    public partial class Form1 : Form
    {

        public Repository Repository { get; set; } = new Repository();
        public Form1()
        {
            InitializeComponent();
        }

     


        private void btnAdicionarCli_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Name = "Cliente exemplo";
            client.Address = "Rua XPTO";
            client.Phone = "(13) 3355-1234";

            Repository.Incluir(client);
            bsClient.ResetBindings(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                bsClient.DataSource = Repository;
            
        }
    }

}   
 