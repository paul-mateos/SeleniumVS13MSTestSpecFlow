using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using CPAAutomationSolution.Environment;
using System.Diagnostics;


namespace CPAAutomationSolution
{
    [TestClass]
    public class BaseTest
    {
        protected static IWebDriver driver;
        protected TestEnvironment environment;
        //private const string DRIVER_PATH = @"ThirdParty";
        
        [TestInitialize]
        public static void Initialize()
        {
            var options = new InternetExplorerOptions()
            {
                IntroduceInstabilityByIgnoringProtectedModeSettings = true
            };

            switch(Properties.Settings.Default.Browser)
            {
                case BrowserType.Firefox:
                    driver = new FirefoxDriver();
                    break;
                case BrowserType.IE:
                    driver = new InternetExplorerDriver(options);
                    break;
                case BrowserType.Chrome:
                    driver = new ChromeDriver();
                    break;
                default:
                    throw new ArgumentException("Browser Type Invalid");
            }

            driver.Navigate().GoToUrl(TestEnvironment.GetEnvironment().Url);
            driver.Manage().Window.Maximize();

        }


        [TestCleanup]
        public static void TestCleanUp()
        {
            driver.Quit();
            switch (Properties.Settings.Default.Browser)
            {
                case BrowserType.Firefox:
                    KillProcess("firefox.exe");
                    break;
                case BrowserType.IE:
                    KillProcess("iexplorer.exe");
                    break;
                case BrowserType.Chrome:
                    KillProcess("chrome.exe");
                    break;
                default:
                    throw new ArgumentException("Browser Type Invalid");
             
            }
        }

        public static void KillProcess(string processName)
        {
            foreach (var process in Process.GetProcessesByName(processName))
            {
                process.Kill();
            }
        }

    }
}
