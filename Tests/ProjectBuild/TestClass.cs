using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectBuild
{
  [TestFixture]
  public class TestClass
  {
    IWebDriver driver;

    [Test]
    public void TestMethod_StartProject_001()
    {
      ProcessStartInfo psiOpt = new ProcessStartInfo("cmd.exe", "/k ng serve");
      // запускаем процесс
      Process procCommand = Process.Start(psiOpt);

      Thread.Sleep(15000);

    }

    [Test]
    public void TestMethod_StartProject_002()
    {

      driver = new ChromeDriver();
      driver.Navigate().GoToUrl("http://localhost:4200");
      driver.Manage().Window.Maximize();
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);


      //var elem = driver.FindElement(By.CssSelector("div.card div.card-header"));

      //for (int i = 0; i < 20; i++)
      //{
      //  if (driver.FindElements(By.CssSelector("div.card div.card-header")).Count < 0)
      //  {
      //    Thread.Sleep(1500);
      //    driver.Navigate().Refresh();
          
      //  }
      //  else
      //  {
      //    Assert.AreEqual("Welcome", elem.Text);
      //  }
      //}


      int i = 0;
      while (i < 1)
      {
        Thread.Sleep(2000);
        driver.Navigate().Refresh();
        i = driver.FindElements(By.CssSelector("div.card div.card-header")).Count;
      }

      Assert.AreEqual("Welcome", driver.FindElement(By.CssSelector("div.card div.card-header")).Text);

    }


  }
}
