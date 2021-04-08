using System;
using System.Collections.Generic;
using System.Text;

namespace UC1_Mood_Analyser
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser()
        {
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string analyseMood(string message)
        {
            if (message.Equals("I am in Happy Mood")) //or I am in Sad Mood
            {
                return "HAPPY";
            }
            else
            {
                return "SAD";
            }
        }
    }
}
