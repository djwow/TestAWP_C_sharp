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
    public class Main
    {
        IWebDriver driver = new ChromeDriver();
        [Test]
        public void myFirstTest()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            Assert.AreEqual("Google", driver.Title);
            driver.Close();
            driver.Quit();
        }

    }
}