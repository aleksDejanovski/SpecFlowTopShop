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
        private readonly string userLoggedInUrl = "account";
        private readonly By lblErrorMessage = By.Id("advice-validate-email-email");



         


        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        

        public bool IfUserIsOnLoginPage()
        {
            return Driver.Url.Contains("login");
        }

        public void SubmitLoginForm(string username, string password)
        {   
            WaitElementToAppear(Driver, txtUserName);
            Driver.FindElement(txtUserName).SendKeys(username);
            Driver.FindElement(txtPassword).SendKeys(password);
            Driver.FindElement(btnNajaviSe).Click();
        }

        public bool IfUserIsLoggedIn(string welcomeText)
        {
            WaitUrlToContain(Driver, userLoggedInUrl);
            return  Driver.FindElement(By.XPath($"//strong[text()='{welcomeText}']")).Enabled;
        }

        public bool IfErrorMessageAppears()
        {
            WaitElementToAppear(Driver,lblErrorMessage);
            return true;
        }
            
    }
}
