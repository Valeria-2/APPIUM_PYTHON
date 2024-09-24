using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumArquetipo1.Src.Main.Core;

namespace SeleniumArquetipo1.Example
{
    [TestFixture]
    public class WaitsTest : BaseChromeTest
    {
        [Test]
        public void Fails()
        {
            driver.Url = "https://www.selenium.dev/selenium/web/dynamic.html";
            driver.FindElement(By.Id("adder")).Click();

            Assert.Throws<NoSuchElementException>(
                () => driver.FindElement(By.Id("box0"))
            );
        }

        [Test]
        public void Sleep()
        {
            driver.Url = "https://www.selenium.dev/selenium/web/dynamic.html";
            driver.FindElement(By.Id("adder")).Click();

            System.Threading.Thread.Sleep(1000);

            IWebElement added = driver.FindElement(By.Id("box0"));

            Assert.That(added.GetAttribute("class"), Is.EqualTo("redbox"));
        }

        [Test]
        public void Implicit()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            driver.Url = "https://www.selenium.dev/selenium/web/dynamic.html";
            driver.FindElement(By.Id("adder")).Click();

            IWebElement added = driver.FindElement(By.Id("box0"));

            Assert.That(added.GetAttribute("class"), Is.EqualTo("redbox"));
        }

        [Test]
        public void Explicit()
        {
            driver.Url = "https://www.selenium.dev/selenium/web/dynamic.html";
            IWebElement revealed = driver.FindElement(By.Id("revealed"));
            driver.FindElement(By.Id("reveal")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(d => revealed.Displayed);

            revealed.SendKeys("Displayed");
            Assert.That(revealed.GetAttribute("value"), Is.EqualTo("Displayed"));
        }

        [Test]
        public void ExplicitOptions()
        {
            driver.Url = "https://www.selenium.dev/selenium/web/dynamic.html";
            IWebElement revealed = driver.FindElement(By.Id("revealed"));
            driver.FindElement(By.Id("reveal")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2))
            {
                PollingInterval = TimeSpan.FromMilliseconds(300),
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            wait.Until(d => {
                revealed.SendKeys("Displayed");
                return true;
            });

            Assert.That(revealed.TagName, Is.EqualTo("input"));
        }
    }
}
