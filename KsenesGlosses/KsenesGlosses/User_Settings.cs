using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Windows.Forms.DataVisualization.Charting;
using KsenesGlosses.Classes;

namespace KsenesGlosses
{
    public partial class User_Settings : Form
    {
        
        public User_Settings()
        {
            InitializeComponent();
        }
        
        VocLearningDataSetTableAdapters.USERSTableAdapter usersTableAdapter;
        VocLearningDataSetTableAdapters.USER_PROFILETableAdapter userProfileTableAdapter;
        private User user;
        /// <summary>
        /// Gets or sets the user that Loged in
        /// </summary>
        public User LoggedUser
        {
            get { return user; }
            set { user = value; }
        }

        private void User_Settings_Load(object sender, EventArgs e)
        {
            usersTableAdapter = new VocLearningDataSetTableAdapters.USERSTableAdapter();
            First_name.Text = user.first_name;
            Last_name.Text = user.last_name;
            Username.Text = user.user_name;
            email.Text = user.email_address;

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
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// pass check constrains for text legth , contain num , contain letters , contain sumbols
        /// return true if one of the above is not match
        /// </summary>
        /// <returns></returns>
        private bool pass_constraint_check()
        {
            int min_len = 8;
            int min_num = 2;
            int min_lett = 2;

            if (Password.Text.Length < min_len)
            {
                return false;
            }

            //Check for Digits, Special Characters and Lower Letters
            int num_count = 0;
            int lett_count = 0;

            foreach (char c in Password.Text)
            {
                if (char.IsDigit(c))
                {
                    num_count++;
                }

                if (char.IsLower(c))
                {
                    lett_count++;
                }
            }

            if (num_count < min_num)
            {
                return false;
            }
            if (lett_count < min_lett)
            {
                return false;
            }

            return true;
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

        /// <summary>
        /// change the password text that the user types in *
        /// and check for caps on the text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Con_Password_TextChanged(object sender, EventArgs e)
        {
            if (Con_Password.Text == "Confirm Password")
            {
                Con_Password.PasswordChar = '\0';
            }
            else
            {
                Con_Password.PasswordChar = '*';
            }
        }

        private void Change_pass_Click(object sender, EventArgs e)
        {
            if (pass_constraint_check() && pass_caps_check())
            {
                if (Password.Text == Con_Password.Text)
                {
                    usersTableAdapter.Update_password_by_username(Password.Text, Username.Text);
                    MessageBox.Show("Password changed");
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password are not the same");
                }

            }
            else
            {
                MessageBox.Show("Password must have 8 or more characters\n" + "And Contains at least 2 letters and 2 digits and no uppercase");
            }
        }

        private void Save_changes_Click(object sender, EventArgs e)
        {
            if (email.Text != "" && First_name.Text != "" && Last_name.Text != "")
            {
                int count = (Int32)usersTableAdapter.Counter_by_email(email.Text);
                if (count == 1 && email.Text != user.email_address)
                {
                    MessageBox.Show("This email already exist");
                }
                else
                {
                    if (email.Text != user.email_address)
                    {
                        usersTableAdapter.Update_email_by_username(email.Text, Username.Text);
                        user.email_address = email.Text;
                    }
                    if (First_name.Text != user.first_name)
                    {
                        usersTableAdapter.Update_firstname_by_username(First_name.Text, Username.Text);
                        user.first_name = First_name.Text;
                    }
                    if (Last_name.Text != user.last_name)
                    {
                        usersTableAdapter.Update_lastname_by_username(Last_name.Text, Username.Text);
                        user.last_name = Last_name.Text;
                    }
                    MessageBox.Show("Change Saved");
                }
            }
            else
            {
                MessageBox.Show("Some field is empty!");
            }
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Password.Text = "";
        }

        private void Con_Password_Click(object sender, EventArgs e)
        {
            Con_Password.Text = "";
        }


        /// <summary> ///Draws a pie chart using the given information./// </summary>
        private Bitmap DrawPieChart(Color bgColor,int width,int height,int[] values)
        {
            //this Creates a new image and erase the background
            Bitmap bitmap = new Bitmap(width, height,PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bitmap);
            SolidBrush brush =new SolidBrush(bgColor);
            graphics.FillRectangle(brush, 0, 0, width, height);
            brush.Dispose();


            // Create brushes for coloring the pie chart
            SolidBrush[] brushes = new SolidBrush[10];
            brushes[0] = new SolidBrush(Color.Yellow);
            brushes[1] = new SolidBrush(Color.Green);
            brushes[2] = new SolidBrush(Color.Blue);
            brushes[3] = new SolidBrush(Color.Cyan);

            int total = 0;
            foreach (int val in values)
            {
                total += val;
            }

            // Draw the pie chart
            float start = 0.0f;
            float end = 0.0f;
            int current = 0;
            for( int i = 0; i < values.Length; i++)
            {
                current += values[i];
                start = end;
                end = (float)(current / total) * 360.0f;
                graphics.FillPie(brushes[i % 10], 0.0f, 0.0f, width, height, start, end - start);
            }
            // disposes the brush resources
            /*
            foreach (SolidBrush cleanBrush in brushes)
            {
                cleanBrush.Dispose();
            }
            */
            return bitmap;
        }

        private void Statistics_Button_Click(object sender, EventArgs e)
        {
            
            /*
            int user_id = this.user.user_id;
            userProfileTableAdapter = new VocLearningDataSetTableAdapters.USER_PROFILETableAdapter();
            VocLearningDataSet.USER_PROFILEDataTable userProfileDatatable = userProfileTableAdapter.GetDataBy(user_id);
             for (int i = 1; i <= 4; i++)
            { 
               int difficulty = userProfileDatatable.Rows[0].Field<int>("Test_Level");
               int CorrectAnswers = userProfileDatatable.Rows[0].Field<int>("Total_Correct");
               this.chart1.Series["Performance"].Points.AddXY(0,CorrectAnswers);
            }
            */        

            
            
            this.chart1.Series["Performance"].Points.AddXY(2, 24);
            this.chart1.Series["Performance"].Points.AddXY(3, 29);
            this.chart1.Series["Performance"].Points.AddXY(4, 21);
            

        }
    }
}
    

