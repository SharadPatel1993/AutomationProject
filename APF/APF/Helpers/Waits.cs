using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace APF.Helpers
{
    internal static class Waits
    {
        private static readonly TimeSpan TimeOut = TimeSpan.FromSeconds(20);

        internal static bool WaitForElementToExist(IWebDriver driver, By elementSelector)
        {
            return WaitCondition(driver, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(elementSelector));
        }

        internal static bool WaitForElementToBeClickable(IWebDriver driver, By elementSelector)
        {
            return WaitCondition(driver, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(elementSelector));
        }

        private static bool WaitCondition(IWebDriver driver, Func<IWebDriver, IWebElement> expectedConditions)
        {
            var wait = new WebDriverWait(driver, TimeOut);
            var element = wait.Until(expectedConditions);
            if (element == null) throw new NoSuchElementException();
            return true;
        }
    }
}
