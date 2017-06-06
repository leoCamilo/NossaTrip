using NossaTrip.global;
using NossaTrip.view.components;
using NossaTrip.view.pages.trip.insert.components;
using System;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.insert
{
    public class NewTripPage : ContentPage
    {
        public NewTripPage()
        {
            BackgroundColor = ColorConstants.NewTripBackground;

            var saveBtn = new ToolbarItem { Icon = ImgConstants.Next };
            var grid = new Grid { Padding = 20 };

            saveBtn.Clicked += (sender, e) => Navigation.PushAsync(new UploadImgPage());
            ToolbarItems.Add(saveBtn);

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) });

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(20, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(20, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(20, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(20, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(200, GridUnitType.Absolute) });


            var descEditor = new Editor { TextColor = ColorConstants.NewTripFontColor };
            var placeEntry = new NewTripEntry();
            var nameEntry = new NewTripEntry();
            var newTagEntry = new NewTripEntry();

            var newTagBtn = new Button
            {
                FontSize = 20,
                TextColor = ColorConstants.NewTripFontColor,
                FontFamily = FontAwsomeXamarin.GetFontName(),
                Text = FontAwsomeXamarin.FAPlusCircle
            };

            var tagStack = new StackLayout { Orientation = StackOrientation.Horizontal };
            var tagStackScroll = new ScrollView { Orientation = ScrollOrientation.Horizontal, Content = tagStack };

            newTagBtn.Clicked += (sender, e) =>
            {
                var _rnd = new Random();
                var color = Color.FromRgb(_rnd.Next(100, 200), _rnd.Next(100, 200), _rnd.Next(100, 200));
                tagStack.Children.Add(new NewTripTag { Text = newTagEntry.Text, BackgroundColor = color });
                newTagEntry.Text = "";
            };

            /*
            var photoBtn = new Button
            {
                FontSize = 40,
                TextColor = Color.White,
                Text = FontAwsomeXamarin.FACamera,
                FontFamily = FontAwsomeXamarin.GetFontName()
            };

            photoBtn.Clicked += async (sender, e) => 
            {
                if (!CrossMedia.Current.IsPickPhotoSupported)
                    return;

                var photo = await CrossMedia.Current.PickPhotoAsync();

                if (photo == null)
                    return;

                var image = new Image
                {
                    Source = ImageSource.FromStream(() =>
                    {
                        var stream = photo.GetStream();
                        photo.Dispose();
                        return stream;
                    })
                };

                photoBtn.IsVisible = false;
                grid.Children.Add(image, 0, 0);
            };
            */

            grid.Children.Add(new Label { TextColor = Color.White, Text = "trip name:" }, 0, 0);
            grid.Children.Add(nameEntry, 0, 1);
            grid.Children.Add(new Label { TextColor = Color.White, Text = "trip location:" }, 0, 2);
            grid.Children.Add(placeEntry, 0, 3);
            grid.Children.Add(new Label { TextColor = Color.White, Text = "trip tags:" }, 0, 4);
            grid.Children.Add(newTagEntry, 0, 5);
            grid.Children.Add(newTagBtn, 1, 5);
            grid.Children.Add(tagStackScroll, 0, 6);
            grid.Children.Add(new Label { TextColor = Color.White, Text = "description:" }, 0, 7);
            grid.Children.Add(descEditor, 0, 8);

            Grid.SetColumnSpan(nameEntry, 2);
            Grid.SetColumnSpan(placeEntry, 2);
            Grid.SetColumnSpan(descEditor, 2);
            Grid.SetColumnSpan(tagStackScroll, 2);

            Content = grid;
        }
    }
}
