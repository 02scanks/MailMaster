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
    public partial class RemoveUser : Form
    {
        Database database = new Database();

        public RemoveUser()
        {
            InitializeComponent();
            database.PopulateRemoveUserList(userListView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userListView.SelectedItems.Count > 0)
            { 
                string name = userListView.SelectedItems[0].Text;
                database.RemoveUser(name);
            }
            else 
            {
                MessageBox.Show("Please Select A Client First");
            }
        }
    }
}
