using SeleniumAndSikuli.src.main.core;
using NUnit.Framework;
using System;
using System.IO;
using SeleniumAndSikuli.src.main.utils;
using OpenQA.Selenium.Winium;
using Sikuli4Net.sikuli_REST;

namespace SeleniumAndSikuli.src.tests.test_cases.test_suite_division

{
    internal class TestSuiteDiv : BaseTest
    {
        [Test]
        public void Test_Div_2_Numeros()
        {
            //ARRANGE
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string btn3 = projectDirectory + Constantes.btn3;
            string btn7 = projectDirectory + Constantes.btn7;
            string btndiv = projectDirectory + Constantes.btnDiv;
            string btnigual = projectDirectory + Constantes.btnIgual;
            string resultado = projectDirectory + Constantes.restDiv;

            Pattern Boton3 = new Pattern(btn3);
            Pattern Boton7 = new Pattern(btn7);
            Pattern BotonDiv = new Pattern(btndiv);
            Pattern BotonIgual = new Pattern(btnigual, 0.2);
            Pattern resuldiv = new Pattern(resultado, 0.2);

            //ACT
            screen.Click(Boton7);
            screen.Click(BotonDiv);
            screen.Click(Boton3);
            screen.Click(BotonIgual);

            //ASSERT
            Assert.That(screen.Exists(resuldiv), Is.True, "El Resultado de la Division no ha sido visible correctamente.");

        }
    }
}

