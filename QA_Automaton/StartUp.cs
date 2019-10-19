using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using QA_Automaton.Pages;
using System;
using System.IO;
using System.Reflection;

namespace QA_Automaton
{
    [TestFixture]
    public class StartUp
    {
        private ChromeDriver _driver;
        private LoginPage _loginpage;
        private SoftUniPage _softunipage;

        [SetUp]
        public void TestInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
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
