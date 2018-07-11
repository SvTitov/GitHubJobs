using System;
using System.Reactive.Linq;
using Android.App;
using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using GitHubJobs.Core;
using GitHubJobs.Core.Events;
using GitHubJobs.Core.Views;
using Ninject;

namespace GitHubJobs.Droid.Fragments
{
    public class JobCriteria : Android.Support.V4.App.DialogFragment, ICriteriaEdit
    {
        private MainScreenViewModel _viewModel;

        public OnCriteriaSubmit OnSubmit { get; set; }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            _viewModel = ApplicationStarter.AppKernel.Get<MainScreenViewModel>();
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var mainView = inflater.Inflate(Resource.Layout.job_criteria, container);
            var descr = mainView.FindViewById<EditText>(Resource.Id.description);
            var loc = mainView.FindViewById<EditText>(Resource.Id.location);
            var fullTime = mainView.FindViewById<CheckBox>(Resource.Id.fulltime);

            var btn = mainView.FindViewById<Button>(Resource.Id.submit);

            Observable.FromEventPattern<EventArgs>(btn, "Click").Subscribe(args => 
            {
                this.Dismiss();
                OnSubmit?.Invoke(new Core.Data.Models.Outgoing.JobRequest { Description = descr.Text, FullTime = fullTime.Checked.ToString(), Location = loc.Text });
            });

            return mainView;
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
            OnSubmit = null;
        }
    }
}
