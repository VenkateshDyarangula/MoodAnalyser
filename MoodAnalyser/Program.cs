using System;

namespace UC2_HandleException
{
    class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            string mood = moodAnalyser.analyseMood("I am in sad Mood"); //UC1.1
            Console.WriteLine(mood);
            /// string mood2 = moodAnalyser.analyseMood();
            ///Console.WriteLine(mood2);
            
        }
    }
}
