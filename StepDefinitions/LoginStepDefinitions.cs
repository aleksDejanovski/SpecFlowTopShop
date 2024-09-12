using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        DashBoardPage DashBoardPage => new DashBoardPage(Driver);
       
        LoginPage LoginPage => new LoginPage(Driver);
      

        public IWebDriver Driver { get; private set; }
        public WebDriverWait Wait { get; private set; }

        public LoginStepDefinitions(IWebDriver Driver)
        {
          
            this.Driver = Driver;
        }
       


        [Given(@"The user is navigated to the ""([^""]*)""")]
        public void GivenTheUserIsNavigatedToThe(string url)
        {
            DashBoardPage.NavigateToUrl(url);
        }


        [When(@"The user clicks the login button")]
        public void WhenTheUserClicksTheLoginButton()
        {
            DashBoardPage.ClickLoginButton();
        }

        [When(@"The user clicks the ""([^""]*)"" red button")]
        public void WhenTheUserClicksTheRedButton(string titleText)
        {
            DashBoardPage.ClickLoginRedButton(titleText);
        }

        [When(@"I enter the username as ""([^""]*)"", password as ""([^""]*)"" and click submit")]
        public void WhenIEnterTheUsernameAsPasswordAsAndClickSubmit(string username, string pass)
        {
            LoginPage.SubmitLoginForm(username, pass);
        }



        [Then(@"The ""([^""]*)"" red button should appear")]
        public void ThenTheRedButtonShouldAppear(string titleText)
        {
           Assert.True(DashBoardPage.RedButtonAppears(titleText));
        }

        [Then(@"The Login page should appear")]
        public void ThenTheLoginPageShouldAppear()
        {
            Assert.True(LoginPage.IfUserIsOnLoginPage(), "User is not on login page");
        }


        [Then(@"The user should be sucessfuly loged in and text ""([^""]*)"" should be presented at the page")]
        public void ThenTheUserShouldBeSucessfulyLogedInAndTextShouldBePresentedAtThePage(string welcomeText)
        {
            Assert.True(LoginPage.IfUserIsLoggedIn(welcomeText));   
            
        }



    }
}
