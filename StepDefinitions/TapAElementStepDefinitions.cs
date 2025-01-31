using AppiumSpecFlowProject1.Hooks;
using AppiumSpecFlowProject1.Pages;
using OpenQA.Selenium.Appium.Android;
using System;
using TechTalk.SpecFlow;

namespace AppiumSpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TapAElementStepDefinitions: TestInitializeUnit
    {
        ClickPage cp = new ClickPage((OpenQA.Selenium.Appium.Android.AndroidDriver)ScenarioContext.Current["androidContext"]);
  
        [Given(@"Launch the application")]
        public void GivenLaunchTheApplication()
        {
           
        }

        [When(@"User taps on the views element")]
        public void WhenUserTapsOnTheViewsElement()
        {


        }

        [Then(@"User is naviagted to views page")]
        public void ThenUserIsNaviagtedToViewsPage()
        {
            Console.WriteLine("User is navigated to views page");
        }

      

        [When(@"User taps on the radio group  element")]
        public void WhenUserTapsOnTheRadioGroupElement()
        {
            cp.HandlingRadioCheckboxes();
        }

        [Then(@"User clicks on the radio button")]
        public void ThenUserClicksOnTheRadioButton()
        {

            Console.WriteLine("User is has clicked on the radio button");

        }
    }
}
