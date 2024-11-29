using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {

            InitializeComponent();

        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            String email = emailTextBox.Text;
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            if (name == null || regex.IsMatch(email) )
            {
                User user = new User(name, email);
                LibrarySystemForm librarySystem = new LibrarySystemForm();
                librarySystem.Show();
            } else
            {
                displayMessage.Text = "ERROR : name or email is invalid";
            }
        }
    }
}
