using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;
namespace SeleniumTests.SeleniumEasy
{
    internal class BasicFirstFormDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            BasicFirstFormDemo.Open();
        }
        [Test]
        public void SingleInputField()
        {
            string expectedResult = "Simonas";
            BasicFirstFormDemo.EnterMessage(expectedResult);
            BasicFirstFormDemo.ClickShowMessage();
            string actualResult = BasicFirstFormDemo.GetYourMessage();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void DoubleInputField()
        {
            string valueA = "3";
            string valueB = "4";
            string expectedResult = "7";
            BasicFirstFormDemo.EnterValueA(valueA);
            BasicFirstFormDemo.EnterValueB(valueB);
            BasicFirstFormDemo.ClickGetTotal();
            string actualResult = BasicFirstFormDemo.GetTotalAB();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TearDown] 
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
