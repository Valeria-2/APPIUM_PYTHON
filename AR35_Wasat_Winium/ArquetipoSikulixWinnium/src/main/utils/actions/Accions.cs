using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Winium;

namespace SeleniumAndSikuli.src.main.utils.actions
{
    public class Accions
    {
        public WiniumDriver winDriver;

        public Accions(WiniumDriver winDriver)
        {
            this.winDriver = winDriver;

        }

        public string TakeScreenshot()
        {
            // Obtener la ruta del directorio del proyecto
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            // Combinar la ruta del directorio del proyecto con la estructura de carpetas donde deseas guardar las capturas de pantalla
            string screenshotsDirectory = Path.Combine(projectDirectory, "ArquetipoSikulixWinnium", "src","tests","screenshots");

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
            Screenshot screenshot = ((ITakesScreenshot)winDriver).GetScreenshot();

            // Guardar la captura de pantalla en un archivo
            screenshot.SaveAsFile(filePath);

            Console.WriteLine(filePath);

            return filePath;
        }

    }
}

