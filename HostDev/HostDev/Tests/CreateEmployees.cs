using OpenQA.Selenium;
using HostDev.Framework;

namespace _087Nov18
{
    internal class CreateEmployees
    {
        private IWebDriver driver;

        public CreateEmployees(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement ClickonCreateButton => driver.FindElement(By.XPath("//a[@class='btn btn-primary']"));
        IWebElement Name => driver.FindElement(By.Id("Name"));
        IWebElement Username => driver.FindElement(By.Id("Username"));
        IWebElement Contact => driver.FindElement(By.Id("ContactDisplay"));
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
            WebElementExtensions.ElementExists(driver, By.Name(""), System.TimeSpan.FromDays(1));
        }
    }
}