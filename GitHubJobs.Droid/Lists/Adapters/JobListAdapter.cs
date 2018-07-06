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
using GitHubJobs.Core.Data.Models.Incoming;
using GitHubJobs.Droid.Lists.ViewHolders;

namespace GitHubJobs.Droid.Lists.Adapters
{
    public class JobListAdapter : RecyclerView.Adapter
    {
        private List<JobDescription> jobsList;

        public JobListAdapter(IEnumerable<JobDescription> jobsList)
        {
            this.jobsList = jobsList.ToList();
        }

        public override int ItemCount => jobsList.Count();

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            JobItemViewHolder vh = holder as JobItemViewHolder;
            vh.JobDesription.Text = jobsList[position].Description;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).
                Inflate(Resource.Layout.item_joblist, parent, false);

            JobItemViewHolder vh = new JobItemViewHolder(itemView);
            return vh;
        }

        public void UpdateData(IEnumerable<JobDescription> jobsList)
        {
            this.jobsList = jobsList.ToList();
            this.NotifyDataSetChanged();
        }
    }
}