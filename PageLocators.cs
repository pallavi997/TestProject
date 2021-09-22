using OpenQA.Selenium;
using OpenQA.Selenium.Remote;


namespace TestProject.UITest
{
    public class PageLocators
    {
        private RemoteWebDriver driver;
        public PageLocators(RemoteWebDriver driver)
        {
            this.driver = driver;
        }

        public By loginPage = By.XPath("//div[contains(@class,'ce-login-layout__body')]/h1[contains(@class, 'ce-login-layout__title')]");
        public By email = By.Name("username");
        public By password = By.Id("ce-input-1");
        public By btnLogin = By.XPath("//span[contains(@class, 'btn-text')]");
        public By homePage = By.XPath("//div[contains(@class, 'ce-header ce-header--middle no-padding')]/h2[contains(@class, 'padding-left--xs ce-header__title')]");
        public By orderToCash = By.XPath("//div[contains(@class, 'ce-tile-column ce-tile-column--with-css-grid ng-star-inserted')]/ce-analysis-tile/span/ce-tile/a[contains(@data-testing-uid, 'analysisListComponent-analysisName-Order to Cash - Process Overview (EUR) - EN-button')]");
        public By analysisOTC = By.XPath("//div[contains(@class, 'ce-text-comp ng-isolate-scope')]/div/span/font/span[contains(@style, 'font-size:44px')]");
        public By profileDropDown = By.XPath("//div[contains(@class, 'icon icon_avatar')]");
        public By btnLogOut = By.XPath("//div[contains(@ng-click, 'logoutUser()')]");
       
        public By purchaseToPay = By.XPath("//div[contains(@class, 'ce-tile-column ce-tile-column--with-css-grid ng-star-inserted')]/ce-analysis-tile/span/ce-tile/a[contains(@data-testing-uid, 'analysisListComponent-analysisName-Purchase to Pay - Demo - EN (EUR)-button')]");
        public By analysisPTP = By.XPath("//div[contains(@class, 'ce-text-comp ng-isolate-scope')]/div/span/font/span[contains(@style, 'font-size:40px')]");
        public By serviceNowTicketing = By.XPath("//div[contains(@class, 'ce-tile-column ce-tile-column--with-css-grid ng-star-inserted')]/ce-analysis-tile/span/ce-tile/a[contains(@data-testing-uid, 'analysisListComponent-analysisName-ServiceNow - Ticket Status-button')]");
        public By analysisSNT = By.XPath("//div[contains(@class, 'ce-text-comp ng-isolate-scope')]/div/font/span[contains(@style, 'font-size:28px')]");
    }
}
