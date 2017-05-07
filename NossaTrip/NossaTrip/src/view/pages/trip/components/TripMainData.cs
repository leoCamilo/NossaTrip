using NossaTrip.control.controllers.trip;
using NossaTrip.view.components;
using System;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.components
{
    public class TripMainData : AbsoluteLayout
    {
        public Image Bg { get; internal set; }

        private class BtnLabel : Label
        {
            public BtnLabel()
            {
                TextColor = Color.White;
                FontSize = 30;
                Margin = new Thickness(0, 20, 0, 0);
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

        public TripMainData(string source)
        {
            var bg_opacity = new BoxView
            {
                Color = Color.Black,
                Opacity = 0.5
            };

            Bg = new Image { Source = source };

            var bgContainer = new Frame { Padding = 0, Content = Bg, HasShadow = false, CornerRadius = 0 };
            var grid = new Grid();

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            var fs = new FormattedString();
            
            var name = new Span
            {
                Text = "Best U.S.A Trip =)\n",
                ForegroundColor = Color.White,
                FontSize = 30
            };

            var address = new Span {
                Text = FontAwsomeXamarin.FAMapMarker + " New York, USA",
                FontFamily = FontAwsomeXamarin.GetFontName(),
                ForegroundColor = Color.White
            };

            fs.Spans.Add(name);
            fs.Spans.Add(address);

            var label = new Label { Margin = new Thickness(20, 0, 0, 0) };

            label.FormattedText = fs;

            var like = new BtnLabel { Text = FontAwsomeXamarin.FAHeartO };
            var share = new BtnLabel { Text = FontAwsomeXamarin.FAShareAlt };
            var favorite = new BtnLabel { Text = FontAwsomeXamarin.FAStarO };

            like.AddFunction(TripController.Like());
            share.AddFunction(TripController.Share());
            favorite.AddFunction(TripController.Favorite());

            grid.Children.Add(label, 0, 0);
            grid.Children.Add(like, 0, 1);
            grid.Children.Add(share, 1, 1);
            grid.Children.Add(favorite, 2, 1);

            Grid.SetColumnSpan(label, 3);

            HeightRequest = App.ScreenHeight;

            SetLayoutBounds(bgContainer, new Rectangle(0, 0, 1, 1));
            SetLayoutBounds(bg_opacity, new Rectangle(0, 0, 1, 1));
            SetLayoutBounds(grid, new Rectangle(0, 0.95, 1, 0.25));

            SetLayoutFlags(bgContainer, AbsoluteLayoutFlags.SizeProportional);
            SetLayoutFlags(bg_opacity, AbsoluteLayoutFlags.SizeProportional);
            SetLayoutFlags(grid, AbsoluteLayoutFlags.All);

            Children.Add(bgContainer);
            Children.Add(bg_opacity);
            Children.Add(grid);
        }
    }
}
