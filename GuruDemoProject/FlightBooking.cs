using GuruDemoProject.Base;
using GuruDemoProject.page;
using GuruDemoProject.Utilities;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruDemoProject
{
    public class FlightBooking : AutomationWrapper
    {
        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.FlightBookingData1))]
        public void FlightBookTest(string username,string password,string count ,string location,string month ,string date)
        {
            LoginPage loginpage = new LoginPage(driver);
            loginpage.EnterUserName(username);
            loginpage.EnterPassword(password);
            loginpage.ClickOnSubmit();

            //  Flight Details
            driver.FindElement(By.LinkText("Flights")).Click();
            driver.FindElement(By.XPath("//input[@value='oneway']")).Click();

            SelectElement Passengers = new SelectElement(driver.FindElement(By.Name("passCount")));
            Passengers.SelectByText(count);

            SelectElement DepartingFrom = new SelectElement(driver.FindElement(By.Name("fromPort")));
            DepartingFrom.SelectByText(location);
            Thread.Sleep(1000);
            SelectElement Month = new SelectElement(driver.FindElement(By.Name("fromMonth")));
            Month.SelectByText(month);
            

            SelectElement Day = new SelectElement(driver.FindElement(By.Name("fromDay")));
            Day.SelectByText(date);


            driver.FindElement(By.XPath("(//input[@value='First'])")).Click();

            SelectElement Airline = new SelectElement(driver.FindElement(By.Name("airline")));
            Airline.SelectByText("No Preference");

            driver.FindElement(By.Name("findFlights")).Click();










        }


    }
}
