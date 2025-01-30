using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;

namespace AppiumSpecFlowProject1.Utilities
{
    public  class Base
    {
        public AppiumLocalService AppiumServiceContext;
        public static AndroidDriver AndroidContext;

        public AppiumUtillities AppiumUtilities => new AppiumUtillities(AppiumServiceContext, AndroidContext);

        public AndroidDriver StartAppiumServerForHybdrid()
        {
            AppiumServiceContext = AppiumUtilities.StartAppiumLocalService();
            AndroidContext = AppiumUtilities.InitializeAndroidNativeApp();
            return AndroidContext;




        }



    }
}
