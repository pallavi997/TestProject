using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace TestProject.UITest
{
    public class BaseSteps
    {
        public static RemoteWebDriver driver;
        public static PageLocators pageLocators;
        public static WebDriverWait wait;

        public void NavigateToUrl()
        {
            InitialisingWebBrowser("chrome");

            driver.Navigate().GoToUrl("https://applications.eu-1.celonis.cloud/ui/login");           
            Thread.Sleep(5);
            pageLocators = new PageLocators(driver);
            wait.Until(x => driver.FindElement(pageLocators.loginPage).Text.Contains("Sign in - Celonis"));
        }

        public void LogOutAndCloseBrowser()
        {
            IWebElement profileDropDown = driver.FindElement(pageLocators.profileDropDown);
            profileDropDown.Click();
            IWebElement btnLogOut = driver.FindElement(pageLocators.btnLogOut);
            btnLogOut.Click();
            driver.Close();
            driver.Quit();
        }

        public void InitialisingWebBrowser(string brwoserName)
        {
            switch (brwoserName.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver(@"C:\Users\pjain\source\repos\TestProject.UITest\packages\Selenium.Chrome.WebDriver\driver");
                    break;

                case "firefox":
                    driver = new FirefoxDriver();
                    break;

                case "ie":
                    driver = new InternetExplorerDriver();
                    break;

            }
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }
    }
}




