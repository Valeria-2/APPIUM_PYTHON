using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumArquetipo1.Src.Main.Config;

namespace SeleniumArquetipo1.Example
{
    [TestFixture]
    public class MyTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            // Configura cualquier opción adicional que necesites, como ubicación del driver, etc.
            driver = new ChromeDriver(options);
        }

        [Test]
        public void MyTestFunctionality()
        {
            // Abre la URL almacenada en WebConfig

            driver.Navigate().GoToUrl(WebConfig.WebsiteUrl);

            
        }

        [TearDown]
        public void Teardown()
        {
            // Cierra el navegador al final de la prueba
            driver.Quit();
            driver.Dispose();
        }
    }
}
