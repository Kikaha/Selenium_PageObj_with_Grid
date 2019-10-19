using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationpracticeRegistrationPage.Pages
{
    public partial class LoginPage
    {
 
        public void AssertErrorMessage(string expected)
        {
            Wait.Until(x => x.Url == "http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation");
            Assert.AreEqual(expected, Driver.Url.ToString());
        }
    }
}
