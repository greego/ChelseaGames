using Android.App;
using Android.OS;
using Android.Widget;
using FootballDataOrgDataSource;

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

            var data = new JsonFootballData();

            var textView = FindViewById<TextView>(Resource.Id.applicationText);
            textView.Text = string.Format("Chelsea's next game is at {0}, against {1}.", data.GetNextChelseaGameDate().ToLocalTime(), data.GetNextChelseaGameOpponent());
        }
    }
}

