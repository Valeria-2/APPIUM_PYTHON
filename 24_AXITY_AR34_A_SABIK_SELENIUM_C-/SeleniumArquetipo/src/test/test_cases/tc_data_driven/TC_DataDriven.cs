using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumArquetipo1.Src.Main.Config;
using SeleniumArquetipo1.Src.Main.Core;
using SeleniumArquetipo1.Src.Main.Pages;
using SeleniumArquetipo1.Src.Test.TestReport;
using SeleniumArquetipo1.Src.Test.TestReport.Models;
using SeleniumExtras.WaitHelpers;
using SeleniumArquetipo1.Src.Main.Utils.Actions;
using SeleniumArquetipo1.Src.Test.TestReport.Utility;


namespace SeleniumArquetipo1.Src.Test.TestCases.TC_DataDriven
{
    internal class TC_DataDriven : BaseChromeTest
    {

        [TestCase("TC1", "Admin", "admin123")]
        [TestCase("TC2", "User1", "password1")]
        //[TestCase("User2", "password2")]
        public void ValidUserData(string testCaseName, string username, string password)
        {  //ARRANGE

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


            //Paso 1 Entrar Al URL deseado
            paso1.DescPaso = "1. Entrar a la pagina de Orange HRM LIVE";
            paso1.DescResult = "1. Entró a la pagina de Orange HRM LIVE correctamente";
            paso1.EstatusPaso = "Pasado";
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(9));
                driver.Navigate().GoToUrl(WebConfig.WebsiteUrl);
                Assert.That(driver.Url, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login"));
                Console.WriteLine(driver.Url);

                wait.Until(ExpectedConditions.ElementIsVisible(loginPage.loginButton));

                paso1.InputRoute = actions.TakeScreenshot();

            }

            catch (NoSuchElementException)
            {

                paso1.EstatusPaso = "Fallado";
                paso1.StatusEjecuccion = "Fallado";
                paso1.InputRoute = actions.TakeScreenshot();
            }

            //Paso 2 Poner Username y Password
            var paso2 = new ReportModel();
            paso2.DescPaso = "2. Escribir texto en Username y Password";
            paso2.DescResult = "2. Se verifica que el texto se ha escrito en Username y  Password";
            paso2.EstatusPaso = "Pasado";
            try
            {
                loginPage.LogInValidUser(username, password);
                Thread.Sleep(1000);

                string usernameText = loginPage.GetUsernameFieldValue();
                Assert.That(usernameText, Is.EqualTo("Admin"), "El texto en la barra de usuario no es el esperado.");
                string passText = loginPage.GetPasswordFieldValue();
                Assert.That(passText, Is.EqualTo("admin123"), "El texto en la barra de Password no es el esperado.");
                paso2.InputRoute = actions.TakeScreenshot();


            }
            catch (AssertionException)
            {
                paso2.EstatusPaso = "Fallado";
                paso1.StatusEjecuccion = "Fallado";
                paso2.InputRoute = actions.TakeScreenshot();
            }

            //Paso 3 Entrar a Main page
            var paso3 = new ReportModel();
            paso3.DescPaso = "3.Entrar a Main Page";
            paso3.DescResult = "3.Se entró a Main Page";
            paso3.EstatusPaso = "Pasado";
            try
            {
                MainPage mainPage = new(driver);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(9));

                loginPage.ClickLoginButton();
                Thread.Sleep(3000);
                Assert.That(driver.Url, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index"));

                wait.Until(ExpectedConditions.ElementIsVisible(mainPage.FlechitaMenu));
                paso3.InputRoute = actions.TakeScreenshot();
            }
            catch (Exception)
            {

                paso3.EstatusPaso = "Fallado";
                paso1.StatusEjecuccion = "Fallado";
                paso3.InputRoute = actions.TakeScreenshot();
            }

            // Mi ruta donde guardado mi archivo CSV
            string filePath = paso1.NombreCasoPrueba + "_datos.csv";

            paso1.FinEjecuccion = DateTime.Now;
            var tiempoEjecuccion = DateTime.Now - paso1.InicioEjecuccion;
            paso1.TiempoEjecuccion = $"{tiempoEjecuccion.Minutes:00}:{tiempoEjecuccion.Seconds:00}";

            var listPasos = new List<ReportModel> { paso1, paso2, paso3 };

            var csvWriter = new CreateCSV();
            csvWriter.CreatFile(filePath, listPasos);

            var report = new Createreport();
            var reportName = string.Format(ReportConstant.NombreReporte, paso1.NombreCasoPrueba, testCaseName, DateTime.Now.ToString("ddMMyyyy"));
            var reportROute = report.CreateReport(filePath, reportName);
            TestContext.AddTestAttachment(reportROute);

        }


    }
}
