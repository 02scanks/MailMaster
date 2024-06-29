using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Linq;
using System.Net;


namespace MailMaster
{
    public partial class main : Form
    {
        //Database
        Database database = new Database();
        int adminID;

        //email properties
        string subjectBody;
        string messageBody;

        public main(int id)
        {
            adminID = id;
            InitializeComponent();
            database.PopulateUserComboBox(userComboBox, adminID);
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string clientName = Interaction.InputBox("Client Name?", "Add Client", "");
            string clientEmail = Interaction.InputBox("Client Email?", "Add Client", "");

            if (clientName != string.Empty || clientEmail != string.Empty)
            {
                database.AddClientToDatabase(clientName, clientEmail, adminID);
            }
        }
        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveUser removeUserForm = new RemoveUser();
            removeUserForm.Show();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (subjectField.Text == string.Empty || messageField.Text == string.Empty)
            {
                MessageBox.Show("Subject Field / Message Field Cannot Be Blank");
            }
            else
            {
                if (sendAllCheckBox.Checked == true)
                {
                    subjectBody = subjectField.Text;
                    messageBody = messageField.Text;

                    //send to all users 
                    foreach (string name in userComboBox.Items) 
                    {
                        string email = database.GetClientEmail(name);
                        string massMessageBody = $"Hey {name}!\n\n{messageBody}";

                        MailMessage mailMessage = new MailMessage();

                        mailMessage.From = new MailAddress(database.GetAdminEmail(adminID));
                        mailMessage.Subject = subjectBody;
                        mailMessage.To.Add(new MailAddress(email));
                        mailMessage.Body = massMessageBody;
                        mailMessage.IsBodyHtml = false;
                        // if user has attached a file then send with the email
                        if (attachedFileDisplay.Text != string.Empty) 
                        {
                            mailMessage.Attachments.Add(new Attachment(attachedFileDisplay.Text));
                        }
                        

                        var smtpClient = new SmtpClient("smtp.gmail.com")
                        {
                            Port = 587,
                            Credentials = new NetworkCredential(database.GetAdminEmail(adminID), database.GetAdminEmailPassword(adminID)),
                            EnableSsl = true
                        };

                        smtpClient.Send(mailMessage);
                    }

                    MessageBox.Show($"Mass Email Sent");
                }
                else 
                {
                    subjectBody = subjectField.Text;
                    messageBody = messageField.Text;

                    // send to specific user
                    string email = database.GetClientEmail(userComboBox.Text);

                    MailMessage mailMessage = new MailMessage();

                    mailMessage.From = new MailAddress(database.GetAdminEmail(adminID));
                    mailMessage.Subject = subjectBody;
                    mailMessage.To.Add(new MailAddress(email));
                    mailMessage.Body = messageBody;
                    mailMessage.IsBodyHtml = false;
                    // if user has attached a file then send with the email
                    if (attachedFileDisplay.Text != string.Empty)
                    {
                        mailMessage.Attachments.Add(new Attachment(attachedFileDisplay.Text));
                    }

                    var smtpClient = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential(database.GetAdminEmail(adminID), database.GetAdminEmailPassword(adminID)),
                        EnableSsl = true
                    };

                    smtpClient.Send(mailMessage);

                    MessageBox.Show($"Email Sent To: {email}");
                }

            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void refreshClientList_Click(object sender, EventArgs e)
        {
            userComboBox.Items.Clear();
            database.PopulateUserComboBox(userComboBox, adminID);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Add Attachment";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                string fileName = openFileDialog1.FileName;
                attachedFileDisplay.Text = fileName;
                
            }
        }
    }
}
