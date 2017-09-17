using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PmaProject
{
    class PmaMainPage
    {
        private IWebDriver browser;
        private WebDriverWait wait;

        By linkCreateDataBase_locator = By.XPath("//*[@id='topmenucontainer']/ul/li[1]/a");
        public IWebElement ButtonCreateDataBase => this.browser.FindElement(linkCreateDataBase_locator);

        By chooseMainLanguage_locator = By.XPath("//*[@id='create_database_form']/select");

        public IWebElement ChooseMainLanguageDropBox => this.browser.FindElement(chooseMainLanguage_locator);

        public PmaMainPage SelectDataBaseMainLanguage()
        {
            WaitForByLocator(chooseMainLanguage_locator);


            SelectElement select = new SelectElement(ChooseMainLanguageDropBox);
            select.SelectByValue("utf8_general_ci");

           
            return this;
        }


        public bool IsRefCreateDataBasePresent()
        {
            WaitForByLocator(linkCreateDataBase_locator);
            return this.browser.FindElement(linkCreateDataBase_locator) != null;
        }

        public PmaMainPage ButtonDataBaseClick()
        {
            ButtonCreateDataBase.Click();
            return this;
        }







        public PmaMainPage(IWebDriver browser)
        {
            wait = new WebDriverWait(browser, TimeSpan.FromSeconds(5));
            this.browser = browser;
        }


        public string GetTitle => this.browser.Title;

        private void WaitForByLocator(By locator)
        {
            if (wait == null)
                wait = new WebDriverWait(browser, new TimeSpan(0, 0, 5));
            wait.Until(d => d.FindElement(locator));
        }

    }
}
