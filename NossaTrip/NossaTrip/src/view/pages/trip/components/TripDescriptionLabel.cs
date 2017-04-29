using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.components
{
    public class TripDescriptionLabel : Label
    {
        public TripDescriptionLabel(string description)
        {
            Margin = new Thickness(0, 80, 0, 0);
            TextColor = Color.White;

            var desc_label_fs = new FormattedString();

            desc_label_fs.Spans.Add(
                new Span { Text = "description:\n\n", FontSize = 13 }
            );

            desc_label_fs.Spans.Add(
                new Span { Text = description, FontSize = 14 }
            );

            FormattedText = desc_label_fs;
        }
    }
}
