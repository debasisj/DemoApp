using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    public class InitDriver
    {
        private static IWebDriver webDriver;
        public static void Init(string driverTyper, string url )
        {
           
            switch (driverTyper)
            {
                case "chrome":
                    webDriver = new ChromeDriver(@"C:\Users\deb.jagadeba\source\repos\DemoApp\Driver");
                    break;

                case "firefox":
                    webDriver = new FirefoxDriver(@"C:\Users\deb.jagadeba\source\repos\DemoApp\Driver");
                    break;

                case "ie":
                    webDriver = new InternetExplorerDriver(@"C:\Users\deb.jagadeba\source\repos\DemoApp\Driver");
                    break;
            }
          
            webDriver.Navigate().GoToUrl(url);
            webDriver.Manage().Window.Maximize();
            webDriver.Close();
            webDriver.Quit();

        }
    }
}
