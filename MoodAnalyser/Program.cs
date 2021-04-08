using System;
using UC1_Mood_Analyser;

namespace UC1_Mood_Analyser
{
    class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyser mood = new MoodAnalyser();
            String result=mood.analyseMood("I am in Happy Mood"); //or Sad
            Console.WriteLine(result);
        }
    }
}
