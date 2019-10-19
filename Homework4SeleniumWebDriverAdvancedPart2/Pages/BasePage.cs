using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Homework4SeleniumWebDriverAdvancedPart2.Pages
{
    public abstract class BasePage
    {
        private ChromeDriver _driver;
        private WebDriverWait _wait;

        public BasePage(ChromeDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
        }
        public IWebDriver Driver => _driver;
        public WebDriverWait Wait => _wait;
        
        public virtual void Navigate(string url)
        {
            Driver.Url = url;
        }

    }

}
