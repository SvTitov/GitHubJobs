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

namespace GitHubJobs.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        private MainScreenViewModel _viewModel;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
                
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            _viewModel = ApplicationStarter.AppKernel.Get<MainScreenViewModel>();

            _viewModel.GetJobs(new JobRequest { Description = "C#", FullTime = "true" }).Subscribe(onNext: OnUpdateJobs);
        }

        private void OnUpdateJobs(IEnumerable<JobDescription> jobs)
        {
            
        }
    }
}

