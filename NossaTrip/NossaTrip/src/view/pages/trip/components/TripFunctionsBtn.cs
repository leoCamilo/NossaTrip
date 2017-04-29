using NossaTrip.view.components;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.components
{
    public class TripFunctionsBtn : Grid
    {
        private class BtnLabel : Label
        {
            public BtnLabel()
            {
                TextColor = Color.White;
                FontSize = 30;
                HorizontalTextAlignment = TextAlignment.Center;
                FontFamily = Device.OnPlatform("FontAwesome", "FontAwesome.ttf#FontAwesome", null);
            }
        }

        public TripFunctionsBtn()
        {
            Margin = new Thickness(0, 80, 0, 0);

            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var like = new BtnLabel { Text = FontAwsomeXamarin.FAHeartO };
            var share = new BtnLabel { Text = FontAwsomeXamarin.FAShareAlt };
            var favorite = new BtnLabel { Text = FontAwsomeXamarin.FAStarO };

            Children.Add(like, 0, 0);
            Children.Add(share, 1, 0);
            Children.Add(favorite, 2, 0);
        }
    }
}
