using MVPMarsOnboarding.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPMarsOnboarding.Pages
{
    public class ProfilePage:CommonDriver

    {
        public string GetHiUser(IWebDriver driver)
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/div[1]/div[2]/div/span",5);
            IWebElement HiUser = driver.FindElement(By.XPath("//div/div[1]/div[2]/div/span"));
            return HiUser.Text;
        }

        public void GoToEducationModule(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);
            IWebElement EducationModule = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            EducationModule.Click();
        }
    }
}
