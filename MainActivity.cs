using Android.App;
using Android.Widget;
using Android.OS;

namespace Day_9_1_PopUpMenuDemo
{
    [Activity(Label = "Day_9_1_PopUpMenuDemo", MainLauncher = true)]
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

