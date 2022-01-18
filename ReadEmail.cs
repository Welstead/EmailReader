using MailKit.Net.Imap;
using MimeKit;
using System.Data;
using System.Text;

namespace EmailReader
{

    public partial class ReadEmail : Form
    {
        
        public static string YourEmail = "louis.welstead@gmail.com";
        public static string YourPassword = "";
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
            
            using (ImapClient IC =new ImapClient())
            {
                IC.Connect("imap.gmail.com", 993, true);
                IC.Authenticate(YourEmail, YourPassword);
                var folder = IC.GetFolder("Inbox");
                folder.Open(MailKit.FolderAccess.ReadOnly);
                int count = folder.Count;
                for (int i = 1; i < 20; i++)
                {
                    var email = folder.GetMessage(count - i);
                    if (email.Attachments.FirstOrDefault() != null)
                    {
                        emails.Add(new EmailModel { EmailID = i, Sender = email.From.ToString(), Subject = email.Subject.ToString(), Content = email.Body.ToString(), Files = email.Attachments.ToList() });
                    }
                }

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
            var test = emails[selectedEmail].Files;
            try
            {
                if(test != null)
                {
                    foreach(var file in test)
                    {
                        Attachments.Add(file.ContentType.Name);
                    }
                }
                
            }
            catch(Exception ex)
            {
                //
            }
            
            listAttachments.DataSource = null;
            listAttachments.DataSource = Attachments;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            var test = emails[selectedEmail].Files.FirstOrDefault();
            var files = emails[selectedEmail].Files;
            foreach (var file in files)
            {
                if(file.ContentType.Name == listAttachments.SelectedItem)
                {
                    test = file;
                }
            }
            
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = test.ContentType.Name;
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Create(sfd.FileName))
                    {

                        ((MimePart)test).Content.DecodeTo(stream);
                    }
                    MessageBox.Show($"{sfd.FileName} successfully downloaded!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
