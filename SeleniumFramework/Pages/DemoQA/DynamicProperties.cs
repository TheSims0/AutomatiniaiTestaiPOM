namespace SeleniumFramework.Pages.DemoQA
{
    public class DynamicProperties
    {
        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/dynamic-properties");
        }

        public static string GetInitialColor()
        {
            string locator = "//*[@id='colorChange']";
            return Common.GetElementCssAttributeValue(locator, "color");
        }

        public static string GetUpdatedColor(string initialColor)
        {
            string locator = "//*[@id='colorChange']";
            Common.WaitForElementCSSAttributeValueToChange(locator, "color", initialColor);
            return Common.GetElementCssAttributeValue(locator, "color");
        }

        public static void WaitUntilButtonIsClickable()
        {
            string locator = "//*[@id='enableAfter']";
            Common.WaitUntilElementIsClickable(locator);
        }

        public static void ClickWillEnable5SecondsButton()
        {
            string locator = "//*[@id='enableAfter']";
            Common.Click(locator);
        }

        public static void WaitUntilButtonIsVisible()
        {
            string locator = "//*[@id='visibleAfter']";
            Common.WaitUntilElementIsVisibleAndClickable(locator);
        }

        public static void ClickVisibleButton()
        {
            string locator = "//*[@id='visibleAfter']";
            Common.Click(locator);
        }
    }
}
