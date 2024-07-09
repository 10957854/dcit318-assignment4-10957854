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

            // You can save this information to a database or file, or simply display it
            string message = $"Name: {name}\nEmail: {email}\nPhone: {phone}";
            MessageBox.Show(message, "Saved Information");

            // Clear the text boxes after saving
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
        }
    }
}
