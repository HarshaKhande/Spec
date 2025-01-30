using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;


namespace AppiumSpecFlowProject1.Pages
{
    public class ClickPage
    {

        public ClickPage(AndroidDriver androidDriver)
        {

            PageFactory.InitElements(androidDriver, this);

        }

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@content-desc=\"Views\"]")]
        private IWebElement Views { get; set; }



        public void CLickViews()
        {

            Views.Click();
        }






    }
}
