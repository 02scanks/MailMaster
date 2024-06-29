using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailMaster
{
    public partial class LoginForm : Form
    {

        Database database = new Database();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userInput.Text;
            string password = passwordInput.Text;
            database.Login(username, password);
            
        }
    }
}
