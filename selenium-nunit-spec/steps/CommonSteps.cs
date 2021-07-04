using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace selenium_nunit_spec
{
    [Binding]
    public class CommonSteps
    {


        [BeforeScenario]
        public void runBeforeScenario()
        {
            TestContext.Progress.WriteLine("Run before scenario");

        }

        [AfterScenario]
        public void runAfterScenario()
        {
            TestContext.Progress.WriteLine("Run after scenario");

        }
    }
}
