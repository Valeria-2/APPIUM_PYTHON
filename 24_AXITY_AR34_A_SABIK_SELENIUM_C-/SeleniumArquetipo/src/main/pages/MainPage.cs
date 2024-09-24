using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumArquetipo1.Src.Main.Pages
{
    public class MainPage
    {

        public IWebDriver driver;
        private WebDriverWait wait;
        public By MyInfoButton = By.XPath("//a[contains(.,'Admin')]");
        public By FirstName = By.XPath("//input[@class='oxd-input oxd-input--active']");
        public By FlechitaMenu = By.XPath("//i[@class='oxd-icon bi-chevron-left']");

        // Constructor
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void FirstNameInput(string name)
        {
            LoginPage loginPage = new (driver);
            loginPage.LogInValidUser("Admin", "admin123");

            wait.Until(ExpectedConditions.ElementIsVisible(MyInfoButton));
            driver.FindElement(MyInfoButton).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(FlechitaMenu));

            driver.FindElement(FlechitaMenu).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(FirstName));
          
            driver.FindElement(FirstName).SendKeys(name);


        }


    }
}
