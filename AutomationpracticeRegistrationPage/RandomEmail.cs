using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationpracticeRegistrationPage
{
    public static class RandomEmail
    {
        public static string Generate()
        {
            return Guid.NewGuid().ToString().Substring(0, 6) + "@" + "abv.bg";
        }
    }
}
