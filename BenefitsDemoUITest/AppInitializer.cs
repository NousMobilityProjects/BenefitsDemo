using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace BenefitsDemoUITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.InstalledApp("com.info.BenefitsDemo").StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}