using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Search.Pages
{
    public partial class LoginPage
    {
        private ChromeDriver _driver;
        private WebDriverWait _wait;

        public LoginPage(ChromeDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
        }

        public IWebElement inputField => _wait.Until(x => x.FindElement(By.XPath(@"//*[@id=""tsf""]/div[2]/div[1]/div[1]/div/div[2]/input")));
        public IWebElement submintButton => _wait.Until(x => x.FindElement(By.XPath(@"//*[@id=""tsf""]/div[2]/div[1]/div[3]/center/input[1]")));

        public IList<IWebElement> ListLinks =>_wait.Until(x=>x.FindElements(By.PartialLinkText("Selenium")));

        public void Navigate()
        {
            _driver.Url = "https://www.google.com";
        }

    }
}
