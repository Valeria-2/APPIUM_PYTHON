using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;



namespace SeleniumArquetipo1.Src.Main.Pages
{
    public class LoginPage
    {
        public IWebDriver driver;
        private WebDriverWait wait;

        // Localizadores de elementos
        public readonly By usernameInput = By.XPath("//input[@name='username']");
        public readonly By passwordInput = By.XPath("//input[@name='password']");
        public readonly By loginButton = By.XPath("//button[@type='submit']");
        //public readonly By mensajeobligatorio2 = By.XPath("(//span[contains(.,'Obligatorio')])[2]");
        public readonly By mensajeobligatorio2 = By.XPath("(//span[contains(@class,'message')])[1]");




        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); 
        }

        // Métodos para interactuar con los elementos de la página

        public void EnterUsername(string username)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(usernameInput));
        
            driver.FindElement(usernameInput).SendKeys(username);

            
        }

        public void EnterPassword(string password)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(passwordInput));
            driver.FindElement(passwordInput).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(loginButton));
            driver.FindElement(loginButton).Click();
        }

        public void LogInValidUser(string username,string password)
        {
            EnterUsername(username);
            EnterPassword(password);

        }

        public bool IsLoginPageLoaded()
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(usernameInput));
                wait.Until(ExpectedConditions.ElementIsVisible(passwordInput));
                wait.Until(ExpectedConditions.ElementToBeClickable(loginButton));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
       

        public string GetUsernameFieldValue()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(usernameInput));
            return driver.FindElement(usernameInput).GetAttribute("value");
        }

        public string GetPasswordFieldValue()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(passwordInput));
            return driver.FindElement(passwordInput).GetAttribute("value");
        }
    }
}
