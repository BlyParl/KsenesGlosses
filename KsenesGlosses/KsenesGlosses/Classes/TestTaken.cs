using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Diagnostics;
using KsenesGlosses.Classes;

namespace KsenesGlosses.Classes
{
    /// <summary>
    /// This class describes a Test that has been taken and answered by a User.
    /// </summary>
    class TestTaken
    {
        public Test test { get; set; }
        public User user { get; set; }
        public String[] answers { get; set; }
        public float timeTaken { get; set; }

        public TestTaken()
        {
        }

        //full constructor
        public TestTaken(Test test, User user, string[] answers, float timeTaken)
        {
            this.test = test;
            this.user = user;
            this.answers = answers;
            this.timeTaken = timeTaken;
        }





        /// <summary>
        /// Posts and saves the testTaken on the database
        /// </summary>
      public  void postTestTaken()
        {
            string strSQL = "INSERT INTO TESTS_TAKEN (User_ID, Test_Level, Test_Type, Correct_Answers, Wrong_Answers, Take_date, Time_to_finish) VALUES(@user_id, @test_level, @test_type, @correct_answers, @wrong_answers, @take_date, @time_to_finish)";


            try
            {

                using (OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.VocLearningConnectionString)) //this will colse the connection only need to open
                {
                    using (OleDbCommand command = new OleDbCommand(strSQL, connection))
                    {

                        connection.Open();
                        //set tthe Parameters
                        command.Parameters.AddWithValue("@user_id", user.user_id);
                        command.Parameters.AddWithValue("@test_level", 3);
                        command.Parameters.AddWithValue("@test_type","dnt Know");
                        command.Parameters.AddWithValue("@correct_answers", getTotalCorrectAnswers());
                        command.Parameters.AddWithValue("@wrong_answers", getTotalWrongAnswers());
                        command.Parameters.AddWithValue("@take_date", DateTime.Now.Date.ToString("d"));
                        command.Parameters.AddWithValue("@time_to_finish", timeTaken);

                        command.ExecuteScalar();
                    }
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message+"smthing wrong  here");

            }
        }

        /// <summary>
        /// Calculates and returns the total correct answers the user has made in the test.
        /// </summary>
        /// <returns></returns>
       public int getTotalCorrectAnswers()
        {
            int correct = 0;
           
            for(int i =0; i<answers.Length;i++)
            {
                if (test.questions[i].translatedWord == answers[i])
                    correct++;
            }
            return correct;
        }

        /// <summary>
        /// Calculates and returns the total wrong answers the user has made in the test.
        /// </summary>
        /// <returns></returns>
      public  int getTotalWrongAnswers()
        {
            int wrong = 0;

            for (int i = 0; i < answers.Length; i++)
            {
                if (test.questions[i].translatedWord != answers[i])
                    wrong++;
            }
            return wrong;
        }
    }
}
