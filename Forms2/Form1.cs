using System;
using System.Windows.Forms;

namespace AddressBookApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;

            string entry = $"Name: {name}, Email: {email}, Phone: {phone}";

            listBoxEntries.Items.Add(entry);

            // Clear text boxes
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
        }

        private void listBoxEntries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

