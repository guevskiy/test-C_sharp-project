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

      //получаем ответ запущенного процесса
      //StreamReader srIncoming = procCommand.;
      // выводим результат
      //Console.WriteLine(srIncoming.ReadToEnd());
      // закрываем процесс
      //procCommand.Close();
      //Console.ReadKey();

    }

    //[Test]
    //public void TestMethod_StartProject_002()
    //{
      
    //  driver = new ChromeDriver();
    //  driver.Navigate().GoToUrl("http://localhost:4200");
    //  driver.Manage().Window.Maximize();
    //  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


    //  var elem = driver.FindElement(By.CssSelector("div.card div.card-header"));

      
    //  Assert.AreEqual("Welcome", elem.Text);
    //}


    //public string GetElemName(int nn)
    //{
    //  WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

    //  string labelName = wait.Until(
    //    (IWebDriver d) =>
    //    {
    //      string name = driver.FindElement(By.CssSelector("div.card div.card-header")).Text;
    //      return name != "" ? name : null;
    //    }
    //    );
    //  return labelName;
    //}

  }
}
