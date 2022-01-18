using System.Net;
using System.Net.Mail;

namespace EmailReader
{
    public partial class Form1 : Form
    {
        static string YourEmail = "louis.welstead@gmail.com";
        static string YourPassword = "";
        public Form1()
        {
            InitializeComponent();
            lblLoggedInAs.Text += YourEmail;
            
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(YourEmail, YourPassword);
                MailMessage mail = new MailMessage();
                mail.To.Add(txtRecipient.Text);
                mail.From = new MailAddress(YourEmail);
                mail.Subject = txtSubject.Text;
                mail.Body = txtMessage.Text;
                client.Send(mail);
            }
        }

       

        private void btnRead_Click_1(object sender, EventArgs e)
        {
            var read = new ReadEmail();
            read.Show();
            this.Hide();
        }
    }
}