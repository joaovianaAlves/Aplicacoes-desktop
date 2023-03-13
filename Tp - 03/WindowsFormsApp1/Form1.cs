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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (textTarefa.Text != "")
            {
                LISTA.Items.Add($"{date.Value:d} - {textTarefa.Text}");
                textTarefa.Clear();
            }
            else
            {
                MessageBox.Show("Escreva algo");
                textTarefa.Clear();
            }
        }

        private void btnrREMOVE_Click(object sender, EventArgs e)
        {
            if(LISTA.SelectedItem != null)
            {
                LISTA.Items.Remove(LISTA.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecione um item no listBox");
                textTarefa.Clear();
            }
        }
    }
}