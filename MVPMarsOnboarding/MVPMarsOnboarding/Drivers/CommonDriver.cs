using MVPMarsOnboarding.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MVPMarsOnboarding.Drivers
{

    [Binding]
    public class CommonDriver
    {
        public static IWebDriver driver;
        public static LoginPage loginpageObj;

        public CommonDriver()
        {
            loginpageObj = new LoginPage(driver);
        }

        [BeforeTestRun]
        public static void oneTimeSetup()
        {
            //Open chrome browser
            driver = new ChromeDriver();

        }


        [AfterTestRun]
        public static void CloseTestRun()
        {
            driver.Quit();
        }

    }
}

