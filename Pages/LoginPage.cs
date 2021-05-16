using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowNUNIT.Pages
{
    public class LoginPage
    {
        public IWebDriver WebDriver { get; }
        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
        public IWebElement txtUsername => WebDriver.FindElement(By.XPath("//input[@id='formBasicEmail']"));
        public IWebElement txtPassword => WebDriver.FindElement(By.XPath("//input[@id='formBasicPassword']"));
        public IWebElement btnLogin => WebDriver.FindElement(By.XPath("//button[@type='submit' and @class='lg-btn action btn btn-primary']"));
       
        public void Login(string userName, string password)
        {
            txtUsername.SendKeys(userName);
            txtPassword.SendKeys(password);
           
        }

        public void ClickLoginButton() => btnLogin.Click();


    }
}
