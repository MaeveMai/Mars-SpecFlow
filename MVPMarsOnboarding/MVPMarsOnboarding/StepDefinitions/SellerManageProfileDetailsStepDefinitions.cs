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

            driver.Close();
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

            driver.Close();

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

            driver.Close();

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

            driver.Close();
        }


        [When(@"I navigate to education Module")]
        public void WhenINavigateToEducationModule()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.GoToEducationModule(driver);
        }

        [When(@"I add new education record with '([^']*)' and '([^']*)'")]
        public void WhenIAddNewEducationRecord(string p0, string p1)
        {
            EducationModule educationModuleObj = new EducationModule();
            educationModuleObj.AddNewEducation(driver, p0, p1);
        }

        [Then(@"the education record should be added successfully with correct '([^']*)' and '([^']*)'")]
        public void ThenNewEducationRecordShouldBeAddedSuccessfully(string p0, string p1)
        {
            EducationModule educationModuleObj = new EducationModule();
            string NewCountry = educationModuleObj.GetNewCountryName(driver);
            string NewUniName = educationModuleObj.GetNewUniversityName(driver);
            string NewTitle = educationModuleObj.GetNewTitle(driver);
            string NewDegree = educationModuleObj.GetNewDegree(driver);
            string NewGraduationYear = educationModuleObj.GetNewGraduationYear(driver);

            Assert.That(NewCountry == "New Zealand", "Actual Country do not match");
            Assert.That(NewUniName == p0, "Actual University name do not match");
            Assert.That(NewTitle == "PHD", "Actual title do not match");
            Assert.That(NewDegree == p1, "Actual degree do not match");
            Assert.That(NewGraduationYear == "2019", "Actual Graduation Year do not match");

            driver.Close();
        }



        [When(@"I update '([^']*)' and '([^']*)' on existing education record")]
        public void WhenIUpdateAndOnExistingEducationRecord(string p0, string p1)
        {
            EducationModule educationModuleObj = new EducationModule();
            educationModuleObj.EditExistingEducation(driver, p0, p1);
        }

        [Then(@"the education record should have updated '([^']*)' and '([^']*)'")]
        public void ThenTheEducationRecordShouldHaveUpdated(string p0, string p1)
        {
            EducationModule educationModuleObj = new EducationModule();
            string NewUniName = educationModuleObj.GetNewUniversityName(driver);
            string NewCountry = educationModuleObj.GetNewCountryName(driver);
            string NewTitle = educationModuleObj.GetNewTitle(driver);
            string NewDegree = educationModuleObj.GetNewDegree(driver);
            string NewGraduationYear = educationModuleObj.GetNewGraduationYear(driver);
            
            Assert.That(NewUniName == p0, "Actual name do not match");
            Assert.That(NewCountry == "New Zealand", "Actual Country do not match");
            Assert.That(NewTitle == "PHD", "Actual title do not match");
            Assert.That(NewDegree == p1, "Actual degree do not match");
            Assert.That(NewGraduationYear == "2019", "Actual Graduation Year do not match");

            driver.Close();
        }

        [When(@"I delete existing education record")]
        public void WhenIDeleteExistingEducationRecord()
        {
            EducationModule educationModuleObj = new EducationModule();
            educationModuleObj.DeleteExistingEducation(driver);
        }

        [Then(@"the education record should disappear from the education module")]
        public void ThenTheEducationRecordShouldDisappearFromTheEducationModule()
        {
            EducationModule educationModuleObj = new EducationModule();
            string NewUniName = educationModuleObj.GetNewUniversityName(driver);
            string NewDegree = educationModuleObj.GetNewDegree(driver);

            Assert.That(NewUniName != "The University of Auckland", NewUniName);
            Assert.That(NewDegree != "Master", "Deleted degree record still existing");

            driver.Close();
        }

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
        //[When(@"I navigate to skills Module")]
        //public void WhenINavigateToSkillsModule()
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"I add new '([^']*)' record in skill module")]
        //public void WhenIAddNewRecordInSkillModule(string programming)
        //{
        //    throw new PendingStepException();
        //}


        //[Then(@"the '([^']*)' record should be added successfully in skill module")]
        //public void ThenTheRecordShouldBeAddedSuccessfullyInSkillModule(string programming)
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
    }
}
