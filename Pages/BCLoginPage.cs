using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowNUNIT.Pages
{
    class BCLoginPage
    {
        public IWebDriver WebDriver { get; }
        Actions actions;
        public BCLoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            actions = new Actions(WebDriver);
        }
        public IWebElement btnSignin => WebDriver.FindElement(By.XPath("//a[@id='cta-bc-signin']"));
       public IWebElement txtUserName => WebDriver.FindElement(By.Name("loginfmt"));
        public IWebElement btnNext => WebDriver.FindElement(By.Id("idSIButton9"));

        public IWebElement txtPassword => WebDriver.FindElement(By.Name("passwd"));
      //  public IWebElement btnSignin => WebDriver.FindElement(By.Id("idSIButton9"));

        public void ClickSignin() => btnSignin.Click();
        public void ClickNext(string Uname)
        {
            
            actions.MoveToElement(txtUserName)
                .Click()
                .SendKeys("27255@davfbd14.onmicrosoft.com")
                .Build().Perform();
            actions.MoveToElement(btnNext)
                .Click()
                .Build()
                .Perform();
          
        }
        public void ClickSignIn(string Password)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)WebDriver;
            jse.ExecuteScript("alert(hi)");
            actions.MoveToElement(txtPassword)
                .Click()
                .SendKeys("angel@2402")
                .Build().Perform();
        }
    }
}
