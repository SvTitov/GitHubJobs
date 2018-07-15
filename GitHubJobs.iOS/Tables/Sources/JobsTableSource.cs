using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using GitHubJobs.Core.Data.Models.Incoming;
using GitHubJobs.iOS.Tables.Cells;
using UIKit;

namespace GitHubJobs.iOS.Tables.Sources
{
    public class JobsTableSource : UITableViewSource
    {
        private List<JobDescription> jobsList;
        private const string CELL_IDENTIFER = "job_cell";

        public JobsTableSource(IEnumerable<JobDescription> jobsList)
        {
            this.jobsList = jobsList.ToList();
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(CELL_IDENTIFER, indexPath) as JobCell;
            var job = jobsList[indexPath.Row];

            if (cell == null)
                cell = new JobCell(UITableViewCellStyle.Default, CELL_IDENTIFER);
            
            cell.UpdateCell(job);

            return cell; 
        }

        public void UpdateJobs(IEnumerable<JobDescription> jobsList)
        {
            this.jobsList = jobsList.ToList();
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return jobsList.Count;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            //return UITableView.AutomaticDimension;
            return (nfloat) 220;
        }
    }
}
