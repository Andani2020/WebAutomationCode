using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAutomation.pages
{
    public class betwaypage
    {
        public IWebDriver WebDriver { get; }
        
        public  betwaypage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        //UI Elements
        public IWebElement BtnSignUp => WebDriver.FindElement(By.Id("SignUp"));
        public IWebElement TxtmobileNo=> WebDriver.FindElement(By.Id("MobileNumber_tmpl"));
        public IWebElement Txtpasssword => WebDriver.FindElement(By.Id("Password_tmpl"));
        public IWebElement TxtFirstName => WebDriver.FindElement(By.Id("FirstName_tmpl"));
        public IWebElement TxtLastName => WebDriver.FindElement(By.Id("LastName_tmpl"));
        public IWebElement TxtEmail => WebDriver.FindElement(By.Id("Email_tmpl"));

        public void ClickSignup() => BtnSignUp.Click(); 
        public void SignUp (string mobileNo ,string txtpasssword, string FirstName,string LastName,string Email)
        {
            TxtmobileNo.SendKeys(mobileNo);
            Txtpasssword.SendKeys(txtpasssword);
            TxtFirstName.SendKeys(FirstName);
            TxtLastName.SendKeys(LastName);
            TxtEmail.SendKeys(Email);
        }
        



    }
}
