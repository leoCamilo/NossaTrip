using NossaTrip.view.components;
using Xamarin.Forms;

namespace NossaTrip.view.pages.basepage.components
{
    public class MenuListCell : ViewCell
    {
        public MenuListCell()
        {
            var label = new Label
            {
                FontFamily = FontAwsomeXamarin.GetFontName(),
                FontSize = 16,
                TextColor = Color.White,
                Margin = new Thickness(10, 0, 0, 0),
                VerticalTextAlignment = TextAlignment.Center
            };

            label.Text = FontAwsomeXamarin.FAAdjust + " option";
            label.SetBinding(Label.TextProperty, "Text");

            View = label;
        }
    }
}
