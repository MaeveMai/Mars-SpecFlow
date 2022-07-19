using MVPMarsOnboarding.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPMarsOnboarding.Pages
{
    public class LoginPage
    {
        public IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //find element by XPath
        private IWebElement SigninButton => driver.FindElement(By.XPath(SigninButtonXpath));
        private IWebElement EmailAddressTextBox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        private IWebElement PasswordTextBox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        private IWebElement LoginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));


        //String
        private string SigninButtonXpath = "//*[@id='home']/div/div/div[1]/div/a";
        private string PortalUrl = "http://localhost:5000";


        public void LoginSteps()
        {
            //maximize the window
            driver.Manage().Window.Maximize();

            //open mars portal
            driver.Navigate().GoToUrl(PortalUrl);

            try
            {
                //click on signin button
                WaitHelpers.WaitToBeClickable(driver, "XPath", SigninButtonXpath, 5);
                SigninButton.Click();

                //input email address
                EmailAddressTextBox.SendKeys("mvpstudiomaeve@gmail.com");

                //input password
                PasswordTextBox.SendKeys("mvpstudioMaeve2022");

                //click on login button               
                LoginButton.Click();


            }
            catch (Exception ex)
            {
                Assert.Fail("Portal does not launch.", ex.Message);
            }
        }

    }
}
