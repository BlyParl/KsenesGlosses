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
    public partial class TestVoiceRec : Form
    {
        Voice voice = new Voice(); // voice Class that i made
       
        
        public TestVoiceRec()
        {
            InitializeComponent();
        }

        private void enableVoiceButton_Click(object sender, EventArgs e)//button enables mic and inputs word
        {


            voice.startRec(); //use this to start 


            enableVoiceButton.Enabled = false;
            disableVoiceButton.Enabled = true;
            
           
        }
             
        private void disableVoiceButton_Click(object sender, EventArgs e)//disables the mic and closes rec
        {
            voice.recEngine.RecognizeAsyncStop();
            disableVoiceButton.Enabled = false;
            enableVoiceButton.Enabled = true;
        }

       
        private void TestVoiceRec_Load(object sender, EventArgs e)
        {
            voice.wordInput(wordLabel.Text);// in put the word 
        }
    }
}
