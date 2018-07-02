using GitHubJobs.Core.Data.Models;
using System;
using System.Collections.Generic;

namespace GitHubJobs.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            GitHubJobs.Core.Data.Repositiry.RestWrapper wrapper = new Core.Data.Repositiry.RestWrapper(@"https://jobs.github.com/positions.json");

            //var ss = wrapper.ExecuteGet<List<JobDescription>>(new  { description = "xamarin" }).Result;
            var ss = wrapper.ExecuteGet<List<JobDescription>, Foo>(new Foo {Description = "xamarin" }).Result;
        }

        class Foo
        {
            public string Description { get; set; }
        }
    }
}
