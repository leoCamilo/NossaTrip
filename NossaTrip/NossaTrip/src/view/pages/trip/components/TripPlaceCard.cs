using NossaTrip.view.components;
using NossaTrip.view.pages.place;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.components
{
    public class TripPlaceCard : Grid
    {
        public TripPlaceCard(string place, string url)
        {
            BackgroundColor = Color.FromHex("#ededed");

            Margin = new Thickness(20, 0, 20, 30);
            RowSpacing = 1;

            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(70, GridUnitType.Absolute) });

            RowDefinitions.Add(new RowDefinition { Height = new GridLength(120, GridUnitType.Absolute) });
            RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            var img = new Image
            {
                Source = url,
                Aspect = Aspect.AspectFill
            };

            var likes = new Label
            {
                Text = FontAwsomeXamarin.FAHeartO + " 1,231",
                FontFamily = FontAwsomeXamarin.GetFontName(),
                Margin = 6,
                HorizontalTextAlignment = TextAlignment.End,
                FontSize = 15
            };

            var name = new Label
            {
                Text = place,
                Margin = 6
            };

            Children.Add(img, 0, 0);
            Children.Add(name, 0, 1);
            Children.Add(likes, 1, 1);

            SetColumnSpan(img, 2);

            var tgr = new TapGestureRecognizer();

            tgr.Tapped += (sender, e) =>
            {
                Navigation.PushModalAsync(new PlacePage());
            };

            GestureRecognizers.Add(tgr);
        }
    }
}
