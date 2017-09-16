using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;


namespace MyRunClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"e:\GeckoDriver");
            // service.FirefoxBinaryPath = @"c:\Program Files\Mozilla Firefox\firefox.exe";
            //var driver = new FirefoxDriver(service);

            IWebDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("http://localhost/pma");
 
         

          

            driver.Close();
        }
    }
}
