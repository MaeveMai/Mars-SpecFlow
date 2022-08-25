using MVPMarsOnboarding.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPMarsOnboarding.Pages
{
    public class ProfilePage

    {
        public IWebDriver driver;

        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;       
        }

        private IWebElement HiUser => driver.FindElement(By.XPath(HiUserXpath));
        private string HiUserXpath = "//div/div[1]/div[2]/div/span";

        public string GetHiUser()
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", HiUserXpath, 10);
            return HiUser.Text;
        }


    }
}
