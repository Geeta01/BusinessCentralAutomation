using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowNUNIT.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowNUNIT.Steps
{
    [Binding]
    public sealed class LoginSteps
    {

        LoginPage loginPage = null;

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://stv2.inn-flow.net/login");
            // webDriver.Navigate().GoToUrl("https://dynamics.microsoft.com/en-us/business-central/signin/?ru=https%3A%2F%2Fbusinesscentral.dynamics.com%2F%3FnoSignUpCheck%3D1");
            // webDriver.Navigate().GoToUrl("www.google.com");


            loginPage = new LoginPage(webDriver);

        }

        [Given(@"I click login link")]


        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            loginPage.Login((string)data.UserName, (string)data.Password);
        }

        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            loginPage.ClickLoginButton();
            //  Console.WriteLine("**************Hey m HERE************************");
        }

        [Then(@"I should see the homepage")]
        public void ThenIShouldSeeTheHomepage()
        {
            // Assert.IsTrue()
        }

        [Given(@"I landed application")]
        public void GivenILandedApplication()
        {
            // ScenarioContext.Current.Pending();
        }

        [When(@"I fill all details in form (.*),(.*) and (.*)")]
        [Obsolete]
        public void WhenIFillAllDetailsinform(string name, int age, Int64 phone)
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Name:" + age);
            Console.WriteLine("Name:" + phone);

            ScenarioContext.Current["InfoForNextStep"] = "Step1 Passed";
            Console.WriteLine(ScenarioContext.Current["InfoForNextStep"].ToString());

            List<EmployeeDetails> empDetails = new List<EmployeeDetails>()
            {
                new EmployeeDetails()
                {
                    Name = "Liner1",
                    Age = 10,
                    Phone = 787
                },
            new EmployeeDetails()
            {
                Name = "Liner2",
                Age = 20,
                Phone = 333
            },
            new EmployeeDetails()
            {
                Name = "Liner3",
                Age = 30,
                Phone = 444
            }
            };

            //Save the value in SC
            ScenarioContext.Current.Add("EmpDetails", empDetails);

            //Get the value fro SC

            var empList = ScenarioContext.Current.Get<IEnumerable<EmployeeDetails>>("EmpDetails");
            foreach(EmployeeDetails emp in empList)
            {
                Console.WriteLine("The Emp Name is:" + emp.Name);
                Console.WriteLine("The Emp Age is:" + emp.Age);
                Console.WriteLine("The Emp Phone is:" + emp.Phone);
                Console.WriteLine("\n");
            }


        }
    }
}
