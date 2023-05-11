using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void Click(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void ScrollUntilElementIsClicable(string locator)
        {
            IWebElement element = GetElement(locator);
            bool isClickable = false;
            int maxTries = 25;
            int currentTry = 0;
            while (!isClickable)
            {
                try
                {
                    element.Click();
                    isClickable = true;
                }
                catch(Exception exception)
                {
                    if (exception is ElementClickInterceptedException && currentTry < maxTries)
                    {
                        Driver.GetDriver().ExecuteJavaScript("window.scrollBy(0, 50)");
                        currentTry++;
                    }
                    else
                    {
                        throw exception;
                    }
                }
            }
        }

        internal static string GetElementCssAttributeValue(string locator, string attribute)
        {
            return GetElement(locator).GetCssValue(attribute);
        }

        internal static void WaitForElementCSSAttributeValueToBe(string locator, string attributeName, string expectedAttributeValue)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(driver => GetElement(locator).GetCssValue(attributeName) == (expectedAttributeValue));
        }

        internal static void WaitUntilElementIsVisibleAndContainsExpectedText(string locator, string expectedText)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(driver => GetElement(locator).Displayed && GetElement(locator).Text.Contains(expectedText));
        }

        internal static void WaitForElementCSSAttributeValueToChange(string locator, string attributeName, string initialAttributeValue)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(driver => GetElement(locator).GetCssValue(attributeName) != initialAttributeValue);
        }

        internal static void WaitUntilElementIsClickable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(driver => GetElement(locator).Enabled);
        }

        internal static void WaitUntilElementIsVisibleAndClickable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(driver => GetElement(locator).Enabled && GetElement(locator).Displayed);
        }
    }
}
