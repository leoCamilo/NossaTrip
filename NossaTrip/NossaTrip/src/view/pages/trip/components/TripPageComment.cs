using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.components
{
    public class TripPageComment : Grid
    {
        public TripPageComment(string comment)
        {
            Margin = new Thickness(20, 0);

            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) });
            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var avatar = new Image
            {
                Source = "http://www.lovemarks.com/wp-content/uploads/profile-avatars/default-avatar-tech-guy.png",
                HeightRequest = 40,
                WidthRequest = 40,
                Margin = 10,
                VerticalOptions = LayoutOptions.Start
            };

            var comment_label = new Label { TextColor = Color.White, Margin = new Thickness(0, 10, 0, 0) };
            var comment_label_fs = new FormattedString();

            comment_label_fs.Spans.Add(new Span { Text = "Leonardo Camilo ", FontSize = 14, FontAttributes = FontAttributes.Bold });
            comment_label_fs.Spans.Add(new Span { Text = comment, FontSize = 13, FontAttributes = FontAttributes.Italic, ForegroundColor = Color.FromHex("#EDEDED") });
            comment_label_fs.Spans.Add(new Span { Text = "\n\n10/02/2017", FontSize = 10 });
            comment_label.FormattedText = comment_label_fs;

            Children.Add(avatar, 0, 0);
            Children.Add(comment_label, 1, 0);
        }
    }
}
