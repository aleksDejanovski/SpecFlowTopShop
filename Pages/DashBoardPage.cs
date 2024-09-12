using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAutomation.Pages
{
    public class DashBoardPage : BasePage
    {

        private readonly By btnLogin = By.ClassName("header-sign-in");
        
      

        public DashBoardPage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateToUrl (string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void ClickLoginButton()
        {
            Driver.FindElement(btnLogin).Click();
        }

        public bool RedButtonAppears(string title)
        {
           return Driver.FindElement(By.CssSelector($"a[title='{title}']")).Enabled ;
        }

        public void ClickLoginRedButton(string title)
        {
            Driver.FindElement(By.CssSelector($"a[title='{title}']")).Click() ;
        }


       



    }
}
