using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace Homework4SeleniumWebDriverAdvancedPart2.Pages
    {
    public class LoginPage:BasePage
    {

        public LoginPage(IWebDriver driver):base(driver)
        {
            //_driver = driver;
            //_driver.Url = "http://automationpractice.com/index.php?controller=authentication&back=my-account";

        }

        //public new string Url = "http://automationpractice.com/index.php?controller=authentication&back=my-account";
        public IWebElement Email => Driver.FindElement(By.Id("email_create"));

        public IWebElement SubmitButton => Driver.FindElement(By.Id("SubmitCreate"));


    }
}
