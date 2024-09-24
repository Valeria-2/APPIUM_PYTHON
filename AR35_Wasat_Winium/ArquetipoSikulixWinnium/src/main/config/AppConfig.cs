using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Winium;
using SeleniumAndSikuli.src.main.utils;

namespace SeleniumAndSikuli.src.main.config
{
    public class AppConfig
    {
        public const string DesktopApp = @"C:\Windows\System32\calc.exe";

        public string driverPath() 
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string WinDriverPath = Path.Combine(projectDirectory, "ArquetipoSikulixWinnium", "src", "drivers");
            return WinDriverPath;
        }
        public static DesktopOptions WiniumCapabilities()
        {
            var WiniumOptions = new DesktopOptions
            {
                ApplicationPath = DesktopApp
            };

            return WiniumOptions;

        }
    }
}
