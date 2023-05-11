namespace SeleniumFramework.Pages.DemoQA
{
    public class TextBox
    {
        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/text-box");
        }

        public static void EnterFullName(string name)
        {
            string locator = "//*[@id='userName']";
            Common.SendKeys(locator, name);
        }

        public static void EnterEmail(string email)
        {
            string locator = "//*[@id='userEmail']";
            Common.SendKeys(locator, email);
        }

        public static void EnterCurrentAdress(string currentAdress)
        {
            string locator = "//*[@id='currentAddress']";
            Common.SendKeys(locator, currentAdress);
        }

        public static void EnterPermanentAdress(string permanentAdress)
        {
            string locator = "//*[@id='permanentAddress']";
            Common.SendKeys(locator, permanentAdress);
        }

        public static void ClickSubmitButton()
        {
            string locator = "//*[@id='submit']";
            Common.ScrollUntilElementIsClicable(locator);
        }

        public static string GetFullName()
        {
            string locator = "//*[@id=\"name\"]";
            return Common.GetElementText(locator);
        }

        public static string GetEmail()
        {
            string locator = "//*[@id='email']";
            return Common.GetElementText(locator);
        }

        public static string GetCurrentAdress()
        {
            string locator = "/html/body/div[2]/div/div/div[2]/div[2]/div[2]/form/div[6]/div/p[3]";
            return Common.GetElementText(locator);
        }

        public static string GetPermanentAdress()
        {
            string locator = "/html/body/div[2]/div/div/div[2]/div[2]/div[2]/form/div[6]/div/p[4]";
            return Common.GetElementText(locator);
        }

        public static string GetEmailInputBorderColor()
        {
            string locator = "//*[@id='userEmail']";
            string expectedColor = "rgb(255, 0, 0)";
            Common.WaitForElementCSSAttributeValueToBe(locator, "border-color", expectedColor);
            return Common.GetElementCssAttributeValue(locator, "border-color");
        }
    }
}
