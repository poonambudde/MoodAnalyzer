using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyser_Problems;

namespace Mood_Analyser_Testing
{
    [TestClass]
    public class MoodAnalyserTestCase
    {
        [TestMethod]
        public void GivenMood_WhenSad_ShouldReturn_SAD_MOOD()
        {
            string moodMessage = "I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string expected = "SAD";

            string actual = moodAnalyser.AnalyseMood(moodMessage);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMood_WhenHappy_ShouldReturn_HAPPY_MOOD()
        {
            string moodMessage = "I am in Any Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string expected = "HAPPY";

            string actual = moodAnalyser.AnalyseMood(moodMessage);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMood_WhenNull_ShouldReturn_Null_MOOD_EXCEPTION_MESSAGE()
        {
            string moodMessage = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string expected = "Null message passed.";

            string actual = moodAnalyser.AnalyseMood(moodMessage);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMood_WhenEmpty_ShouldReturn_EMPTY_MOOD_EXCEPTION_MESSAGE()
        {
            string moodMessage = string.Empty;
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string expected = "Empty message passed.";

            string actual = moodAnalyser.AnalyseMood(moodMessage);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturns_MoodAnalyserObject()
        {          
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("Mood_Analyser_Problems.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }
    }
}