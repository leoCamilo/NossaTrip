using NossaTrip.global;
using NossaTrip.view.components;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.insert.components
{
    public class UploadImgLabelInstruction : Label
    {
        public UploadImgLabelInstruction()
        {
            Margin = 20;
            TextColor = ColorConstants.TextColor;
            VerticalOptions = LayoutOptions.Center;
            HorizontalOptions = LayoutOptions.Center;
            HorizontalTextAlignment = TextAlignment.Center;

            var fs = new FormattedString();

            fs.Spans.Add(new Span { Text = FontAwsomeXamarin.FACamera, FontSize = 40, FontFamily = FontAwsomeXamarin.GetFontName() });
            fs.Spans.Add(new Span { Text = "\n\nAdd photos you took, double tap to delete. =)" });

            FormattedText = fs;
        }
    }
}
