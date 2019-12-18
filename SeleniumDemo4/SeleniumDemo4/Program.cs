using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumDemo4
{
    class Program
    {
        IWebDriver driver;
     [SetUp]
     public void lauchBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void openURL()
        {
            driver.Navigate().GoToUrl("https://www.twitter.com");
        }
    }
}
