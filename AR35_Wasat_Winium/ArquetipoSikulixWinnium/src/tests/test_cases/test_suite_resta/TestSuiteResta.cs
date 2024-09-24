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

namespace SeleniumAndSikuli.src.tests.test_cases.test_suite_resta
{
    internal class TestSuiteResta : BaseTest
    {
        [Test]
        public void Test_Resta_2_Numeros()
        {
            //ARRANGE
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string btn3 = projectDirectory + Constantes.btn3;
            string btn7 = projectDirectory + Constantes.btn7;
            string btnresta = projectDirectory + Constantes.btnResta;
            string btnigual = projectDirectory + Constantes.btnIgual;
            string resultado = projectDirectory + Constantes.restResta;

            Pattern Boton3 = new Pattern(btn3);
            Pattern Boton7 = new Pattern(btn7);
            Pattern BotonResta = new Pattern(btnresta);
            Pattern BotonIgual = new Pattern(btnigual, 0.2);
            Pattern resulresta = new Pattern(resultado, 0.2);


            //ACT
            screen.Click(Boton7);
            screen.Click(BotonResta);
            screen.Click(Boton3);
            screen.Click(BotonIgual);

            //ASSERT
            Assert.That(screen.Exists(resulresta), Is.True, "El Resultado de la Resta no ha sido visible correctamente.");
        }
    }
}
