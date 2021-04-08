using System;

namespace UC3_InvalidMood
{
    class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            string mood = moodAnalyser.analyseMood();
              
        }
    }
}
