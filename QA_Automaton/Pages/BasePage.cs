using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace QA_Automaton.Pages
{
    public abstract class BasePage
    {

        private ChromeDriver _driver;
        private WebDriverWait _wait;

        public BasePage(ChromeDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
        }

        public ChromeDriver Driver => _driver;

        public WebDriverWait Wait => _wait;

        public void Navigate(string url)
        {
            Driver.Url = url;
        }

    }
}
