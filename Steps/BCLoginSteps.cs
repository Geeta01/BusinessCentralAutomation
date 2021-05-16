using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowNUNIT.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowNUNIT.Steps
{
    [Binding]
    class BCLoginSteps
    {
        BCLoginPage BCloginPage = null;
        [Given(@"I launch the BC application")]
        public void GivenILaunchTheBCApplication()
        {
            IWebDriver webDriver = new ChromeDriver();
            // webDriver.Manage().Timeouts().SetPageLoadTimeout(3000);
            //  webDriver.Navigate().GoToUrl("https://dynamics.microsoft.com/en-us/business-central/signin/?ru=https%3A%2F%2Fbusinesscentral.dynamics.com%2F%3FnoSignUpCheck%3D1");
            //   BCloginPage = new BCLoginPage(webDriver);

            webDriver.Manage().Timeouts().PageLoad=TimeSpan.FromSeconds(30);

            //((IJavaScriptExecutor)webDriver).ExecuteScript("alert('hello world');");
            ((IJavaScriptExecutor)webDriver).ExecuteAsyncScript("window.setTimeout(arguments[arguments.length - 1], 500);");
            // Use the timeout when navigating to a webpage
            try
            {
                webDriver.Navigate().GoToUrl("https://dynamics.microsoft.com/en-us/business-central/signin/?ru=https%3A%2F%2Fbusinesscentral.dynamics.com%2F%3FnoSignUpCheck%3D1");
                   BCloginPage = new BCLoginPage(webDriver);


            }
            catch (Exception e)
            {
                Console.WriteLine("Page:  did not load within 40 seconds!" + e.Message);
                webDriver.Quit();
                // treat the timeout as needed
            }
        }

        [Given(@"I click on Sign in button")]
        public void GivenIClickOnSignInButton()
        {
            BCloginPage.ClickSignin();
        }
        [Given(@"I enter the UserName '(.*)'")]
        public void GivenIEnterTheUserName(string UserName)
        {
            BCloginPage.ClickNext(UserName);
        }
        [Given(@"I enter the Password '(.*)'")]
        public void GivenIEnterThePassword(string Password)
        {
            BCloginPage.ClickSignIn(Password);
        }


        [Then(@"I should see the BC homepage")]
        public void ThenIShouldSeeTheBCHomepage()
        {
           
        }

    }
}
