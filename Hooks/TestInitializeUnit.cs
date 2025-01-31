using AppiumSpecFlowProject1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSpecFlowProject1.Hooks
{
    [TestFixture]
    public  class TestInitializeUnit : Base
    {


        [SetUp]
        public void TestInitializeTest()
        {
            AndroidContext = StartAppiumServerForHybdrid();

        }

        [TearDown]
        public void CleanUp()
        {

            AppiumUtilities.CloseAppiumServer();
        }
    }
}
