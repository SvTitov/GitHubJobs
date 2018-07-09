using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace GitHubJobs.Droid.Lists.ViewHolders
{
    public class JobItemViewHolder : RecyclerView.ViewHolder
    {
        public TextView JobDesription;
        public TextView JobTitle;
        public TextView JobCompany;
        public TextView JobType;
        public TextView JobLocation;

        public JobItemViewHolder(View itemView) 
            : base(itemView)
        {
            JobDesription = itemView.FindViewById<TextView>(Resource.Id.job_description);
            JobTitle = itemView.FindViewById<TextView>(Resource.Id.job_title);
            JobCompany = itemView.FindViewById<TextView>(Resource.Id.job_company);
            JobType = itemView.FindViewById<TextView>(Resource.Id.job_type);
            JobLocation = itemView.FindViewById<TextView>(Resource.Id.job_location);
        }
    }
}