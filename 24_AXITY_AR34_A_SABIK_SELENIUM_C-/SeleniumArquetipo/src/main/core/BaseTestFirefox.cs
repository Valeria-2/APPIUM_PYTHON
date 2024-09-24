using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumArquetipo1.Src.Main.Config;

namespace SeleniumArquetipo1.Src.Main.Core
{
    [TestFixture]
    internal class BaseFirefoxTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
           
            string geckoDriverPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Drivers", "geckodriver.exe");
            Console.WriteLine(geckoDriverPath);
           
            var options = new FirefoxOptions();
           
            driver = new FirefoxDriver(geckoDriverPath, options);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void EntrarPagina()
        {
            
            driver.Navigate().GoToUrl(WebConfig.WebsiteUrl);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose(); 
        }
    }
}
