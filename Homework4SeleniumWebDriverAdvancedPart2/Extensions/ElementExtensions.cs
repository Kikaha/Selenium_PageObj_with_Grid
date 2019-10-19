using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4SeleniumWebDriverAdvancedPart2

{
    public static class ElementExtensions
    {
        public static void Type(this IWebElement element)
        {
            element.Clear();
        }
    }
}
