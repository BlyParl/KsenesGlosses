using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KsenesGlosses
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        // gia na kinite to frame
        Point lastPoint;

        private void Border_MouseMove(object sender, MouseEventArgs e)
        {
            //metakinisi tou frame
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Border_MouseDown(object sender, MouseEventArgs e)
        {
            //apothikeuei to teleuteo simio pou afise to parathiro
            lastPoint = new Point(e.X, e.Y);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Login temp = new Login();
            temp.Show();
            this.Close();
            
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void email_textbox_Click(object sender, EventArgs e)
        {
            if (email_textbox.Text == "email")
            {
                email_textbox.Text = "";
            }
            panel_email.BackColor = Color.FromArgb(0, 175, 255);
            email_textbox.ForeColor = Color.FromArgb(0, 175, 255);
        }

        private void Email_Click(object sender, EventArgs e)
        {
            if (email_textbox.Text == "")
            {
                email_textbox.Text = "email";
            }
        }

        private void Send_email_Click(object sender, EventArgs e)
        {
            if (email_textbox.Text == "")
            {
                email_textbox.Text = "email";
            }

            email(sender, e);

            MessageBox.Show("Email Send");
        }

        protected void email(object sender, EventArgs e)
        {
            var fromAddress = new MailAddress("from@gmail.com", "From Name");
            var toAddress = new MailAddress("to@gmail.com", "To Name");
            const string fromPassword = "password";
            const string subject = "Subject";
            const string body = "Body";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }

    
}
