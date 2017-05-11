using NossaTrip.view.components;
using Xamarin.Forms;

namespace NossaTrip.view.pages.place.components
{
    public class AddressCard : Frame
    {
        public AddressCard()
        {
            HasShadow = false;
            CornerRadius = 0;
            Padding = 15;
            Margin = 0;
            BackgroundColor = Color.FromHex("#323232");

            var contentLabel = new Label { TextColor = Color.White };
            var contentFs = new FormattedString();

            contentFs.Spans.Add(new Span { Text = FontAwsomeXamarin.FAMapMarker, FontSize = 20, FontFamily = FontAwsomeXamarin.GetFontName() });
            contentFs.Spans.Add(new Span { Text = "   Manguinhos, Serra, State of Espirito Santo, Brazil" });

            contentLabel.FormattedText = contentFs;
            Content = contentLabel;
        }
    }
}
