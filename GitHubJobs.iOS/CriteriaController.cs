using Foundation;
using GitHubJobs.Core.Data.Models.Outgoing;
using GitHubJobs.Core.Events;
using System;
using UIKit;

namespace GitHubJobs.iOS
{
    public partial class CriteriaController : UIViewController, ICriteriaEdit, IUITextFieldDelegate
    {
        public CriteriaController (IntPtr handle) : base (handle)
        {
        }


        public OnCriteriaSubmit OnSubmit { get; set; }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.description.Delegate = this;
            this.location.Delegate = this;

            this.submit.TouchUpInside += OnSubmitClick;
        }

        [Export("textFieldShouldReturn:")]
        public bool ShouldReturn(UITextField textField)
        {
            textField.ResignFirstResponder();
            return true;
        }

        void OnSubmitClick(object sender, EventArgs e)
        {
            var jobReq = new JobRequest
            {
                Description = this.description.Text,
                FullTime = this.isFullTime.On.ToString(),
                Location = this.location.Text
            };

            DismissModalViewController(true);
            OnSubmit?.Invoke(jobReq);
        }
    }
}