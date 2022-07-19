using MVPMarsOnboarding.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPMarsOnboarding.Pages
{
    public class CertificationModule
    {
        public IWebDriver driver;

        public CertificationModule(IWebDriver driver)
        {
            this.driver = driver;
        }

        //find element by xpath
        private IWebElement CertificationModuleTab => driver.FindElement(By.XPath(CertificationModuleTabXpath));
        private IWebElement NewCertificateName => driver.FindElement(By.XPath(NewCertificateNameXpath));
        private IWebElement NewCertifiedFrom => driver.FindElement(By.XPath(NewCertifiedFromXpath));
        private IWebElement NewCertifiedYear => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]"));
        private IWebElement AddNewCertificateButton => driver.FindElement(By.XPath(AddNewCertificateButtonXpath));
        private IWebElement CertificateNameTextBox => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
        private IWebElement CertifiedFromTextBox => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
        private IWebElement YearDropDownBox => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
        private IWebElement Option2020 => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[4]"));
        private IWebElement AddButton => driver.FindElement(By.XPath(AddButtonXpath));
        private IWebElement EditButton => driver.FindElement(By.XPath(EditButtonXpath));
        private IWebElement EditCertificateNameTextBox => driver.FindElement(By.XPath(EditCertificateNameTextBoxXpath));
        private IWebElement EditCertifiedFromTextBox => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[2]/input"));
        private IWebElement UpdateButton => driver.FindElement(By.XPath(UpdateButtonXpath));
        private IWebElement DeleteButton => driver.FindElement(By.XPath(DeleteButtonXpath));


        //xpath
        private string CertificationModuleTabXpath = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]";
        private string NewCertificateNameXpath = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]";
        private string NewCertifiedFromXpath = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]";
        private string AddNewCertificateButtonXpath = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div";
        private string AddButtonXpath = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]";
        private string EditButtonXpath = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i";
        private string EditCertificateNameTextBoxXpath = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input";
        private string UpdateButtonXpath = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]";
        private string DeleteButtonXpath = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]/i";



        public void GoToCertificationModule()
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", CertificationModuleTabXpath, 10);
            CertificationModuleTab.Click();
        }

        public string GetNewCertificateName()
        {
            driver.Navigate().Refresh();
            WaitHelpers.WaitToBeClickable(driver, "XPath", CertificationModuleTabXpath, 10);
            CertificationModuleTab.Click();

            try
            {
                //Get New Certificate Name
                WaitHelpers.WaitToBeVisible(driver, "XPath", NewCertificateNameXpath, 10);
                return NewCertificateName.Text;
            }

            catch (Exception)
            {
                return "No record existing";
            }

        }

        public string GetNewCertifiedFrom()
        {
            try
            {            
                WaitHelpers.WaitToBeVisible(driver, "XPath", NewCertifiedFromXpath, 10); 
                return NewCertifiedFrom.Text;
            }
            catch (Exception)
            {
                return "No record existing";
            }
        }

        public string GetNewCertifiedYear()
        {
            try
            {                
                return NewCertifiedYear.Text;
            }
            catch (Exception)
            {
                return "No record existing";
            }
        }

        public void AddNewCertificate(string CertificateName, string CertifiedFrom)
        {
            //Click on add new button
            WaitHelpers.WaitToBeClickable(driver, "XPath", AddNewCertificateButtonXpath, 10);
            
            AddNewCertificateButton.Click();

            //input certificate name
            CertificateNameTextBox.SendKeys(CertificateName);

            //input Certified From
            CertifiedFromTextBox.SendKeys(CertifiedFrom);

            //click on certification year dropdown box            
            YearDropDownBox.Click();

            //Select 2020 option from certification year dropdown box           
            Option2020.Click();

            //click on add button
            WaitHelpers.WaitToBeClickable(driver, "XPath", AddButtonXpath, 10);
            AddButton.Click();
        }

        public void EditExistingCertificate(string CertificateName, string CertifiedFrom)
        {
            //Click on the Edit button of the latest record in the Certificate module
            WaitHelpers.WaitToBeClickable(driver, "XPath", EditButtonXpath, 10);
            EditButton.Click();

            //input edited certificate name
            WaitHelpers.WaitToBeVisible(driver, "XPath", EditCertificateNameTextBoxXpath, 10);
            EditCertificateNameTextBox.Clear();
            EditCertificateNameTextBox.SendKeys(CertificateName);

            //input edited Certified From
            EditCertifiedFromTextBox.Clear();
            EditCertifiedFromTextBox.SendKeys(CertifiedFrom);

            // click on update button
            WaitHelpers.WaitToBeClickable(driver, "XPath", UpdateButtonXpath, 10); 
            UpdateButton.Click();

        }

        public void DeleteExistingCertificate()
        {

            WaitHelpers.WaitToBeClickable(driver, "XPath", DeleteButtonXpath, 10);     
            DeleteButton.Click();

        }
    }
}
