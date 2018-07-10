using GitHubJobs.Core.Data.Models.Incoming;
using GitHubJobs.Core.Data.Repositiry.Faces;
using System.Reactive.Linq;
using System.Collections.Generic;
using System.Reactive.Concurrency;
using GitHubJobs.Core.Data.Models.Outgoing;
using System;
using System.Reactive.Disposables;

namespace GitHubJobs.Core.Views
{
    public class MainScreenViewModel
    {
        public IGitHubJobsRepository _repository;

        public MainScreenViewModel(IGitHubJobsRepository repository)
        {
            this._repository = repository;
        }

        public IObservable<IEnumerable<JobDescription>> GetJobs(JobRequest request)
        {
            return Observable.Create<IEnumerable<JobDescription>>(observer =>
                            Scheduler.Schedule(scheduler: Scheduler.Default,
                                               action: async () =>
                                               {
                                                   var result = await _repository.GetJobs(request);
                                                   observer.OnNext(result);
                                                   observer.OnCompleted();
                                               }));

        }
    }
}
