﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Flurl;
using Flurl.Http;
using GitHubJobs.Core.Data.Repositiry.Attributes;

namespace GitHubJobs.Core.Data.Repositiry.Extensions
{
	public static class FlurlExtension 
	{
        public static Url SetQueryModel<TType>(this IFlurlRequest url, TType model)
        {
            var properties = model.GetType().GetProperties();

            Dictionary<string, object> dict = new Dictionary<string, object>();
            foreach (var prop in properties)
            {
                var name  = prop.Name.ToLower();
                var value = prop.GetValue(model, null);
                var attrs = prop.GetCustomAttributes(false);

                foreach (var item in attrs)
                {
                    if (item is FlurlPropertyAttribute castedItem)
                        name = castedItem.ParamName;
                }

                if (value != null)
                    dict.Add(name, value);
            }

            return new Url(url.Url).SetQueryParams(dict);
        }
	}
}