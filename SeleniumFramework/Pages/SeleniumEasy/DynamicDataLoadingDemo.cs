namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class DynamicDataLoadingDemo
    {
        public static void Open()
        {
            Driver.OpenPage("https://demo.seleniumeasy.com/dynamic-data-loading-demo.html");
        }
        public static void ClickGetNewUser()
        {
            string locator = "//*[@id='save']";
            Common.Click(locator);
        }
        public static string GetGeneratedUser()
        {
            string locator = "//*[@id='loading']";
            string expectedText = "First Name : ";
            Common.WaitUntilElementIsVisibleAndContainsExpectedText(locator, expectedText);
            return Common.GetElementText(locator);
        }
    }
}
