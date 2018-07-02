using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using GitHubJobs.Core.Views;

namespace GitHubJobs
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        MainScreenViewModel mainScreenViewModel = new MainScreenViewModel();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //mainScreenViewModel.Jobs.Su
        }
    }
}

