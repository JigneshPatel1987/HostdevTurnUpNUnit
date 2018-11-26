using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostDev.Framework
{
    public static class WebElementExtensions
    {
        public static void ElementExists(IWebDriver driver, By by,TimeSpan time)
        {
            WebDriverWait wait = new WebDriverWait(driver, time);
            wait.Until(ExpectedConditions.ElementExists(by));
        }
    }
}
