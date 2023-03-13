using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            if (CtoF.Checked)
            {
                if(Celsius.Text != "")
                {
                    float c = float.Parse(Celsius.Text);
                    float f = (c * 9/5)+32;
                    Result.Text = f.ToString(); 
                }
            }
            else
            {
                if (Fahrenheit.Text != "")
                {
                    float f = float.Parse(Fahrenheit.Text);
                    float c = (f - 32) * 5 / 9;
                    Result.Text = c.ToString();
                }
            }
        }
    }
}
