using MVPMarsOnboarding.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPMarsOnboarding.Pages
{
    public class LanguageModule
    {
        public IWebDriver driver;
        public LanguageModule(IWebDriver driver)
        {
            this.driver = driver;
        }

        //find elements by XPath
        private IWebElement LanguageModuleTab => driver.FindElement(By.XPath(LanguageModuleTabXpath));
        private IWebElement NewLanguageRecord => driver.FindElement(By.XPath(NewLanguageRecordXpath));
        private IWebElement AddNewLanguageButton => driver.FindElement(By.XPath(AddNewLanguageButtonXpath));
        private IWebElement LanguageTextBox => driver.FindElement(By.XPath(LanguageTextBoxXpath));
        private IWebElement LanguageLevelDropDownBox => driver.FindElement(By.XPath(LanguageLevelDropDownBoxXpath));
        private IWebElement FluentLevel => driver.FindElement(By.XPath(FluentLevelXpath));
        private IWebElement AddButton => driver.FindElement(By.XPath(AddButtonXpath));
        private IWebElement EditExistingLanguageButton => driver.FindElement(By.XPath(EditExistingLanguageButtonXpath));
        private IWebElement EditLanguageTextBox => driver.FindElement(By.XPath(EditLanguageTextBoxXpath));
        private IWebElement UpdateButton => driver.FindElement(By.XPath(UpdateButtonXpath));
        private IWebElement DeleteButton => driver.FindElement(By.XPath(DeleteButtonXpath));

        //Xpath
        private string NewLanguageRecordXpath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]";
        private string LanguageModuleTabXpath = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]";
        private string AddNewLanguageButtonXpath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div";
        private string LanguageTextBoxXpath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input";
        private string LanguageLevelDropDownBoxXpath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select";
        private string FluentLevelXpath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]";
        private string AddButtonXpath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]";
        private string EditExistingLanguageButtonXpath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i";
        private string EditLanguageTextBoxXpath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input";
        private string UpdateButtonXpath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]";
        private string DeleteButtonXpath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i";

        public void GoToLanguageModule()
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", LanguageModuleTabXpath, 10);
            LanguageModuleTab.Click();
        }
        public string GetNewLanguage()
        {
            driver.Navigate().Refresh();
            LanguageModuleTab.Click();
            try
            {
                //Get New Language
                WaitHelpers.WaitToBeVisible(driver, "XPath", NewLanguageRecordXpath, 10);
                return NewLanguageRecord.Text;
            }
            catch(Exception)
            {
               return "No record existing";
            }
        }

        public void AddNewLanguages(string Language)
        {
            //click on add button
            WaitHelpers.WaitToBeClickable(driver, "XPath", AddNewLanguageButtonXpath, 10);            
            AddNewLanguageButton.Click();

            //input new language to Language TextBox
            WaitHelpers.WaitToBeVisible(driver, "XPath", LanguageTextBoxXpath, 10);    
            LanguageTextBox.SendKeys(Language);

            //click on Language Level DropDown Box
            WaitHelpers.WaitToBeClickable(driver, "XPath", LanguageLevelDropDownBoxXpath, 10);          
            LanguageLevelDropDownBox.Click();


            //choose level
            WaitHelpers.WaitToBeClickable(driver, "XPath", FluentLevelXpath, 10);          
            FluentLevel.Click();

            //click on add button
            WaitHelpers.WaitToBeClickable(driver, "XPath", AddButtonXpath, 10);            
            AddButton.Click();

        }

        public void EditExistingLanguage(string Language)
        {
            //click on edit button
            WaitHelpers.WaitToBeClickable(driver, "XPath", EditExistingLanguageButtonXpath, 10);    
            EditExistingLanguageButton.Click();

            //clear Language TextBox and input new language
            WaitHelpers.WaitToBeVisible(driver, "XPath", EditLanguageTextBoxXpath, 10);
            EditLanguageTextBox.Clear();
            EditLanguageTextBox.SendKeys(Language);

            //click on update button
            WaitHelpers.WaitToBeClickable(driver, "XPath", UpdateButtonXpath, 10);           
            UpdateButton.Click();
        }

        public void DeleteExistingLanguage()
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", DeleteButtonXpath, 10);
            DeleteButton.Click();

        }
    }

}

