using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QA_Automaton.Pages
{
    public class SoftUniPage:BasePage
    {
        private string text;
        public SoftUniPage(ChromeDriver driver):base(driver)
        {
        }

        public void AssertText(string expected)
        {
            Assert.AreEqual(expected, text);
        }

        public void Navigate(LoginPage loginPage)
        {
            loginPage.Navigate();
            loginPage.SearchButton.Click();
            loginPage.searchField.SendKeys("QA Automation - януари 2019");
            loginPage.searchField.Submit();
            loginPage.boxQAcourse.Click();
            loginPage.Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            text = loginPage.finalBoxText.GetAttribute("innerText");
        }


    }
}
