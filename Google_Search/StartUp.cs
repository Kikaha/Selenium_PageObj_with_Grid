using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using Google_Search.Pages;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;

namespace Google_Search
{
    [TestFixture]
    public class StartUp
    {
        private IWebDriver _driver;
        private LoginPage _loginPage;

        [SetUp]
        public void TestInit()
        {
            ChromeOptions options = new ChromeOptions();
            options.PlatformName = "windows";
            options.BrowserVersion = "77.0";

            _driver = new RemoteWebDriver(new Uri("http://192.168.254.1:18415/wd/hub"), options.ToCapabilities(), TimeSpan.FromSeconds(10));
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

            //_driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            _loginPage = new LoginPage(_driver);
        }

        [Test]
        public void firstLink()
        {
            _loginPage.Navigate();
            _loginPage.inputField.SendKeys("Selenium");
             _loginPage.submintButton.Click();
            _loginPage.ListLinks[0].Click();
            _loginPage.AssertErrorMessage("https://www.seleniumhq.org/");
         }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

    }
}
