using Android.App;
using Android.OS;

namespace NossaTrip.Droid
{
    [
        Activity(
            Theme = "@style/Theme.Splash",  // Indicates the theme to use for this activity
            MainLauncher = true,            // Set it as boot activity
            NoHistory = true                // Doesn't place it in back stack
        )
    ]

    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.StartActivity(typeof(MainActivity));
        }
    }
}