using MVPMarsOnboarding.Drivers;
using MVPMarsOnboarding.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MVPMarsOnboarding.StepDefinitions
{
    [Binding]
    public class EducationModuleStepDefinition:CommonDriver
    {
        LoginPage loginPageObj;
        EducationModule educationModuleObj;

        public EducationModuleStepDefinition()
        {
            driver = new ChromeDriver();
            loginPageObj = new LoginPage(driver);
            educationModuleObj = new EducationModule(driver);
        }


        [Given(@"I logged into the Mars portal successfully")]
        public void GivenILoggedIntoMarsPortalSuccessfully()
        {
            //log in mars portal
            loginPageObj.LoginSteps();
        }

        [When(@"I navigate to education Module")]
        public void WhenINavigateToEducationModule()
        {
            educationModuleObj.GoToEducationModule();
        }

        [When(@"I add new education record with '([^']*)' and '([^']*)'")]
        public void WhenIAddNewEducationRecord(string p0, string p1)
        {
            educationModuleObj.AddNewEducation(p0, p1);
        }

        [Then(@"the education record should be added successfully with correct '([^']*)' and '([^']*)'")]
        public void ThenNewEducationRecordShouldBeAddedSuccessfully(string p0, string p1)
        {
            //Check if the education was created successful
            string NewCountry = educationModuleObj.GetNewCountryName();
            string NewUniName = educationModuleObj.GetNewUniversityName();
            string NewTitle = educationModuleObj.GetNewTitle();
            string NewDegree = educationModuleObj.GetNewDegree();
            string NewGraduationYear = educationModuleObj.GetNewGraduationYear();

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
            educationModuleObj.EditExistingEducation(p0, p1);
        }

        [Then(@"the education record should have updated '([^']*)' and '([^']*)'")]
        public void ThenTheEducationRecordShouldHaveUpdated(string p0, string p1)
        {
            //Check if the education was updated successful
            string NewUniName = educationModuleObj.GetNewUniversityName();
            string NewCountry = educationModuleObj.GetNewCountryName();
            string NewTitle = educationModuleObj.GetNewTitle();
            string NewDegree = educationModuleObj.GetNewDegree();
            string NewGraduationYear = educationModuleObj.GetNewGraduationYear();

            Assert.That(NewUniName == p0, "updated name do not match");
            Assert.That(NewCountry == "New Zealand", "updated Country do not match");
            Assert.That(NewTitle == "PHD", "updated title do not match");
            Assert.That(NewDegree == p1, "updated degree do not match");
            Assert.That(NewGraduationYear == "2019", "updated Graduation Year do not match");
            driver.Close();
        }

        [When(@"I delete existing education record")]
        public void WhenIDeleteExistingEducationRecord()
        {
            educationModuleObj.DeleteExistingEducation();
        }

        [Then(@"the education record should disappear from the education module")]
        public void ThenTheEducationRecordShouldDisappearFromTheEducationModule()
        {
            //Check if the education was deleted successful
            string NewUniName = educationModuleObj.GetNewUniversityName();
            string NewDegree = educationModuleObj.GetNewDegree();

            Assert.That(NewUniName != "The University of Auckland", "Universiyu name should be deleted still existing");
            Assert.That(NewDegree != "Master", "degree should be deleted still existing");
            driver.Close();
        }    
    }
}