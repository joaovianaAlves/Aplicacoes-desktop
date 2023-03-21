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

namespace ListaTelefonica
{
    public partial class Test : Form
    {
        PhoneList phonelist = new PhoneList();
        public Test()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Include_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = InputName.Text;
            person.Phone = InputPhone.Text;
        
            phonelist.add(person);
            ListPhone.Items.Add(new ListViewItem(new string[] { person.Name.ToString(),person.Phone.ToString()}));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListStart();
        }

        public void ListStart()
        {
            ListPhone.View = View.Details;
            ListPhone.Columns.Add("Name:");
            ListPhone.Columns.Add("Phone:");
            ListPhone.Columns[0].Width = 210;
            ListPhone.Columns[1].Width = 210;
            

            ListPhone.GridLines = true;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            Person person = phonelist.FindPerson(InputName.Text);
            phonelist.remove(person);
            ListPhone.Clear();
            ListStart();
            foreach(Person person1 in phonelist.PersonList)
            {
                ListPhone.Items.Add(new ListViewItem(new string[] { person1.Name.ToString(), person1.Phone.ToString() }));
            }

        }

        private void InputPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
