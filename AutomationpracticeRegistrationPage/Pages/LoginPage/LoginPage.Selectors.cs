using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationpracticeRegistrationPage.Pages
{
    public partial class LoginPage:BasePage
    {
        public LoginPage(IWebDriver driver):base(driver)
        {
        }
        public IWebElement inputField => Driver.FindElement(By.Id("email_create"));
        public IWebElement submitButton => Driver.FindElement(By.Id("SubmitCreate"));

        public void Navigate(InitialPage initialpage)
        {
            initialpage.Navigate();
            initialpage.signInButton.Click();
        }

    }
}
