using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace KsenesGlosses.Classes
{
    class Voice
    {

       string word;
        public string answer { get;  set ; }
       

        public SpeechSynthesizer s = new SpeechSynthesizer();

        public SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();

       

        public void wordInput(String word1 )
        {
            word = word1;
            Choices commands = new Choices();
            commands.Add(new string[] { word ,"how are you"}); //input the world list
            GrammarBuilder grammarBuilder = new GrammarBuilder();        //Speech Rec input commands (christos)
            grammarBuilder.Append(commands);
            Grammar grammar = new Grammar(grammarBuilder);
           
            grammar = new DictationGrammar();// loads all the worlds

            

            recEngine.RequestRecognizerUpdate();
            recEngine.LoadGrammarAsync(grammar);
                
            recEngine.SetInputToDefaultAudioDevice();                      //mic device 

           // recEngine.SpeechRecognized += recEngine_SpeechRecognized;       //not going to be trigered if nothing is recognized

            

            s.SelectVoiceByHints(VoiceGender.Female);      //set the voice you want 

           

        }
        public void startRec()
        {
            recEngine.RecognizeAsync(RecognizeMode.Single);               // recognize once 
        }
        /// <summary>
        /// speaks the string you put in
        /// </summary>
        /// <param name="h"></param>
        public void say(String h) { s.Speak(h); } //speaks back at you 

        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)   //Speech Rec e returns what word we said  from the list  (christos)  
        {

            answer = e.Result.Text;
            if(answer == word)
            {
                say("correct");
                recEngine.RecognizeAsyncStop();//stop rec
            }
                   
            if(answer =="how are you")
            {
                say("fine");
            }
        }
       
    }

}
