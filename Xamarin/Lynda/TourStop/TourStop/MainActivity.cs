using Android.App;
using Android.Widget;
using Android.OS;

namespace TourStop
{
    [Activity(Label = "TourStop", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            Button btn = FindViewById<Button>(Resource.Id.button);

            int count = 1;

            btn.Click += delegate { btn.Text = string.Format($"{count} clicks!", count++); };
        }
    }
}

