using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationpracticeRegistrationPage.Pages
{
    public class InitialPage:BasePage
    {
        public InitialPage(IWebDriver driver):base(driver)
        {
        }

        public IWebElement signInButton => Driver.FindElement(By.XPath(@"//*[@id=""header""]/div[2]/div/div/nav/div[1]/a"));

        public void Navigate()
        {
            Driver.Url = "http://automationpractice.com/index.php";
        }
    }
}
