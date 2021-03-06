﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KsenesGlosses.Classes;


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
        VocLearningDataSetTableAdapters.USERSTableAdapter usersTableAdapter;

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

            //reset all panels under the texts to white
            panel_username.BackColor = Color.FromArgb(255, 255, 255);
            panel_password.BackColor = Color.FromArgb(255, 255, 255);

            //reset the text if it is empty
            if (Username.Text == "")
            {
                Username.Text = "Username";
            }
            if (Password.Text == "")
            {
                Password.Text = "Password";
            }
            

            //reset all text colors to white
            Username.ForeColor = Color.FromArgb(255, 255, 255);
            Password.ForeColor = Color.FromArgb(255, 255, 255);
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
            //create a create_acc form 
            Create_acc temp = new Create_acc();
            // hide this form
            this.Hide();
            //show the other form
            temp.Show();
            //new form have the same location
            temp.Left = this.Left;
            temp.Top = this.Top;

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
            }
        }

        private void Sing_in_Click(object sender, EventArgs e)
        {
            reset();

            var username = Username.Text;
            var password = Password.Text;

            //check the textboxes
            if (string.IsNullOrEmpty(username) || username.Equals("Username"))
            {
                MessageBox.Show("Please type your Username");
                Username_Click(sender, e);
                Username.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password) || password.Equals("Password"))
            {
                MessageBox.Show("Please type your Password");
                Password_Click(sender, e);
                Password.Focus();
                return;
            }

            if (pass_caps_check())
            {
                MessageBox.Show("Password contains uppercase characters");
                Password_Click(sender, e);
                Password.Focus();
                return;
            }

            // Seperate the login check and make it lously coupled from the UI (= do not refer to the UI elements, instead pass the values to a method)
            CheckLogin(username, password);

        }

        //check if user exist in database
        private void CheckLogin(string username, string password)
        {
            try
            {
                int count = (Int32)usersTableAdapter.Count_by_username_password(password, username);

                if (count == 1)
                {
                    MessageBox.Show("Login Successful");
                    //create a create_acc form 
                    MainForm temp = new MainForm();
                    // hide this form
                    this.Hide();
                    //show the other form
                    temp.Show();
                    //
                    //get user from db for testing  this is not a log in 
                    //
                    User newUser = User.getUserFromDB(username);
                    temp.LoggedUser = newUser;
                    MessageBox.Show("User :" + newUser.first_name);

                }
                else
                {
                    MessageBox.Show("Username or Password do not match");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_MouseClick(object sender, MouseEventArgs e)
        {
            reset();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //set icon
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            //user adapter
            usersTableAdapter = new VocLearningDataSetTableAdapters.USERSTableAdapter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Email temp = new Email();
            this.Hide();
            //show the form
            temp.Show();
        }

        
    }
}
