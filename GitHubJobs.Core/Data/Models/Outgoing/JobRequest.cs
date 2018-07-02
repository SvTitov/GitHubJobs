using System;
using GitHubJobs.Core.Data.Repositiry.Attributes;

namespace GitHubJobs.Core.Data.Models.Outgoing
{
    public class JobRequest
    {
        public string Description { get; set; }
        public string Location { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }

        [FlurlProperty(ParamName = "full_time")]
        public string FullTime { get; set; }
    }
}
