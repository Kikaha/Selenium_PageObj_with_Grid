using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Homework4SeleniumWebDriverAdvancedPart2.Pages
{
    public partial class RegistrationPage:BasePage
    {

        public RegistrationPage(ChromeDriver driver):base(driver)
        {
        }
        public IList<IWebElement> Radiobuttons => Wait.Until(x => x.FindElements(By.ClassName("radio-inline")));

        public IWebElement CustomerFirstName => Driver.FindElement(By.Id("customer_firstname"));

        public IWebElement CustomerLastName => Driver.FindElement(By.Id("customer_lastname"));

        public IWebElement passwordField => Driver.FindElement(By.Id("passwd"));

        public SelectElement Days
        {
            get
            {
                var remainder = Driver.FindElement(By.Id("days"));
                return new SelectElement(remainder);
            }
        }

        public SelectElement Months
        {
            get
            {
                var remainder = Driver.FindElement(By.Id("months"));
                return new SelectElement(remainder);
            }
        }

        public SelectElement Years
        {
            get
            {
                var remainder = Driver.FindElement(By.Id("years"));
                return new SelectElement(remainder);
            }
        }
        public IWebElement ErrorMessage => Driver.FindElement(By.XPath(@"//*[@id=""center_column""]/div/ol/li"));

        public IWebElement FirstName => Driver.FindElement(By.Id("firstname"));

        public IWebElement LastName => Driver.FindElement(By.Id("lastname"));

        public IWebElement Address => Driver.FindElement(By.Id("address1"));

        public IWebElement City => Driver.FindElement(By.Id("city"));

        
        public IWebElement Email => Wait.Until(d=>d.FindElement(By.Id("email")));


        public SelectElement State
        {
            get
            {
                IWebElement statefind = Driver.FindElement(By.Id("id_state"));
                return new SelectElement(statefind);
            }
        }

        public IWebElement PostCode => Driver.FindElement(By.Id("postcode"));

        public IWebElement Phone => Driver.FindElement(By.Id("phone_mobile"));

        public IWebElement Alias => Driver.FindElement(By.Id("alias"));

        public IWebElement RegisterButton => Driver.FindElement(By.Id("submitAccount"));


    }
}
