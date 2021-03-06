﻿using System;
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
                if (IsValidEmail(email.Text))
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
                    MessageBox.Show("Invalid email");
                }
            }
            else
            {
                MessageBox.Show("Some field is empty!");
            }
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch (Exception ex)
            {
                return false;
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
        private void Statistics_Button_Click(object sender, EventArgs e)
        {
            
            
            /*
            userProfileTableAdapter = new VocLearningDataSetTableAdapters.USER_PROFILETableAdapter();
            VocLearningDataSet.USER_PROFILEDataTable userProfileDatatable = userProfileTableAdapter.GetDataBy(this.user.user_id);
             for (int i = 1; i <= 4; i++)
            { 
               int difficulty = userProfileDatatable.Rows[i].Field<int>("Test_Level");
               int CorrectAnswers = userProfileDatatable.Rows[i].Field<int>("Total_Correct");
               this.chart1.Series["Performance"].Points.AddXY(difficulty,CorrectAnswers);
            }
            */
            this.chart1.Series["Performance"].Points.AddXY(2, 24);
            this.chart1.Series["Performance"].Points.AddXY(3, 29);
            this.chart1.Series["Performance"].Points.AddXY(4, 21);

            userProfileTableAdapter = new VocLearningDataSetTableAdapters.USER_PROFILETableAdapter();
            VocLearningDataSet.USER_PROFILEDataTable userProfileDatatable = userProfileTableAdapter.GetDataBy(this.user.user_id);
            this.CorrectLabel.Text = Convert.ToString(userProfileDatatable.Rows[0].Field<int>("Total_Correct"));
            this.WrongLabel.Text = Convert.ToString(userProfileDatatable.Rows[0].Field<int>("Total_Wrong"));
            this.RatioLabel.Text = Convert.ToString(userProfileDatatable.Rows[0].Field<int>("Ratio_Score"));


        }
    }
}
    

