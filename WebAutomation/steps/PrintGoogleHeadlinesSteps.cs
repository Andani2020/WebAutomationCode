using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using TechTalk.SpecFlow;

namespace WebAutomation.steps
{
    
      


    [Binding]
    public sealed class PrintGoogleHeadlinesSteps
    {
      private  IWebDriver webDriver = new ChromeDriver();
      //List<String> textHeadlines = new List<string>();

        [Test]
        [Given(@"I navigate to google news website")]
        public void GivenINavigateToGoogleNewsWebsite()
        {
            //Open browser

            
            webDriver.Navigate().GoToUrl("http://news.google.com/");
            webDriver.Manage().Window.Maximize();
            //locate headlines elelment



        }
        [Test]
        [Given(@"I read all the headlines and print")]
        public void GivenIReadAllTheHeadlinesAndPrint()
        {

            List<String> textHeadLines = new List<String>();
            ReadOnlyCollection<IWebElement> webElements = webDriver.FindElements(By.ClassName("DY5T1d"));

            foreach (IWebElement webElement in webElements)
            {
                textHeadLines.Add(webElement.Text);
            }

            Console.WriteLine(textHeadLines);
            webDriver.Close();
            Assert.Pass();
            
        }
        [Then(@"close")]
        public void ThenClose()
        {
            webDriver.Close();
        }



    }
}
