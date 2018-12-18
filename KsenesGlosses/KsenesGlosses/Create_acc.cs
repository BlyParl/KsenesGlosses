using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KsenesGlosses
{
    public partial class Create_acc : Form
    {
        public Create_acc()
        {
            InitializeComponent();
        }

        // gia na kinite to frame
        Point lastPoint;

        private void Close_Click(object sender, EventArgs e)
        {
            //exit aplication
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            //minimize aplication
            this.WindowState = FormWindowState.Minimized;
        }

        private void First_name_Click(object sender, EventArgs e)
        {

            reset();
            //change the text to empty when click on the textbox
            if (First_name.Text == "First name")
            {
                First_name.Text = "";
            }
            select(panel_fisrt_name, First_name);
            //change the image to blue version
            img_fisrt_name.Image = Properties.Resources.user_blue;
        }

        private void Last_name_Click(object sender, EventArgs e)
        {
            reset();
            //change the text to empty when click on the textbox
            if (Last_name.Text == "Last name")
            {
                Last_name.Text = "";
            }
            select(panel_last_name, Last_name);
            //change the image to blue version
            img_last_name.Image = Properties.Resources.user_blue;
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

        public void reset()
        {
            //reset all the icon to white
            img_fisrt_name.Image = Properties.Resources.user;
            img_last_name.Image = Properties.Resources.user;
            img_username.Image = Properties.Resources.username;
            img_password.Image = Properties.Resources.password;
            img_email.Image = Properties.Resources.email;

            //reset all panels under the texts to white
            panel_fisrt_name.BackColor = Color.FromArgb(255, 255, 255);
            panel_last_name.BackColor = Color.FromArgb(255, 255, 255);
            panel_username.BackColor = Color.FromArgb(255, 255, 255);
            panel_password.BackColor = Color.FromArgb(255, 255, 255);
            panel_email.BackColor = Color.FromArgb(255, 255, 255);

            //reset the text if it is empty
            if (First_name.Text == "")
            {
                First_name.Text = "First name";
            }
            if (Last_name.Text == "")
            {
                Last_name.Text = "Last name";
            }
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
            First_name.ForeColor = Color.FromArgb(255, 255, 255);
            Last_name.ForeColor = Color.FromArgb(255, 255, 255);
            Username.ForeColor = Color.FromArgb(255, 255, 255);
            Password.ForeColor = Color.FromArgb(255, 255, 255);
            email.ForeColor = Color.FromArgb(255, 255, 255);
        }

        public void select(Panel panel,TextBox text)
        {
            //change panel and text color to blue
            panel.BackColor = Color.FromArgb(0, 175, 255);
            text.ForeColor = Color.FromArgb(0, 175, 255);
        }

        private void Go_back_Click(object sender, EventArgs e)
        {
            //create login item
            Login temp = new Login();
            //hide create form
            this.Hide();
            //shows login form
            temp.Show();
            //new form have the same location
            temp.Left = this.Left;
            temp.Top = this.Top;
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

        /// <summary>
        /// check every char in pass if it has caps character
        /// </summary>
        /// <returns></returns>
        private bool pass_caps_check()
        {
            foreach (char c in Password.Text)
            {
                if (char.IsUpper(c))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// pass check constrains for text legth , contain num , contain letters , contain sumbols
        /// return true if one of the above is not match
        /// </summary>
        /// <returns></returns>
        private bool pass_constraint_check()
        {
            int min_len=8;
            int min_num=2;
            int min_lett=2;
            int min_sym=2;

            if(Password.Text.Length < min_len)
            {
                return true;
            }

            //Check for Digits, Special Characters and Lower Letters
            int num_count = 0;
            int sym_count = 0;
            int lett_count = 0;

            foreach (char c in Password.Text)
            {
                if (char.IsDigit(c))
                {
                    num_count++;
                }

                if (Regex.IsMatch(c.ToString(), @"[!#$%&'()*+,-.:;<=>?@[\\\]{}^_`|~]"))
                {
                    sym_count++;
                }

                if (char.IsLower(c))
                {
                    lett_count++;
                }
            }

            if (num_count < min_num)
            {
                return true;
            }
            if (sym_count < min_sym)
            {
                return true;
            }
            if (lett_count < min_lett)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// change the password text that the user types in *
        /// and check for caps on the text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '*';
                if (pass_caps_check())
                {
                    Password.Text = "caps";
                }
            } 
        }

        private void Sing_up_Click(object sender, EventArgs e)
        {
            if (pass_constraint_check())
            {
                Password.Text = "constraint";
            }
        }
    }
}
