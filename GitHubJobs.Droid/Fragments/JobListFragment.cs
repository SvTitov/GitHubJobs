using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using GitHubJobs.Core;
using GitHubJobs.Core.Data.Models.Outgoing;
using GitHubJobs.Core.Views;
using System.Reactive.Linq;
using Ninject;
using GitHubJobs.Core.Data.Models.Incoming;
using Android.Support.V7.Widget;
using GitHubJobs.Droid.Lists.Adapters;

namespace GitHubJobs.Droid.Fragments
{
    public class JobListFragment : Android.Support.V4.App.Fragment
    {
        private MainScreenViewModel _viewModel;
        private IEnumerable<JobDescription> _jobs = new List<JobDescription>();
        private JobListAdapter _jobListAdapter;
        private ProgressBar _progressDialog;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            _viewModel = ApplicationStarter.AppKernel.Get<MainScreenViewModel>();

            _viewModel.GetJobs(new JobRequest { Description = "C#", FullTime = "true" })
                      .Subscribe(onNext: OnUpdateJobs, onCompleted: HideLoadingIndicator);
        }

        private void ShowLoadingIndicator()
        {
            _progressDialog.Visibility = ViewStates.Visible;
            this.Activity.Window.SetFlags(WindowManagerFlags.NotTouchable, WindowManagerFlags.NotTouchable);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var mainView = inflater.Inflate(Resource.Layout.fragment_joblist, container, false);
            _progressDialog = mainView.FindViewById<ProgressBar>(Resource.Id.loadingIndicator);

            ShowLoadingIndicator();

            var recycler = mainView.FindViewById<RecyclerView>(Resource.Id.jobs_list);
            var llManager = new LinearLayoutManager(this.Context);
            llManager.Orientation = LinearLayoutManager.Vertical;

            recycler.SetLayoutManager(llManager);

            _jobListAdapter = new JobListAdapter(_jobs);
            recycler.SetAdapter(_jobListAdapter);

            return mainView;
        }

        private void HideLoadingIndicator()
        {
            this.Activity.RunOnUiThread(() => 
            {
                _progressDialog.Visibility = ViewStates.Gone;
                this.Activity.Window.ClearFlags(WindowManagerFlags.NotTouchable);
            });
        }


        private void OnUpdateJobs(IEnumerable<JobDescription> jobs)
        {
            _jobs = jobs;
            this.Activity.RunOnUiThread(() => _jobListAdapter.UpdateData(_jobs));
        }
    }
}