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
                BackgroundColor = Color.FromHex("#dedede"),
                ColumnSpacing = 0,
                RowSpacing = 0
            };

            var card = new CardView
            {
                Margin = new Thickness(15, 12, 15, 0),
                HeightRequest = 210,
                CornerRadius = 10,
                Padding = 0
            };

            var avaliation = new BoxView { Color = Color.FromHex("#52a43a") };

            var avatar = new Image
            {
                HeightRequest = 40,
                WidthRequest = 40,
                Margin = 10
            };

            var trip_label = new Label
            {
                VerticalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(10, 0, 10, 0)
            };

            var trip_label_fs = new FormattedString();
            var trip_span = new Span { Text = "Best trip USA ever!!", FontSize = 14 };
            trip_label_fs.Spans.Add(new Span { Text = "description:\n", FontSize = 10 });
            trip_label_fs.Spans.Add(trip_span);
            trip_label.FormattedText = trip_label_fs;

            var name_label = new Label
            {
                FontSize = 14,
                VerticalTextAlignment = TextAlignment.Center
            };

            var time_label = new Label
            {
                FontSize = 11,
                Margin = new Thickness(10, 0, 0, 0),
                VerticalTextAlignment = TextAlignment.Center
            };

            var address_label = new Label
            {
                Margin = new Thickness(10, 0, 0, 0),
                VerticalTextAlignment = TextAlignment.Center
            };

            var address_label_fs = new FormattedString();
            address_label_fs.Spans.Add(new Span { Text = "place:\n", FontSize = 10 });
            address_label_fs.Spans.Add(new Span { Text = Place, FontSize = 14 });
            address_label.FormattedText = address_label_fs;

            var paid_label = new Label
            {
                Margin = new Thickness(15, 0, 0, 0),
                VerticalTextAlignment = TextAlignment.Center
            };

            var paid_label_fs = new FormattedString();
            paid_label_fs.Spans.Add(new Span { Text = "trip value:\n", FontSize = 10 });
            paid_label_fs.Spans.Add(new Span { Text = "U$ 2.500,00", FontSize = 12 });
            paid_label.FormattedText = paid_label_fs;

            var liked_label = new Label
            {
                FontSize = 11,
                Margin = new Thickness(10, 0, 0, 0),
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };

            var tags_label = new Label
            {
                Margin = new Thickness(10, 0, 0, 0),
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };

            var tags_label_fs = new FormattedString();
            tags_label_fs.Spans.Add(new Span { Text = "trip tags:\n", FontSize = 10 });
            tags_label_fs.Spans.Add(new Span { Text = "Praia, Dunas, Nordeste", FontSize = 11 });
            tags_label.FormattedText = tags_label_fs;

            avatar.SetBinding(Image.SourceProperty, "Url");
            name_label.SetBinding(Label.TextProperty, "Name");
            time_label.SetBinding(Label.TextProperty, "Time");
            liked_label.SetBinding(Label.TextProperty, "Likes");

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(10, GridUnitType.Absolute) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(50, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(50, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(50, GridUnitType.Absolute) });

            grid.Children.Add(avaliation, 0, 0);
            grid.Children.Add(avatar, 1, 0);
            grid.Children.Add(name_label, 2, 0);
            grid.Children.Add(time_label, 4, 0);
            grid.Children.Add(trip_label, 1, 1);
            grid.Children.Add(address_label, 1, 2);
            grid.Children.Add(paid_label, 3, 2);
            grid.Children.Add(liked_label, 1, 3);
            grid.Children.Add(tags_label, 3, 3);

            Grid.SetRowSpan(avaliation, 4);
            Grid.SetColumnSpan(name_label, 2);
            Grid.SetColumnSpan(trip_label, 4);
            Grid.SetColumnSpan(address_label, 2);
            Grid.SetColumnSpan(paid_label, 2);
            Grid.SetColumnSpan(liked_label, 2);
            Grid.SetColumnSpan(tags_label, 2);

            card.Content = grid;
            View = card;
        }
    }
}
