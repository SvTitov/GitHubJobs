using GitHubJobs.Core;
using GitHubJobs.Core.Data.Models.Incoming;
using GitHubJobs.Core.Data.Models.Outgoing;
using GitHubJobs.Core.Data.Repositiry.Impl;
using GitHubJobs.Core.Views;
using Ninject;
using System;
using System.Collections.Generic;

namespace GitHubJobs.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationStarter.Init();
            var ss = ApplicationStarter.AppKernel.Get<MainScreenViewModel>();

            ss.GetJobs(new JobRequest { Description = "C#", FullTime = "true" }).Subscribe(onNext: (obj) =>
            {
                foreach (JobDescription item in obj)
                    System.Console.WriteLine(item);
            });



            System.Console.ReadKey(true);
        }
    }
}
