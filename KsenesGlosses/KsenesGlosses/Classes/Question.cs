using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.OleDb;
using System.Diagnostics;


namespace KsenesGlosses.Classes
{
    /// <summary>
    /// A question that contains the word asked, its correct translation and other properties associated with the word.
    /// </summary>
    class Question
    {
        public String word { set; get; }
        public String translatedWord { set; get; }
        public String language { set; get; }
        public String translatedLanguage { set; get; }
        public Image image { set; get; }
        public int level { set; get; }
        public String category { set; get; }

        public Question()
        {
            
        }

        //Full constructor, use null if something not exists (ex. image or category).
        public Question(string word, string translatedWord, string language, string translatedLanguage, Image image, int level, string category)
        {
            this.word = word;
            this.translatedWord = translatedWord;
            this.language = language;
            this.translatedLanguage = translatedLanguage;
            this.image = image;
            this.level = level;
            this.category = category;
        }


       

    }


}
