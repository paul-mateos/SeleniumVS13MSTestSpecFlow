using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using CPAAutomationSolution.Pages;

namespace CPAAutomationSolution.Tests
{
    /// <summary>
    /// Summary description for GoogleSearch
    /// </summary>
    [TestClass]
    public class CPALoginTest : BaseTest
    {
        public CPALoginTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void SuccessfulLogin()
        {
             //Log on to site as user.
            Assert.IsTrue(driver.Title == "CPA Australia - Home");
            HomePage homePage = new HomePage(driver);            
            homePage.ClickLoginButton();
            LoginPage loginPage = new LoginPage(driver);
            Assert.IsTrue(driver.Title == "CPA Australia - Sign in or create an account"); 
            loginPage.SetCustomerID("9822090");
            loginPage.SetPassword("01Password");
            loginPage.ClickSubmitButton();
            Assert.IsTrue(driver.Title == "CPA Australia - Home");
            homePage.ClickLogOutButton();
            
        }

        [TestMethod]
        public void FailedLogin()
        {

            //Log on to site as user.
            Assert.IsTrue(driver.Title == "CPA Australia - Home");
            HomePage homePage = new HomePage(driver);
            homePage.ClickLoginButton();
            Assert.IsTrue(driver.Title == "CPA Australia - Sign in or create an account");
            LoginPage loginPage = new LoginPage(driver);
            loginPage.SetCustomerID("1234");
            loginPage.SetPassword("abcd");
            loginPage.ClickSubmitButton();
            Assert.IsTrue(driver.Title == "CPA Australia - Home");

        }
    }
}
