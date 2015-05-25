using CPAAutomationSolution.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace CPAAutomationSolution
{
    [Binding]
    public class CPALoginSteps: BaseTest
    {

  
        [Given(@"I have clicked the login button")]
        public void GivenIHaveClickedTheLoginButton()
        {
            Assert.IsTrue(driver.Title == "CPA Australia - Home");
            HomePage homePage = new HomePage(driver);
            homePage.ClickLoginButton();
            LoginPage loginPage = new LoginPage(driver);
            Assert.IsTrue(driver.Title == "CPA Australia - Sign in or create an account");
            
        }
        
        [Given(@"I have entered the customer id")]
        public void GivenIHaveEnteredTheCustomerId()
        {
            LoginPage loginPage = new LoginPage(driver);
            Assert.IsTrue(driver.Title == "CPA Australia - Sign in or create an account");
            loginPage.SetCustomerID("9822090");
        }
        
        [Given(@"I have entered the customer password")]
        public void GivenIHaveEnteredTheCustomerPassword()
        {
            LoginPage loginPage = new LoginPage(driver); 
            loginPage.SetPassword("01Password");
        }
        
        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.ClickSubmitButton();
        }
        
        [Then(@"the result should be a successful login")]
        public void ThenTheResultShouldBeASuccessfulLogin()
        {
            HomePage homePage = new HomePage(driver); 
            Assert.IsTrue(driver.Title == "CPA Australia - Home");
            homePage.ClickLogOutButton();
        }

        [Given(@"I have entered the (.*) and (.*)")]
        public void GivenIHaveEnteredTheAnd(string p0, string p1, Table table)
        {
            string customerID = ((string[])(table.Rows[0].Values))[0].ToString();
            string password = ((string[])(table.Rows[0].Values))[1].ToString();
            LoginPage loginPage = new LoginPage(driver);
            Assert.IsTrue(driver.Title == "CPA Australia - Sign in or create an account");
            loginPage.SetCustomerID(customerID);
            loginPage.SetPassword(password);
        }

    }
}
