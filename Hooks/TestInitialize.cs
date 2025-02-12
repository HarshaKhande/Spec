﻿using AppiumSpecFlowProject1.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSpecFlowProject1.Hooks
{

    [Binding]
    public partial class TestInitialize : Base
    {
        [BeforeScenario]
        public void TestInitializeTest()
        {



            AndroidContext = StartAppiumServerForHybdrid();

            ScenarioContext.Current["androidContext"] = AndroidContext;

        }


        [AfterScenario]
        public void CleanUp()
        {

            AppiumUtilities.CloseAppiumServer();


        }


    }
}
