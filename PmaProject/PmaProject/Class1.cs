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
        [SetUp]
        public void SetUp()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"e:\GeckoDriver");
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
           driver = new FirefoxDriver(service);
        }

        [Test]
        public void Navigate()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            var clickableElement = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id("hplogo")));
            string title= driver.FindElement(By.Id("hplogo")).GetAttribute("title");
            Assert.AreEqual("Google", title);

        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }




    }
}
