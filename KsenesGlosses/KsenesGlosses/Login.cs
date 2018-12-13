using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KsenesGlosses
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        // gia na kinite to frame
        Point lastPoint;

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void Username_Click(object sender, EventArgs e)
        {
            reset();
            //change the text to empty when click on the textbox
            if (Username.Text == "Username")
            {
                Username.Text = "";
            }
            select(panel_username, Username);
            //change the image to blue version
            img_username.Image = Properties.Resources.username_blue;
        }

        private void Password_Click(object sender, EventArgs e)
        {
            reset();
            //change the text to empty when click on the textbox
            if (Password.Text == "Password")
            {
                Password.Text = "";
            }
            select(panel_password, Password);
            //change the image to blue version
            img_password.Image = Properties.Resources.password_blue;
        }

        private void email_Click(object sender, EventArgs e)
        {
            reset();
            //change the text to empty when click on the textbox
            if (email.Text == "email")
            {
                email.Text = "";
            }
            select(panel_email, email);
            //change the image to blue version
            img_email.Image = Properties.Resources.email_blue;
        }


        private void Facebook_MouseEnter(object sender, EventArgs e)
        {
            Facebook.Image= Properties.Resources.facebook;
        }

        private void Facebook_MouseLeave(object sender, EventArgs e)
        {
            Facebook.Image = Properties.Resources.facebook_blue;
        }

        private void Gmail_MouseEnter(object sender, EventArgs e)
        {
            Gmail.Image = Properties.Resources.gmail;
        }

        private void Gmail_MouseLeave(object sender, EventArgs e)
        {
            Gmail.Image = Properties.Resources.gmail_blue;
        }

        private void Twitter_MouseEnter(object sender, EventArgs e)
        {
            Twitter.Image = Properties.Resources.twitter;
        }

        private void Twitter_MouseLeave(object sender, EventArgs e)
        {
            Twitter.Image = Properties.Resources.twitter_blue;
        }


        public void reset()
        {
            //reset all the icon to white
            img_username.Image = Properties.Resources.username;
            img_password.Image = Properties.Resources.password;
            img_email.Image = Properties.Resources.email;

            //reset all panels under the texts to white
            panel_username.BackColor = Color.FromArgb(255, 255, 255);
            panel_password.BackColor = Color.FromArgb(255, 255, 255);
            panel_email.BackColor = Color.FromArgb(255, 255, 255);

            //reset the text if it is empty
            if (Username.Text == "")
            {
                Username.Text = "Username";
            }
            if (Password.Text == "")
            {
                Password.Text = "Password";
            }
            if (email.Text == "")
            {
                email.Text = "email";
            }

            //reset all text colors to white
            Username.ForeColor = Color.FromArgb(255, 255, 255);
            Password.ForeColor = Color.FromArgb(255, 255, 255);
            email.ForeColor = Color.FromArgb(255, 255, 255);
        }

        public void select(Panel panel, TextBox text)
        {
            //change panel and text color to blue
            panel.BackColor = Color.FromArgb(0, 175, 255);
            text.ForeColor = Color.FromArgb(0, 175, 255);
        }

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

        private void Register_Click(object sender, EventArgs e)
        {
            Create_acc temp = new Create_acc();

            this.Hide();

            temp.Show();

        }
    }
}
