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
        public string test_type { get; set; }
        public float timeTaken { get; set; }

        public TestTaken()
        {
        }

        //full constructor
        public TestTaken(Test test, User user, string[] answers, string test_type, float timeTaken)
        {
            this.test = test;
            this.user = user;
            this.answers = answers;
            this.test_type = test_type;
            this.timeTaken = timeTaken;
        }





        /// <summary>
        /// Posts and saves the testTaken on the database
        /// </summary>
      public  void postTestTaken()
        {
           

            try
            {

                VocLearningDataSetTableAdapters.TESTS_TAKENTableAdapter testTableAdapter = new VocLearningDataSetTableAdapters.TESTS_TAKENTableAdapter();
                testTableAdapter.InsertTest(user.user_id, 3, test_type, getTotalCorrectAnswers(), getTotalWrongAnswers(), DateTime.Now.Date, DateTime.Now.Date);
               
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
                if(test_type== "Translation")//check the Test_type because of different type of answers
                {
                    if (test.questions[i].translatedWord == answers[i])
                        correct++;
                }
                else if(test_type == "Listening")
                {
                    if (test.questions[i].word == answers[i])
                        correct++;
                }

                
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
                if (test_type == "Translation")//check the Test_type because of different type of answers
                {
                    if (test.questions[i].translatedWord != answers[i])
                        wrong++;
                }
                else if (test_type == "Listening")
                {
                    if (test.questions[i].word != answers[i])
                        wrong++;
                }
            }
            return wrong;
        }
    }
}
