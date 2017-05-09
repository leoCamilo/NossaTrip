using Xamarin.Forms;

namespace NossaTrip.view.pages.basepage.components
{
    public class ProfileGrid : Grid
    {
        public ProfileGrid()
        {
            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
            RowDefinitions.Add(new RowDefinition { Height = new GridLength(100, GridUnitType.Absolute) });

            var name = new Label { VerticalTextAlignment = TextAlignment.Center };
            var name_fs = new FormattedString();

            name_fs.Spans.Add(new Span { Text = "Oi Leonardo!\n", FontSize = 18, ForegroundColor = Color.White });
            name_fs.Spans.Add(new Span { Text = "@leonardo", FontSize = 16, ForegroundColor = Color.Gray });

            name.FormattedText = name_fs;

            var avatar = new Image
            {
                Source = "http://www.lovemarks.com/wp-content/uploads/profile-avatars/default-avatar-tech-guy.png",
                Margin = 10
            };

            Children.Add(avatar, 0, 0);
            Children.Add(name, 1, 0);
        }
    }
}
