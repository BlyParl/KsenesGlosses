using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsenesGlosses.Classes
{

    /// <summary>
    /// This class describes a Test that contains its questions and other properties 
    /// </summary>
    class Test
    {
        public Question[] questions { set; get; }
        public String name { set; get; }
        public int levelMin { set; get; }
        public int levelMax { set; get; }
        public String category { set; get; }
        public String languageFrom { set; get; }
        public String languageTo { set; get; }

        public Test()
        {
        }

        public Test(Question[] questions, string name, int levelMin, int levelMax, string category, string languageFrom, string languageTo)
        {
            this.questions = questions;
            this.name = name;
            this.levelMin = levelMin;
            this.levelMax = levelMax;
            this.category = category;
            this.languageFrom = languageFrom;
            this.languageTo = languageTo;
        }

        /// <summary>
        /// Creates and returns a random Test using random questions from database taking into account the parameters of this method
        /// </summary>
        /// <param name="numberOfQuestions"></param>
        /// <param name="levelMin"></param>
        /// <param name="levelMax"></param>
        /// <param name="category"></param>
        /// <param name="languageFrom"></param>
        /// <param name="languageTo"></param>
        /// <returns></returns>
        public static Test createRandomTest(int numberOfQuestions, int levelMin, int levelMax, String category, String languageFrom, String languageTo)
        {
            //NOT FINISHED
            //using this method for general purposes as it can be used later for various types of tests instead of only one specific type as questions and words are accessible through this
            return null;

        }

        



    }
}
