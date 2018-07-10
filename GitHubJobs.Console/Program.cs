using GitHubJobs.Core;
using GitHubJobs.Core.Data.Models.Incoming;
using GitHubJobs.Core.Data.Models.Outgoing;
using GitHubJobs.Core.Data.Repositiry.Impl;
using GitHubJobs.Core.Views;
using Ninject;
using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace GitHubJobs.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationStarter.Init();
            var ss = ApplicationStarter.AppKernel.Get<MainScreenViewModel>();

            //ss.GetJobs(new JobRequest { Description = "C#", FullTime = "true" }).Subscribe(onNext: (obj) =>
            //{
            //    foreach (JobDescription item in obj)
            //        System.Console.WriteLine(item);
            //});

            IObservable<int> sb = GetObservable();

            sb.Subscribe(onNext: arg => { System.Console.WriteLine(arg); });

            var vv = GetObservable();
            vv.Subscribe(onNext: arg => { System.Console.WriteLine(arg + "kekke"); });


            System.Console.ReadKey(true);
        }

        public static IObservable<int> GetObservable()
        {
            return Observable.Create<int>(async (arg) =>
            {
                await Task.Delay(1000);

                arg.OnNext(5);

                await Task.Delay(1000);

                arg.OnNext(7);

                await Task.Delay(5000);

                arg.OnNext(3);


                return Disposable.Empty;
            });
        }
    }
}
