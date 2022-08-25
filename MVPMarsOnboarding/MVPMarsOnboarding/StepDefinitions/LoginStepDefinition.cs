using MVPMarsOnboarding.Drivers;
using MVPMarsOnboarding.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MVPMarsOnboarding.StepDefinitions
{
    [Binding]
    public class LoginStepDefinition : CommonDriver
    {

        ProfilePage profilePageObj;

        public LoginStepDefinition()
        {
            profilePageObj = new ProfilePage(driver);
        }


        [Given(@"I login mars portal")]
        public void GivenILoginMarsPortal()
        {
            // log in step
            loginpageObj.LoginSteps();
        }

        [Then(@"The profile page should be presented")]
        public void ThenTheProfilePageShouldBePresented()
        {
            string HiUser = profilePageObj.GetHiUser();
            Assert.That(HiUser == "Hi Maeve" | HiUser == "Hi", "Hi User not match");
        }

    }
}