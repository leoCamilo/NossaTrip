using NossaTrip.global;
using NossaTrip.view.components;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.insert.components
{
    public class AddPlaceLabelInstruction : Label
    {
        public AddPlaceLabelInstruction()
        {
            Margin = 20;
            TextColor = ColorConstants.TextColor;
            VerticalOptions = LayoutOptions.Center;
            HorizontalOptions = LayoutOptions.Center;
            HorizontalTextAlignment = TextAlignment.Center;

            var fs = new FormattedString();

            fs.Spans.Add(new Span { Text = FontAwsomeXamarin.FAMapMarker, FontSize = 40, FontFamily = FontAwsomeXamarin.GetFontName() });
            fs.Spans.Add(new Span { Text = "\n\nAdd places where you've been, double tap to delete. =)" });

            FormattedText = fs;
        }
    }
}
