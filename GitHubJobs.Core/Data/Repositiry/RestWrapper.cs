using Flurl.Http;
using Flurl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitHubJobs.Core.Data.Repositiry.Extensions;

namespace GitHubJobs.Core.Data.Repositiry
{
	public class RestWrapper 
	{
        private readonly string _url;

        public RestWrapper(string url)
        {
            this._url = url;
        }

        public async Task<TType> ExecuteGet<TType, TArg>(TArg value = null) 
            where TArg : class
        {
            return await _url
                .AllowAnyHttpStatus()
                .SetQueryModel<TArg>(value)
                .GetJsonAsync<TType>();
        }
	}
}