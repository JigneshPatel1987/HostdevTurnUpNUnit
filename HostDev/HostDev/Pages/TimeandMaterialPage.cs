using System;
using System.Threading;
using HostDev.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace _087Nov18
{
    internal class TimeandMaterialPage
    {
        private IWebDriver driver;

        public TimeandMaterialPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement Clickcreate1 => driver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']"));
        IWebElement Id => driver.FindElement(By.Id("Code"));
        IWebElement Descid => driver.FindElement(By.Id("Description"));
        IWebElement Editbutton => driver.FindElement(By.XPath("//a[contains(.,'Edit')]"));
        IWebElement nextbtn => driver.FindElement(By.XPath("//span[@class='k-icon k-i-arrow-e']"));

        internal void Clickcreate()
        {
            Clickcreate1.Click();            
        }

        internal void Savebutton1()
        {
            Id.SendKeys("Test");
            Descid.SendKeys("Test Descrition");
            driver.FindElement(By.XPath(".//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("7.90");
            driver.FindElement(By.XPath("//input[@id='SaveButton']")).Click();
            WebElementExtensions.ElementExists(driver, By.Name(""), TimeSpan.FromDays(1));
        }

        internal void CreateTimeAndMaterial()
        {
            // For Creating First Record
            Id.SendKeys(ExcelLibHelpers.ReadData(2, "Code"));
            Descid.SendKeys(ExcelLibHelpers.ReadData(2, "Description"));
            driver.FindElement(By.XPath(".//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys(ExcelLibHelpers.ReadData(2, "PricePerUnit"));
            driver.FindElement(By.XPath("//input[@id='SaveButton']")).Click();
            WebElementExtensions.ElementExists(driver, By.Name(""), TimeSpan.FromDays(1));

            //For Creating Second Record
            Id.SendKeys(ExcelLibHelpers.ReadData(3, "Code"));
            Descid.SendKeys(ExcelLibHelpers.ReadData(3, "Description"));
            driver.FindElement(By.XPath(".//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys(ExcelLibHelpers.ReadData(3, "PricePerUnit"));
            driver.FindElement(By.XPath("//input[@id='SaveButton']")).Click();
            WebElementExtensions.ElementExists(driver, By.Name(""), TimeSpan.FromDays(1));

            //For Creating Third Record
            Id.SendKeys(ExcelLibHelpers.ReadData(4, "Code"));
            Descid.SendKeys(ExcelLibHelpers.ReadData(4, "Description"));
            driver.FindElement(By.XPath(".//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys(ExcelLibHelpers.ReadData(4, "PricePerUnit"));
            driver.FindElement(By.XPath("//input[@id='SaveButton']")).Click();
            WebElementExtensions.ElementExists(driver, By.Name(""), TimeSpan.FromDays(1));

        }

        internal void ValidateTimenMaterial()
        {
            WebElementExtensions.ElementExists(driver, By.XPath("//a[contains(.,'Edit')]"), TimeSpan.FromSeconds(10));

            try
            {
                while (true)
                {
                    for (var i = 1; i <= 10; i++)
                    {
                        IWebElement code = driver.FindElement(By.XPath("//tr[" + i + "]/td[1]"));
                        IWebElement desc = driver.FindElement(By.XPath("//tr[" + i + "]/td[3]"));
                        IWebElement TypeCode = driver.FindElement(By.XPath("//tr[" + i + "]/td[2]"));
                        IWebElement Price = driver.FindElement(By.XPath("//tr[" + i + "]/td[4]"));
                        //IWebElement Editbtn = driver.FindElement(By.XPath("//tr[" + i + "]/td[5]/a[@class='k-button k-button-icontext k-grid-Edit' and 1]"));

                        Console.WriteLine(code.Text);
                        Console.WriteLine(desc.Text);
                        Console.WriteLine(TypeCode.Text);
                        Console.WriteLine(Price.Text);
                        if (code.Text == "Test" && desc.Text == "Test Descrition" && TypeCode.Text == "M" && Price.Text == "7.90")
                        {
                            Console.WriteLine("Test Passed");

                            //Editbtn.Click();

                            return;
                        }
                    }

                    nextbtn.Click();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Test Failed");
            }


        }

        internal void EditTimenMaterail()
        {
            WebElementExtensions.ElementExists(driver, By.XPath("//a[contains(.,'Edit')]"), TimeSpan.FromSeconds(10));

            try
            {
                while (true)
                {
                    for (var i = 1; i <= 10; i++)
                    {
                        IWebElement code = driver.FindElement(By.XPath("//tr[" + i + "]/td[1]"));
                        IWebElement desc = driver.FindElement(By.XPath("//tr[" + i + "]/td[3]"));
                        IWebElement TypeCode = driver.FindElement(By.XPath("//tr[" + i + "]/td[2]"));
                        IWebElement Price = driver.FindElement(By.XPath("//tr[" + i + "]/td[4]"));
                        IWebElement btnedit = driver.FindElement(By.XPath("//tr[" + i + "]/td[5]/a[@class='k-button k-button-icontext k-grid-Edit' and 1]"));

                        Console.WriteLine(code.Text);
                        Console.WriteLine(desc.Text);
                        Console.WriteLine(TypeCode.Text);
                        Console.WriteLine(Price.Text);
                        if (code.Text == "PlasticP1" && desc.Text == "bad palcticP2")// && TypeCode.Text == "M" && Price.Text == "7.90")
                        {
                            Console.WriteLine("Test Passed");

                            btnedit.Click();
                            Id.Clear();
                            Id.SendKeys("P1");
                            Descid.Clear();
                            Descid.SendKeys("P2");
                            driver.FindElement(By.XPath(".//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("7.90");
                            driver.FindElement(By.XPath("//input[@id='SaveButton']")).Click();


                            WebElementExtensions.ElementExists(driver, By.XPath("//a[contains(.,'Edit')]"), TimeSpan.FromSeconds(10));

                            return;
                        }
                    }

                    nextbtn.Click();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Test Failed");
            }
        }

        internal void deleteTimenMaterial()
        {
            // WebElementExtensions.ElementExists(driver, By.XPath("//tr[1]/td[5]/a[@class='k-button k-button-icontext k-grid-Delete' and 2]"), TimeSpan.FromSeconds(10));
            WebElementExtensions.ElementExists(driver, By.XPath("//a[contains(.,'Edit')]"), TimeSpan.FromSeconds(10));
            try
            {
                while (true)
                {
                    for (var i = 1; i <= 10; i++)
                    {
                        IWebElement code = driver.FindElement(By.XPath("//tr[" + i + "]/td[1]"));
                        IWebElement desc = driver.FindElement(By.XPath("//tr[" + i + "]/td[3]"));
                        IWebElement TypeCode = driver.FindElement(By.XPath("//tr[" + i + "]/td[2]"));
                        IWebElement Price = driver.FindElement(By.XPath("//tr[" + i + "]/td[4]"));
                        IWebElement btndelete = driver.FindElement(By.XPath("//tr[" + i + "]/td[5]/a[@class='k-button k-button-icontext k-grid-Delete' and 2]"));

                        Console.WriteLine(code.Text);
                        Console.WriteLine(desc.Text);
                        Console.WriteLine(TypeCode.Text);
                        Console.WriteLine(Price.Text);
                        if (code.Text == "SSRR112" && desc.Text == "SSRR112")// && TypeCode.Text == "M" && Price.Text == "7.90")
                        {
                            Console.WriteLine("Test Passed");
                            btndelete.Click();
                            Thread.Sleep(2000);
                            driver.SwitchTo().Alert().Accept();
                            Thread.Sleep(2000);

                            //Deletbtn.Click();

                            //Editbtn.Click();
                            //Id.Clear();
                            //Id.SendKeys("Testnew");
                            //Descid.SendKeys("Test Descritionnew");
                            //driver.FindElement(By.XPath(".//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("7.90");
                            //driver.FindElement(By.XPath("//input[@id='SaveButton']")).Click();


                            //WebElementExtensions.ElementExists(driver, By.XPath("//a[contains(.,'Edit')]"), TimeSpan.FromSeconds(10));

                            return;
                        }
                    }

                    nextbtn.Click();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Test Failed");
            }
        }

        //internal void Editbutoon()
        //{
        //    //Thread.Sleep(2000);
        //    //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //    //wait.Until(ExpectedConditions.ElementExists((By.XPath("//a[contains(.,'Edit')]"))));

        //    WebElementExtensions.ElementExists(driver, By.XPath("//a[contains(.,'Edit')]"), TimeSpan.FromSeconds(10));
        //    Editbutton.Click();        


        //}
    }
}