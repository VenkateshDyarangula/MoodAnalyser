using System;
using System.Reflection;

namespace UC6_Reflection_Invoking_Method
{
    class Program
    {
       static void Main(string[] args)
        {
            Assembly executing = Assembly.GetExecutingAssembly();
            Type moodAnalyseType = executing.GetType("MoodAnalyserProject.MoodAnalyser");
            MethodInfo methodInfo = moodAnalyseType.GetMethod("analyseMood");
            object result = null;
            ConstructorInfo ctor = moodAnalyseType.GetConstructor(new[] { typeof(string) });
            object instance = ctor.Invoke(new object[] { "I am feeling happy today" });
            result = methodInfo.Invoke(instance, null);
            Console.WriteLine(result);
        }
    }
}
