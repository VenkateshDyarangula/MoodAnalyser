using System;
using System.Collections.Generic;
using System.Text;

namespace UC6_Reflection_Invoking_Method
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
         public string analyseMood()
         {
             try
             {
                 if (this.message.Equals(string.Empty))
                 {
                     throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                 }
                 if (this.message.Contains("sad"))
                     return "SAD";
                 else
                     return "HAPPY";
             }
             catch (NullReferenceException)
             {
                 throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
             }
         }
     }
}
