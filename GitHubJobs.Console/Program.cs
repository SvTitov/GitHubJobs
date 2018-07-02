using GitHubJobs.Core.Data.Models.Incoming;
using GitHubJobs.Core.Data.Models.Outgoing;
using System;
using System.Collections.Generic;

namespace GitHubJobs.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            GitHubJobs.Core.Data.Repositiry.RestWrapper wrapper = new Core.Data.Repositiry.RestWrapper(@"https://jobs.github.com/positions.json");

            var ss = wrapper.ExecuteGet<List<JobDescription>, JobRequest>(new JobRequest{Description = "xamarin", FullTime = "true"} ).Result;
        }
    }
}
