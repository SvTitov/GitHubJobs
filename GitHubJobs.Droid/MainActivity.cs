using Android.App;
using Android.OS;
using Android.Support.V7.App;
using GitHubJobs.Core.Views;
using GitHubJobs.Core;
using Ninject;
using System.Reactive.Linq;
using System;
using GitHubJobs.Core.Data.Models.Incoming;
using System.Collections.Generic;
using GitHubJobs.Core.NinjectModules;
using GitHubJobs.Core.Data.Models.Outgoing;
using GitHubJobs.Droid.Fragments;
using Android.Support.V7.Widget;
using Android.Views;

namespace GitHubJobs.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        Toolbar toolBar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
                
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            toolBar = FindViewById<Toolbar>(Resource.Id.app_toolbar);
            SetSupportActionBar(toolBar);
           
            SupportFragmentManager
                .BeginTransaction()
                .Replace(Resource.Id.fragment_container, new JobListFragment())
                .Commit();
        }
    }
}

