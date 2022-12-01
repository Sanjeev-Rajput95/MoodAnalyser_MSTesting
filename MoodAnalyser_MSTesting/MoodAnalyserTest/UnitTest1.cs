using MoodAnalyser_MSTesting;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoodAnayser moodAnayser = new MoodAnayser("I am in Any Mood");
            string result = moodAnayser.AnalyseMood();
            Assert.AreEqual("HAPPY".ToUpper(),result);
        }

        [TestMethod]
        public void TestSadOrHappyMood()
        {
            MoodAnayser moodAnayser = new MoodAnayser("I am in Sad Mood");
            string result = moodAnayser.AnalyseMood();
            Assert.AreEqual("SAD".ToUpper(), result);
        }

        [TestMethod]
        public void TestForHappyMood()
        {
            MoodAnayser moodAnayser = new MoodAnayser("I am in Happy Mood");
            string result = moodAnayser.AnalyseMood();
            Assert.AreEqual("HAPPY".ToUpper(), result);
        }

        [TestMethod]
        public void TestExceptionHandling()
        {
            MoodAnayser moodAnayser = new MoodAnayser(null);
            string result = moodAnayser.AnalyseMood();
            Assert.AreEqual("Should Not NULL value", result);
        }

        [TestMethod]
        public void TestExceptionReturn_HAPPY_WhenPassNull()
        {
            MoodAnayser moodAnayser = new MoodAnayser(null);
            string result = moodAnayser.AnalyseMood();
            Assert.AreEqual("It is Null", result);
        }

        [TestMethod]
        public void CustomException_when_Null()
        {
            MoodAnayser moodAnayser = new MoodAnayser(null);
            string result = moodAnayser.AnalyseMood();
            Assert.AreEqual("It is Null", result);
        }
        [TestMethod]
        public void CustomException_when_Empty()
        {
            MoodAnayser moodAnayser = new MoodAnayser("");
            string result = moodAnayser.AnalyseMood();
            Assert.AreEqual("It is a empty string", result);
        }

        [TestMethod]
        public void Reflection_GivenClassName_Return_Object()
        {
            MoodAnayser moodAnayser = new MoodAnayser();
            var obj = MoodAnayserFactory.CreateInstance("MoodAnalyser_MSTesting.MoodAnayser");
            Assert.IsInstanceOfType(moodAnayser, (Type)obj);
        }

        [TestMethod]
        public void Reflection_GivenInvalideClass_Return_NoSuchClass_Exception()
        {
            //MoodAnayser moodAnayser = new MoodAnayser();
            var obj = MoodAnayserFactory.CreateInstance("MoodAnalyser_MSTesting.MoodAnayse");
            Assert.AreEqual("No such class", obj);
        }
    }
}