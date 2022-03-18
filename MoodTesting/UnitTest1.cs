using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
using Moq;

namespace MoodTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Using_Mock_Happy()
        {
            var analyze = new Mock<IAnalyzer>();
            analyze.Setup(x => x.MoodChecker()).Returns("Checking Mood");
            analyze.Setup(x => x.IsHappy(It.IsAny<string>())).Returns("Your Are Happy");
            var mood =analyze.Object;
            var result = mood.IsHappy("Happy");
            Assert.AreEqual("Your Are Happy",result);
        }
        [TestMethod]
        public void TestMethod_Using_Mock_Not_Happy()
        {
            var analyze = new Mock<IAnalyzer>();
            analyze.Setup(x => x.MoodChecker()).Returns("Checking Mood");
            analyze.Setup(x => x.IsHappy(It.IsAny<string>())).Returns("Your are Not Happy");
            var mood = analyze.Object;
            var result = mood.IsHappy("Not Happy");
            Assert.AreEqual("Your are Not Happy", result);
        }
    }
}
