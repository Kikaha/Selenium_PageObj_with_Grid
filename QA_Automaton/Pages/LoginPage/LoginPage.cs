using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace QA_Automaton.Pages
{
    public class LoginPage:BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement SearchButton => Driver.FindElement(By.XPath(@"//*[@id=""search-icon-container""]/a/span/i"));

        public IWebElement searchField => Wait.Until(x => x.FindElement(By.Id("search-input")));

        public IWebElement boxQAcourse => Wait.Until(x => x.FindElement(By.XPath(@"//*[@id=""fast-track-instance-results""]/ul/li[1]/div/a/span[1]/span")));

        public IWebElement finalBoxText => Wait.Until(x=>x.FindElement(By.XPath(@"/html/body/div[2]/header/h1")));
        public void Navigate()
        {
            Driver.Url = "https://softuni.bg";
        }


    }
}
