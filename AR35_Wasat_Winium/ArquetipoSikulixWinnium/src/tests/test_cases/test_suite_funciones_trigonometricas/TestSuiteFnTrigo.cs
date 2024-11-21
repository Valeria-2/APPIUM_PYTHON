using SeleniumAndSikuli.src.main.core;
using NUnit.Framework;
using System;
using System.IO;
using SeleniumAndSikuli.src.main.utils;
using OpenQA.Selenium.Winium;
using Sikuli4Net.sikuli_REST;
using System.Threading;
using SeleniumAndSikuli.src.tests.test_report.models;
using SeleniumAndSikuli.src.tests.test_report.utility;
using SeleniumAndSikuli.src.tests.test_report;
using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumAndSikuli.src.main.utils.actions;


namespace SeleniumAndSikuli.src.tests.test_cases.test_suite_calculadora
{
    public class TestsuiteFnTrigo : BaseTest
    {
        [Test]
        public void Test_Boton_cientifica()
        {
            //ARRANGE
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string menu = projectDirectory + Constantes.menubtn;
            string cientifica = projectDirectory + Constantes.cientificabtn;

            Pattern menubtn = new Pattern(menu);
            Pattern cientificabtn = new Pattern(cientifica);

            //ACT
            screen.Click(menubtn);
            screen.Click(cientificabtn);


            //ASSERT
            Assert.That(screen.Exists(cientificabtn), Is.True, "El botón para cambiar a Calculadora cientifica no se ha presionado correctamente.");

        }

        [Test]
        public void Test_Fn_Seno()
        {
            //ARRANGE
            Test_Boton_cientifica();

            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string fntrigo = projectDirectory + Constantes.fntrigobtn;
            string fnseno = projectDirectory + Constantes.senobtn;
            string btn4 = projectDirectory + Constantes.btn4;
            string btn5 = projectDirectory + Constantes.btn5;

            Pattern Boton4 = new Pattern(btn4, 0.2);
            Pattern Boton5 = new Pattern(btn5);
            Pattern Fntrigobtn = new Pattern(fntrigo);
            Pattern Fnsenobtn = new Pattern(fnseno, 0.3);

            //ACT

            screen.Click(Boton4);
            screen.Click(Boton5);
            screen.Click(Fntrigobtn);
            screen.Click(Fnsenobtn);

            //ASSERT
            Assert.That(screen.Exists(Fnsenobtn), Is.True, "El botón de La funcioón SENO no se ha presionado correctamente.");


        }
        [Test]
        public void Test_Fn_Seno_report()
        {
            //ARRANGE

            Accions accions = new Accions(winDriver);
            var paso1 = new ReportModel();

            paso1.NombreProyecto = "ArquetipoSikulixWinium";
            paso1.InicioEjecuccion = DateTime.Now;
            paso1.StatusEjecuccion = "Pasado";
            paso1.Precondiciones = "Se debe de usar la versión Windows 10 o Windows 11 siguiendo las recomendaciones del documento WORD";
            paso1.NombreCasoPrueba = TestContext.CurrentContext.Test.MethodName;
            paso1.DescCasoPrueba = "Se debe de verificar que la funcion trigonometrica Seno funcione correctamente";
            paso1.NombreScript = Path.GetFileName(TestContext.CurrentContext.Test.ClassName);
            var isTestPassing = true;



            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string fntrigo = projectDirectory + Constantes.fntrigobtn;
            string fnseno = projectDirectory + Constantes.senobtn;
            string btn4 = projectDirectory + Constantes.btn4;
            string btn5 = projectDirectory + Constantes.btn5;

            Pattern Boton4 = new Pattern(btn4, 0.2);
            Pattern Boton5 = new Pattern(btn5);
            Pattern Fntrigobtn = new Pattern(fntrigo);
            Pattern Fnsenobtn = new Pattern(fnseno, 0.3);


            //ACT

            //PASO 1
            paso1.DescPaso = "Paso 1: Se abre la Calculadora";
            paso1.DescResult = "Resultado 1: La Calculadora esta desplegueda en la pantalla";
            paso1.EstatusPaso = "Pasado";
            try
            {
                Thread.Sleep(1000);
                paso1.InputRoute = accions.TakeScreenshot();



            }
            catch (NoSuchElementException)
            {
                paso1.InputRoute = accions.TakeScreenshot();
                paso1.EstatusPaso = "Fallado";
                paso1.StatusEjecuccion = "Fallado";
                isTestPassing = false;
            }

            //PASO 2
            var paso2 = new ReportModel();
            paso2.DescPaso = "Paso 2: Ir a Calculadora Cientifica";
            paso2.DescResult = "Resultado 2: Se abre sin problema la Calculadora Cientifica";
            paso2.EstatusPaso = "Pasado";
            paso2.InputRoute = string.Empty;
            try
            {
                Test_Boton_cientifica();
                Thread.Sleep(500);
                paso2.InputRoute = accions.TakeScreenshot();



            }
            catch (NoSuchElementException)
            {
                paso2.InputRoute = accions.TakeScreenshot();
                paso2.EstatusPaso = "Fallado";
                paso2.StatusEjecuccion = "Fallado";
                isTestPassing = false;
            }

            var paso3 = new ReportModel();
            paso3.DescPaso = "Paso 3: Calcular La Funcion Seno de 45";
            paso3.DescResult = "Resultado 2:Se obtiene el resultado de la Función Seno de 45";
            paso3.EstatusPaso = "Pasado";
            paso3.InputRoute = string.Empty;
            try
            {
                screen.Click(Boton4);
                screen.Click(Boton5);
                screen.Click(Fntrigobtn);
                screen.Click(Fnsenobtn);

                Thread.Sleep(500);
                paso3.InputRoute = accions.TakeScreenshot();



            }
            catch (NoSuchElementException)
            {
                paso3.InputRoute = accions.TakeScreenshot();
                paso3.EstatusPaso = "Fallado";
                paso3.StatusEjecuccion = "Fallado";
                isTestPassing = false;
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
            var reportName = string.Format(ReportConstant.NombreReporte, paso1.NombreCasoPrueba, "-", DateTime.Now.ToString("ddMMyyyy"));
            var reportROute = report.CreateReport(filePath, reportName);
            TestContext.AddTestAttachment(reportROute);
        }



    }
}