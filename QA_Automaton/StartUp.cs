using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using QA_Automaton.Pages;
using System;
using System.IO;
using System.Reflection;

namespace QA_Automaton
{
    [TestFixture]
    public class StartUp
    {
        private IWebDriver _driver;
        private LoginPage _loginpage;
        private SoftUniPage _softunipage;

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
            _loginpage = new LoginPage(_driver);
            _softunipage = new SoftUniPage(_driver);
        }

        [Test]
        public void softUniNvigate()
        {
            _softunipage.Navigate(_loginpage);
            _softunipage.AssertText("QA Automation - януари 2019"); 
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
