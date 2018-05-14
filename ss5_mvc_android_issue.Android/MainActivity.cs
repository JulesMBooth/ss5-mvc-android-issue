using Android.App;
using Android.Widget;
using Android.OS;

namespace ss5_mvc_android_issue.Android
{
    [Activity(Label = "ss5_mvc_android_issue.Android", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

