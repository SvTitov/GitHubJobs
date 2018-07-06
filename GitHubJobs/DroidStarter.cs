using Android.App;
using Android.OS;
using Android.Support.V7.App;
using GitHubJobs.Core;
using GitHubJobs.Droid;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GitHubJobs.Droid
{
    /// <summary>
    /// Good choice to replace Init logic to splash screen, but not now...
    /// </summary>
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class DroidStarter : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            ApplicationStarter.Init();

            StartActivity(typeof(MainActivity));
        }
    }
}