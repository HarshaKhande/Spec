using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSpecFlowProject1.Utilities
{
    public class AppiumUtillities
    {

        private AppiumLocalService _appiumLocalService;
        private AndroidDriver _androidDriver;


        public AppiumUtillities(AppiumLocalService appiumLocalService, AndroidDriver androidDriver)
        {
            _appiumLocalService = appiumLocalService;
            _androidDriver = androidDriver;
        }

        public AndroidDriver InitializeAndroidNativeApp()
        {


            var appPath = "C:\\Users\\Harsha Patil\\Documents\\Appium\\ApiDemos-debug.apk";

            var driverOptions = new AppiumOptions()
            {

                AutomationName = AutomationName.AndroidUIAutomator2,
                PlatformName = "Andriod",
                DeviceName = "ca1f79ac",
                // DeviceName = "emulator-5554",
            };

            // Desired capabilities 
            driverOptions.AddAdditionalAppiumOption("Application", appPath);
            driverOptions.AddAdditionalAppiumOption("noReset", true);

            AndroidDriver androidDriver = new AndroidDriver(_appiumLocalService, driverOptions, TimeSpan.FromSeconds(180));


            return androidDriver;
        }


        public AndroidDriver InitializeAndroidWebApp()
        {


            var appPath = "C:\\Users\\Harsha Patil\\Documents\\Appium\\ApiDemos-debug.apk";

            var driverOptions = new AppiumOptions()
            {

                AutomationName = AutomationName.AndroidUIAutomator2,
                PlatformName = "Andriod",
                DeviceName = "ca1f79ac",
                // DeviceName = "emulator-5554",
            };

            // Desired capabilities 
            driverOptions.AddAdditionalAppiumOption("Application", appPath);
            driverOptions.AddAdditionalAppiumOption("noReset", true);

            AndroidDriver androidDriver = new AndroidDriver(_appiumLocalService, driverOptions, TimeSpan.FromSeconds(180));

            List<string> AllContexts = new List<string>();
            foreach (var context in (androidDriver.Contexts))
            {
                Console.WriteLine(context);
            }

            var driv = androidDriver.Contexts.First(x => x.Contains("WEBVIEW_io.appium.android.apis"));
            androidDriver.Context = driv;

            return androidDriver;
        }


        public AppiumLocalService StartAppiumLocalService() {

            _appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();

            if (!_appiumLocalService.IsRunning)
                _appiumLocalService.Start();


            return _appiumLocalService;

        }


        public AppiumLocalService StartAppiumLocalService(int portNumber)
        {

            _appiumLocalService = new AppiumServiceBuilder().UsingPort(portNumber).Build();

            if (!_appiumLocalService.IsRunning)
                _appiumLocalService.Start();


            return _appiumLocalService;

        }

        public void CloseAppiumServer()
        {
            _appiumLocalService.Dispose();
           // _androidDriver.Close();

        }





    }

}
