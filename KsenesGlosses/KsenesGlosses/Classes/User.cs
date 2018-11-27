using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsenesGlosses
{
    
    //@VP
    class User
    {
        public int user_id { get; private set; }
        public String first_name { get; set; }
        public String last_name { get; set; }
        public String user_name { get; set; }
        public String email_address { get; set; }

        //will contain list of available statistics
        public enum statistic { }
        //will contain list of available settings
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

        //returns a User searching with username in Database
        public static User getUserFromDB(String user_name)
        {
            //NOT FINISHED
            return null;
        }

        //returns true if username and password exist in database
        public static bool checkCredentials(String user_name, String encryptedPassword)
        {
            //NOT FINISHED
            //This method will not encrypt the password, it should be done using encryptPassword(String password)
            return false;
        }

        //encrypts a password string and returns its hashed value
        public static String encryptPassword(String password)
        {
            //NOT FINISHED
            //While this method is in prodcution it may change and may not return a String but it is adviced to.
            return null;
        }

        //creates a new user in database
        public static void createUserInDB(String first_name, String last_name, String user_name, String email_address, String encryptedPassword)
        {
            //NOT FINISHED
            //IF THERE ARE CHANGES IN DATABASE STRUCTURE, METHOD WILL NOT WORK AND SHOULD BE CHANGED
            //This method might become bool or returning a database status code in future if we think it's better to prevent missing errors
        }

        //returns true if a username exists in database and is being already used
        public static bool userExists(String user_name)
        {
            //NOT FINISHED
            return false;
        }

        //changes with new value a selected setting of a user (The changes are made both in Database and this)
        public void changeUserSetting(String setting, String newValue)
        {
            //NOT FINISHED
            //This method might become bool or returning a database status code in future if we think it's better to prevent missing errors
            //instead of String statistic, you might make this method with enum setting
        }

        //returns one's user statistic by a list of options
        public float getStatistic(String statistic)
        {
            //NOT FINISHED
            //instead of String statistic, you might make this method with enum statistic
            return -1f;
        }





    }
}
