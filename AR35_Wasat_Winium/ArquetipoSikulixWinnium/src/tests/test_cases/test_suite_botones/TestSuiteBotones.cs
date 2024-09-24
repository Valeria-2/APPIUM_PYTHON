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


namespace SeleniumAndSikuli.src.tests.test_cases.test_suite_calculadora
{
    public class TestSuiteBotones: BaseTest
    {
        [Test]
        public void Test_calculadora_open()
        {

            Console.WriteLine("Prueba  1 PASS");
        
        }

        [Test]
        public void Test_Boton_0()
        {
            //ARRANGE
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string btn0 = projectDirectory + Constantes.btn0;
            Pattern Boton0 = new Pattern(btn0);
            Console.WriteLine(btn0);

            //ACT
            screen.Click(Boton0);

            //ASSERT
            Assert.That(screen.Exists(Boton0), Is.True, "El botón 0 no se ha presionado correctamente.");

        }

        [Test]
        public void Test_Boton_1()
        {
            //ARRANGE
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string btn1 = projectDirectory + Constantes.btn1;
            Pattern Boton1 = new Pattern(btn1);
            Console.WriteLine(btn1);

            //ACT
            screen.Click(Boton1);

            //ASSERT
            Assert.That(screen.Exists(Boton1), Is.True, "El botón 4 no se ha presionado correctamente.");

        }

        [Test]
        public void Test_Boton_2()
        {
            //ARRANGE
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string btn2 = projectDirectory + Constantes.btn2;
            Pattern Boton2 = new Pattern(btn2,0.3);

            Console.WriteLine(btn2);

            //ACT
            screen.Click(Boton2);


            //ASSERT
            Assert.That(screen.Exists(Boton2), Is.True, "El botón 4 no se ha presionado correctamente.");

        }
        [Test]
        public void Test_Boton_3()
        {
            //ARRANGE
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string btn3 = projectDirectory + Constantes.btn3;
            Pattern Boton3 = new Pattern(btn3);

            //ACT
            screen.Click(Boton3);

            //ASSERT
            Assert.That(screen.Exists(Boton3), Is.True, "El botón 4 no se ha presionado correctamente.");


        }
        [Test]
        public void Test_Boton_4()
        {
            //ARRANGE
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string btn4 = projectDirectory + Constantes.btn4;
            Pattern Boton4 = new Pattern(btn4,0.2);

            //ACT
            screen.Click(Boton4);

            //ASSERT
            Assert.That(screen.Exists(Boton4), Is.True, "El botón 4 no se ha presionado correctamente.");

        }
        [Test]
        public void Test_Boton_5()
        {
            //ARRANGE
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string btn5 = projectDirectory + Constantes.btn5;
            Pattern Boton5 = new Pattern(btn5);

            //ACT
            screen.Click(Boton5);

            //ASSERT
            Assert.That(screen.Exists(Boton5), Is.True, "El botón 5 no se ha presionado correctamente.");

        }
        [Test]
        public void Test_Boton_6()
        {
            //ARRANGE
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string btn6 = projectDirectory + Constantes.btn6;
            Pattern Boton6 = new Pattern(btn6);

            //ACT
            screen.Click(Boton6);

            //ASSERT
            Assert.That(screen.Exists(Boton6), Is.True, "El botón 6 no se ha presionado correctamente.");

        }
        [Test]
        public void Test_Boton_7()
        {
            //ARRANGE
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string btn7 = projectDirectory + Constantes.btn7;
            Pattern Boton7 = new Pattern(btn7);

            //ACT
            screen.Click(Boton7);

            //ASSERT
            Assert.That(screen.Exists(Boton7), Is.True, "El botón 4 no se ha presionado correctamente.");

        }
        [Test]
        public void Test_Boton_8()
        {
            //ARRANGE
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string btn8 = projectDirectory + Constantes.btn8;
            Pattern Boton8 = new Pattern(btn8);

            //ACT
            screen.Click(Boton8);

            //ASSERT
            Assert.That(screen.Exists(Boton8), Is.True, "El botón 8 no se ha presionado correctamente.");

        }
        [Test]
        public void Test_Boton_9()
        {
            //ARRANGE
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string btn9 = projectDirectory + Constantes.btn9;
            Pattern Boton9 = new Pattern(btn9);

            //ACT
            screen.Click(Boton9);

            //ASSERT
            Assert.That(screen.Exists(Boton9), Is.True, "El botón 9 no se ha presionado correctamente.");

        }


    }
}
