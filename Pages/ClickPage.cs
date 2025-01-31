using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Interactions;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions;
using PointerInputDevice = OpenQA.Selenium.Appium.Interactions.PointerInputDevice;


namespace AppiumSpecFlowProject1.Pages
{
    public class ClickPage
    {

        public  AndroidDriver androidDriver;

        public ClickPage(AndroidDriver androidDriver)
        {

            PageFactory.InitElements(androidDriver, this);

        }

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@content-desc=\"Views\"]")]
        private IWebElement Views { get; set; }

        [FindsBy(How = How.ClassName, Using = "android.widget.TextView")]
        private IWebElement AllElements { get; set; }


        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@content-desc=\"Radio Group\"]")]
        private IWebElement Radio { get; set; }


        [FindsBy(How = How.XPath, Using = "//android.widget.RadioButton[@content-desc=\"Dinner\"]")]
        private IWebElement Dinner { get; set; }






        public void CLickViews()
        {

            Views.Click();
        }

        public void HandlingRadioCheckboxes()
        {

            ActionBuilder actionBuilder = new ActionBuilder();
            var touch = new PointerInputDevice(PointerKind.Touch, "finger");



            // add the actions move, tap , pause , up 

            IList<AppiumElement> els = androidDriver.FindElements((By)AllElements);

            var origin = els[14];
            var loc1 = origin.Location;
            var target = els[1];
            var loc2 = target.Location;

            actionBuilder.ClearSequences();

            // move to element
            actionBuilder.AddAction(touch.CreatePointerMove(origin, 0, 0, TimeSpan.FromMilliseconds(800)));
            // touch the element
            actionBuilder.AddAction(touch.CreatePointerDown(PointerButton.TouchContact));
            actionBuilder.AddAction(touch.CreatePause(TimeSpan.FromMilliseconds(800)));
            actionBuilder.AddAction(touch.CreatePointerMove(target, 0, 0, TimeSpan.FromMilliseconds(800)));
            actionBuilder.AddAction(touch.CreatePointerUp(PointerButton.TouchContact));

            var sequenceActions = actionBuilder.ToActionSequenceList();
            androidDriver.PerformActions(sequenceActions);

            IWebElement Radiogroup = androidDriver.FindElement((By)Radio);
            Radiogroup.Click();

            // scroll down or swipe 

            IWebElement dinnerradio = androidDriver.FindElement((By)Dinner);
            dinnerradio.Click();

        }






    }
}
