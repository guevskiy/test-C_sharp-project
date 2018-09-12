using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests4Jenkins
{
    [TestFixture]
    public class TestClass
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void SetUp()
        {
            driver.Navigate().GoToUrl("http://google.com.ua");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
        [Test]
        public void TestMethod()
        {
            driver.FindElement(By.CssSelector("input#lst-ib")).SendKeys("Как заработать миллион");
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector("ul[role='listbox'] li:nth-child(2)")).Click();
            Thread.Sleep(3000);
            //Assert.Pass("Your first passing test");
        }
    }
}
