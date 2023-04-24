using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        Agenda agenda;
        CEP cepForm;
        Sobre sobre;
        public Menu()
        {
            InitializeComponent();
        }

        
        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (agenda == null)
            {
                agenda = new Agenda();
                agenda.MdiParent = this;
                agenda.WindowState = FormWindowState.Maximized;
                agenda.Show();
            }
            else
            {
                agenda.Activate();
            }
        }

        private void cEPToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (cepForm == null)
            {
                cepForm = new CEP();
                cepForm.MdiParent = this;
                cepForm.WindowState = FormWindowState.Maximized;
                cepForm.Show();
            }
            else
            {
                cepForm.Activate();
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();   
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
           sobre = new Sobre();
            sobre.ShowDialog();
        }
    }
}
