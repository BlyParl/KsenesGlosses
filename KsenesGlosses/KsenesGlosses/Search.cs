using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KsenesGlosses
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            String wordToSearch = search_textBox.Text;

            VocLearningDataSetTableAdapters.WORD_INFOTableAdapter wordInfoTableAdapter = new VocLearningDataSetTableAdapters.WORD_INFOTableAdapter();
            VocLearningDataSet.WORD_INFODataTable foundWord = wordInfoTableAdapter.findWord(wordToSearch, wordToSearch, wordToSearch);//den hksera pws na kanw query me idia metablith sta or

            String greekWord = null;
            String englishWord = null;
            String spanishWord = null;
            String greekPhonetic = null;
            String englishPhonetic = null;
            String spanishPhonetic = null;

            //if is found gets the strings and then shows them on the labels they represent
            if(foundWord.Rows.Count > 0)
            {
                greekWord = foundWord.Rows[0].Field<String>("Greek Word");
                englishWord = foundWord.Rows[0].Field<String>("English Word");
                spanishWord = foundWord.Rows[0].Field<String>("Spanish Word");
                greekPhonetic = foundWord.Rows[0].Field<String>("Greek Phonetic");
                englishPhonetic = foundWord.Rows[0].Field<String>("English Phonetic");
                spanishPhonetic = foundWord.Rows[0].Field<String>("Spanish Phonetic");

            }

            greek_label.Text = greekWord;
            english_label.Text = englishWord;
            spanish_label.Text = spanishWord;
            greekPhonetic_label.Text = greekPhonetic;
            englishPhonetic_label.Text = englishPhonetic;
            spanishPhonetic_label.Text = spanishPhonetic;
        }

        
    }
}
