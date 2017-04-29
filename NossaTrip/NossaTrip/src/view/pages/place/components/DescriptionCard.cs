using Xamarin.Forms;

namespace NossaTrip.view.pages.place.components
{
    public class DescriptionCard : Frame
    {
        public DescriptionCard()
        {
            Padding = 0;
            Margin = new Thickness(8, 4, 8, 4);

            var grid = new Grid
            {
                BackgroundColor = Color.FromHex("#dedede")
            };

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(30, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            var title_label = new Label
            {
                Text = "Description",
                VerticalOptions = LayoutOptions.Center,
                Margin = 5
            };

            var content_label = new Label
            {
                Text = "teste de texxto teste de texxto teste de texxtoteste de texxto teste de texxto teste de texxto teste de texxtoteste de texxtoteste de texxtoteste de texxtoteste de texxtoteste de texxtoteste de texxtoteste de texxtoteste de texxtoteste de texxtoteste de texxtoteste de texxtoteste de texxto",
                Margin = 5
            };

            grid.Children.Add(title_label, 0, 0);
            grid.Children.Add(content_label, 0, 1);

            Content = grid;
        }
    }
}
