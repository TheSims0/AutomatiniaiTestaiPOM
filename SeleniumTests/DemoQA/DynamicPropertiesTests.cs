using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoQA;
namespace SeleniumTests.DemoQA
{
    internal class DynamicPropertiesTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            DynamicProperties.Open();
        }
        [Test]
        public void ClickButtonAfter5Seconds()
        {
            DynamicProperties.WaitUntilButtonIsClickable();
            DynamicProperties.ClickWillEnable5SecondsButton();
        }
        [Test]
        public void WaitUntilButtonChangesColor()
        {
            string initialColor = DynamicProperties.GetInitialColor();
            string updatedColor = DynamicProperties.GetUpdatedColor(initialColor);
            Assert.AreNotEqual(initialColor, updatedColor);
        }
        [Test]
        public void WaitUntilButtonIsVisible()
        {
            DynamicProperties.WaitUntilButtonIsVisible();
            DynamicProperties.ClickVisibleButton();
        }
        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
