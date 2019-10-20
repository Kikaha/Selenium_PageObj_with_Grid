using AutoFixture;
using Homework4SeleniumWebDriverAdvancedPart2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Homework4SeleniumWebDriverAdvancedPart2
{
    [TestFixture]
    public class Class1
    {
        private IWebDriver _driver;
        private UserProperty _user;
        private LoginPage _loginPage;
        private RegistrationPage _regPage;

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
            _user = Factory.CreateUser();
            _loginPage = new LoginPage(_driver);
            _regPage = new RegistrationPage(_driver);

        }

        [Test]
        public void Registration_Missing_FirstName()
        {
            _user.FirstName = "";
            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);
            _regPage.AssertErrorMessage("firstname is required.");
        }
        [Test]
        public void Test_SuccessfullRegistration()
        {
            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            var signFieldEntered = _driver.FindElement(By.XPath(@"//*[@class=""account""]/span"));
            Assert.AreEqual("Duke Nukem", signFieldEntered.Text);
        }

        [Test]
        public void Registration_missing_PhoneNumber()
        {
            _user.Phone = "";
            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);
            _regPage.AssertErrorMessage("You must register at least one phone number.");
        }

        [Test]
        public void Registration_Missing_LastName()
        {
            _user.LastName = "";
            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);
            _regPage.AssertErrorMessage("lastname is required.");
        }

        [Test]
        public void Registration_Missing_Email()
        {
            _regPage.Navigate(_loginPage);
            _regPage.FillFormEmail(_user);
            _regPage.AssertErrorMessage("email is required.");


        }

        [Test]
        public void Registration_Missing_Password()
        {

            _user.Password = "";
            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);
            _regPage.AssertErrorMessage("passwd is required.");
        }

        [Test]
        public void Registration_Missing_Address1()
        {
            _user.Address = "";
            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);
            _regPage.AssertErrorMessage("address1 is required.");
        }

        [Test]
        public void Registration_Missing_City()
        {
            _user.City = "";
            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);
            _regPage.AssertErrorMessage("city is required.");
        }

        [Test]
        public void Registration_Missing_ZipCode()
        {
            _user.Postalcode = "";
            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);
            _regPage.AssertErrorMessage("The Zip/Postal code you've entered is invalid. It must follow this format: 00000");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
