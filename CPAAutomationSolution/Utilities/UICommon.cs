using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPAAutomationSolution.Utilities
{
    public class UICommon
    {
        public static IWebElement GetElement(By searchType, IWebDriver d)
        {

            WebDriverWait wait = new WebDriverWait(d, TimeSpan.FromSeconds(Properties.Settings.Default.WaitTime));
            IWebElement elem = wait.Until(ExpectedConditions.ElementIsVisible(searchType));
            return elem;
            
        }

        public static void ClickButton(By searchType, IWebDriver d)
        {
            IWebElement elem = GetElement(searchType, d);
            elem.Click();
        }

        public static void SetValue(By searchType, string value, IWebDriver d)
        {
            IWebElement elem = GetElement(searchType, d);
            elem.SendKeys(value);

        }

    }
}
