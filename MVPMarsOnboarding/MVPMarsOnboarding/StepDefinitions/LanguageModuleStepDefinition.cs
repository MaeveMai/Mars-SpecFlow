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
    public class LanguageModuleStepDefinition : CommonDriver
    {
        LanguageModule LanguageModuleObj;

        public LanguageModuleStepDefinition()
        {
            LanguageModuleObj = new LanguageModule(driver);
        }



        [Given(@"I login to Mars portal successfully")]
        public void GivenILoggedIntoMarsPortalSuccessfully()
        {
            //log in mars portal
            loginpageObj.LoginSteps();
        }


        [When(@"I navigate to language module")]
        public void WhenINavigateToLanguageModule()
        {
            LanguageModuleObj.GoToLanguageModule();
        }


        [When(@"I add new '([^']*)' records on lauguange module")]
        public void WhenIAddNewRecordsOnLauguangeModule(string p0)
        {
            LanguageModuleObj.AddNewLanguages(p0);
        }

        [Then(@"the '([^']*)' records should be added in language module successfully")]
        public void ThenTheRecordsShouldBeAddedInLanguageModuleSuccessfully(string p0)
        {
            //Check if the language was created successful
            string NewLanguage = LanguageModuleObj.GetNewLanguage();
            Assert.That(NewLanguage == p0, "added language do not match");
        }


        [When(@"I update '([^']*)'on existing language record")]
        public void WhenIUpdateOnExistingLanguageRecord(string p0)
        {
            LanguageModuleObj.EditExistingLanguage(p0);
        }

        [Then(@"the language record should have updated '([^']*)'")]
        public void ThenTheLanguageRecordShouldHaveUpdated(string p0)
        {
            //Check if the language was updated successful
            string NewLanguage = LanguageModuleObj.GetNewLanguage();
            Assert.That(NewLanguage == p0, "Updated language do not match");
        }

        [When(@"I delete existing language record")]
        public void WhenIDeleteExistingLanguageRecord()
        {
            LanguageModuleObj.DeleteExistingLanguage();
        }

        [Then(@"the language record should disappear from the language module")]
        public void ThenTheLanguageRecordShouldDisappearFromTheLanguageModule()
        {
            //Check if the language was deleted successful
            String NewLanguage = LanguageModuleObj.GetNewLanguage();
            Assert.That(NewLanguage != "Japanese", "language should be deleted still existing");
        }

    }
}
