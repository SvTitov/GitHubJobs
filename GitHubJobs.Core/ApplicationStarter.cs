using GitHubJobs.Core.NinjectModules;
using Ninject;
using System;

namespace GitHubJobs.Core
{
    public static class ApplicationStarter
	{
        private static Ninject.StandardKernel _kernel;

        public static void Init()
        {
            var settings = new Ninject.NinjectSettings() { LoadExtensions = false };
            _kernel = new Ninject.StandardKernel(settings: settings, modules: new CommonModule());
        }

        public static Ninject.StandardKernel AppKernel => _kernel;
    }
}