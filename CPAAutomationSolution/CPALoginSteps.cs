using CPAAutomationSolution.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace CPAAutomationSolution
{
    [Binding]
    public class CPALoginSteps : BaseTest
    {

        [BeforeScenario]
        public void BeforeScenario()
        {

            BaseTest.Initialize();
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            BaseTest.TestCleanUp();
            
        } 


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
    }
}
