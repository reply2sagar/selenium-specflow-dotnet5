using NUnit.Framework;
using selenium_nunit_spec.models;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace selenium_nunit_spec
{
    [Binding]
    public class SpecFlowFeature1Steps
    {

        string destom = "";

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
           // ScenarioCont.Current.Pending();
        }

        [Given(@"I entered the following data into the new account form:")]
        public void GivenIEnteredTheFollowingDataIntoTheNewAccountForm(Table table)
        {
            var account = table.CreateInstance<Account>();

        }

        [Given(@"I entered the following data into the new travel form:")]
        public void GivenIEnteredTheFollowingDataIntoTheNewTravelForm(Table table)
        {
            //  var travelData = table.CreateInstance<TravelData>();
            //  int a = 1;
            //

            //driver.findelement

            var travelData = TravelData.getSample();
            //travelData.returnDate = new DateTime().AddDays(-2);
            // travelData.destinations = new List<String> { "australia","india" };
           //  travelData


            // - removes duplication
            // - verification - state of application/ state of scenario
            Assert.AreEqual(travelData.,)

         }



        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
