using HostDev;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using HostDev.Framework;

namespace _087Nov18
{
    class Program
    {
        class Nunit201118
        {
            [SetUp]
            public void setup()
            {
                //Creating instance of chrome driver
               GlobalDriver.driver = new ChromeDriver();
                
                // IWebDriver driver = new ChromeDriver();
                GlobalDriver.driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login");
                ExcelLibHelpers.PopulateInCollection(@"E:\TestData\TestDataForHorseDev.xlsx", "Login");
                
                // login page :: Identifying and sending valid inputs
                LoginPage loginPage = new LoginPage(GlobalDriver.driver);
                loginPage.LoginSuccess();

                // Home Page - clicking on adminsitration and time n materials
                HomePage instanceName = new HomePage(GlobalDriver.driver);
                instanceName.clickAdminstration();
                instanceName.clickTimenMaterial();
                
            }

            [Test]
            public void CreateTest()
            {
                TimeandMaterialPage inssatnceNameTandM = new TimeandMaterialPage(GlobalDriver.driver);
                inssatnceNameTandM.Clickcreate();
                //inssatnceNameTandM.Savebutton1();
                ExcelLibHelpers.PopulateInCollection(@"E:\TestData\TestDataForHorseDev.xlsx", "CreateTimeAndMaterials");
                inssatnceNameTandM.CreateTimeAndMaterial();
                GlobalDriver.driver.Dispose();
            }

            //[Test]
            //public void createst()
            //{
            //    // Time & Material Page - Click on Create New record and Submit Time and Material Value.
            //    TimeandMaterialPage instanceNameTandM = new TimeandMaterialPage(GlobalDriver.driver);
            //    instanceNameTandM.Clickcreate();
            //    instanceNameTandM.Savebutton1();
            //    GlobalDriver.driver.Close();
            //}

            [Test]
            public void edittest()
            {
                // Time & Material Page - Click on Edit Button and Edit Time and Material Value.
                TimeandMaterialPage instanceNameTandM = new TimeandMaterialPage(GlobalDriver.driver);
                instanceNameTandM.EditTimenMaterail();
            }

            [Test]
            public void deletetest()
            {
                // Time & Material Page - Click on Delete and Confirm Delete Time and Material value.
                TimeandMaterialPage instanceNameTandM = new TimeandMaterialPage(GlobalDriver.driver);
                instanceNameTandM.deleteTimenMaterial();
            }

            [Test]
            public void CreateEmployees()
            {
                // Home Page - clicking on adminsitration and Employees
                HomePage instanceName = new HomePage(GlobalDriver.driver);
                instanceName.clickAdminstration();
                instanceName.ClickEmployees();

                // Employees Page - Click on Create New record and Submit Employee Record Value.
                CreateEmployees instanceEmp = new CreateEmployees(GlobalDriver.driver);
                instanceEmp.ClickonCreate();
                instanceEmp.SaveButton();
                GlobalDriver.driver.Close();

            }

            [TearDown]
            public void teardown()
            {
                //Closing driver instance
                GlobalDriver.driver.Close();
            }
        }

        static void Main(string[] args)
        {
                                                               
        //    //Time and Material Page - create new and adding valid details

        //    //Time and Material Page  - validating the record created

         //Closing driver instance
            GlobalDriver.driver.Close();


        //    //IWebDriver driver1 = new ChromeDriver();
        //    //driver1.Navigate().GoToUrl("http://www.industryconnect.io");

        //    //driver1.FindElement(By.Id("Email")).SendKeys("jigneshpatel1987@gmail.com");
        //    //driver1.FindElement(By.Id("Password")).SendKeys("Test@123");

        //    //driver1.FindElement(By.XPath("//input[@class='btn btn-xl  signinbtn']")).Click();



        }



    }

}
