using AE.Net.Mail;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailReader
{
    
    public partial class ReadEmail : Form
    {
        
        public static string YourEmail = "louis.welstead@gmail.com";
        public static string YourPassword = "";
        public static ImapClient IC;
        public int selectedEmail;
        List<EmailModel> emails = new List<EmailModel>();
        List<string> Attachments = new List<string>();
        public string filename;


        public ReadEmail()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            var form1 = new Form1();
            form1.Show();
        }

        

        private void btnLoadInbox_Click(object sender, EventArgs e)
        {
            IC = new ImapClient("imap.gmail.com", YourEmail, YourPassword, AuthMethods.Login, 993, true);
            
            for (int i = 1; i < 10; i++)
            {
                var email = IC.GetMessage(IC.GetMessageCount() - i);
                emails.Add(new EmailModel { EmailID = i, Sender = email.From.ToString(), Subject = email.Subject.ToString(), Content = email.Body , Files = email.Attachments.ToList()});
                //TODO: Filter out emails that don't have attachments
                
                

            }
            
            listEmails.DataSource = emails.Select(e => e.Subject).ToList();
        }

        private void listEmails_SelectedIndexChanged(object sender, EventArgs e)
        {
            Attachments.Clear();
            selectedEmail = listEmails.SelectedIndex;
            txtSubject.Text = emails[selectedEmail].Subject;
            txtSender.Text = emails[selectedEmail].Sender;
            txtReadEmail.Text = emails[selectedEmail].Content;
            ShowAttachments();
            if(Attachments.Count == 0)
            {
                btnOpenFile.Enabled = false;
            }
            else
            {
                btnOpenFile.Enabled = true;
            }
        }

        public void ShowAttachments()
        {
            
            try
            {
                if(emails[selectedEmail].Files[0] != null)
                {
                    Attachments.Add(emails[selectedEmail].Files[0].Filename);
                    filename = emails[selectedEmail].Files[0].Filename;
                }
                
            }
            catch(Exception ex)
            {
                
            }
            
            listAttachments.DataSource = null;
            listAttachments.DataSource = Attachments;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            
            var test = emails[selectedEmail].Files[0];
            var test2 = test.GetData();
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.ShowDialog();

            File.WriteAllBytes(Path.Join(Directory.GetCurrentDirectory(), test.Filename), test2);
            
            
            
            //PdfDocument pdfDocument = PdfReader.Open(test);
            //pdfDocument.Save(test);

        }
    }
}
