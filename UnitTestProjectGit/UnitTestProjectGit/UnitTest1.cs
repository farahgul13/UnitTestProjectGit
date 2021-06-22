using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProjectGit
{
    [TestClass]
    public class UnitTest1
    {

        public static string url = "https://www.demoblaze.com/";
        public static IWebDriver Driver { get; set; }

        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver chromeDriver = new ChromeDriver();
            Driver = chromeDriver;
            Driver.Url = url;
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();
            WebDriverWait webdriverWait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            String actualTitle = Driver.Title;
            Assert.AreEqual("STORE", actualTitle);
            Driver.Quit();

        }
    }
}
