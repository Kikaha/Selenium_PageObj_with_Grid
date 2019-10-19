using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using Google_Search.Pages;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Support.UI;

namespace Google_Search
{
    [TestFixture]
    public class StartUp
    {
        private ChromeDriver _driver;
        private LoginPage _loginPage;

        [SetUp]
        public void TestInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
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
