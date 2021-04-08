using System;

namespace UC4_Using_Reflection_MoodAnalyser
{
    public class Program
    {
       public static void Main(string[] args)
       {
         MoodAnalyser moodAnalyser = new MoodAnalyser(null);
         string mood = moodAnalyser.analyseMood();
               
       }
    }
}
