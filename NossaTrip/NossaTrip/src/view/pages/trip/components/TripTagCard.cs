using System;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.components
{
    public class TripTagCard : Frame
    {
        private static Random _rnd = new Random();

        public TripTagCard(string tag)
        {
            var tag_label = new Label
            {
                Text = tag,
                TextColor = Color.FromHex("#ededed")
            };

            HasShadow = false;
            Margin = new Thickness(10, 0, 0, 0);
            Padding = 3;
            Content = tag_label;
            BackgroundColor = Color.FromRgb(_rnd.Next(100, 200), _rnd.Next(100, 200), _rnd.Next(100, 200));
            HorizontalOptions = LayoutOptions.Start;
        }
    }
}