using OpenQA.Selenium;
using System.Threading;
using Xunit;

namespace TestProject.UITest
{
    public class HealthCheckTests: BaseSteps 
    {
        [Fact]
        public void CheckHealthofOrderToCash()
        {
            NavigateToUrl();
            //Add Login Details          
            pageLocators.email.SendKeys("jainpallavi997@gmail.com");
            pageLocators.password.SendKeys("");
            pageLocators.btnLogin.MoveMouseAndClick();

            //Wait for HomePage to Load and click on Order to Crash demo
            wait.Until(x => driver.FindElement(pageLocators.homePage).Text.Contains("Analyses"));
            pageLocators.orderToCash.MoveMouseAndClick();
            Thread.Sleep(10);
            
            //Verify Health of order to crash demo
            wait.Until(x => driver.FindElement(pageLocators.analysisOTC).Text.Contains("Order-to-Cash Analysis"));
            Assert.Equal("Order-to-Cash Analysis", driver.FindElement(pageLocators.analysisOTC).Text);

            LogOutAndCloseBrowser();
        }

        [Fact]
        public void CheckHealthofPurchaseToPay()
        {
            NavigateToUrl();
            //Add Login Details          
            pageLocators.email.SendKeys("jainpallavi997@gmail.com");
            pageLocators.password.SendKeys("");
            pageLocators.btnLogin.MoveMouseAndClick();

            //Wait for HomePage to Load and click on Purchase To Pay demo
            wait.Until(x => driver.FindElement(pageLocators.homePage).Text.Contains("Analyses"));
            pageLocators.purchaseToPay.MoveMouseAndClick();
            Thread.Sleep(10);

            //Verify Health of Purchase To Pay demo
            wait.Until(x => driver.FindElement(pageLocators.analysisPTP).Text.Contains("Purchase-to-Pay Analysis"));
            Assert.Equal("Purchase-to-Pay Analysis", driver.FindElement(pageLocators.analysisPTP).Text);

            LogOutAndCloseBrowser();
        }

        [Fact]
        public void CheckHealthofServiceNowTicketing()
        {
            NavigateToUrl();
            //Add Login Details          
            pageLocators.email.SendKeys("jainpallavi997@gmail.com");
            pageLocators.password.SendKeys("");
            pageLocators.btnLogin.MoveMouseAndClick();

            //Wait for HomePage to Load and click on Service Now Ticketing demo
            wait.Until(x => driver.FindElement(pageLocators.homePage).Text.Contains("Analyses"));
            pageLocators.serviceNowTicketing.MoveMouseAndClick();
            Thread.Sleep(10);

            //Verify Health of Service Now Ticketing demo
            wait.Until(x => driver.FindElement(pageLocators.analysisSNT).Text.Contains("INCIDENT MANAGEMENT (TICKET STATUS)"));
            Assert.Equal("INCIDENT MANAGEMENT (TICKET STATUS)", driver.FindElement(pageLocators.analysisSNT).Text);

            LogOutAndCloseBrowser();
        }
    }
}
