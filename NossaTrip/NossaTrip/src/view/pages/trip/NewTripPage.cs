using NossaTrip.view.components;
using Plugin.Media;
using System;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip
{
    public class NewTripPage : ContentPage
    {
        public NewTripPage()
        {
            var cancelBtn = new ToolbarItem { Text = "cancel" };
            var saveBtn = new ToolbarItem { Text = "save" };
            var grid = new Grid { Padding = 15 };

            ToolbarItems.Add(cancelBtn);
            ToolbarItems.Add(saveBtn);

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(90, GridUnitType.Absolute) } );
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) });

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(90, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(100, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) });

            
            var descEditor = new Editor { Text = "Description..." };

            var placeEntry = new Entry
            {
                Placeholder = "Trip address...",
                VerticalOptions = LayoutOptions.End
            };

            var photoBtn = new Button
            {
                FontSize = 40,
                TextColor = Color.White,
                Text = FontAwsomeXamarin.FACamera,
                FontFamily = FontAwsomeXamarin.GetFontName()
            };

            var nameEntry = new Entry
            {
                Margin = 0,
                Placeholder = "Trip name...",
                VerticalOptions = LayoutOptions.End
            };

            var newTagEntry = new Entry
            {
                Placeholder = "new tag",
                VerticalOptions = LayoutOptions.End
            };

            var newTagBtn = new Button
            {
                Text = "add"
            };

            var tagStack = new StackLayout { Orientation = StackOrientation.Horizontal };
            var tagStackScroll = new ScrollView { Orientation = ScrollOrientation.Horizontal, Content = tagStack };

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

            newTagBtn.Clicked += (sender, e) =>
            {
                var _rnd = new Random();
                var color = Color.FromRgb(_rnd.Next(100, 200), _rnd.Next(100, 200), _rnd.Next(100, 200));
                tagStack.Children.Add(new Label { Text = newTagEntry.Text, BackgroundColor = color, VerticalOptions = LayoutOptions.Center });
                newTagEntry.Text = "";
            };

            grid.Children.Add(new BoxView { Color = Color.FromHex("#323232") }, 0, 0);
            grid.Children.Add(photoBtn, 0, 0);
            grid.Children.Add(nameEntry, 1, 0);
            grid.Children.Add(placeEntry, 0, 1);
            grid.Children.Add(descEditor, 0, 2);
            grid.Children.Add(newTagBtn, 2, 3);
            grid.Children.Add(newTagEntry, 0, 3);
            grid.Children.Add(tagStackScroll, 0, 4);

            Grid.SetColumnSpan(nameEntry, 2);
            Grid.SetColumnSpan(placeEntry, 3);
            Grid.SetColumnSpan(descEditor, 3);
            Grid.SetColumnSpan(newTagEntry, 2);
            Grid.SetColumnSpan(tagStackScroll, 3);

            Content = grid;
        }
    }
}
