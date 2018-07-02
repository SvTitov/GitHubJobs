using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitHubJobs.Core.Data.Models.Incoming;
using GitHubJobs.Core.Data.Models.Outgoing;

namespace GitHubJobs.Core.Data.Repositiry.Faces
{
	public interface IGitHubJobsRepository 
	{
        Task<IEnumerable<JobDescription>> GetAllJobs();
        Task<IEnumerable<JobDescription>> GetJobs(JobRequest request);
	}
}