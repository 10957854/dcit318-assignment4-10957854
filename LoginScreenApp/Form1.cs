using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // For demonstration purposes, display the entered username and password
            MessageBox.Show($"Username: {username}\nPassword: {password}", "Login Information");

            // Clear the text boxes after displaying the information
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }
    }
}
