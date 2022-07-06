using MVPMarsOnboarding.Drivers;
using MVPMarsOnboarding.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MVPMarsOnboarding.StepDefinitions
{
    [Binding]
    public class SellerManageProfileDetailsStepDefinitions : CommonDriver
    {
        [Given(@"I Open mars portal")]
        public void GivenIOpenMarsPortal()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.OpenMarsPortal(driver);
        }


        [When(@"I input correct credential")]
        public void WhenIInputCorrectCredential()
        {
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [Then(@"The profile page should be presented")]
        public void ThenTheProfilePageShouldBePresented()
        {
            ProfilePage profilePageObj = new ProfilePage();
            string HiUser = profilePageObj.GetHiUser(driver);
            Assert.That(HiUser == "Hi Maeve", "Hi User not match");
        }


        [Given(@"I logged into Mars portal successfully")]
        public void GivenILoggedIntoMarsPortalSuccessfully()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.OpenMarsPortal(driver);
            loginPageObj.LoginSteps(driver);

        }

        [When(@"I add new '([^']*)' records on lauguange module")]
        public void WhenIAddNewRecordsOnLauguangeModule(string p0)
        {
            LanguageModule LanguageModuleObj = new LanguageModule();
            LanguageModuleObj.AddNewLanguages(driver, p0);
        }

        [Then(@"the '([^']*)' records should be added in language module successfully")]
        public void ThenTheRecordsShouldBeAddedInLanguageModuleSuccessfully(string p0)
        {
            LanguageModule LanguageModuleObj = new LanguageModule();
            string NewLanguage = LanguageModuleObj.GetNewLanguage(driver);

            Assert.That(NewLanguage == p0, "New language do not match");

        }


        [When(@"I update '([^']*)'on existing language record")]
        public void WhenIUpdateOnExistingLanguageRecord(string p0)
        {
            LanguageModule languageModuleObj = new LanguageModule();
            languageModuleObj.EditExistingLanguage(driver, p0);
        }

        [Then(@"the language record should have updated '([^']*)'")]
        public void ThenTheLanguageRecordShouldHaveUpdated(string p0)
        {
            LanguageModule LanguageModuleObj = new LanguageModule();
            string NewLanguage = LanguageModuleObj.GetNewLanguage(driver);

            Assert.That(NewLanguage == p0, "Updated language do not match");

        }

        [When(@"I delete existing language record")]
        public void WhenIDeleteExistingLanguageRecord()
        {
            LanguageModule languageModuleObj = new LanguageModule();
            languageModuleObj.DeleteExistingLanguage(driver);
        }

        [Then(@"the language record should disappear from the language module")]
        public void ThenTheLanguageRecordShouldDisappearFromTheLanguageModule()
        {
            LanguageModule languageModuleObj = new LanguageModule();
            String NewLanguage = languageModuleObj.GetNewLanguage(driver);

            Assert.That(NewLanguage != "Japanese",NewLanguage);
        }

        //[When(@"I navigate to skills Module")]
        //public void WhenINavigateToSkillsModule()
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"I add new '([^']*)' record")]
        //public void WhenIAddNewLanguageRecord(string language)
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"the '([^']*)' record should be added successfully")]
        //public void ThenTheSkillShouldBeAddedSuccessfully(string programming)
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"I update '([^']*)'on existing skill record")]
        //public void WhenIUpdateOnExistingSkillRecord(string p0)
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"the skill record should have updated '([^']*)'")]
        //public void ThenTheSkillRecordShouldHaveUpdated(string p0)
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"I delete existing skill record")]
        //public void WhenIDeleteExistingSkillRecord()
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"the skill record should disappear from the skills module")]
        //public void ThenTheSkillRecordShouldDisappearFromTheSkillsModule()
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"I navigate to education Module")]
        //public void WhenINavigateToEducationModule()
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"I add new education record with '([^']*)' and '([^']*)'s Degree'")]
        //public void WhenIAddNewEducationRecordWithAndSDegree(string p0, string bachelor)
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"the education record should be added successfully with correct '([^']*)' and '([^']*)'s Degree'")]
        //public void ThenTheEducationRecordShouldBeAddedSuccessfully(string p0, string bachelor)
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"I update '([^']*)' and '([^']*)' on existing education record")]
        //public void WhenIUpdateAndOnExistingEducationRecord(string p0, string p1)
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"the education record should have updated '([^']*)' and '([^']*)'")]
        //public void ThenTheEducationRecordShouldHaveUpdatedAnd(string p0, string p1)
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"I delete existing education record")]
        //public void WhenIDeleteExistingEducationRecord()
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"the education record should disappear from the education module")]
        //public void ThenTheEducationRecordShouldDisappearFromTheEducationModule()
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"I navigate to certification Module")]
        //public void WhenINavigateToCertificationModule()
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"I add new certification record with '([^']*)' and '([^']*)'")]
        //public void WhenIAddNewCertificationRecordWithAnd(string p0, string p1)
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"the certification record should be added successfully with correct '([^']*)' and '([^']*)'")]
        //public void ThenTheCertificationRecordShouldBeAddedSuccessfullyWithCorrectAnd(string p0, string p1)
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"I update '([^']*)' and '([^']*)' on existing certification record")]
        //public void WhenIUpdateAndOnExistingCertificationRecord(string p0, string p1)
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"the certification record should have updated '([^']*)' and '([^']*)'")]
        //public void ThenTheCertificationRecordShouldHaveUpdated(string p0, string p1)
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"I delete existing certification record")]
        //public void WhenIDeleteExistingCertificationRecord()
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"the certification record should disappear from the certification module")]
        //public void ThenTheCertificationRecordShouldDisappearFromTheCertificationModule()
        //{
        //    throw new PendingStepException();
        //}
    }
}
