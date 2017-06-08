using NossaTrip.global;
using NossaTrip.view.components;
using NossaTrip.view.pages.profile.components;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using Xamarin.Forms;

namespace NossaTrip.view.pages.profile
{
    public class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            BackgroundColor = ColorConstants.NewTripBackground;

            var saveBtn = new ToolbarItem { Icon = ImgConstants.Check };
            var grid = new Grid { Padding = 20, ColumnSpacing = 15 };

            // saveBtn.Clicked += (sender, e) => Navigation.PushAsync(new UploadImgPage());

            ToolbarItems.Add(saveBtn);

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(90, GridUnitType.Absolute) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(45, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(45, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(25, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(45, GridUnitType.Absolute) });
            
            var nameEntry = new ProfileEntry();
            var mailEntry = new ProfileEntry();

            var photoBtn = new Button
            {
                FontSize = 40,
                TextColor = Color.White,
                Text = FontAwsomeXamarin.FACamera,
                FontFamily = FontAwsomeXamarin.GetFontName()
            };

            photoBtn.Clicked += async (sender, e) => 
            {
                if (!CrossMedia.Current.IsTakePhotoSupported)
                    return;

                var photo = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    Directory = "NossaTrip",
                    Name = DateTime.Now + ".jpg"
                });

                if (photo == null)
                    return;

                var image = new Image
                {
                    Aspect = Aspect.AspectFill,
                    Source = ImageSource.FromStream(() =>
                    {
                        var stream = photo.GetStream();
                        photo.Dispose();
                        return stream;
                    })
                };

                photoBtn.IsVisible = false;
                grid.Children.Add(image, 0, 0);
                Grid.SetRowSpan(image, 2);
            };

            grid.Children.Add(photoBtn, 0, 0);
            grid.Children.Add(new ProfileLabel { Text = "name:" }, 1, 0);
            grid.Children.Add(nameEntry, 1, 1);
            grid.Children.Add(new ProfileLabel { Text = "e-mail:" }, 0, 2);
            grid.Children.Add(mailEntry, 0, 3);

            Grid.SetRowSpan(photoBtn, 2);
            Grid.SetColumnSpan(mailEntry, 2);

            Content = grid;
        }
    }
}