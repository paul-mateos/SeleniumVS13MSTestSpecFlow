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
using CPAAutomationSolution.Utilities;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace CPAAutomationSolution.Tests
{

    [TestClass]
    public class MEPAOnlineTests : BaseTest
    {
        public MEPAOnlineTests()
        {

        }

       
        [TestCategory("PVT"), TestCategory("Regression")]
        [TestMethod] 
        public void MEPAOnlineApplication()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Properties.Settings.Default.WaitTime)); 
            Actions action = new Actions(driver);
            //Log on to site as user.
            HomePage homePage = new HomePage(driver);
            homePage.ClickLoginButton();
            UICommon.SetValue(By.Id("UserName"), "10300149", driver);
            UICommon.SetValue(By.Id("Password"), "01Password", driver);
            UICommon.ClickButton(By.XPath("//button[@type='submit']"), driver);
            IWebElement elem = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("logout_btn")));
            UICommon.GetElement(By.Id("phcorp_pagebody_0_phcorp_home_quicktasks_0_rptData_li_0"), driver).Click();
            UICommon.GetElement(By.LinkText("Apply now"), driver).Click();
            Thread.Sleep(30000);
            //01
            UICommon.ClickButton(By.XPath("//input[@type='submit' and @name='Agree']"), driver);
            StringAssert.Contains((UICommon.GetElement(By.ClassName("validationHeading"), driver).Text), 
                "Your submission contains errors. Please correct the errors that have been highlighted below and resubmit the form.");
            UICommon.GetElement(By.Id("HasAgreedToPrivacy"), driver).Click();
            UICommon.ClickButton(By.XPath("//input[@type='submit' and @name='Agree']"), driver);

            //02
            UICommon.GetElement(By.Id("HasEducationQualifications_Yes"),driver).Click();
            UICommon.GetElement(By.Id("HasOtherProfessionalAccountingBodies_No"), driver).Click();
            UICommon.GetElement(By.XPath("//select/option[text()='Public Practice']"), driver).Click();
            elem = UICommon.GetElement(By.Id("CurrentEmploymentSituation"), driver);
            elem.Click();
            UICommon.GetElement(By.XPath("//select/option[text()='Public Practice']"), driver).Click();
            UICommon.ClickButton(By.XPath("//button[@type='submit' and @name='Next']"), driver);

            //03
            UICommon.SetValue(By.Id("ContactDetails_MiddleName"), "Middle Name", driver);
            UICommon.GetElement(By.Id("ContactDetails_Gender_Male"), driver).Click();
            UICommon.SetValue(By.Id("ContactDetails_DateOfBirth"), "01/01/1980", driver);
            UICommon.SetValue(By.Id("Addresses_Billing_AddressLine1"), "123 SomeWhere St", driver);
            UICommon.GetElement(By.Id("Addresses_Billing_StateId"), driver).Click();
            UICommon.GetElement(By.XPath("//select/option[text()='Victoria']"), driver).Click();
            UICommon.SetValue(By.Id("Addresses_Billing_SuburbCity"), "Melbourne", driver);
            UICommon.SetValue(By.Id("Addresses_Billing_Postcode"), "3000", driver);
            UICommon.SetValue(By.Id("ContactDetails_MobilePhone"), "0411111111", driver);
            UICommon.ClickButton(By.XPath("//button[@type='submit' and @name='Next']"), driver);

            //04
            UICommon.GetElement(By.Id("Qualifications_0__CountryId"), driver).Click();
            UICommon.GetElement(By.XPath("//select/option[text()='AUSTRALIA']"), driver).Click();
            UICommon.SetValue(By.Id("Qualifications_0__Institution"), "Monash College", driver);
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@id='fs-preloader' and contains(@style,'opacity: 0;')]")));
            wait.Until(x => x.FindElement(By.ClassName("progress-text")));
            Thread.Sleep(5000);
            elem = wait.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@class='typeahead dropdown-menu']/li/a[text()='Monash College']")));
            elem.Click();
            wait.Until(x => x.FindElement(By.ClassName("progress-text")));
            Thread.Sleep(2000);
            UICommon.GetElement(By.Id("Qualifications_0__QualificationId"), driver).Click();
            UICommon.GetElement(By.XPath("//select/option[text()='Bachelor Degree in Accounting']"), driver).Click();
            UICommon.GetElement(By.Id("Qualifications_0__QualificationLevel_Undergraduate_level"), driver).Click();
            UICommon.GetElement(By.Id("Qualifications_0__ModeOfStudy_Full_time"), driver).Click();
            UICommon.ClickButton(By.XPath("//button[@type='submit' and @name='Add']"), driver);
            UICommon.ClickButton(By.XPath("//button[@type='submit' and @name='Next']"), driver);

            //05
            UICommon.SetValue(By.Id("CompanyDetailsViewModel_Company"), "Peter Dunn", driver);
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@id='fs-preloader' and contains(@style,'opacity: 0;')]")));
            wait.Until(x => x.FindElement(By.ClassName("progress-text")));
            Thread.Sleep(5000);
            elem = wait.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@class='typeahead dropdown-menu']/li/a[text()='Peter Dunn']")));
            elem.Click();
            Thread.Sleep(2000);
            wait.Until(x => x.FindElement(By.ClassName("progress-text")));
            UICommon.SetValue(By.Id("JobDetails_Position"), "Bean Counter", driver);
            elem = UICommon.GetElement(By.Id("JobDetails_Function"), driver);
            elem.Click();
            elem.FindElement(By.XPath("//select/option[text()='General Management']")).Click();
            elem = UICommon.GetElement(By.Id("JobDetails_Responsibility"), driver);
            elem.Click();
            elem.FindElement(By.XPath("//select/option[text()='General Manager']")).Click();
            UICommon.ClickButton(By.XPath("//button[@type='submit' and @name='Next']"), driver);

            //06
            UICommon.GetElement(By.Id("HasPastCriminalOffense_Yes"), driver).Click();
            UICommon.GetElement(By.Id("HasBeenbankrupted_No"), driver).Click();
            UICommon.GetElement(By.Id("HasBeenDebtorInSequestration_Yes"), driver).Click();
            UICommon.GetElement(By.Id("HasBeenDisqualified_No"), driver).Click();
            UICommon.GetElement(By.Id("HasBeenRefusedMembership_Yes"), driver).Click();
            UICommon.GetElement(By.Id("HadMembershipForfeited_No"), driver).Click();
            UICommon.GetElement(By.Id("HadDisciplinaryProceedings_Yes"), driver).Click();
            UICommon.GetElement(By.Id("IsProvidingPublicAccountingService_No"), driver).Click();
            UICommon.GetElement(By.Id("IdentificationIds_Birth_Certificate__70_"), driver).Click();
            UICommon.GetElement(By.Id("IdentificationIds_Utility_Bill__30_"), driver).Click();
            UICommon.ClickButton(By.XPath("//button[@type='submit' and @name='Next']"), driver);


            
            //07
            Assert.IsNotNull(UICommon.GetElement(By.XPath("//div/p/strong[contains(text(),'$160.00')]"), driver));
            UICommon.ClickButton(By.XPath("//button[@type='submit' and @name='Next']"), driver);
            Thread.Sleep(2000);
            //08
            UICommon.GetElement(By.Id("AgreesToDeclaration"), driver).Click();
            UICommon.ClickButton(By.XPath("//button[@type='submit' and @name='Next']"), driver);

            //09
            UICommon.GetElement(By.Id("SelectedCard"), driver).Click();
            UICommon.SetValue(By.Id("creditCardNumber"), "4444333322221111", driver);
            UICommon.SetValue(By.Id("expiryMonth"), "12", driver);
            UICommon.SetValue(By.Id("expiryYear"), "2020", driver);
            UICommon.SetValue(By.Id("creditCardCVN"), "200", driver);
            UICommon.GetElement(By.Id("cb-agree-to-terms"), driver).Click();
            UICommon.ClickButton(By.Id("reviewButton"), driver);

            //Review
            UICommon.GetElement(By.Id("review-placeOrderButton"),driver);



        }

       
    }
}
