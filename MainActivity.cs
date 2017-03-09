using Android.App;
using Android.OS;

namespace Login
{
    [Activity(Label = "Login", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            Android.Widget.Button botaoSignEmail = FindViewById<Android.Widget.Button>(Resource.Id.button2);
            botaoSignEmail.Click += delegate
            {
                var transaction = FragmentManager.BeginTransaction();
                var dialogFragment = new Fragment1();
                dialogFragment.Show(transaction, "dialog_fragment");
                //StartActivity(typeof(Activity1));
            };
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

