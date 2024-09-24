using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumArquetipo1.Src.Main.Config;
using SeleniumArquetipo1.Src.Main.Core;
using SeleniumArquetipo1.Src.Main.Pages;
using SeleniumArquetipo1.Src.Main.Utils.Actions;

namespace SeleniumArquetipo1.Src.Test
{

    public class TestSuiteEdge : BaseEdgeTest
    {

        [Test]
        public void EntrarPaginaEdge()
        {
            // Abre la URL almacenada en WebConfig
            driver.Navigate().GoToUrl(WebConfig.WebsiteUrl);

        }
    }
}