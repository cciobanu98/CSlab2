using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6.Specs.Extensions
{
    public static class IWebDriverExtensions
    {
        public static IWebElement WaitForElementToAppear(this IWebDriver driver, int waitTime, By waitingElement)
        {
            IWebElement wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime)).Until(ExpectedConditions.ElementExists(waitingElement));
            return wait;
        }

        public static IWebElement WaitForElementToBeClickable(this IWebDriver driver, int waitTime, IWebElement waitingElement)
        {
            IWebElement wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime)).Until(ExpectedConditions.ElementToBeClickable(waitingElement));
            return wait;
        }
    }
}
