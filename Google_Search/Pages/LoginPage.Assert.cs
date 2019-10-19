using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Search.Pages
{
    public partial class LoginPage
    {
       public void AssertErrorMessage(string expected)
        {
            Assert.AreEqual(expected, _driver.Url.ToString());
        }



    }
}
