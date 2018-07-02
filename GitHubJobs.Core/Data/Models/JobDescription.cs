using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GitHubJobs.Core.Data.Models
{
    public class JobDescription
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("how_to_apply")]
        public string HowToApply { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("company_url")]
        public string CompanyUrl { get; set; }

        [JsonProperty("company_logo")]
        public string CompanyLogo { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}