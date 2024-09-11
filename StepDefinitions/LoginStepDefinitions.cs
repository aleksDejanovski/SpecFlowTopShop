using BoDi;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAutomation.Hooks;
using TestingAutomation.Pages;

namespace TestingAutomation.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        LoginPage LoginPage => new LoginPage(Driver);

        public IWebDriver Driver { get; private set; }

        public LoginStepDefinitions(IWebDriver Driver)
        {
            this.Driver = Driver;
        }



        [Given(@"The user is navigated to the ""([^""]*)""")]
        public void GivenTheUserIsNavigatedToThe(string url)
        {
           LoginPage.NavigateToUrl(url);
        }


        [When(@"The user clicks the login button")]
        public void WhenTheUserClicksTheLoginButton()
        {
            LoginPage.ClickLoginButton();
        }


        [Then(@"The ""([^""]*)"" red button should appear")]
        public void ThenTheRedButtonShouldAppear(string titleText)
        {
           Assert.True(LoginPage.RedButtonAppears(titleText));
        }




    }
}
