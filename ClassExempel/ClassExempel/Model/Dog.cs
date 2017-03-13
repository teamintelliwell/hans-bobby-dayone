using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace ClassExempel.Model
{
     class Dog
    {
        public string Name;
       public Gender Gender;
        public int Age;



        public string Bark()
        {
            string bark = "Woff!";

            SpeechSynthesizer synth = new SpeechSynthesizer();

            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);

            synth.Speak(bark);

            return bark;


        
           
        } 

    }

    

}
