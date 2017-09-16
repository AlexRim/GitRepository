using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace PmaProject
{
    class PmaLoginPageObject
    {
        private IWebDriver browser;
        private WebDriverWait wait;
        
        public PmaLoginPageObject(IWebDriver browser)
        {
            wait = new WebDriverWait(browser, TimeSpan.FromSeconds(30));
            this.browser = browser;
        }

        public IWebElement UserField => this.browser.FindElement(By.Id("input_username"));

        public PmaLoginPageObject InputUserName(string username)
        {
            this.UserField.Clear();
            this.UserField.SendKeys(username);
            return this;
        }
       

    }
}
