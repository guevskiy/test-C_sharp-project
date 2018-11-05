using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests4Jenkins
{
  [TestFixture]
  public class TestClass
  {
    IWebDriver driver;

    [OneTimeSetUp]
    public void SetUp()
    {
      driver = new ChromeDriver();
      ////driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
      ////driver.Navigate().GoToUrl("http://addressbook:8087/group.php");
      driver.Navigate().GoToUrl("http://localhost:4200");
      driver.Manage().Window.Maximize();
      Thread.Sleep(1000);
    }

    [OneTimeTearDown]
    public void TearDown()
    {
      driver.Close();
      driver.Quit();
    }

    [Test]
    public void TestMethod_001()
    {
      string sz = driver.Manage().Window.Size.ToString();
      Console.WriteLine(sz);
      Assert.AreEqual("{Width=1936, Height=1056}", sz);
    }


    [Test]
    public void TestMethod_002()
    {
      string str = driver.FindElement(By.CssSelector("div.card div.card-header")).Text;
      Assert.AreEqual("Welcome", str);
      Thread.Sleep(1000);
    }

    [Test]
    public void TestMethod_002_2()
    {
      string str = driver.FindElement(By.CssSelector("div.container-fluid h3")).Text;
      Assert.AreEqual("Deborah Kurata", str);
      Thread.Sleep(1000);
    }

    [Test]
    public void TestMethod_003()
    {
      driver.FindElement(By.CssSelector("ul.nav.nav-pills li:nth-child(2)")).Click();
      Thread.Sleep(1000);
      string str = driver.FindElement(By.CssSelector("div.card div.card-header")).Text;
      Assert.AreEqual("Product List", str);
      Thread.Sleep(1000);
    }


  }
}
