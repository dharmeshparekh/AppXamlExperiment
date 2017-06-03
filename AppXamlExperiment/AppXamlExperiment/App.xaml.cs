using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Xamarin.Forms;

namespace AppXamlExperiment
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppXamlExperiment.MainPage();
        }

        protected override void OnStart()
        {
            MobileCenter.Start("android=5c6670b8-cac0-4952-872c-3b31e156beaa;" +
                   "uwp={Your UWP App secret here};" +
                   "ios={Your iOS App secret here}",
                   typeof(Analytics), typeof(Crashes));
            MobileCenterLog.Info("Info", "Application started");
            Crashes.Enabled = true;
            Analytics.TrackEvent("Start");

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
