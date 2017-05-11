using NossaTrip.src.view.pages.login;
using NossaTrip.view.pages.basepage;
using Xamarin.Forms;

namespace NossaTrip
{
    public class App : Application
    {
        public static double ScreenWidth { get; set; }
        public static double ScreenHeight { get; set; }

        public App()
        {
            // MainPage = new LoginPage();
            MainPage = new NavigationPage(new BasePage { Title = "NossaTrip" });
            // MainPage = new PlacePage();
        }

        public void GetIn()
        {
            MainPage = new NavigationPage(new BasePage { Title = "NossaTrip" });
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