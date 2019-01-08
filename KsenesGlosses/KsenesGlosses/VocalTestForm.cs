using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KsenesGlosses.Classes;

namespace KsenesGlosses
{
    public partial class VocalTestForm : Form
    {

        Test test;

        TestTaken testTaken;

        Voice voice = new Voice();

        int count = 0;//a number to navigate  questions[]

        int nofq;//number of questions

        string languegeToLearn;

        string languegeYouKnow;

        string[] answers;

        private User user;

        /// <summary>
        /// Gets or sets the user that Loged in
        /// </summary>
        public User LoggedUser
        {
            get { return user; }
            set { user = value; }
        }

        /// <summary>
        /// Number of questons 
        /// </summary>
        public int NoOfQuestons
        {
            get { return nofq; }
            set { nofq = value; }
        }

        /// <summary>
        /// Languegw you want to learn
        /// </summary>
        public string LanguegeToLearn
        {
            get { return languegeToLearn; }
            set { languegeToLearn = value; }
        }
        /// <summary>
        /// Languegw you already know
        /// </summary>
        public string LanguegeYouKnow
        {
            get { return languegeYouKnow; }
            set { languegeYouKnow = value; }
        }

        public VocalTestForm()
        {
            InitializeComponent();
        }

        

        private void answerButton_Click(object sender, EventArgs e)
        {
            progressBar1.Step = 1; //sets the progres bar length 
            progressBar1.PerformStep(); //progress bar goes forward
            if (progressBar1.Value == nofq - 1) //track the progresbar if it is full disable the button
            {
                nextButton.Enabled = false;
                previousButton.Enabled = true;
            }

            previousButton.Enabled = true;



            count++;
            voice.say(test.questions[count].word);//says the word 
            answerTextBox.Text = answers[count];

        }

        private void VocalTestForm_Load(object sender, EventArgs e)
        {
            test = Test.createRandomTest(nofq, 2, 4, "", languegeYouKnow, languegeToLearn); //create a test 
            progressBar1.Maximum = nofq - 1;

            progressBar1.Step = nofq - 1; //sets the progres bar length 

            voice.say(test.questions[0].word); // says first word of questions[] 

            answers = new string[nofq]; //set the number of answers

            previousButton.Enabled = false; //disable the previus button at the start 

            testTaken = new TestTaken(test, user, answers,"Listening", 0);  //create testtake to do the work for the answers 
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            progressBar1.Step = -1; //sets the progres bar to go reverse
            progressBar1.PerformStep();

            if (progressBar1.Value == 0)
            {
                progressBar1.Step = progressBar1.Maximum / (nofq - 1); //sets the progres bar lto go straight
                previousButton.Enabled = false;
                nextButton.Enabled = true;
            }
            nextButton.Enabled = true;
            count--;
            voice.say(test.questions[count].word);// says the word of questions[] 

            answerTextBox.Text = answers[count];
        }

        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {
            answers[count] = answerTextBox.Text;//get the answer of the user 
        }

        private void listenWord_Click(object sender, EventArgs e)
        {
            voice.say(test.questions[count].word);//says the word 
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test Type :" + testTaken.test_type + "\n" + "correct answers :" + testTaken.getTotalCorrectAnswers() + "\n" + "wrong answers :" + testTaken.getTotalWrongAnswers() + "\n" + "Test finished Please Exit");
            nextButton.Enabled = false;
            previousButton.Enabled = false;
            doneButton.Enabled = false;
            testTaken.postTestTaken();//here we post the results in the DB

        }
    }
}
