using NUnit.Framework;
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
    [TestFixture]
    public class Class1
    {
        private IWebDriver driver;
        private PmaLoginPageObject loginPage;
        
        [OneTimeSetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            loginPage = new PmaLoginPageObject(driver);
        }

      
     [Test, Order(1)]
        public void Navigate()
        {
            driver.Url= "http://localhost/pma";
            Assert.AreEqual("phpMyAdmin", loginPage.GetTitle);
        }

        [Test, Order(1)]
        public void InputLoginPassword()
        {
            loginPage.InputUserNameAndPassword("root", "123456");
        }



        [OneTimeTearDown]
       public void CleanUp()
        {
          // driver.Close();
           driver.Quit();
        }




    }
}
