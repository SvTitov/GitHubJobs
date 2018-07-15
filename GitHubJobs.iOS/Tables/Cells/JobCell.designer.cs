// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace GitHubJobs.iOS.Tables.Cells
{
    [Register ("JobCell")]
    partial class JobCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel JobCompany { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView JobDesription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel JobLocation { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel JobTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel JobType { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (JobCompany != null) {
                JobCompany.Dispose ();
                JobCompany = null;
            }

            if (JobDesription != null) {
                JobDesription.Dispose ();
                JobDesription = null;
            }

            if (JobLocation != null) {
                JobLocation.Dispose ();
                JobLocation = null;
            }

            if (JobTitle != null) {
                JobTitle.Dispose ();
                JobTitle = null;
            }

            if (JobType != null) {
                JobType.Dispose ();
                JobType = null;
            }
        }
    }
}