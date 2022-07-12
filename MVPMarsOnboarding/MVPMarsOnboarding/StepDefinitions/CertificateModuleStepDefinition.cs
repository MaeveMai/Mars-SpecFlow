using MVPMarsOnboarding.Drivers;
using MVPMarsOnboarding.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MVPMarsOnboarding.StepDefinitions
{
    [Binding]
    public class CertificateModuleStepDefinition : CommonDriver
    {

        ProfilePage profilePageObj;
        LoginPage loginPageObj;
        CertificationModule certificationModuleObj;

        public CertificateModuleStepDefinition()
        {
            driver = new ChromeDriver();
            loginPageObj = new LoginPage(driver);
            profilePageObj = new ProfilePage(driver);
            certificationModuleObj = new CertificationModule(driver);
        }


        [AfterScenario]
        public void AfterScenario()
        {
            if (driver != null)
            {
                driver.Close();
            }
        }

        [Given(@"I login to the Mars portal successfully")]
        public void GivenILoggedIntoMarsPortalSuccessfully()
        {

            //log in mars portal
            loginPageObj.LoginSteps();
        }

        [When(@"I navigate to certification Module")]
        public void WhenINavigateToCertificationModule()
        {
            profilePageObj.GoToCertificationModule();
        }

        [When(@"I add new certification record with '([^']*)' and '([^']*)'")]
        public void WhenIAddNewCertificationRecordWithAnd(string p0, string p1)
        {
            certificationModuleObj.AddNewCertificate(p0, p1);
        }

        [Then(@"the certification record should be added successfully with correct '([^']*)' and '([^']*)'")]
        public void ThenTheCertificationRecordShouldBeAddedSuccessfullyWithCorrectAnd(string p0, string p1)
        {
            //Check if the certification was created successful
            string NewCertificateName = certificationModuleObj.GetNewCertificateName();
            string NewCertifiedFrom = certificationModuleObj.GetNewCertifiedFrom();
            string NewCertifiedYear = certificationModuleObj.GetNewCertifiedYear();

            Assert.That(NewCertificateName == p0, "New Certificate Name do not match");
            Assert.That(NewCertifiedFrom == p1, "New Certified from do not match");
            Assert.That(NewCertifiedYear == "2020", "New Certified Year do not match");
        }

        [When(@"I update '([^']*)' and '([^']*)' on existing certification record")]
        public void WhenIUpdateAndOnExistingCertificationRecord(string p0, string p1)
        {
            certificationModuleObj.EditExistingCertificate(p0, p1);
        }

        [Then(@"the certification record should have updated '([^']*)' and '([^']*)'")]
        public void ThenTheCertificationRecordShouldHaveUpdated(string p0, string p1)
        {
            //Check if the certification was updated successful
            string NewCertificateName = certificationModuleObj.GetNewCertificateName();
            string NewCertifiedFrom = certificationModuleObj.GetNewCertifiedFrom();
            string NewCertifiedYear = certificationModuleObj.GetNewCertifiedYear();

            Assert.That(NewCertificateName == p0, "updated Certificate Name do not match");
            Assert.That(NewCertifiedFrom == p1, "updated Certified from do not match");
            Assert.That(NewCertifiedYear == "2020", "updated Certified Year do not match");
        }

        [When(@"I delete existing certification record")]
        public void WhenIDeleteExistingCertificationRecord()
        {
            certificationModuleObj.DeleteExistingCertificate();
        }

        [Then(@"the certification record should disappear from the certification module")]
        public void ThenTheCertificationRecordShouldDisappearFromTheCertificationModule()
        {
            //check if the certification record deleted successful
            string NewCertificateName = certificationModuleObj.GetNewCertificateName();
            string NewCertifiedFrom = certificationModuleObj.GetNewCertifiedFrom();

            Assert.That(NewCertificateName != "Best Tutors", "Certificate Name should be deleted still existing");
            Assert.That(NewCertifiedFrom != "University of Canterbury", "Certified From should be deleted still existing");
        }
        
    }
}