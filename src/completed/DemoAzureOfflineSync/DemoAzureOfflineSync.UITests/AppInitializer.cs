using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace DemoAzureOfflineSync.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.DeviceSerial("10.71.34.100:5555")
                    .ApkFile(@"C:\Users\rcervantes\Desktop\VSTS.DemoAzureOfflineSync\DemoAzureOfflineSync\Droid\bin\Release\demo.Droid.DemoAzureOfflineSync.apk").StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

