using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;
namespace SeleniumTests.SeleniumEasy
{
    internal class DynamicDataLoadingDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            DynamicDataLoadingDemo.Open();
        }
        [Test]
        public void GetNewRandomUserInfo()
        {
            string expectedName = "First Name : ";
            DynamicDataLoadingDemo.ClickGetNewUser();
            string generatedUser = DynamicDataLoadingDemo.GetGeneratedUser();
            StringAssert.Contains(expectedName, generatedUser);
        }
        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
