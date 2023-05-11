using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoQA;
namespace SeleniumTests.DemoQA
{
    internal class TextBoxTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            TextBox.Open();
        }
        [Test]
        public void FillFormWithValidInfo() 
        {
            string expectedName = "Simonas";
            string expectedEmail = "test@test.com";
            string expectedCurrentAdress = "Gatve abc";
            string expectedPermanentAdress = "Namai namuciai";
            TextBox.EnterFullName(expectedName);
            TextBox.EnterEmail(expectedEmail);
            TextBox.EnterCurrentAdress(expectedCurrentAdress);
            TextBox.EnterPermanentAdress(expectedPermanentAdress);
            TextBox.ClickSubmitButton();
            string actualName = TextBox.GetFullName();
            string actualEmail = TextBox.GetEmail();
            string actualCurrentAdress = TextBox.GetCurrentAdress();
            string actualPermanentAdress = TextBox.GetPermanentAdress();
            StringAssert.Contains(expectedName,actualName);
            StringAssert.Contains(expectedEmail, actualEmail);
            StringAssert.Contains(expectedCurrentAdress, actualCurrentAdress);
            StringAssert.Contains(expectedPermanentAdress, actualPermanentAdress);
        }
        [Test]
        public void EmailValidation()
        {
            string invalidEmail = "abc";
            string expectedColor = "rgb(255, 0, 0)";
            TextBox.EnterEmail(invalidEmail);
            TextBox.ClickSubmitButton();
            string actualEmailInputBorderColor = TextBox.GetEmailInputBorderColor();
            Assert.AreEqual(expectedColor, actualEmailInputBorderColor);
        }
        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
