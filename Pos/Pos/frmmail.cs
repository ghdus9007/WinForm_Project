using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Pos
{
    public partial class frmmail : Form
    {
        public frmmail()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                MailAddress fromAddr = new MailAddress(textBox1.Text, textBox6.Text, Encoding.UTF8);
                MailAddress toAddr = new MailAddress(textBox2.Text);

                SmtpClient client = new SmtpClient("smtp.naver.com", 587);

                MailMessage msg = new MailMessage(fromAddr, toAddr);
                msg.Subject = textBox6.Text;
                msg.Body = textBox3.Text;
                msg.BodyEncoding = Encoding.UTF8;
                msg.SubjectEncoding = Encoding.UTF8;

                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new NetworkCredential(textBox1.Text, "");

                client.Send(msg);
            }
            catch (Exception)
            {

            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            textBox1.Focus();
        }
    }
}
