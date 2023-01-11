using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuruDemoProject.Base;
using GuruDemoProject.Utilities;
using GuruDemoProject.page;

namespace GuruDemoProject
{
    public class LoginTest : AutomationWrapper
    {
       
        [Test]
        public void ValidLoginTest()
        {
            driver.FindElement(By.Name("userName")).SendKeys("shital");
            driver.FindElement(By.Name("password")).SendKeys("shital@12345");
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();

           string actualUrl = driver.Url;

           Assert.That(actualUrl.Contains("https://demo.guru99.com/test/newtours/login_sucess.php"));

        }
       

        [Test ,TestCaseSource(typeof(DataSource),nameof(DataSource.InvalidLoginData1))]
      
        public void InvalidLoginTest(string username ,string password,string expectederror)
        {
            LoginPage loginpage = new LoginPage(driver);
            loginpage.EnterUserName(username);
            loginpage.EnterPassword(password);
            loginpage.ClickOnSubmit();
          

          

            string actualerror=loginpage.GetInvalidErrorMessage();
       
            Assert.That(actualerror.Contains(expectederror), "Assertion on error message");
         
        }
    }
}
