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
using System.Diagnostics;

namespace KsenesGlosses
{
    public partial class TranslationTestForm : Form
    {
       
        
        
        Test test;

        TestTaken testTaken;

        int count = 0;//a number to navigate  questions[]

        int nofq = 5;//number of questions

        string[] answers;
        public TranslationTestForm()
        {
            InitializeComponent();

            
        }
        private User user;

        /// <summary>
        /// Gets or sets the user that Loged in
        /// </summary>
        public User LoggedUser
        {
            get { return user; }
            set { user = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Step = progressBar1.Maximum / (nofq - 1); //sets the progres bar length 
            progressBar1.PerformStep(); //progress bar goes forward
            if (progressBar1.Value == 100) //track the progresbar if it is full disable the button
            {
                nextButton.Enabled = false;
                previousButton.Enabled = true;
            }

            previousButton.Enabled = true;

            

            count++;
            wordToTranslateTextBox.Text = test.questions[count].word;//put the word into the screen
            answerTextBox.Text = answers[count];
           
           
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Current Test?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MainForm main = new MainForm();
                this.Close();         
             
            }
        }

        private void TranslationTestForm_Load(object sender, EventArgs e)
        {
            
            test = Test.createRandomTest(nofq, 2, 4, "", "", ""); //create a test 

           

            progressBar1.Step = progressBar1.Maximum/(nofq-1); //sets the progres bar length 

            wordToTranslateTextBox.Text = test.questions[0].word; // first word of questions[] goes into the screen

            answers = new string[nofq]; //set the number of answers

            previousButton.Enabled = false; //disable the previus button at the start 

            testTaken = new TestTaken(test, user, answers, 0);  //create testtake to do the work for the answers 
           

        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            progressBar1.Step = - progressBar1.Maximum / (nofq-1); //sets the progres bar to go reverse
            progressBar1.PerformStep();

            if (progressBar1.Value == 0)
            {
                progressBar1.Step = progressBar1.Maximum / (nofq - 1); //sets the progres bar lto go straight
                previousButton.Enabled = false;
                nextButton.Enabled = true;
            }
            nextButton.Enabled = true;
            count--;
            wordToTranslateTextBox.Text = test.questions[count].word;

            answerTextBox.Text = answers[count];
        }

        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {
            answers[count] = answerTextBox.Text;//get the answer of the user 
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("correct answers :" + testTaken.getTotalCorrectAnswers()+"\n"+"wrong answers :"+testTaken.getTotalWrongAnswers()+"\n"+"Test finished Please Exit");
            nextButton.Enabled = false;
            previousButton.Enabled = false;
            doneButton.Enabled = false;
            testTaken.postTestTaken();//here we post the results in the DB
        }
    }
}
