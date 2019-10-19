using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4SeleniumWebDriverAdvancedPart2.Pages
{
    public partial class RegistrationPage
    {
        public void FillForm(UserProperty user)
        {
            Radiobuttons[0].Click();
            CustomerFirstName.SendKeys(user.FirstName);
            CustomerLastName.SendKeys(user.LastName);
            passwordField.SendKeys(user.Password);
            Days.SelectByValue(user.Day);
            Months.SelectByValue(user.Month);
            Years.SelectByValue(user.Year);
            FirstName.SendKeys(user.AdressFirstName);
            LastName.SendKeys(user.AddressLastName);
            Address.SendKeys(user.Address);
            City.SendKeys(user.City);
            State.SelectByText(user.State);
            PostCode.SendKeys(user.Postalcode);
            Phone.SendKeys(user.Phone);
            Alias.SendKeys(user.Alias);
            RegisterButton.Click();
        }
        public void FillFormEmail(UserProperty user)
        {
            Radiobuttons[0].Click();
            CustomerFirstName.SendKeys(user.FirstName);
            CustomerLastName.SendKeys(user.LastName);
            passwordField.SendKeys(user.Password);
            Days.SelectByValue(user.Day);
            Months.SelectByValue(user.Month);
            Years.SelectByValue(user.Year);
            FirstName.SendKeys(user.AdressFirstName);
            LastName.SendKeys(user.AddressLastName);
            Address.SendKeys(user.Address);
            City.SendKeys(user.City);
            State.SelectByText(user.State);
            PostCode.SendKeys(user.Postalcode);
            Phone.SendKeys(user.Phone);
            Alias.SendKeys(user.Alias);
            Email.Clear();
            RegisterButton.Click();
        }

        public void Navigate(LoginPage loginPage)
        {
            loginPage.Navigate("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            loginPage.Email.SendKeys(RandomEmail.Generate());
            loginPage.SubmitButton.Click();
        }
    }
}
