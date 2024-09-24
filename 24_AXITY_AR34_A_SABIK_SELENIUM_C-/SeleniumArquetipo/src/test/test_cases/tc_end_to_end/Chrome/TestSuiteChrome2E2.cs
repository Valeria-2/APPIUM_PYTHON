using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumArquetipo1.Src.Main.Config;
using SeleniumArquetipo1.Src.Main.Core;
using SeleniumArquetipo1.Src.Main.Pages;
using SeleniumArquetipo1.Src.Main.Utils.Actions;
using SeleniumArquetipo1.Src.Test.TestCases.TC_Navegacion;

namespace SeleniumArquetipo1.Src.Test.TestCases.TC_2E2.Chrome
{
    public class TestSuiteChrome2E2 : BaseChromeTest
    {
        [Test]
        public void ValidLogIn()
        {
            //Arrange
            TestSuiteChrome testSuiteChrome = new();
            testSuiteChrome.EntrarPagina();
            LoginPage loginPage = new(driver);

            //ACT
            loginPage.LogInValidUser("Admin", "admin123");

            //ASSERT
            Assert.That(driver.Url, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index"));

        }
    }
}
