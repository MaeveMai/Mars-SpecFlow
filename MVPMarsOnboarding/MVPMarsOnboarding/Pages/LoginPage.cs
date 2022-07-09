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
        public void LoginSteps(IWebDriver driver)
        {
            //maximize the window
            driver.Manage().Window.Maximize();

            //open mars portal
            driver.Navigate().GoToUrl("http://localhost:5000");

            try
            {
                //click on signin button
                WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id='home']/div/div/div[1]/div/a", 5);

                IWebElement SigninButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
                SigninButton.Click();

                //input email address
                IWebElement EmailAddressTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                EmailAddressTextBox.SendKeys("mvpstudiomaeve@gmail.com");

                //input password
                IWebElement PasswordTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                PasswordTextBox.SendKeys("mvpstudioMaeve2022");

                //click on login button
                IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                LoginButton.Click();


            }
            catch (Exception ex)
            {
                Assert.Fail("Portal does not launch.", ex.Message);
            }
        }

    }
}
