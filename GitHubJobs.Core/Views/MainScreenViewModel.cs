using System;
using System.Reactive;
using GitHubJobs.Core.Data.Models.Incoming;
using GitHubJobs.Core.Data.Repositiry.Faces;
using System.Reactive.Linq;
using System.Collections.Generic;

namespace GitHubJobs.Core.Views
{
    public class MainScreenViewModel
    {
        public IObservable<JobDescription> Jobs { get; set; }

        public async void GetJobs()
        {
            IGitHubJobsRepository repository = null;
            IEnumerable<JobDescription> result = await repository.GetAllJobs();
            IObservable<JobDescription> casted = result.ToObservable();

            Jobs = casted;
        }
    }
}
