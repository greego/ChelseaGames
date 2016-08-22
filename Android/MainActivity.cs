using Android.App;
using Android.OS;
using Android.Widget;
using FootballDataOrgDataSource;
using NextGame;

namespace NextGameAndroid
{
    [Activity(Label = "Next Game", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            FindViewById<TextView>(Resource.Id.applicationText).Text = (new NextGameFormattedString(new JsonFootballData()).GetNextGameInfo());
        }
    }
}

