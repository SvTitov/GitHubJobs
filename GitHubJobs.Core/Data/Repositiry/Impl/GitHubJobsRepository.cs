using GitHubJobs.Core.Data.Repositiry.Faces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GitHubJobs.Core.Data.Models;

namespace GitHubJobs.Core.Data.Repositiry.Impl
{
	public class GitHubJobsRepository : IGitHubJobsRepository
    {
        public string MainUrl => @"https://jobs.github.com/positions.json";

        //public IEnumerable<JobDescription> GetAllJobs()
        //{

        //}
    }
}