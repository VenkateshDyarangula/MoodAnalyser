using System;

namespace UC5_UsingParameterized_MoodAnalyser
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
