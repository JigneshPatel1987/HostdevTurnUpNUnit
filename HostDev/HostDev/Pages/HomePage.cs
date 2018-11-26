using System;
using OpenQA.Selenium;

namespace _087Nov18
{
    internal class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement administrationclick => driver.FindElement(By.XPath("//a[contains(.,'Administration ')]"));
        IWebElement timeandmaterialclick => driver.FindElement(By.XPath("//a[@href='/TimeMaterial']"));
        IWebElement EmployeesClick => driver.FindElement(By.XPath("//a[contains(.,'Employees')]"));

        internal void clickAdminstration()
        {

            administrationclick.Click();
         }

        internal void clickTimenMaterial()
        {
            timeandmaterialclick.Click();
        }

        internal void ClickEmployees()
        {
            EmployeesClick.Click();
        }
    }
}