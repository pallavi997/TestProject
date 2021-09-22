using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;
using static TestProject.UITest.BaseSteps;

namespace TestProject.UITest
{
    public static class Element
    {
        public static void SendKeys(this By locator, string text)
        {
            IWebElement element = driver.FindElement(locator);
            element.SendKeys(text);
        }
        public static void MoveMouseAndClick(this By locator)
        {
            IWebElement element = driver.FindElement(locator);
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Build().Perform();
            Thread.Sleep(500);
            builder.MoveToElement(element).Click().Perform();
        }
    }
}
