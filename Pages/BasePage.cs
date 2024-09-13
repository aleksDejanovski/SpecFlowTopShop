using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAutomation.Pages
{
    public  class BasePage
    {
        public readonly IWebDriver Driver;
       

        public BasePage (IWebDriver driver)
        {
            Driver = driver;
        }

        public static void WaitElementToAppear(IWebDriver Driver, By byLocator)
        {
            WebDriverWait Wait = new WebDriverWait(Driver, timeout: TimeSpan.FromSeconds(12));
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(byLocator));
        }

        public static void WaitUrlToContain(IWebDriver Driver, string pageUrl)
        {
            WebDriverWait Wait = new WebDriverWait(Driver, timeout: TimeSpan.FromSeconds(12));
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains(pageUrl));

        }

        public static void WaitElementToBeClickable(IWebDriver Driver, By byLocator)
        {
            WebDriverWait Wait = new WebDriverWait(Driver, timeout: TimeSpan.FromSeconds(12));
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(byLocator));
        }


    }
}
