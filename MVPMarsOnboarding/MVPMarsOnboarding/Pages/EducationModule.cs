using MVPMarsOnboarding.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPMarsOnboarding.Pages
{
    public class EducationModule
    {
        public IWebDriver driver;

        public EducationModule(IWebDriver driver)
        {
            this.driver = driver;
        }

        //find element by Xpath
        private IWebElement EducationModuleTab => driver.FindElement(By.XPath(EducationModuleTabXpath));
        private IWebElement NewTitle => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]"));
        private IWebElement NewUniversityName => driver.FindElement(By.XPath(NewUniversityNameXpath));
        private IWebElement NewCountryName => driver.FindElement(By.XPath(NewCountryNameXpath));
        private IWebElement NewDegree => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]"));
        private IWebElement NewGraduationYear => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[5]"));
        private IWebElement AddNewEducationButton => driver.FindElement(By.XPath(AddNewEducationButtonXpath));
        private IWebElement UniNameTextBox => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
        private IWebElement DegreeTextBox => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
        private IWebElement CountryDropDownBox => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
        private IWebElement OptionNewZealand => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]"));
        private IWebElement TitleDropdownBox => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
        private IWebElement OptionPHD => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[12]"));
        private IWebElement YearOfGraduationDropDownBox => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
        private IWebElement Option2019 => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[5]"));
        private IWebElement AddButton => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
        private IWebElement EditEducationButton => driver.FindElement(By.XPath(EditEducationButtonXpath));
        private IWebElement EditUniNameTextBox => driver.FindElement(By.XPath(EditUniNameTextBoxXpath));
        private IWebElement EditDegreeTextBox => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
        private IWebElement UpdateButton => driver.FindElement(By.XPath(UpdateButtonXpath));
        private IWebElement DeleteButton => driver.FindElement(By.XPath(DeleteButtonXpath));



        //Xpath
        private string EducationModuleTabXpath = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]";
        private string NewUniversityNameXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]";
        private string NewCountryNameXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]";
        private string AddNewEducationButtonXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div";
        private string EditEducationButtonXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]/i";
        private string EditUniNameTextBoxXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input";
        private string UpdateButtonXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]";
        private string DeleteButtonXpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]/i";




        public void GoToEducationModule()
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", EducationModuleTabXpath, 10);
            EducationModuleTab.Click();
        }
            public string GetNewUniversityName()
        {
            driver.Navigate().Refresh();
            WaitHelpers.WaitToBeClickable(driver, "XPath", EducationModuleTabXpath, 10);
            EducationModuleTab.Click();

            try
            {
                //Get New University Name
                WaitHelpers.WaitToBeVisible(driver, "XPath", NewUniversityNameXpath, 10);               
                return NewUniversityName.Text;
            }
            catch (Exception)
            {
                return "No record existing";
            }
        }

        public string GetNewCountryName()
        {
            try
            {
                WaitHelpers.WaitToBeVisible(driver, "XPath", NewCountryNameXpath, 10);
                return NewCountryName.Text;
            }
            catch (Exception)
            {
                return "No record existing";
            }
        }

        public string GetNewTitle()
        {
            try
            {
                return NewTitle.Text;
            }
            catch (Exception)
            {
                return "No record existing";
            }
        }
        public string GetNewDegree()
        {
            try
            {
                return NewDegree.Text;
            }
            catch (Exception)
            {
                return "No record existing";
            }
        }
        public string GetNewGraduationYear()
        {
            try
            {
                return NewGraduationYear.Text;
            }
            catch (Exception)
            {
                return "No record existing";
            }
        }

        public void AddNewEducation(string UniversityName, string Degree)
        {
            //click on add button
            WaitHelpers.WaitToBeClickable(driver, "XPath", AddNewEducationButtonXpath, 10);
            AddNewEducationButton.Click();
            
            //input university name
            UniNameTextBox.SendKeys(UniversityName);

            //input degree
            DegreeTextBox.SendKeys(Degree);

            //click on country dropdown box           
            CountryDropDownBox.Click();

            //choose country
            OptionNewZealand.Click();

            //click on Title Dropdown Box       
            TitleDropdownBox.Click();

            //choose title            
            OptionPHD.Click();

            //click on Year Of Graduation DropDown Box
            YearOfGraduationDropDownBox.Click();

            //choose year          
            Option2019.Click();

            //click on add button            
            AddButton.Click();
        }

        public void EditExistingEducation(string UniName, string Degree)
        {
            //click on edit button
            WaitHelpers.WaitToBeClickable(driver, "XPath", EditEducationButtonXpath, 10); 
            EditEducationButton.Click();

            //clear University Name TextBox and input new University Name
            WaitHelpers.WaitToBeVisible(driver, "XPath", EditUniNameTextBoxXpath, 10);
            EditUniNameTextBox.Clear();
            EditUniNameTextBox.SendKeys(UniName);

            //clear Degree TextBox and input Degree          
            EditDegreeTextBox.Clear();
            EditDegreeTextBox.SendKeys(Degree);

            //click on update button
            WaitHelpers.WaitToBeClickable(driver, "XPath", UpdateButtonXpath, 10);   
            UpdateButton.Click();

        }

        public void DeleteExistingEducation()
        {

            WaitHelpers.WaitToBeClickable(driver, "XPath", DeleteButtonXpath, 10);
            DeleteButton.Click();

        }


    }
}
