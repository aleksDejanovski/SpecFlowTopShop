using BoDi;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAutomation.Pages;

namespace TestingAutomation.Hooks
{
    [Binding]
    public class SeleniumBindings
    {
        // LoginPage LoginPage => new LoginPage(Driver);
        //private IWebDriver Driver;


        private readonly IObjectContainer container;

        

        public SeleniumBindings(IObjectContainer container)
        {
            this.container = container;
        }

        [BeforeScenario]
        public void SetUp()
        {
            IWebDriver Driver = new ChromeDriver();
            container.RegisterInstanceAs<IWebDriver>(Driver);
            
        }

        [AfterScenario]
        public void TearDown()
        {
            IWebDriver Driver = container.Resolve<IWebDriver>();

            Driver.Close();
            Driver.Dispose();
        }

      



    }
}
