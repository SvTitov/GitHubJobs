// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace GitHubJobs.iOS
{
    [Register ("CriteriaController")]
    partial class CriteriaController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField description { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch isFullTime { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField location { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton submit { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (description != null) {
                description.Dispose ();
                description = null;
            }

            if (isFullTime != null) {
                isFullTime.Dispose ();
                isFullTime = null;
            }

            if (location != null) {
                location.Dispose ();
                location = null;
            }

            if (submit != null) {
                submit.Dispose ();
                submit = null;
            }
        }
    }
}