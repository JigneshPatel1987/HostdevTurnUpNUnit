using HostDev.Framework;
using OpenQA.Selenium;

namespace HostDev
{
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement username => driver.FindElement(By.Id("UserName"));
        IWebElement password => driver.FindElement(By.Id("Password"));
        IWebElement clickbutton => driver.FindElement(By.XPath("//input[@class='btn btn-default']"));

        internal void LoginSuccess()
        {
            username.SendKeys(ExcelLibHelpers.ReadData(2, "UserName"));
            password.SendKeys(ExcelLibHelpers.ReadData(2, "Password"));

            clickbutton.Click();
        }

        internal void ValidateTheMaxcharacterforemailfield()
        {
            //IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");
        }
    }
}
