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
        CertificationModule CertificationModuleObj;
        ProfilePage profilePageObj;

        public CertificationModule(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetNewCertificateName()
        {
            try
            {
                //refresh the page
                driver.Navigate().Refresh();
                profilePageObj = new ProfilePage(driver);
                profilePageObj.GoToCertificationModule();

                //Get New Certificate Name
                WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]", 10);
                IWebElement NewCertificateName = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
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
                WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]", 10);
                IWebElement NewCertifiedFrom = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
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
                IWebElement NewCertifiedYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
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
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div", 10);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")).Click();

            //input certificate name
            IWebElement CertificateNameTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            CertificateNameTextBox.SendKeys(CertificateName);

            //input Certified From
            IWebElement CertifiedFromTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            CertifiedFromTextBox.SendKeys(CertifiedFrom);

            //click on certification year dropdown box
            IWebElement YearDropDownBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            YearDropDownBox.Click();

            //Select 2020 option from certification year dropdown box
            IWebElement Option2020 = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[4]"));
            Option2020.Click();

            //click on add button
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]", 10);
            IWebElement AddButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            AddButton.Click();
        }

        public void EditExistingCertificate(string CertificateName, string CertifiedFrom)
        {
            //Click on the Edit button of the latest record in the Certificate module
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i", 10);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i")).Click();

            //input edited certificate name
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input", 10);
            IWebElement CertificateNameTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input"));
            CertificateNameTextBox.Clear();
            CertificateNameTextBox.SendKeys(CertificateName);

            //input edited Certified From
            IWebElement CertifiedFromTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[2]/input"));
            CertifiedFromTextBox.Clear();
            CertifiedFromTextBox.SendKeys(CertifiedFrom);

            // click on update button
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]", 10);
            IWebElement UpdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            UpdateButton.Click();

        }

        public void DeleteExistingCertificate()
        {

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]/i", 10);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]/i")).Click();

        }
    }
}
