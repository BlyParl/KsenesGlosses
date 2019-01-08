using System;
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
        // Fail login counter
        private int _failedLoginCounter = 0;

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

        private void CheckLogin(string username, string password)
        {
            try
            {

                using (OleDbConnection conDataBase = new OleDbConnection(Properties.Settings.Default.VocLearningConnectionString)) //this will colse the connection only need to open
                {
                    using (OleDbCommand cmdDataBase = conDataBase.CreateCommand())
                    {
                        cmdDataBase.CommandText =
                            "SELECT ID, First_Name, Last_Name, User_Name, Email_Adress FROM USERS WHERE Username=@username AND Password = @password";

                        cmdDataBase.Parameters.AddRange(new OleDbParameter[]
                        {
                    new OleDbParameter("@username", username),
                    new OleDbParameter("@password", password)
                        });

                        // Open database if not open
                        if (conDataBase.State != ConnectionState.Open)
                            conDataBase.Open();

                        var numberOrResults = 0;


                        // You need to use a using statement since OleDbDataReader inherits DbDataReader which implements IDisposable
                        // more info: http://msdn.microsoft.com/en-us/library/system.data.common.dbdatareader(v=vs.110).aspx
                        using (OleDbDataReader myReader = cmdDataBase.ExecuteReader())
                        {
                            while (myReader != null && myReader.Read())
                            {
                                numberOrResults++;
                            }
                        }

                        // If only one result was returned by the database => Succesful login
                        if (numberOrResults == 1)
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

                        // If more than 1 result was returned by the database => Failed login
                        // This is not a good idea, this situation should never occor.
                        // Always make sure username + pass (or whatever you use for authentication) is unique.
                        else if (numberOrResults > 1)
                        {
                            MessageBox.Show("Duplicate Username or Password");
                            // increment the failed login counter
                            _failedLoginCounter++;
                        }
                        // No match was found in te database => Failed login
                        else if (numberOrResults == 0)
                        {
                            MessageBox.Show("Username or Password do not match");
                            // increment the failed login counter
                            _failedLoginCounter++;
                        }


                    }


                    // If the user has 3 failed login attempts on a row => close.
                    if (_failedLoginCounter >= 3)
                        this.Close();
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
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            
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
