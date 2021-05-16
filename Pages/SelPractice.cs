using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowNUNIT.Pages
{
    class SelPractice
    {
        public IWebDriver driver { get; }
        public SelPractice(IWebDriver idriver)
        {
            driver = idriver;
        }
        public void ImplicitWait()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(12);
            driver.Url ="http://www.uitestpractice.com/students/contact";
            driver.FindElement(By.PartialLinkText("This is")).Click();
            string result = driver.FindElement(By.ClassName("ContactUs")).Text;
            Console.WriteLine(result.Contains("Python"));
            driver.Quit();

        }
        
    }
}
