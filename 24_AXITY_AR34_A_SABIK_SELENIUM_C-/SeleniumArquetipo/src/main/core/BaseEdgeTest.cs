using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using SeleniumArquetipo1.Src.Main.Config;
using SeleniumArquetipo1.Src.Main.Utils;

namespace SeleniumArquetipo1.Src.Main.Core
{
    public class BaseEdgeTest
    {
        public IWebDriver? driver;

        [SetUp]
        public void Setup()
        {

            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string edgeDriverPath = Path.Combine(projectDirectory, Constantes.EdgeDriver);

            var options = new EdgeOptions();

            // Inicializa el WebDriver de Edge con las opciones y la ubicación del controlador
            driver = new EdgeDriver(edgeDriverPath, options);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
            driver?.Dispose(); 
        }
    }
}
