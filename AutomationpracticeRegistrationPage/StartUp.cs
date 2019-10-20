﻿using AutomationpracticeRegistrationPage.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Reflection;

namespace AutomationpracticeRegistrationPage
{
    [TestFixture]
    public class StartUp
    {
        private IWebDriver _driver;
        private InitialPage _initialPage;
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
            _initialPage = new InitialPage(_driver);
            _loginPage = new LoginPage(_driver);           
        }

        [Test]
        public void GoToRegPage()
        {
            _loginPage.Navigate(_initialPage);
            _loginPage.inputField.SendKeys(RandomEmail.Generate());
            _loginPage.submitButton.Click();
            _loginPage.AssertErrorMessage("http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
