using NossaTrip.global;
using NossaTrip.view.components;
using Xamarin.Forms;

namespace NossaTrip.view.pages.feed.components
{
    public class FeedListCell : ViewCell
    {
        public static readonly BindableProperty PlaceProperty = BindableProperty.Create("Place", typeof(string), typeof(FeedListCell), "");

        public string Place
        {
            get { return (string) GetValue(PlaceProperty); }
            set { SetValue(PlaceProperty, value); }
        }

        public FeedListCell()
        {
            SetBinding(PlaceProperty, new Binding("TripPlace"));

            var grid = new Grid
            {
                BackgroundColor = ColorConstants.FeedCard,
                ColumnSpacing = 0,
                RowSpacing = 0
            };

            var card = new CardView
            {
                Margin = new Thickness(15, 12, 15, 0),
                CornerRadius = 10,
                Padding = 0
            };

            var avaliation = new BoxView();

            var avatar = new Image
            {
                HeightRequest = 40,
                WidthRequest = 40,
                Margin = 10
            };

            var name_label = new Label
            {
                FontSize = 14,
                TextColor = ColorConstants.TextColor,
                VerticalTextAlignment = TextAlignment.Center
            };

            var time_label = new Label
            {
                FontSize = 11,
                TextColor = ColorConstants.TextColor,
                Margin = new Thickness(10, 0, 0, 0),
                VerticalTextAlignment = TextAlignment.Center
            };

            var trip_label = new Label
            {
                FontSize = 22,
                Margin = new Thickness(15, 10, 10, 0),
                TextColor = ColorConstants.TextColor,
                FontFamily = FontAwsomeXamarin.GetKhulaFontName(true),
                VerticalTextAlignment = TextAlignment.End,
            };

            var address_label = new Label
            {
                Margin = new Thickness(15, 5, 10, 10),
                TextColor = ColorConstants.TextColor,
                FontFamily = FontAwsomeXamarin.GetFontName(),
                VerticalTextAlignment = TextAlignment.Start
            };

            avatar.SetBinding(Image.SourceProperty, "Url");
            name_label.SetBinding(Label.TextProperty, "UserName");
            trip_label.SetBinding(Label.TextProperty, "TripName");
            time_label.SetBinding(Label.TextProperty, "Time");
            address_label.SetBinding(Label.TextProperty, "TripPlace");
            avaliation.SetBinding(BoxView.ColorProperty, "AvaliationColor");

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(10, GridUnitType.Absolute) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });

            grid.Children.Add(avaliation, 0, 0);
            grid.Children.Add(avatar, 1, 0);
            grid.Children.Add(name_label, 2, 0);
            grid.Children.Add(time_label, 4, 0);
            grid.Children.Add(trip_label, 1, 1);
            grid.Children.Add(address_label, 1, 2);

            Grid.SetRowSpan(avaliation, 4);
            Grid.SetColumnSpan(name_label, 2);
            Grid.SetColumnSpan(trip_label, 4);
            Grid.SetColumnSpan(address_label, 4);

            card.Content = grid;
            View = card;
        }
    }
}
