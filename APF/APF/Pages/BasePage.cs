using APF.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace APF.Pages
{
    internal class BasePage
    {
        internal BasePage(IWebDriver driver, By pageSelector, bool searchContext = false)
        {
            Waits.WaitForElementToExist(driver, pageSelector);
            if (searchContext)
            {
                PageFactory.InitElements(driver.FindElement(pageSelector), this);
            }
            else
            {
                PageFactory.InitElements(driver, this);
            }
        }
    }
}
