using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        void postTestTaken()
        {
            //NOT FINISHED
        }

        /// <summary>
        /// Calculates and returns the total correct answers the user has made in the test.
        /// </summary>
        /// <returns></returns>
        int getTotalCorrectAnswers()
        {
            //NOT FINISHED
            return -1;
        }

        /// <summary>
        /// Calculates and returns the total wrong answers the user has made in the test.
        /// </summary>
        /// <returns></returns>
        int getTotalWrongAnswers()
        {
            //NOT FINISHED
            return -1;
        }
    }
}
