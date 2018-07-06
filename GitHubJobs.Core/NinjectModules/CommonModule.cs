using GitHubJobs.Core.Data.Repositiry.Faces;
using GitHubJobs.Core.Data.Repositiry.Impl;
using GitHubJobs.Core.Views;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHubJobs.Core.NinjectModules
{
    public class CommonModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IGitHubJobsRepository>().To<GitHubJobsRepository>();
            Bind<MainScreenViewModel>().ToSelf().InSingletonScope();
        }
    }
}