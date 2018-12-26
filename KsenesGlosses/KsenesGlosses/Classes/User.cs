using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;//this is for the database
using System.Diagnostics;//this is for debug meesage 

namespace KsenesGlosses
{
    
    /// <summary>
    /// Class type of a User. Used to describe a user using this application.
    /// </summary>
   public class User //to ekana public gt eixa problhma me to na pernaw User antikeimeno metaxi twn  Forms dn 3erw poso swsto einai
    {
        public int user_id { get; private set; }
        public String first_name { get; set; }
        public String last_name { get; set; }
        public String user_name { get; set; }
        public String email_address { get; set; }

        /// <summary>
        /// will contain list of available statistics
        /// </summary>
        public enum statistic { }

        /// <summary>
        /// will contain list of available settings
        /// </summary>
        public enum setting { }

        //default constructor
        public User() 
        {
            user_id = -1; 
            first_name = null;
            last_name = null;
            user_name = null;
            email_address = null;
        }

        //full constructor
        public User(int user_id, string first_name, string last_name, string user_name, string email_address)
        {
            this.user_id = user_id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.user_name = user_name;
            this.email_address = email_address;
        }

        //returns true if same id, username and email
        public override bool Equals(object obj)
        {
            var user = obj as User;
            return user != null &&
                   user_id == user.user_id &&
                   user_name == user.user_name &&
                   email_address == user.email_address;
        }

        /// <summary>
        /// returns a User searching with username in Database
        /// </summary>
        /// <param name="user_name"></param>
        /// <returns>Type User from Database</returns>
        public static User getUserFromDB(String user_name)
        {
            User user = new User();
            string strSQL = "SELECT ID, First_Name, Last_Name, User_Name, Email_Adress FROM USERS WHERE(User_Name = @name) ";


            try
            {

                using (OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.VocLearningConnectionString)) //this will colse the connection only need to open
                {
                    using (OleDbCommand command = new OleDbCommand(strSQL, connection))
                    {

                        connection.Open();
                        command.Parameters.AddWithValue("@name", user_name);
                        OleDbDataReader reader = command.ExecuteReader();

                      
                        while (reader.Read())
                        {
                            user.user_id = reader.GetInt32(0);
                            user.first_name = reader.GetString(1);
                            user.last_name = reader.GetString(2);
                            user.user_name = reader.GetString(3);
                            user.email_address = reader.GetString(4);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

            }
            return user;
        }

        /// <summary>
        /// Returns true if username and password exist in database.
        /// This method will not encrypt the password, it should be done using encryptPassword(String password).
        /// </summary>
        /// <param name="user_name"></param>
        /// <param name="encryptedPassword"></param>
        /// <returns></returns>
        public static bool checkCredentials(String user_name, String encryptedPassword)
        {
            //NOT FINISHED
            return false;
        }

        /// <summary>
        /// Encrypts a password string and returns its hashed value.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static String encryptPassword(String password)
        {
            //NOT FINISHED
            //While this method is in prodcution it may change and may not return a String but it is adviced to.
            return null;
        }

        

        /// <summary>
        /// Creates a new user in database
        /// </summary>
        /// <param name="first_name"></param>
        /// <param name="last_name"></param>
        /// <param name="user_name"></param>
        /// <param name="email_address"></param>
        /// <param name="encryptedPassword"></param>
        public static void createUserInDB(String first_name, String last_name, String user_name, String email_address, String encryptedPassword)
        {
            //NOT FINISHED
            //IF THERE ARE CHANGES IN DATABASE STRUCTURE, METHOD WILL NOT WORK AND SHOULD BE CHANGED
            //This method might become bool or returning a database status code in future if we think it's better to prevent missing errors
        }

       

        /// <summary>
        /// Returns true if a username exists in database and is already being used.
        /// </summary>
        /// <param name="user_name"></param>
        /// <returns></returns>
        public static bool userExists(String user_name)
        {
            //NOT FINISHED
            return false;
        }

        

        /// <summary>
        /// Changes a selected setting of a user with its new Value (The changes are made both in Database and this object)
        /// </summary>
        /// <param name="setting"></param>
        /// <param name="newValue"></param>
        public void changeUserSetting(String setting, String newValue)
        {
            //NOT FINISHED
            //This method might become bool or returning a database status code in future if we think it's better to prevent missing errors
            //instead of String statistic, you might make this method with enum setting
        }



        /// <summary>
        /// Returns one's user statistic by a list of options
        /// </summary>
        /// <param name="statistic"></param>
        /// <returns></returns>
        public float getStatistic(String statistic)
        {
            //NOT FINISHED
            //instead of String statistic, you might make this method with enum statistic
            return -1f;
        }






    }
}
