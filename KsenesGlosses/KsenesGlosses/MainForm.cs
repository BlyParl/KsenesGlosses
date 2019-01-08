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
    public partial class MainForm : Form
    {

        //values of chosen test:
        public String languageToLearn = null;
        public String languageKnown = null;
        public String category = null; //stays null if "any" is selected
        public int difficultyFrom = 0; //0 indicates any difficulty will be chosen
        public int difficultyTo = 0; //0 indicates any difficulty will be chosen
        public int numberOfQuestions = 5;
        //

        

       
        public MainForm()
        {
            InitializeComponent();

        }
        public Panel GetMainPanel()
        {
            return MainPanel;
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

        // gia na kinite to frame
        Point lastPoint;

        private void button4_Click(object sender, EventArgs e)
        {
            if(allChoicesCorrect())
            {

                //updates values of variables that can be used in determing the options of the test that was selected
                updateChoicesValues();
                

                //text translation form
                if (typeOfTest_comboBox.SelectedIndex == 0)
                {
                    foreach (Control c in this.MainPanel.Controls)
                    {
                        c.Visible = false;
                    }

                    TranslationTestForm TranslationTest = new TranslationTestForm();
                    TranslationTest.LoggedUser = user; // transfer the user info to the other form
                    TranslationTest.NoOfQuestons = numberOfQuestions; //transfer the No Of questions
                    TranslationTest.LanguegeToLearn = languageToLearn;//transfer the languege to learn
                    TranslationTest.LanguegeYouKnow = languageKnown;//transfer the known languege
                    TranslationTest.Dock = DockStyle.Fill;
                    TranslationTest.TopLevel = false;
                    MainPanel.Controls.Add(TranslationTest);
                    TranslationTest.Show();



                }
                //reverse text translation form
                else if (typeOfTest_comboBox.SelectedIndex == 1)
                {
                    //here will be shwon TranslationTestForm but with reversed languages translations
                    //NOT FINISHED SO MESSAGE BOX APPEARS FOR NOW
                    MessageBox.Show("This test is not available yet!");
                }
                //listening translation form (vocal test)
                else if(typeOfTest_comboBox.SelectedIndex == 2)
                {
                    foreach (Control c in this.MainPanel.Controls)
                    {
                        c.Visible = false;
                    }

                    VocalTestForm vocal = new VocalTestForm();
                    vocal.LoggedUser = user;// transfer the user info to the other form
                    vocal.NoOfQuestons = numberOfQuestions; //transfer the No Of questions
                    vocal.LanguegeToLearn = languageToLearn;//transfer the languege to learn
                    vocal.LanguegeYouKnow = languageKnown;//transfer the known languege
                    vocal.Dock = DockStyle.Fill;
                    vocal.TopLevel = false;
                    MainPanel.Controls.Add(vocal);
                    vocal.Show();

                }
                //image test
                else if(typeOfTest_comboBox.SelectedIndex == 3)
                {
                    foreach (Control c in this.MainPanel.Controls)
                    {
                        c.Visible = false;
                    }

                    ImageTestForm imagesTest = new ImageTestForm();
                    imagesTest.Dock = DockStyle.Fill;
                    imagesTest.TopLevel = false;
                    MainPanel.Controls.Add(imagesTest);
                    imagesTest.Show();
                }
                //image listening test
                else if(typeOfTest_comboBox.SelectedIndex == 4)
                {
                    //NOT FINISHED MESSAGE BOX APPEARS INSTEAD
                    MessageBox.Show("This test is not available yet!");
                }
            }

            


        }

        private void updateChoicesValues()
        {
            //language to learn
            if(learnEnglish_radioButton.Checked)
            {
                languageToLearn = "English";
            }
            else if(learnGreek_radioButton.Checked)
            {
                languageToLearn = "Greek";
            }
            else if(learnSpanish_radioButton.Checked)
            {
                languageToLearn = "Spanish";
            }
            
            //language known
            if(knowEnglish_RadioButton.Checked)
            {
                languageKnown = "English";
            }
            else if(knowGreek_radioButton.Checked)
            {
                languageKnown = "Greek";
            }
            else if(knowSpanish_radioButton.Checked)
            {
                languageKnown = "Spanish";
            }

            //category
            if(categoryAny_radioButton.Checked)
            {
                category = null;
            }
            else
            {
                category = categories_ComboBox.SelectedText;
            }
            
            //difficulties
            if(anyDifficulty_radioButton.Checked)
            {
                difficultyFrom = 0;
                difficultyTo = 0;
            }
            else
            {
                difficultyFrom = (int)difficultyFrom_numericUpDown.Value;
                difficultyTo = (int)difficultyTo_numericUpDown.Value;
            }

            //number of questions
            numberOfQuestions = (int)numberOfQuestions_numericUpDown.Value;
        }

        /// <summary>
        /// checks in the MainForm 
        /// </summary>
        /// <returns></returns>
        private bool allChoicesCorrect()
        {
            bool isCorrect = true;

            //checking if language to learn pressed
            if(!learnEnglish_radioButton.Checked && !learnGreek_radioButton.Checked && !learnSpanish_radioButton.Checked)
            {
                isCorrect = false;
                testErrors_label.Text = "Please Choose Language to Learn";
            }
            //checking if known language pressed
            else if(!knowEnglish_RadioButton.Checked && !knowGreek_radioButton.Checked && !knowSpanish_radioButton.Checked)
            {
                isCorrect = false;
                testErrors_label.Text = "Please Choose The language you know";
            }
            //checking if user selected the same language in both knowing and learning options
            else if(sameLanguageSelected())
            {
                isCorrect = false;
                testErrors_label.Text = "You can't choose the same language for learning and knowing";
            }
            //checking if difficulty from is not smaller than difficulty to as it makes no sense
            else if((difficultyFrom_numericUpDown.Value >= difficultyTo_numericUpDown.Value) && !anyDifficulty_radioButton.Checked)
            {
                
                isCorrect = false;
                testErrors_label.Text = "Difficulty from must be equal or smaller than difficuly to";
            }
            else
            {
                testErrors_label.Text = "";
            }
            return isCorrect;
        }
        /// <summary>
        /// returns true if same language was selected in both knowing and learning options. Used to avoid errors
        /// </summary>
        /// <returns></returns>
        private bool sameLanguageSelected()
        {
            bool isSame = false;

            if(learnEnglish_radioButton.Checked && knowEnglish_RadioButton.Checked)
            {
                isSame = true;
            }
            else if(learnGreek_radioButton.Checked && knowGreek_radioButton.Checked)
            {
                isSame = true;
            }
            else if(learnSpanish_radioButton.Checked && knowSpanish_radioButton.Checked)
            {
                isSame = true;
            }

            return isSame;
        }


        //picturebox3 EventHandlers
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
           /*
            this.pictureBox3.BackColor = Color.FromArgb(192, 225, 0);
            this.pictureBox1.BackColor = Color.FromArgb(34, 36, 49);
            this.pictureBox2.BackColor = Color.FromArgb(34, 36, 49);
            
            if (pictureBox1.BackColor == Color.FromArgb(192, 225, 0))
            {
                this.pictureBox3.BackColor = Color.FromArgb(192, 225, 0);
                this.pictureBox2.BackColor = Color.FromArgb(34, 36, 49);
            }
            else
              if (pictureBox2.BackColor == Color.FromArgb(192, 225, 0))
            {
                this.pictureBox3.BackColor = Color.FromArgb(192, 225, 0);
                this.pictureBox1.BackColor = Color.FromArgb(34, 36, 49);
            }
            else
            {
                this.pictureBox3.BackColor = Color.FromArgb(192, 225, 0);
            }
             */

        }
        
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

            //this.pictureBox3.BackColor = Color.FromArgb(192, 225, 0);
            //this.pictureBox1.BackColor = Color.FromArgb(34, 36, 49);
            //this.pictureBox2.BackColor = Color.FromArgb(34, 36, 49);

        }

        
        //picturebox2 EventHandlers

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            /* 
            this.pictureBox2.BackColor = Color.FromArgb(192, 225, 0);
            this.pictureBox1.BackColor = Color.FromArgb(34, 36, 49);

            this.pictureBox3.BackColor = Color.FromArgb(34, 36, 49);
            
            
           
              if (pictureBox3.BackColor == Color.FromArgb(192, 225, 0))
            {
                this.pictureBox2.BackColor = Color.FromArgb(192, 225, 0);
                this.pictureBox1.BackColor = Color.FromArgb(34, 36, 49);
            }
            else
               if (pictureBox1.BackColor == Color.FromArgb(192, 225, 0))
            {
                this.pictureBox2.BackColor = Color.FromArgb(192, 225, 0);
                this.pictureBox3.BackColor = Color.FromArgb(34, 36, 49);
            }
            else
            {
                this.pictureBox2.BackColor = Color.FromArgb(192, 225, 0);
            }
          */

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //this.pictureBox2.BackColor = Color.FromArgb(192, 225, 0);
            //this.pictureBox1.BackColor = Color.FromArgb(34, 36, 49);
            //this.pictureBox3.BackColor = Color.FromArgb(34, 36, 49);
        }

        

        //picturebox1 EventHandlers
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            /*
            this.pictureBox1.BackColor = Color.FromArgb(192, 225, 0);
            this.pictureBox2.BackColor = Color.FromArgb(34, 36, 49);
            this.pictureBox3.BackColor = Color.FromArgb(34, 36, 49);
            
            if (pictureBox3.BackColor == Color.FromArgb(192, 225, 0))
            {
                this.pictureBox1.BackColor = Color.FromArgb(192, 225, 0);
                this.pictureBox2.BackColor = Color.FromArgb(34, 36, 49);
            }
            else
              if (pictureBox2.BackColor == Color.FromArgb(192, 225, 0))
            {
                this.pictureBox1.BackColor = Color.FromArgb(192, 225, 0);
                this.pictureBox3.BackColor = Color.FromArgb(34, 36, 49);
            }
            else
            {
                this.pictureBox1.BackColor = Color.FromArgb(192, 225, 0);
            }
            */
        }
        private void pictureBox1_MouseLeave(object sender,EventArgs e)
        {
            this.Cursor = Cursors.Default;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.pictureBox1.BackColor = Color.FromArgb(192, 225, 0);
            //this.pictureBox2.BackColor = Color.FromArgb(34, 36, 49);
            //this.pictureBox3.BackColor = Color.FromArgb(34, 36, 49);
        }


        private void Close_Click(object sender, EventArgs e)
        {
            //exit aplication
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            //minimize aplication
            this.WindowState = FormWindowState.Minimized;
        }

        private void Border_MouseMove(object sender, MouseEventArgs e)
        {
            //metakinisi tou frame
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Border_MouseDown(object sender, MouseEventArgs e)
        {
            //apothikeuei to teleuteo simio pou afise to parathiro
            lastPoint = new Point(e.X, e.Y);
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            //create login item
            Login temp = new Login();
            //hide create form
            this.Hide();
            //shows login form
            temp.Show();
        }

        private void User_Settings_Click(object sender, EventArgs e)
        {
            //create User Settings item
            User_Settings temp = new User_Settings();
            //hide main form
            this.Hide();
            //shows User Settings form
            temp.Show();
        }

        public void Show_main_panel()
        {
            
            MainPanel.Visible = true;
            MainPanel.Dock = DockStyle.Fill;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminMenu.AdminEdit adminMenu = new AdminMenu.AdminEdit();
            adminMenu.Dock = DockStyle.Fill;
            adminMenu.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(adminMenu);
            adminMenu.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vocLearningDataSet.CATEGORIES' table. You can move, or remove it, as needed.
            this.cATEGORIESTableAdapter.Fill(this.vocLearningDataSet.CATEGORIES);

        }

        private void categoryChoose_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //disables or enables combobox if radiobutton is checked
            if(categoryChoose_RadioButton.Checked)
            {
                categories_ComboBox.Enabled = true;
            }
            else
            {
                categories_ComboBox.Enabled = false;
            }
        }

        private void chooseDifficulty_CheckedChanged(object sender, EventArgs e)
        {
            //enables the numerics of difficulty if radiobutton selected
            if(chooseDifficulty_radioButton.Checked)
            {
                difficultyFrom_numericUpDown.Enabled = true;
                difficultyTo_numericUpDown.Enabled = true;
            }
            else
            {
                difficultyFrom_numericUpDown.Enabled = false;
                difficultyTo_numericUpDown.Enabled = false;
            }
        }
    }
}
