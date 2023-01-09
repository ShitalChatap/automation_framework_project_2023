using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruDemoProject
{
    public class LoginUITest
    {
        [Test]
       public void ValidTitleTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);
           // driver.Url = "https://demo.guru99.com/";
            driver.Url = "https://demo.guru99.com/test/login.html";
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);

            // Assert.AreEqual(actualTitle, actualTitle);
           // Assert.That(actualTitle, Is.EqualTo("Guru Bank Home Page"));
            Assert.That(actualTitle, Is.EqualTo("Login Page"));


        }


    }
}
