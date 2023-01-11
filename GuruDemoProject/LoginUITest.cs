using GuruDemoProject.Base;
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
    public class LoginUITest : AutomationWrapper
    {

        [Test]
     
       public void ValidTitleTest()
        {
          
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.That(actualTitle, Is.EqualTo("Welcome: Mercury Tours"));


        }
        [Test]

        public void ValidateIdTest()
        {
           

           string userNameId= driver.FindElement(By.XPath("//input[@name='userName']")).GetAttribute("name");
            string passwordId = driver.FindElement(By.XPath("//input[@name='password']")).GetAttribute("name");
            
               Assert.That(userNameId, Is.EqualTo("userName"));
               Assert.That(passwordId,Is.EqualTo("password"));






        }

    }
}
