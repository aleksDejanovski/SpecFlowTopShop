using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAutomation.Pages
{
    public class KitchenPage : BasePage
    {
        
        private readonly By txtSearchBar = By.Id("search");
        private readonly By btnClickSearch = By.CssSelector(".button.search-button");
        private readonly By lblResultItem = By.XPath("//h2[@data-engname='DELIMANO ELECTRIC PRESSURE MULTICOOKER BLACK 5,7l']");
        public KitchenPage(IWebDriver driver) : base(driver)
        {
        }

        public string ReturnDriverUrl()
        {
            return Driver.Url;
        }

        public void SearchItem(string item)
        {
            Driver.FindElement(txtSearchBar).SendKeys(item);
            Driver.FindElement(btnClickSearch).Click();
        }

        public bool IfItemIsThere(string item)
        {
            WaitElementToAppear(Driver, lblResultItem);
            return Driver.FindElement(By.XPath($"//h2[@data-engname='{item}']")).Enabled;
        }


    }
}
