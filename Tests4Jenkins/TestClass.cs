﻿using NUnit.Framework;
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
            driver.Navigate().GoToUrl("http://addressbook:8087/group.php");
            Thread.Sleep(2000);
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
            driver.FindElement(By.CssSelector("input[name='user']")).SendKeys("admin");
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector("input[name='pass']")).SendKeys("secret");
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector("input[value='Login']")).Click();
            Thread.Sleep(2000);
            string str = driver.FindElement(By.CssSelector("div#content h1")).Text;
            Assert.AreEqual("Groups", str);
        }
    }
}
