using SeleniumAndSikuli.src.main.core;
using NUnit.Framework;
using System;
using System.IO;
using SeleniumAndSikuli.src.main.utils;
using OpenQA.Selenium.Winium;
using Sikuli4Net.sikuli_REST;
using System.Threading;
using Microsoft;
using SikuliSharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SeleniumAndSikuli.src.tests.test_cases.test_suite_multiplicacion
{
    internal class TestSuiteMulti : BaseTest
    {
        [Test]
        public void Test_Multi_2_Numeros()
        {
            //ARRANGE
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string btn4 = projectDirectory + Constantes.btn4;
            string btn5 = projectDirectory + Constantes.btn5;
            string btnmulti = projectDirectory + Constantes.btnMulti;
            string btnigual = projectDirectory + Constantes.btnIgual;
            string resultado = projectDirectory + Constantes.restMulti;

            Pattern Boton4 = new Pattern(btn4);
            Pattern Boton5 = new Pattern(btn5);
            Pattern BotonMulti = new Pattern(btnmulti, 0.7);
            Pattern BotonIgual = new Pattern(btnigual, 0.2);
            Pattern resulmulti = new Pattern(resultado, 0.2);


            //ACT
            screen.Click(Boton4);
            Thread.Sleep(500);
            screen.Click(BotonMulti);
            Thread.Sleep(500);
            screen.Click(Boton5);
            Thread.Sleep(500);
            screen.Click(BotonIgual);

            //ASSERT
            Assert.That(screen.Exists(resulmulti), Is.True, "El Resultado de la Multiplicación no ha sido visible correctamente.");



        }
    }
}

