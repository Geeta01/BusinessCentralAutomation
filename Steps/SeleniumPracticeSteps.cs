using SpecflowNUNIT.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowNUNIT.Steps
{
    [Binding]
    class SeleniumPracticeSteps
    {
        SelPractice SelP;
        [Given(@"ImplicitWait")]
        public void GivenImplicitWait()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"ExplicitWait")]
        public void GivenExplicitWait()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
