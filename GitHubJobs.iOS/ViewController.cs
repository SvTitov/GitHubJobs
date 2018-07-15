using System;
using GitHubJobs.Core;
using GitHubJobs.Core.Views;
using GitHubJobs.iOS.Tables.Sources;
using Ninject;
using UIKit;
using System.Reactive.Linq;
using System.Collections.Generic;
using GitHubJobs.Core.Data.Models.Incoming;
using GitHubJobs.Core.Data.Models.Outgoing;
using System.Linq;

namespace GitHubJobs.iOS
{
    public partial class ViewController : UIViewController
    {
        private IEnumerable<JobDescription> _jobs;
        private MainScreenViewModel _viewModel;
        private JobsTableSource _jobsSource;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _viewModel = ApplicationStarter.AppKernel.Get<MainScreenViewModel>();
            _viewModel.GetJobs(new JobRequest { Description = "C#", FullTime = "true" })
                      .Subscribe(onNext: OnReceiveData);

            this.tableView.TableFooterView = new UIView();
            this.tableView.Source = _jobsSource = new JobsTableSource(Enumerable.Empty<JobDescription>());
            this.tableView.NumberOfRowsInSection(1);
        }

        private void OnReceiveData(IEnumerable<JobDescription> jobs)
        {
            _jobs = jobs;
            _jobsSource.UpdateJobs(_jobs);

            InvokeOnMainThread(this.tableView.ReloadData);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
