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
        
        [SetUp]
        public void SetUp()
        {

            driver = new FirefoxDriver();
            loginPage = new PmaLoginPageObject(driver);
        }

        [Test]
        public void Navigate()
        {
            driver.Url= "http://localhost/pma";
            Assert.AreEqual("PhpMyAdmin", driver.Title);

            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //loginPage.InputUserName("root");


        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }




    }
}
