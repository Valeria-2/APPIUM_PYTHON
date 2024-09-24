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


namespace SeleniumAndSikuli.src.tests.test_cases.test_suite_calculadora
{
    public class TestSuiteSumas : BaseTest
    {
        [Test]
        public void Test_Suma_2_Numeros()
        {
            //ARRANGE
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string btn3 = projectDirectory + Constantes.btn3;
            string btn7 = projectDirectory + Constantes.btn7;
            string btnsuma = projectDirectory + Constantes.btnSuma;
            string btnigual = projectDirectory + Constantes.btnIgual;
            string resultado = projectDirectory + Constantes.restSuma;

            Pattern Boton3 = new Pattern(btn3);
            Pattern Boton7 = new Pattern(btn7);
            Pattern BotonSuma = new Pattern(btnsuma);
            Pattern BotonIgual = new Pattern(btnigual,0.2);
            Pattern resulsuma = new Pattern(resultado, 0.2);



            //ACT
            screen.Click(Boton3);
            screen.Click(BotonSuma);
            screen.Click(Boton7);
            screen.Click(BotonIgual);

            //ASSERT
            Assert.That(screen.Exists(resulsuma), Is.True, "El Resultado de la suma no ha sido visible correctamente.");
           

        }

      
    }
}

