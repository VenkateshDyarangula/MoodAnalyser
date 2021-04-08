using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyser;
namespace UC1_MoodAnalyser_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "HAPPY";
            MoodAnalyser moodanalyser = new MoodAnalyser("I am in any mood");
            string result = moodanalyser.analyseMood("I am in Happy Mood");
            Assert.AreEqual(expected, result);
        }
    }
}
