using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using SeleniumArquetipo1.Src.Main.Utils;

namespace SeleniumArquetipo1.Src.Main.Core
{
    public class BaseChromeTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
           
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            // Combina la ruta del directorio del proyecto con la ruta al controlador de Chrome
            string chromeDriverPath = Path.Combine(projectDirectory, Constantes.ChromeDriver);

            // Configura las opciones del navegador Chrome
            var options = new ChromeOptions();

            // Inicializa el WebDriver de Chrome con las opciones y la ubicación del controlador
            driver = new ChromeDriver(chromeDriverPath, options);

            // Maximiza la ventana del navegador
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
