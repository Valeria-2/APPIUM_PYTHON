using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumArquetipo1.Src.Main.Utils;
using Selenium.Extensions;
using SeleniumArquetipo1.Src.Test.TestReport.Models;


namespace SeleniumArquetipo1.Src.Main.Utils.Actions
{
    public class Actions
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public Actions(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); 
        }

        // Método para hacer clic en un elemento
        public void ClickElement(By locator)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator)).Click();
        }

        // Método para escribir texto en un campo de texto
        public void EnterText(By locator, string text)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator)).SendKeys(text);
        }

        // Método para obtener el texto de un elemento
        public string GetText(By locator)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator)).Text;
        }

        // Método para esperar hasta que un elemento esté visible
        public void WaitForElementVisible(By locator)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        // Método para esperar hasta que un elemento esté clickeable
        public void WaitForElementClickable(By locator)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }


        // Método para capturar una captura de pantalla y guardarla como un archivo PNG
        public string TakeScreenshot()
        {
            // Obtener la ruta del directorio del proyecto
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            // Combinar la ruta del directorio del proyecto con la estructura de carpetas donde deseas guardar las capturas de pantalla
            string screenshotsDirectory = Path.Combine(projectDirectory, "Src", "Test", "Screenshots");

            // Crear el directorio si no existe
            if (!Directory.Exists(screenshotsDirectory))
            {
                Directory.CreateDirectory(screenshotsDirectory);
            }

            // Obtener la marca de tiempo actual
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd-HHmmss");

            // Concatenar la marca de tiempo al nombre del archivo
            string filePath = Path.Combine(screenshotsDirectory, $"screenshot-{timestamp}.png");

            // Capturar la captura de pantalla
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

        

            // Guardar la captura de pantalla en un archivo
            screenshot.SaveAsFile(filePath);

            Console.WriteLine(filePath);

            return filePath;
        }

        
        public void CompletePaso1(ReportModel paso1, ReportModel infogeneral)
        {
            paso1.NombreProyecto = infogeneral.NombreProyecto;
            paso1.TiempoEjecuccion = infogeneral.TiempoEjecuccion;
            paso1.InicioEjecuccion = infogeneral.InicioEjecuccion;
            paso1.FinEjecuccion = infogeneral.FinEjecuccion;
            paso1.Precondiciones = infogeneral.Precondiciones;
            paso1.NombreCasoPrueba = infogeneral.NombreCasoPrueba;
            paso1.DescCasoPrueba = infogeneral.DescCasoPrueba;
            paso1.NombreScript = infogeneral.NombreScript;
            paso1.StatusEjecuccion = infogeneral.StatusEjecuccion;
        }
        
    }

 

}

