using System.Data.SqlClient;
using OpenQA.Selenium.Winium;
using Sikuli4Net.sikuli_UTIL;
using Sikuli4Net.sikuli_REST;
using NUnit.Framework;
using SeleniumAndSikuli.src.main.config;
using System.Threading;
using System.IO;
using System;
using SeleniumAndSikuli.src.main.utils;


namespace SeleniumAndSikuli.src.main.core

{

   public class BaseTest:AppConfig
    {
        APILauncher launcher = new APILauncher(true);
        public Screen screen = new Screen();
        public WiniumDriver winDriver = null;
        

        [SetUp]
        public void Setup()
        {

            launcher.Start();
            Screen screen = new Screen();
            DesktopOptions options = WiniumCapabilities();
            string WinDriverPath = driverPath();
            winDriver = NewMethod();

            WiniumDriver NewMethod()
            {
                return new WiniumDriver(WinDriverPath, options);
            }
        }


        [TearDown]
        public void TearDown()
        {
       
            winDriver.Quit();
            winDriver.Dispose();
            launcher.Stop();
            
        }
    }
}