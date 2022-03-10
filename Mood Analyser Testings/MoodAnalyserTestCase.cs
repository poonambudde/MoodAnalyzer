using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyser_Problems;

namespace Mood_Analyser_Testings
{
    [TestClass]
    public class MoodAnalyserTestCase
    {

        // TC 1.1 : Given Mood When Sad Should Return SAD Mood.
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

        // TC 1.2 : Given Mood When Happy Should Return HAPPY Mood.
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


        // TC 2.1 : Given Mood When Null Should Return HAPPY mood.
        [TestMethod]
        public void GivenMood_WhenNull_ShouldReturn_HAPPY_MOOD()
        {
            //Arrange
            string moodMessage = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string expected = "HAPPY";

            //Act
            string actual = moodAnalyser.AnalyseMood("HAPPY");

            //Assert
            Assert.AreEqual(expected, actual);
        }


        // TC 3.1 : Given Mood When Null Should Return Null Mood Exception Message.
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

        // TC 3.2 : Given Mood When Empty Should Return Empty Mood Exception Message.
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


        // TC 4.1 : Given MoodAnalyser Class Name Should Returns MoodAnalyser Object.
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturns_MoodAnalyserObject()
        {
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserReflector.CreateMoodAnalyser("Mood_Analyser_Problems.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        // TC 4.2 : Given Class Name When Improper Should Throw MoodAnalysis Exception.
        [TestMethod]
        public void GivenClassName_WhenImproper_Shouldthrow_MoodAnalysisException()
        {
            string expected = "Class Not Found";
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser();
                object obj = MoodAnalyserReflector.CreateMoodAnalyser("Mood_Analyser.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        // TC 4.3 : Given Constructor When Improper Should Throw MoodAnalysisException.
        [TestMethod]
        public void GivenConstructor_WhenImproper_Shouldthrow_MoodAnalysisException()
        {
            string expected = "Constructor is Not Found";
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser();
                object obj = MoodAnalyserReflector.CreateMoodAnalyser("Mood_Analyser_Problems.MoodAnalyser", "MoodAnalysers");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }


        //TC 5.1 :  Given MoodAnalyser Class Name When Proper Should Returns MoodAnalyser Object
        [TestMethod]
        public void GivenMoodAnalyserClassName_WhenProper_ShouldReturns_MoodAnalyserObject()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserReflector.CreateMoodAnalyserUsingParameterizedConstructor("Mood_Analyser_Problems.MoodAnalyser", "MoodAnalyser", "HAPPY");
            expected.Equals(obj);
        }

        // TC 5.2 : Given Class Name When Improper Should Throw MoodAnalysis Exception.
        [TestMethod]
        public void GivenClassName_WhenImproper_ShouldThrow_MoodAnalysisException()
        {
            string expected = "Class is Not Found";
            try
            {
                object moodAnalyserObject = MoodAnalyserReflector.CreateMoodAnalyserUsingParameterizedConstructor("Mood_Analyser_Problems.MoodAnalyser", "MoodAnalyser", "HAPPY");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        // TC 5.3 : Given Constructor Name When Improper Should Throw MoodAnalysisException.
        [TestMethod]
        public void GivenConstructorName_WhenImproper_Shouldthrow_MoodAnalysisException()
        {
            string expected = "Constructor is Not Found";
            try
            {
                object moodAnalyserObject = MoodAnalyserReflector.CreateMoodAnalyserUsingParameterizedConstructor("Mood_Analyser_Problems.MoodAnalyser", "MoodAnalyser", "HAPPY");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }


        //  TC 6.1 Given happy message using reflection when proper should return happy mood.
        [TestMethod]
        public void GivenHappyMessage_WhenUsingReflection_ThenShouldReturn_HappyMood()
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser("Happy");
                string gettingOutputofMoodAnalyseMethodByReflection = MoodAnalyserReflector.InvokeAnalyseMood("MoodAnalyser", "Happy");
                Assert.AreEqual("Happy".ToUpper(), gettingOutputofMoodAnalyseMethodByReflection);
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual("Method is not found", ex.Message);
            }
        }

        //  TC 6.2 Given happy message when improper method should throw Mood Analysis Exception.
        [TestMethod]
        public void GivenHappyMessage_WhenImproperMethod_ShouldThrow_MoodAnalysisException()

        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser("Happy");
                string gettingOutputofMoodAnalyseMethodByReflection = MoodAnalyserReflector.InvokeAnalyseMood("MoodAnalyser", "Happy");
                Assert.AreEqual("Happy".ToUpper(), gettingOutputofMoodAnalyseMethodByReflection);
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual("Method is not found", ex.Message);
            }
        }


        // TC 7.1 Given field when improper then should throw exception with no such field
        [TestMethod]
        public void GivenField_WhenImproper_ThenShouldThrow_NoSuchFieldException()
        {
            string Expected = "Field is not found";
            try
            {
                string result = MoodAnalyserReflector.SetField("Happy", "WrongmessageField");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual(Expected, ex.Message);
            }
        }

        // TC 7.2 Given message when null then should throw exception message should not be null
        [TestMethod]
        public void GivenMessage_WhenNull_ThenShouldThrow_MessageShouldNotNullException()
        {
            string Expected = "Message should not be null";
            try
            {
                string result = MoodAnalyserReflector.SetField(null, "message");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual(Expected, ex.Message);
            }
        }
    }
}
