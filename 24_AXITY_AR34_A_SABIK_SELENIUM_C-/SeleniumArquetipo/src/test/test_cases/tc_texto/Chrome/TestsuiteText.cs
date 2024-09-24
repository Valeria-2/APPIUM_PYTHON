using SeleniumArquetipo1.Src.Main.Core;
using SeleniumArquetipo1.Src.Main.Pages;
using SeleniumArquetipo1.Src.Test.TestCases.TC_Navegacion;
using SeleniumArquetipo1.Src.Main.Utils.Actions;
using SeleniumArquetipo1.Src.Test.TestReport;
using SeleniumArquetipo1.Src.Main.Config;
using SeleniumArquetipo1.Src.Test.TestReport.Models;
using System.Collections.Generic;
using OpenQA.Selenium;
using Selenium.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SeleniumArquetipo1.Src.Test.TestReport.Utility;
using System.Xml;

namespace SeleniumArquetipo1.Src.Test.TestCases.TC_Texto.Chrome
{
    public class TestsuiteText: BaseChromeTest
    { 
        [Test]
        public void EscribirUsernameValidReportTest()
        {
            //Arrange

            LoginPage loginPage = new(driver);
            Actions actions = new(driver);

            var paso1 = new ReportModel();
            paso1.NombreProyecto = "Folio de Pago 2.0";
            paso1.InicioEjecuccion = DateTime.Now;
            paso1.StatusEjecuccion = "Pasado";
            paso1.Precondiciones = "Se debe de usar la version más actualizada de Google Chrome en Windows";
            paso1.NombreCasoPrueba = TestContext.CurrentContext.Test.MethodName;
            paso1.DescCasoPrueba = "Se debe de verificar que la entrada del campo sea visible para el usuario";
            paso1.NombreScript = Path.GetFileName(TestContext.CurrentContext.Test.ClassName);
            var isTestPassing = true;

            //ACT

            //Paso 1 Entrar Al URL deseado
            paso1.DescPaso = "1. Entrar a la pagina de Orange HRM LIVE";
            paso1.DescResult = "1. Entró a la pagina de Orange HRM LIVE correctamente";
            paso1.EstatusPaso = "Pasado";
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(9));
                driver.Navigate().GoToUrl(WebConfig.WebsiteUrl);
                Assert.That(driver.Url, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login"));
                wait.Until(ExpectedConditions.ElementIsVisible(loginPage.loginButton));
                paso1.InputRoute = actions.TakeScreenshot();

            }

            catch (NoSuchElementException)
            {
               
                Assert.Fail("No Entró al URL deseado");
                paso1.EstatusPaso = "Fallado";
                paso1.StatusEjecuccion = "Fallado";
                paso1.InputRoute = actions.TakeScreenshot();
            }

            //Paso 2
            var paso2 = new ReportModel();
            paso2.DescPaso = "2. Escribir texto en Username";
            paso2.DescResult = "2. Se verifica que el texto se ha escrito en Username";
            paso2.EstatusPaso = "Pasado";

            try 
            {
                loginPage.EnterUsername("Mauricio Gurrola");
                paso2.InputRoute = actions.TakeScreenshot();

                string usernameText = loginPage.GetUsernameFieldValue();
                Assert.That(usernameText, Is.EqualTo("Mauricio Gurrola"), "El texto en la barra de usuario no es el esperado.");
               
            }

            catch (Exception)
            {
                paso2.EstatusPaso = "Fallado";
                paso1.StatusEjecuccion = "Fallado";
                paso2.InputRoute = actions.TakeScreenshot();
            }

            // Mi ruta donde guardado mi archivo CSV
            string filePath = paso1.NombreCasoPrueba + "_datos.csv";

            paso1.FinEjecuccion = DateTime.Now;
            var tiempoEjecuccion = DateTime.Now - paso1.InicioEjecuccion;
            paso1.TiempoEjecuccion = $"{tiempoEjecuccion.Minutes:00}:{tiempoEjecuccion.Seconds:00}";

            var listPasos = new List<ReportModel> { paso1, paso2 };

            var csvWriter = new CreateCSV();
            csvWriter.CreatFile(filePath, listPasos);

            var report = new Createreport();
            var reportName = string.Format(ReportConstant.NombreReporte, paso1.NombreCasoPrueba,"-", DateTime.Now.ToString("ddMMyyyy"));
            var reportROute = report.CreateReport(filePath, reportName);
            TestContext.AddTestAttachment(reportROute);
        }
        [Test]
       
        public void EscribirPasswordnameValidReportTest( )
        {
            //Arrange

            LoginPage loginPage = new(driver);
            Actions actions = new(driver);

            var paso1 = new ReportModel();
            paso1.NombreProyecto = "Folio de Pago 2.0";
            paso1.InicioEjecuccion = DateTime.Now;
            paso1.StatusEjecuccion = "Pasado";
            paso1.Precondiciones = "Se debe de usar la version más actualizada de Google Chrome en Windows";
            paso1.NombreCasoPrueba = TestContext.CurrentContext.Test.MethodName;
            paso1.DescCasoPrueba = "Se debe de verificar que la entrada del campo sea visible para el usuario";
            paso1.NombreScript = Path.GetFileName(TestContext.CurrentContext.Test.ClassName);
            var isTestPassing = true;

            //ACT
            //Paso 1 Entrar Al URL deseado
            paso1.DescPaso = "1. Entrar a la pagina de Orange HRM LIVE";
            paso1.DescResult = "1. Entró a la pagina de Orange HRM LIVE correctamente";
            paso1.EstatusPaso = "Pasado";
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(9));
                driver.Navigate().GoToUrl(WebConfig.WebsiteUrl);
                Assert.That(driver.Url, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login"));

                wait.Until(ExpectedConditions.ElementIsVisible(loginPage.loginButton));

                paso1.InputRoute = actions.TakeScreenshot();

            }

            catch (NoSuchElementException)
            {

                paso1.EstatusPaso = "Fallado";
                paso1.StatusEjecuccion = "Fallado";
                paso1.InputRoute = actions.TakeScreenshot();
                isTestPassing = false;
            }

            //Paso 2
            var paso2 = new ReportModel();
            paso2.DescPaso = "2.Escribir texto en Password";
            paso2.DescResult = "2.Se verifica que el texto se ha escrito en Password";
            paso2.EstatusPaso = "Pasado";
            paso2.InputRoute = string.Empty;
            paso2.EstatusPaso = isTestPassing ? "Pasado" : "No ejecutado";

            try
            {
                Console.WriteLine(isTestPassing);
                if (isTestPassing)
                {
                    loginPage.EnterPassword("PASSWORD");
                    paso2.InputRoute = actions.TakeScreenshot();

                    string usernameText = loginPage.GetPasswordFieldValue();
                    Assert.That(usernameText, Is.EqualTo("PASSWORD"), "El texto en la barra de Password no es el esperado.");
                }
            }

            catch (AssertionException)
            {

                paso2.EstatusPaso = "Fallado";
                paso1.StatusEjecuccion = "Fallado";
                paso2.InputRoute = actions.TakeScreenshot();
            }

            // Mi ruta donde guardado mi archivo CSV
            string filePath = paso1.NombreCasoPrueba + "_datos.csv";

            paso1.FinEjecuccion = DateTime.Now;
            var tiempoEjecuccion = DateTime.Now - paso1.InicioEjecuccion;
            paso1.TiempoEjecuccion = $"{tiempoEjecuccion.Minutes:00}:{tiempoEjecuccion.Seconds:00}";


            var listPasos = new List<ReportModel> { paso1, paso2 };

            var csvWriter = new CreateCSV();
            csvWriter.CreatFile(filePath, listPasos);

            var report = new Createreport();
            var reportName = string.Format(ReportConstant.NombreReporte, paso1.NombreCasoPrueba,"-", DateTime.Now.ToString("ddMMyyyy"));
            var reportROute = report.CreateReport(filePath, reportName);
            TestContext.AddTestAttachment(reportROute);


        }
        [Test]
        public void EscribirPasswordnameInvalidReportTest()
        {
            //Arrange
            LoginPage loginPage = new(driver);
            Actions actions = new(driver);

            var paso1 = new ReportModel();
            paso1.NombreProyecto = "Folio de Pago 2.0";
            paso1.InicioEjecuccion = DateTime.Now;
            paso1.StatusEjecuccion = "Pasado";
            paso1.Precondiciones = "Se debe de usar la version más actualizada de Google Chrome en Windows";
            paso1.NombreCasoPrueba = TestContext.CurrentContext.Test.MethodName;
            paso1.DescCasoPrueba = "Se debe de verificar que la entrada del campo sea visible para el usuario";
            paso1.NombreScript = Path.GetFileName(TestContext.CurrentContext.Test.ClassName);
            var isTestPassing = true;

            //ACT

            //Paso 1 Entrar Al URL deseado
            paso1.DescPaso = "1. Entrar a la pagina de Orange HRM LIVE";
            paso1.DescResult = "1. Entró a la pagina de Orange HRM LIVE correctamente";
            paso1.EstatusPaso = "Pasado";
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(9));
                driver.Navigate().GoToUrl(WebConfig.WebsiteUrl);
                Assert.That(driver.Url, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login"));
                wait.Until(ExpectedConditions.ElementIsVisible(loginPage.loginButton));
                paso1.InputRoute = actions.TakeScreenshot();

            }

            catch (NoSuchElementException)
            {
                paso1.EstatusPaso = "Fallado";
                paso1.StatusEjecuccion = "Fallado";
                paso1.InputRoute = actions.TakeScreenshot();
                isTestPassing = false;
            }

            //Paso 2
            var paso2 = new ReportModel();
            paso2.DescPaso = "2.Escribir texto en Password";
            paso2.DescResult = "2.Se verifica que el texto se ha escrito en Password";
            paso2.EstatusPaso = "Pasado";
            paso2.InputRoute = string.Empty;
            paso2.EstatusPaso = isTestPassing ? "Pasado" : "No ejecutado";

            try
            {
                Console.WriteLine(isTestPassing);
                if (isTestPassing)
                {
                    loginPage.EnterPassword("PASSWORDddd");
                    paso2.InputRoute = actions.TakeScreenshot();

                    string usernameText = loginPage.GetPasswordFieldValue();
                    Assert.That(usernameText, Is.EqualTo("PASSWORD"), "El texto en la barra de Password no es el esperado.");
                }
            }

            catch (AssertionException)
            {

                paso2.EstatusPaso = "Fallado";
                paso1.StatusEjecuccion = "Fallado";
                paso2.InputRoute = actions.TakeScreenshot();
            }

            // Mi ruta donde guardado mi archivo CSV
            string filePath = paso1.NombreCasoPrueba + "_datos.csv";

            paso1.FinEjecuccion = DateTime.Now;
            var tiempoEjecuccion = DateTime.Now - paso1.InicioEjecuccion;
            paso1.TiempoEjecuccion = $"{tiempoEjecuccion.Minutes:00}:{tiempoEjecuccion.Seconds:00}";

            var listPasos = new List<ReportModel> { paso1, paso2 };

            var csvWriter = new CreateCSV();
            csvWriter.CreatFile(filePath, listPasos);

            var report = new Createreport();
            var reportName = string.Format(ReportConstant.NombreReporte, paso1.NombreCasoPrueba, "-", DateTime.Now.ToString("ddMMyyyy"));
            var reportROute = report.CreateReport(filePath, reportName);
            TestContext.AddTestAttachment(reportROute);

        }
    }
}


