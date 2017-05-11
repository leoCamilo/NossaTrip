using Xamarin.Forms;

namespace NossaTrip.view.pages.place.components
{
    public class PlaceMainData : Grid
    {
        public PlaceMainData()
        {
            BackgroundColor = Color.FromHex("#323232");

            RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            var placeLabel = new Label
            {
                Text = "Praia de Manguinhos",
                FontSize = 19,
                TextColor = Color.White,
                Margin = new Thickness(15, 15, 0, 0)
            };

            var avaliationLabel = new Label
            {
                Text = "1,216 people liked this place",
                FontSize = 11,
                TextColor = Color.White,
                Margin = new Thickness(15, 0)
            };

            Children.Add(placeLabel, 0, 0);
            Children.Add(avaliationLabel, 0, 1);
        }
    }
}
