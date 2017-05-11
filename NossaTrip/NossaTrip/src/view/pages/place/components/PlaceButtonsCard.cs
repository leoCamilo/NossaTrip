using NossaTrip.view.components;
using System;
using Xamarin.Forms;

namespace NossaTrip.view.pages.place.components
{
    public class PlaceButtonsCard : Grid
    {
        private class BtnLabel : Label
        {
            public BtnLabel()
            {
                TextColor = Color.White;
                FontSize = 30;
                Margin = new Thickness(0, 15, 0, 15);
                HorizontalTextAlignment = TextAlignment.Center;
                FontFamily = FontAwsomeXamarin.GetFontName();
            }

            public void AddFunction(EventHandler e)
            {
                var tgr = new TapGestureRecognizer();
                tgr.Tapped += e;
                GestureRecognizers.Add(tgr);
            }
        }

        public PlaceButtonsCard()
        {
            BackgroundColor = Color.FromHex("#323232");

            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var like = new BtnLabel { Text = FontAwsomeXamarin.FAThumbsOUp };
            var share = new BtnLabel { Text = FontAwsomeXamarin.FAShareAlt };

            Children.Add(like, 0, 0);
            Children.Add(share, 1, 0);
        }
    }
}
