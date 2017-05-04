using Android.App;
using Android.Content.PM;
using Android.OS;

namespace NossaTrip.Droid
{
    [
        Activity
        (
            Label = "NossaTrip",
            Icon = "@drawable/icon",
            Theme = "@style/MainTheme",
            ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation
        )
    ]

    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            var width = Resources.DisplayMetrics.WidthPixels;
            var height = Resources.DisplayMetrics.HeightPixels;
            var density = Resources.DisplayMetrics.Density;

            App.ScreenWidth = (width - 0.5f) / density;
            App.ScreenHeight = (height - 0.5f) / density;

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

