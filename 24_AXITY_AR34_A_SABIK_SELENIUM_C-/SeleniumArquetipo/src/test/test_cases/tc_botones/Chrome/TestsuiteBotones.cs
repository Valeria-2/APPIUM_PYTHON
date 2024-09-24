
using OpenQA.Selenium;
using SeleniumArquetipo1.Src.Main.Config;
using SeleniumArquetipo1.Src.Main.Core;
using SeleniumArquetipo1.Src.Main.Pages;

namespace SeleniumArquetipo1.Src.Test.TestCases.TC_Botones.Chrome
{
    public class TestsuiteBotones : BaseChromeTest
    {
        [Test]
        public void ClickBotonLogIn()
        {  //ARRANGE
            driver.Navigate().GoToUrl(WebConfig.WebsiteUrl);
            LoginPage loginPage = new(driver);
            

            //ACT
            loginPage.ClickLoginButton();
            IWebElement elemento = driver.FindElement(loginPage.mensajeobligatorio2);

            //ASSERT
            Assert.That(elemento.Displayed, Is.True, "El elemento 'Obligatorio' no está visible.");
        }
           
     }
 }

