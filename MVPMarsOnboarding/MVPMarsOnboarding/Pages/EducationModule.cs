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
        public string GetNewUniversityName(IWebDriver driver)
        {
            try
            {
                //refresh the page
                driver.Navigate().Refresh();
                ProfilePage profilePageObj = new ProfilePage();
                profilePageObj.GoToEducationModule(driver);

                //Get New University Name
                WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 10);
                IWebElement NewUniversityName = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
                return NewUniversityName.Text;
            }
            catch (Exception)
            {
                return "No record existing";
            }
        }

        public string GetNewCountryName(IWebDriver driver)
        {
            try
            {
                WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10);
                IWebElement NewCountryName = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
                return NewCountryName.Text;
            }
            catch (Exception)
            {
                return "No record existing";
            }
        }

        public string GetNewTitle(IWebDriver driver)
        {
            try
            {
                IWebElement NewTitle = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]"));
                return NewTitle.Text;
            }
            catch (Exception)
            {
                return "No record existing";
            }
        }
        public string GetNewDegree(IWebDriver driver)
        {
            try
            {
                IWebElement NewDegree = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]"));
                return NewDegree.Text;
            }
            catch (Exception)
            {
                return "No record existing";
            }
        }
        public string GetNewGraduationYear(IWebDriver driver)
        {
            try
            {
                IWebElement NewGraduationYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[5]"));
                return NewGraduationYear.Text;
            }
            catch (Exception)
            {
                return "No record existing";
            }
        }

        public void AddNewEducation(IWebDriver driver,string UniversityName, string Degree)
        {
            //click on add button
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div", 10);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")).Click();
            
            //input university name
            IWebElement UniNameTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            UniNameTextBox.SendKeys(UniversityName);

            //input degree
            IWebElement DegreeTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            DegreeTextBox.SendKeys(Degree);

            //click on country dropdown box
            IWebElement CountryDropDownBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            CountryDropDownBox.Click();

            //choose country
            IWebElement OptionNewZealand = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]"));
            OptionNewZealand.Click();

            //click on Title Dropdown Box
            IWebElement TitleDropdownBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            TitleDropdownBox.Click();

            //choose title
            IWebElement OptionPHD = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[12]"));
            OptionPHD.Click();

            //click on Year Of Graduation DropDown Box
            IWebElement YearOfGraduationDropDownBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            YearOfGraduationDropDownBox.Click();

            //choose year
            IWebElement Option2019 = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[5]"));
            Option2019.Click();

            //click on add button
            IWebElement AddButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            AddButton.Click();
        }

        public void EditExistingEducation(IWebDriver driver, string UniName, string Degree)
        {
            //click on edit button
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]/i", 10);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]/i")).Click();
            
            //clear University Name TextBox and input new University Name
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input", 10);
            IWebElement UniNameTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
            UniNameTextBox.Clear();
            UniNameTextBox.SendKeys(UniName);

            //clear Degree TextBox and input Degree
            IWebElement DegreeTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
            DegreeTextBox.Clear();
            DegreeTextBox.SendKeys(Degree);

            //click on update button
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]", 10);
            IWebElement UpdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
            UpdateButton.Click();

        }

        public void DeleteExistingEducation(IWebDriver driver)
        {

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]/i", 10);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]/i")).Click();

        }


    }
}
