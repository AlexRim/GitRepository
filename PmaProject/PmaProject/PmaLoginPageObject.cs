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
    class PmaLoginPageObject
    {
        private IWebDriver browser;
        private WebDriverWait wait; 
      //  By userNameField_locator = By.Id("input_username");
        By userNameField_locator = By.XPath("//*[@name='login_form']/fieldset/div/input");
       // By passwordInputField_locator = By.Id("input_password");
       By passwordInputField_locator = By.XPath("//*[@name='login_form']/fieldset/div[2]/input");

    

        public PmaLoginPageObject(IWebDriver browser)
        {
            wait = new WebDriverWait(browser, TimeSpan.FromSeconds(5));
            this.browser = browser;
        }

        By selectLanguage_locator = By.XPath("//form/fieldset/select");
        public IWebElement SelectLanguage => this.browser.FindElement(selectLanguage_locator);
        public void SetEnglishLanguage()
        {
            waitForByLcoator(selectLanguage_locator);
            SelectElement el = new SelectElement(this.SelectLanguage);
            el.SelectByText("English");
        }




     
        public IWebElement UserNameField => this.browser.FindElement(userNameField_locator);
        public IWebElement InputPasswordField => this.browser.FindElement(passwordInputField_locator);

        public string GetTitle => this.browser.Title;

        public PmaLoginPageObject InputUserNameAndPassword(string username, string password)
        {                
            this.UserNameField.Clear();
            this.UserNameField.SendKeys(username);
            this.InputPasswordField.Clear();
            this.InputPasswordField.SendKeys(password);
            return this;
          
        }



        private void waitForByLcoator(By locator)
        {
            if (wait == null)
            wait = new WebDriverWait(browser, new TimeSpan(0, 0, 5));
            wait.Until(d => d.FindElement(locator));
        }


    }
}
