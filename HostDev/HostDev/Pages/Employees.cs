using HostDev.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostDev.Pages
{
   internal class Employees
    {
        private IWebDriver driver;

        public Employees(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement ClickonCreateButton => driver.FindElement(By.XPath("//a[@class='btn btn-primary']"));
        IWebElement Name => driver.FindElement(By.Id("Name"));
        IWebElement Username => driver.FindElement(By.Id("Username"));
        IWebElement Contact => driver.FindElement(By.Id("ContactDispaly"));
        IWebElement Passwrod => driver.FindElement(By.Id("Password"));
        IWebElement ReTypePasswrod => driver.FindElement(By.Id("RetypePassword"));
        IWebElement Vehicle => driver.FindElement(By.XPath("//input[@class='k-input text-box single-line']"));
        IWebElement Groups => driver.FindElement(By.XPath("//input[@class='k-input k-readonly']"));

        internal void ClickonCreate()
        {
            ClickonCreateButton.Click();
        }

        internal void SaveButton()
        {
            Name.SendKeys("Charlie");
            Username.SendKeys("CPathan");
            Contact.SendKeys("02225673");
            Passwrod.SendKeys("Test@1234");
            ReTypePasswrod.SendKeys("Test@1234");
            driver.FindElement(By.XPath("//input[@class='k-input text-box single-line']")).SendKeys("Nissan");
            driver.FindElement(By.XPath("//input[@class='k-input k-readonly']")).SendKeys("Car");
            WebElementExtensions.ElementExists(driver, By.Name(""), TimeSpan.FromDays(1));
        }

    }
}
