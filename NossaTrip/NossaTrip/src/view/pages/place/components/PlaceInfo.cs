using NossaTrip.view.components;
using Xamarin.Forms;

namespace NossaTrip.view.pages.place.components
{
    public class PlaceInfo : StackLayout
    {
        public PlaceInfo()
        {
            Spacing = 10;
            Padding = 15;

            BackgroundColor = Color.FromHex("#323232");

            var siteLabel = new Label { TextColor = Color.White };
            var siteFs = new FormattedString();

            siteFs.Spans.Add(new Span { Text = FontAwsomeXamarin.FAGlobe, FontSize = 20, FontFamily = FontAwsomeXamarin.GetFontName() });
            siteFs.Spans.Add(new Span { Text = "  www.manguinhosbeach.com" });

            siteLabel.FormattedText = siteFs;

            var phoneLabel = new Label { TextColor = Color.White };
            var phoneFs = new FormattedString();

            phoneFs.Spans.Add(new Span { Text = FontAwsomeXamarin.FAPhone, FontSize = 20, FontFamily = FontAwsomeXamarin.GetFontName() });
            phoneFs.Spans.Add(new Span { Text = "  (27) 99612-5988" });

            phoneLabel.FormattedText = phoneFs;

            Children.Add(siteLabel);
            Children.Add(phoneLabel);
        }
    }
}
