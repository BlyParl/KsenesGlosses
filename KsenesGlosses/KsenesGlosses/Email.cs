using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        String pass;
        VocLearningDataSetTableAdapters.USERSTableAdapter usersTableAdapter;

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
            //change color image and text
            if (email_textbox.Text == "email")
            {
                email_textbox.Text = "";
            }
            panel_email.BackColor = Color.FromArgb(0, 175, 255);
            email_textbox.ForeColor = Color.FromArgb(0, 175, 255);
            img_email.Image = Properties.Resources.email_blue;
        }

        private void Email_Click(object sender, EventArgs e)
        {
            //change color image and text
            if (email_textbox.Text == "")
            {
                email_textbox.Text = "email";
            }
            img_email.Image = Properties.Resources.email;
            panel_email.BackColor = Color.FromArgb(255, 255, 255);
            email_textbox.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void Send_email_Click(object sender, EventArgs e)
        {
            //change color image and text
            if (email_textbox.Text == "")
            {
                email_textbox.Text = "email";
            }
            img_email.Image = Properties.Resources.email;
            panel_email.BackColor = Color.FromArgb(255, 255, 255);
            email_textbox.ForeColor = Color.FromArgb(255, 255, 255);

            //if mail exist on database
            if (Checkemail(email_textbox.Text))
            {
                //sends email
                email(sender, e);

                MessageBox.Show("Email Send");

            }
        }

        protected void email(object sender, EventArgs e)
        {
            try
            {
                var fromAddress = new MailAddress("ksenesglosses1@gmail.com", "From Name");
                var toAddress = new MailAddress(email_textbox.Text, "To Name");
                const string fromPassword = "a455288!";
                const string subject = "Account informations from KsenesGlosses";
                string body = "Your new Password is:"+pass;

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool Checkemail(string email)
        {
            try
            {
               
                int count = (Int32)usersTableAdapter.Counter_by_email(email);
               

                if (count == 1)
                {
                    pass = RandomString(9);
                    usersTableAdapter.Updata_password(pass, email);
                    return true;
                }
                else
                {
                    MessageBox.Show("Email not found");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }


        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void Email_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            usersTableAdapter = new VocLearningDataSetTableAdapters.USERSTableAdapter();
        }
    }

    
}
