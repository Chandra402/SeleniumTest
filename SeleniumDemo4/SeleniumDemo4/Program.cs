using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumDemo4
{
    class Program
    {
        static IWebDriver driver;
     public static void Main ()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.twitter.com");
        }
    }
}
