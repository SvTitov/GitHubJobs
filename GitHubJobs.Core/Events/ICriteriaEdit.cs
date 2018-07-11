using GitHubJobs.Core.Data.Models.Outgoing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GitHubJobs.Core.Events
{
	public interface ICriteriaEdit
	{
        OnCriteriaSubmit OnSubmit { get; set; }
    }

    public delegate void OnCriteriaSubmit(JobRequest request);
}