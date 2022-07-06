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
        public void OpenMarsPortal(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://localhost:5000");
        }

        public void LoginSteps(IWebDriver driver)
        {

            try
            {
                WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id='home']/div/div/div[1]/div/a", 5);
   
            IWebElement SigninButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            SigninButton.Click();

            IWebElement EmailAddressTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            EmailAddressTextBox.SendKeys("mvpstudiomaeve@gmail.com");

            IWebElement PasswordTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            PasswordTextBox.SendKeys("mvpstudioMaeve2022");

            IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            LoginButton.Click();


            }
            catch (Exception ex)
            {
                Assert.Fail("Mars portal login fail");
            }
        }

    }
}
