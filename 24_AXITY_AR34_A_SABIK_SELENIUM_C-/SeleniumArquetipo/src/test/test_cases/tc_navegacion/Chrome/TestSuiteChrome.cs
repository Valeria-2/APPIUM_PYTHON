using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumArquetipo1.Src.Main.Config;
using SeleniumArquetipo1.Src.Main.Core;
using SeleniumArquetipo1.Src.Main.Pages;
using SeleniumArquetipo1.Src.Main.Utils.Actions;
using SeleniumExtras.WaitHelpers;

namespace SeleniumArquetipo1.Src.Test.TestCases.TC_Navegacion
{
    public class TestSuiteChrome : BaseChromeTest
    {

        [Test]
        public void EntrarPagina()
        {
           //ARRANGE
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(9));

            //ACT
             driver.Navigate().GoToUrl(WebConfig.WebsiteUrl);

            //ASSERT
            Assert.That(driver.Url, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login"),"No entró correctamente");

        }
    }
}