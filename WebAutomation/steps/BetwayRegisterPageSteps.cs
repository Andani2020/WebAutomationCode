using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Cryptography.X509Certificates;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WebAutomation.pages;

namespace WebAutomation.steps
{
    [Binding]
    public class BetwayRegisterPageSteps
    {
        betwaypage signUpPage = null;

        private IWebDriver webDriver = new ChromeDriver();
        [Given(@"I navigate to beatway home page")]
        public void GivenINavigateToBeatwayHomePage()
        {
            webDriver.Navigate().GoToUrl("https://www.betway.co.za");
            webDriver.Manage().Window.Maximize();
        }

        [Then(@"I click sign up page")]
        public void ThenIClickSignUpPage()
        {
            signUpPage.ClickSignup();
        }

        [Then(@"I enter personal detail to register")]
        public void ThenIEnterPersonalDetailToRegister(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            signUpPage.SignUp((string)data.mobileNumber, (string)data.password, (string)data.firstName, (string)data.surname, (string)data.email;
   
        }

        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser()
        {
            webDriver.Close();
        }

    }
}
