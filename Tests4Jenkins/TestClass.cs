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
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
            driver.Navigate().GoToUrl("http://addressbook:8087/group.php");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void TestMethod_01()
        {
            string sz = driver.Manage().Window.Size.ToString();
            Console.WriteLine(sz);
            Assert.AreEqual("{Width=1936, Height=1056}", sz);
        }

        [Test]
        public void TestMethod_001()
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

        Random rnd = new Random();

        public void createNewGroup()
        {
            int n = rnd.Next(1, 99);

            driver.FindElement(By.CssSelector("input[name='new']")).Click();

            Thread.Sleep(500);
            driver.FindElement(By.CssSelector("input[name='group_name']")).SendKeys("group_name " + n);
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector("textarea[name='group_header']")).SendKeys("group_header" + n);
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector("textarea[name='group_footer']")).SendKeys("group_footer" + n);

            driver.FindElement(By.CssSelector("input[name='submit']")).Click();
        }

        [Test]
        public void TestMethod_002()
        {

            driver.FindElement(By.CssSelector("input[name='user']")).SendKeys("admin");
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector("input[name='pass']")).SendKeys("secret");
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector("input[value='Login']")).Click();
            Thread.Sleep(1000);

            int nn_befor = driver.FindElements(By.CssSelector("span.group")).Count;
            createNewGroup();
            Thread.Sleep(500);
            driver.FindElement(By.LinkText("group page")).Click();
            Thread.Sleep(500);

            int nn_after = driver.FindElements(By.CssSelector("span.group")).Count;
            Assert.AreEqual(nn_befor + 1, nn_after);
        }

    }
}
