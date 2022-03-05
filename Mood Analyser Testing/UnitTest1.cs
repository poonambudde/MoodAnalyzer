using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyser_Problems;

namespace Mood_Analyser_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMood_WhenSad_ShouldReturn_SAD_MOOD()
        {
            //Arrange
            string moodMessage = "I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string expected = "SAD";

            //Act
            string actual = moodAnalyser.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMood_WhenHappy_ShouldReturn_HAPPY_MOOD()
        {
            //Arrange
            string moodMessage = "I am in Any Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string expected = "HAPPY";

            //Act
            string actual = moodAnalyser.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMood_WhenNull_ShouldReturn_Null_MOOD_EXCEPTION_MESSAGE()
        {
            //Arrange
            string moodMessage = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string expected = "Null message passed.";

            //Act
            string actual = moodAnalyser.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMood_WhenEmpty_ShouldReturn_EMPTY_MOOD_EXCEPTION_MESSAGE()
        {
            //Arrange
            string moodMessage = string.Empty;
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string expected = "Empty message passed.";

            //Act
            string actual = moodAnalyser.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
