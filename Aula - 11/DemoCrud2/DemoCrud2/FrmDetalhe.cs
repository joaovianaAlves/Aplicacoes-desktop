using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace DemoCrud2
{
    public partial class FrmDetalhe : Form
    {

        public FrmDetalhe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelado_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        falta aqui o formload
    }
}
