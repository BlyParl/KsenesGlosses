using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Diagnostics;
using System.Data;

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
            //Due to the database not containing correct level, categories, and images these values will be ignored for now

            Test test = new Test();
            test.questions = new Question[numberOfQuestions];

            //gets random words in question

            VocLearningDataSetTableAdapters.WORD_INFOTableAdapter wordInfoAdapter = new VocLearningDataSetTableAdapters.WORD_INFOTableAdapter();

            int totalWords = (int)wordInfoAdapter.CountWords();

            Random random = new Random();

            for(int i = 0; i < numberOfQuestions; i++)
            {
                int randomNumber = random.Next(0, totalWords);
                VocLearningDataSet.WORD_INFODataTable wordDataTable = wordInfoAdapter.GetWordDataByID(randomNumber);

                //risky code please don't change
                //this will create random question that contains word data

                //dhlwsh metablitwn apo th bash
                String greekWord = wordDataTable.Rows[0].Field<String>("Greek Word");
                String englishWord = wordDataTable.Rows[0].Field<String>("English Word");
                String spanishWord = wordDataTable.Rows[0].Field<String>("Spanish Word");
                int level = wordDataTable.Rows[0].Field<Int16>("Level");
                String wordCategory = wordDataTable.Rows[0].Field<String>("Category");

                String word = "";
                String translatedWord = "";

                //checking languages
                if(languageTo == "Greek")
                {
                    word = greekWord;
                }
                else if(languageTo == "English")
                {
                    word = englishWord;
                }
                else if(languageTo == "Spanish")
                {
                    word = spanishWord;
                }

                if(languageFrom == "Greek")
                {
                    translatedWord = greekWord;
                }
                else if(languageFrom == "English")
                {
                    translatedWord = englishWord;
                }
                else if(languageFrom == "Spanish")
                {
                    translatedWord = spanishWord;
                }

                //puts a new question with all the correct values as selected

                test.questions[i] = new Question(word, translatedWord, languageTo, languageFrom, null, level, wordCategory) ;

            }

            //PutARandomword(test, numberOfQuestions,languageFrom,languageTo);

            return test;

        }

        /// <summary>
        /// Execute a query  get word to translate and the translated word from the DataBase to a test
        /// </summary>
        public static void PutARandomword(Test test, int numberOfQuestions, string languegeKnown, string languegeTolearn)
        {
            string strSQL="";
           

            switch (languegeKnown)
            {
                case "Greek":
                    if (languegeTolearn == "English" )
                    {
                            strSQL = "SELECT  ENGLISH.Word, GREEK.Word AS Expr1 FROM(ENGLISH INNER JOIN GREEK ON ENGLISH.Word_ID = GREEK.Word_ID ) ORDER BY Rnd(-(100000* GREEK.Word_ID)*Time())";
                        //  strSQL = "SELECT  ENGLISH.Word, GREEK.Word AS Expr1 FROM(ENGLISH INNER JOIN GREEK ON ENGLISH.Word_ID = GREEK.Word_ID ) where ENGLISH.Word_ID   = ROUND(rnd( ) * 5460)";
                    }
                    else if (languegeTolearn == "Spanish" )
                    {
                        strSQL = "SELECT  SPANISH.Word, GREEK.Word AS Expr1 FROM(SPANISH INNER JOIN GREEK ON SPANISH.Word_ID = GREEK.Word_ID )  ORDER BY Rnd(-(100000* GREEK.Word_ID)*Time()) ";

                    }
                    break;
                case "English":
                    if (languegeTolearn == "Spanish")
                    {
                        strSQL = "SELECT  SPANISH.Word, ENGLISH.Word AS Expr1 FROM(SPANISH INNER JOIN ENGLISH ON SPANISH.Word_ID = ENGLISH.Word_ID )  ORDER BY Rnd(-(100000* ENGLISH.Word_ID)*Time())";

                    }
                    else if (languegeTolearn == "Greek")
                    {
                        strSQL = "SELECT  GREEK.Word, ENGLISH.Word AS Expr1 FROM(GREEK INNER JOIN ENGLISH ON GREEK.Word_ID = ENGLISH.Word_ID ) ORDER BY Rnd(-(100000* ENGLISH.Word_ID)*Time())";

                    }
                    break;
                case "Spanish":
                    if (languegeTolearn == "English")
                    {
                        strSQL = "SELECT  ENGLISH.Word, SPANISH.Word AS Expr1 FROM(ENGLISH INNER JOIN SPANISH ON ENGLISH.Word_ID = SPANISH.Word_ID ) ORDER BY Rnd(-(100000* SPANISH.Word_ID)*Time())";

                    }
                    else if (languegeTolearn == "Greek")
                    {
                        strSQL = "SELECT  GREEK.Word, SPANISH.Word AS Expr1 FROM(GREEK INNER JOIN SPANISH ON GREEK.Word_ID = SPANISH.Word_ID ) ORDER BY Rnd(-(100000* SPANISH.Word_ID)*Time())";

                    }
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }


            VocLearningDataSet vasd = new VocLearningDataSet();
            
            
            try
            {

                using (OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.VocLearningConnectionString)) //this will colse the connection only need to open
                {
                    using (OleDbCommand command = new OleDbCommand(strSQL, connection))
                    {

                        connection.Open();
                        int counter = 0;
                        OleDbDataReader reader = command.ExecuteReader();
                        
                        //
                        //set the words
                        while (reader.Read() && counter< numberOfQuestions)
                        {
                            Question question = new Question();
                            question.word = reader.GetString(0);
                            question.translatedWord = reader.GetString(1);
                            question.language = null;
                            question.translatedLanguage = null;
                            question.image = null;
                            question.level = 0;
                            question.category = null;

                            test.questions[counter]= question;
                           
                            counter++;
                        }

                       
                    }
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

            }


        }




    }
}
