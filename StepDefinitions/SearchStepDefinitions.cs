using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAutomation.Pages;

namespace TestingAutomation.StepDefinitions
{
    [Binding]
    public class SearchStepDefinitions
    {
        DashBoardPage DashBoardPage => new DashBoardPage(Driver);
        KitchenPage KitchenPage => new KitchenPage(Driver);


        public IWebDriver Driver { get; private set; }
        public WebDriverWait Wait { get; private set; }

        public SearchStepDefinitions(IWebDriver Driver)
        {

            this.Driver = Driver;
        }

        [When(@"I click the kitchen button")]
        public void WhenIClickTheKitchenButton()
        {
            DashBoardPage.ClickKitchenButton();
        }

        [Then(@"The kitchen page should be opened")]
        public void ThenTheKitchenPageShouldBeOpened()
        {
            Assert.Contains("kujna",KitchenPage.ReturnDriverUrl());
        }

        [When(@"I search for a ""([^""]*)"" using the search bar")]
        public void WhenISearchForAUsingTheSearchBar(string item)
        {
            KitchenPage.SearchItem(item);
        }

        [Then(@"There should be item ""([^""]*)"" as result")]
        public void ThenThereShouldBeItemAsResult(string item)
        {
            Assert.True(KitchenPage.IfItemIsThere(item));
        }



    }
}
