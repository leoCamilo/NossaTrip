using NossaTrip.view.pages;
using NossaTrip.view.pages.feed;
using NossaTrip.view.pages.trip;
using Xamarin.Forms;

namespace NossaTrip
{
    public class App : Application
    {
        public static double ScreenWidth { get; set; }
        public static double ScreenHeight { get; set; }

        public App()
        {
            MainPage = new NavigationPage(new FeedPage { Title = "NossaTrip" });
            // MainPage = new NavigationPage(new TripPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}