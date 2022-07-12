using MVPMarsOnboarding.Drivers;
using MVPMarsOnboarding.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MVPMarsOnboarding.StepDefinitions
{
    [Binding]
    public class LoginStepDefinition:CommonDriver
    {

        ProfilePage profilePageObj;
        LoginPage loginPageObj;

        public LoginStepDefinition()
        {
            driver = new ChromeDriver();
            loginPageObj = new LoginPage(driver);
            profilePageObj = new ProfilePage(driver);
        }

        [Given(@"I login mars portal")]
        public void GivenILoginMarsPortal()
        {

            // log in steps
            loginPageObj.LoginSteps();
        }

        [Then(@"The profile page should be presented")]
        public void ThenTheProfilePageShouldBePresented()
        {
            //Check if the login was successful
            string HiUser = profilePageObj.GetHiUser();
            Assert.That(HiUser == "Hi Maeve" | HiUser == "Hi", "Hi User not match");
        }


        [After]
        public void AfterScenario()
        {
            if (driver != null)
            {
                driver.Close();
            }
        }
    }
}