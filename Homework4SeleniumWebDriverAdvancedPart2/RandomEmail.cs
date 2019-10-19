
using System;

namespace Homework4SeleniumWebDriverAdvancedPart2
{
    public static class RandomEmail
    {
        public static string Generate()
        {
            return Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 6) + "@" + "abv.bg";
        }
    }
}
