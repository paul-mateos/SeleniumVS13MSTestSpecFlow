using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using CPAAutomationSolution.Pages;
using CPAAutomationSolution.Tests;

namespace CPAAutomationSolution.Tests
{

    [TestClass]
    public class CPALoginTest : BaseTest
    {
        public CPALoginTest()
        {

        }

       
        [TestCategory("PVT"), TestCategory("Regression")]
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

        [TestCategory("Regression")]
        [TestMethod]
        public void FailedLogin()
        {

            //Log on to site as user.
            Assert.IsTrue(driver.Title == "CPA Australia - Home");
            HomePage homePage = new HomePage(driver);
            homePage.ClickLoginButton();
            Assert.IsTrue(driver.Title == "CPA Australia - Sign in or create an account");
            LoginPage loginPage = new LoginPage(driver);
            loginPage.SetCustomerID("982209");
            loginPage.SetPassword("01Password");
            loginPage.ClickSubmitButton();
            Assert.IsTrue(driver.Title == "CPA Australia - Home");

        }
    }
}
