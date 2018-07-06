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
            //    GitHubJobs.Core.Data.Repositiry.RestWrapper wrapper = new Core.Data.Repositiry.RestWrapper(@"https://jobs.github.com/positions.json");

            //MainScreenViewModel model = new MainScreenViewModel();
            //model._repository = new GitHubJobsRepository();

            //model.GetJobs(new JobRequest { Description = "C#", FullTime = "true" }).Subscribe(onNext: (obj) =>
            //{
            //    foreach (var item in obj)
            //        System.Console.WriteLine(item);
            //});

            ApplicationStarter.Init();
            var ss = ApplicationStarter.AppKernel.Get<MainScreenViewModel>();


            System.Console.ReadKey(true);
        }
    }
}
