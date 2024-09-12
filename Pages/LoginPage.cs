using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAutomation.Pages
{
    public class LoginPage : BasePage
    {

        private readonly By txtUserName = By.Id("email");
        private readonly By txtPassword = By.Id("pass");
        private readonly By btnNajaviSe = By.Id("send2");
        



         private WebDriverWait Wait;


        public LoginPage(IWebDriver driver) : base(driver)
        {
        }



        public bool IfUserIsOnLoginPage()
        {
            return Driver.Url.Contains("login");
        }

        public void SubmitLoginForm(string username, string password)
        {
            WebDriverWait Wait = new WebDriverWait(Driver,timeout:TimeSpan.FromSeconds(12));
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(txtUserName));
            Driver.FindElement(txtUserName).SendKeys(username);
            Driver.FindElement(txtPassword).SendKeys(password);
            Driver.FindElement(btnNajaviSe).Click();
        }

        public bool IfUserIsLoggedIn(string welcomeText)
        {
            WebDriverWait Wait = new WebDriverWait(Driver, timeout: TimeSpan.FromSeconds(12));
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("account"));
            return  Driver.FindElement(By.XPath($"//strong[text()='{welcomeText}']")).Enabled;
        }

            
    }
}
