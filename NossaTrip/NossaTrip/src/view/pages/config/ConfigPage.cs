using NossaTrip.global;
using NossaTrip.src.view.pages.login;
using NossaTrip.view.components;
using Xamarin.Forms;

namespace NossaTrip.view.pages.config
{
    public class ConfigPage : ContentPage
    {
        public ConfigPage()
        {
            BackgroundColor = ColorConstants.FeedBackground;

            var logOut = new Button
            {
                Margin = 20,
                FontSize = 20,
                TextColor = ColorConstants.TextColor,
                Text = FontAwsomeXamarin.FASignOut + "  Log out",
                FontFamily = FontAwsomeXamarin.GetFontName()
            };

            logOut.Clicked += LogOut_Clicked;

            Content = new StackLayout
            {
                Children = { logOut }
            };
        }

        private void LogOut_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new LoginPage());
        }
    }
}