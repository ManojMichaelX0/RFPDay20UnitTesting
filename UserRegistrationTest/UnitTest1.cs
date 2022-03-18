using UserRegistration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;


namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = new Mock<IUser>();
            test.Setup(x => x.UserChecker(It.IsAny<string>(), It.IsAny<string>())).Returns("Entered Details / Logging Succesfull");
            test.Setup(x => x.AgeChecker(It.IsAny<int>())).Returns("Welcome");
            var reg = new User(test.Object);
            var result = reg.UserChecker("manoj@gmail.com","12345678");
            Assert.AreEqual("Entered Details / Logging Succesfull", result);
            var age = reg.AgeChecker(23);
            Assert.AreEqual("Welcome", age);
        }
        [TestMethod]
        public void TestMethod_Fail()
        {
            var test = new Mock<IUser>();
            test.Setup(x => x.UserChecker(It.IsAny<string>(), It.IsAny<string>())).Returns("Entered Invalid Details");
            test.Setup(x => x.AgeChecker(It.IsAny<int>())).Returns("Invalid Age");
            var reg = new User(test.Object);
            var result = reg.UserChecker("manoj@gmail.com", "12345678");
            Assert.AreEqual("Entered Invalid Details", result);
            var age = reg.AgeChecker(13);
            Assert.AreEqual("Welcome", age);

        }
    }
}
