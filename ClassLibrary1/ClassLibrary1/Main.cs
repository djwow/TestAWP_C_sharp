using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class Main
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
            driver.Quit();

        }

        [Test]
        public void myFirstTest()
        {
            driver.Navigate().GoToUrl("https://192.168.157.10");
            Assert.AreEqual("MiVoice Office 250", driver.Title);
        }

    }
}