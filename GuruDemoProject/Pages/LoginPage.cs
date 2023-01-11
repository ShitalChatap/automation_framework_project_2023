using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruDemoProject.page
{
    public class LoginPage
    {
        private IWebDriver driver;
        private By _userNamelocator = By.XPath("//input[@name='userName']");

        private By _PasswordLocator =By.XPath("//input[@name='password']");

        private By _submitbuttonloacator = By.XPath("//input[@type='submit']");
        private By _messagelocator = By.XPath("//span[contains(text(),'Enter your')]");

        public LoginPage(IWebDriver driver)
        { 
            this.driver = driver;
        }   
        public void EnterUserName (string user) 
        {
            driver.FindElement(_userNamelocator).SendKeys(user);

        }
        public void EnterPassword(string password) 
        {
            driver.FindElement(_PasswordLocator).SendKeys(password);
        }
        public void ClickOnSubmit()
        {

            driver.FindElement(_submitbuttonloacator).Click();
        }
        public string  GetInvalidErrorMessage()
        {

          return driver.FindElement(_messagelocator).Text;
        }

    }
}
