using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace GuruDemoProject.Base
{
    public class AutomationWrapper
    { 
        protected IWebDriver driver;

        [SetUp]
        public void BeforeMethod()
        {
            string browserName = "";
            if (browserName.ToLower().Equals("edge"))
            {
                driver = new EdgeDriver();
            }
            else if (browserName.ToLower().Equals("firefox"))
            {
                driver = new FirefoxDriver();
            }
            else
            {
                driver = new ChromeDriver();



            }

            //browser launch
           
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
          
            driver.Url = "https://demo.guru99.com/test/newtours/index.php";
        }

        [TearDown]
        public void AfterMethod()
        {
           
           driver.Quit();
        }
    }
}
