using System;
namespace GitHubJobs.Core.Data.Repositiry.Attributes
{
    public class FlurlPropertyAttribute : Attribute
    {
        public string ParamName { get; set; }
    }
}
