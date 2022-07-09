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
    public class ProfileDetailsStepDefinitions : CommonDriver
    {
        ProfilePage profilePageObj = new ProfilePage();
        LoginPage loginPageObj = new LoginPage();
        LanguageModule LanguageModuleObj = new LanguageModule();
        EducationModule educationModuleObj = new EducationModule();
        CertificationModule certificationModuleObj = new CertificationModule();

        [After]
        public void Dispose()
        {
            driver.Close();
        }

        [Given(@"I login mars portal")]
        public void GivenILoginMarsPortal()
        {
            //open chrom browser
            driver = new ChromeDriver();

            // log in steps    
            loginPageObj.LoginSteps(driver);
        }

        [Then(@"The profile page should be presented")]
        public void ThenTheProfilePageShouldBePresented()
        {
            //Check if the login was successful
            string HiUser = profilePageObj.GetHiUser(driver);
            Assert.That(HiUser == "Hi Maeve" | HiUser == "Hi", "Hi User not match");
        }

        [Given(@"I logged into Mars portal successfully")]
        public void GivenILoggedIntoMarsPortalSuccessfully()
        {
            //open chrom browser
            driver = new ChromeDriver();

            //log in mars portal
            loginPageObj.LoginSteps(driver);
        }


        [When(@"I navigate to language module")]
        public void WhenINavigateToLanguageModule()
        {
            profilePageObj.GoToLanguageModule(driver);
        }


        [When(@"I add new '([^']*)' records on lauguange module")]
        public void WhenIAddNewRecordsOnLauguangeModule(string p0)
        {
            LanguageModuleObj.AddNewLanguages(driver, p0);
        }

        [Then(@"the '([^']*)' records should be added in language module successfully")]
        public void ThenTheRecordsShouldBeAddedInLanguageModuleSuccessfully(string p0)
        {
            //Check if the language was created successful
            string NewLanguage = LanguageModuleObj.GetNewLanguage(driver);
            Assert.That(NewLanguage == p0, "added language do not match");
        }


        [When(@"I update '([^']*)'on existing language record")]
        public void WhenIUpdateOnExistingLanguageRecord(string p0)
        {
            LanguageModuleObj.EditExistingLanguage(driver, p0);
        }

        [Then(@"the language record should have updated '([^']*)'")]
        public void ThenTheLanguageRecordShouldHaveUpdated(string p0)
        {
            //Check if the language was updated successful
            string NewLanguage = LanguageModuleObj.GetNewLanguage(driver);
            Assert.That(NewLanguage == p0, "Updated language do not match");
        }

        [When(@"I delete existing language record")]
        public void WhenIDeleteExistingLanguageRecord()
        {
            LanguageModuleObj.DeleteExistingLanguage(driver);
        }

        [Then(@"the language record should disappear from the language module")]
        public void ThenTheLanguageRecordShouldDisappearFromTheLanguageModule()
        {
            //Check if the language was deleted successful
            String NewLanguage = LanguageModuleObj.GetNewLanguage(driver);
            Assert.That(NewLanguage != "Japanese", "language should be deleted still existing");
        }

        [When(@"I navigate to education Module")]
        public void WhenINavigateToEducationModule()
        {
            profilePageObj.GoToEducationModule(driver);
        }

        [When(@"I add new education record with '([^']*)' and '([^']*)'")]
        public void WhenIAddNewEducationRecord(string p0, string p1)
        {
            educationModuleObj.AddNewEducation(driver, p0, p1);
        }

        [Then(@"the education record should be added successfully with correct '([^']*)' and '([^']*)'")]
        public void ThenNewEducationRecordShouldBeAddedSuccessfully(string p0, string p1)
        {
            //Check if the education was created successful
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
        }

        [When(@"I update '([^']*)' and '([^']*)' on existing education record")]
        public void WhenIUpdateAndOnExistingEducationRecord(string p0, string p1)
        {
            educationModuleObj.EditExistingEducation(driver, p0, p1);
        }

        [Then(@"the education record should have updated '([^']*)' and '([^']*)'")]
        public void ThenTheEducationRecordShouldHaveUpdated(string p0, string p1)
        {
            //Check if the education was updated successful
            string NewUniName = educationModuleObj.GetNewUniversityName(driver);
            string NewCountry = educationModuleObj.GetNewCountryName(driver);
            string NewTitle = educationModuleObj.GetNewTitle(driver);
            string NewDegree = educationModuleObj.GetNewDegree(driver);
            string NewGraduationYear = educationModuleObj.GetNewGraduationYear(driver);
            
            Assert.That(NewUniName == p0, "updated name do not match");
            Assert.That(NewCountry == "New Zealand", "updated Country do not match");
            Assert.That(NewTitle == "PHD", "updated title do not match");
            Assert.That(NewDegree == p1, "updated degree do not match");
            Assert.That(NewGraduationYear == "2019", "updated Graduation Year do not match");
        }

        [When(@"I delete existing education record")]
        public void WhenIDeleteExistingEducationRecord()
        {
            educationModuleObj.DeleteExistingEducation(driver);
        }

        [Then(@"the education record should disappear from the education module")]
        public void ThenTheEducationRecordShouldDisappearFromTheEducationModule()
        {
            //Check if the education was deleted successful
            string NewUniName = educationModuleObj.GetNewUniversityName(driver);
            string NewDegree = educationModuleObj.GetNewDegree(driver);

            Assert.That(NewUniName != "The University of Auckland", "Universiyu name should be deleted still existing");
            Assert.That(NewDegree != "Master", "degree should be deleted still existing");
        }

        [When(@"I navigate to certification Module")]
        public void WhenINavigateToCertificationModule()
        {
            profilePageObj.GoToCertificationModule(driver);
        }

        [When(@"I add new certification record with '([^']*)' and '([^']*)'")]
        public void WhenIAddNewCertificationRecordWithAnd(string p0, string p1)
        {
            certificationModuleObj.AddNewCertificate(driver, p0, p1);
        }

        [Then(@"the certification record should be added successfully with correct '([^']*)' and '([^']*)'")]
        public void ThenTheCertificationRecordShouldBeAddedSuccessfullyWithCorrectAnd(string p0, string p1)
        {
            //Check if the certification was created successful
            string NewCertificateName = certificationModuleObj.GetNewCertificateName(driver);
            string NewCertifiedFrom = certificationModuleObj.GetNewCertifiedFrom(driver);
            string NewCertifiedYear = certificationModuleObj.GetNewCertifiedYear(driver);

            Assert.That(NewCertificateName == p0, "New Certificate Name do not match");
            Assert.That(NewCertifiedFrom == p1, "New Certified from do not match");
            Assert.That(NewCertifiedYear == "2020", "New Certified Year do not match");
        }

        [When(@"I update '([^']*)' and '([^']*)' on existing certification record")]
        public void WhenIUpdateAndOnExistingCertificationRecord(string p0, string p1)
        {
            certificationModuleObj.EditExistingCertificate(driver, p0, p1);
        }

        [Then(@"the certification record should have updated '([^']*)' and '([^']*)'")]
        public void ThenTheCertificationRecordShouldHaveUpdated(string p0, string p1)
        {
            //Check if the certification was updated successful
            string NewCertificateName = certificationModuleObj.GetNewCertificateName(driver);
            string NewCertifiedFrom = certificationModuleObj.GetNewCertifiedFrom(driver);
            string NewCertifiedYear = certificationModuleObj.GetNewCertifiedYear(driver);

            Assert.That(NewCertificateName == p0, "updated Certificate Name do not match");
            Assert.That(NewCertifiedFrom == p1, "updated Certified from do not match");
            Assert.That(NewCertifiedYear == "2020", "updated Certified Year do not match");
        }

        [When(@"I delete existing certification record")]
        public void WhenIDeleteExistingCertificationRecord()
        {
            certificationModuleObj.DeleteExistingCertificate(driver);
        }

        [Then(@"the certification record should disappear from the certification module")]
        public void ThenTheCertificationRecordShouldDisappearFromTheCertificationModule()
        {
            //check if the certification record deleted successful
            string NewCertificateName = certificationModuleObj.GetNewCertificateName(driver);
            string NewCertifiedFrom = certificationModuleObj.GetNewCertifiedFrom(driver);

            Assert.That(NewCertificateName != "Best Tutors", "Certificate Name should be deleted still existing");
            Assert.That(NewCertifiedFrom != "University of Canterbury", "Certified From should be deleted still existing");
        }
    }
}
