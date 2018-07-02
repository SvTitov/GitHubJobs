using GitHubJobs.Core.Data.Repositiry.Faces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GitHubJobs.Core.Data.Models;
using GitHubJobs.Core.Data.Models.Incoming;
using GitHubJobs.Core.Data.Models.Outgoing;
using System.Threading.Tasks;

namespace GitHubJobs.Core.Data.Repositiry.Impl
{
	public class GitHubJobsRepository : IGitHubJobsRepository
    {
        RestWrapper _restWrapper;

        public string MainUrl => @"https://jobs.github.com/positions.json";

        public GitHubJobsRepository()
        {
            _restWrapper = new RestWrapper(MainUrl);
        }

        public async Task<IEnumerable<JobDescription>> GetAllJobs()
        {
            var result = await _restWrapper.ExecuteGet<List<JobDescription>, JobRequest>();
            return result;
        }

        public async Task<IEnumerable<JobDescription>> GetJobs(JobRequest request)
        {
            var result = await _restWrapper.ExecuteGet<List<JobDescription>, JobRequest>(request);
            return result;
        }
    }
}