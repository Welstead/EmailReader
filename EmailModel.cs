using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Imap;
using MimeKit;

namespace EmailReader
{
    public class EmailModel
    {
        public int EmailID { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public List<MimeEntity> Files { get; set; }

    }
}
