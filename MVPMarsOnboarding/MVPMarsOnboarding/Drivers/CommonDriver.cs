using MVPMarsOnboarding.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPMarsOnboarding.Drivers
{
    
    public class CommonDriver
    {
        public static IWebDriver driver;
        LoginPage loginpageObj = new LoginPage(driver);


        [OneTimeSetUp]
        public void oneTimeSetup()
        {
            //Open chrome browser
            driver = new ChromeDriver();

            //Login page object initialization and definition
            loginpageObj.LoginSteps();

        }


        [OneTimeTearDown]
        public void CloseTestRun()
        {
            // Open chrome browser
            //driver = new ChromeDriver();
            driver.Quit();
        }

    }

}

