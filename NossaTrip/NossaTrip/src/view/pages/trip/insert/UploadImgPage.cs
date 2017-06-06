using NossaTrip.global;
using NossaTrip.view.components;
using NossaTrip.view.pages.trip.insert.components;
using Plugin.Media;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.insert
{
    public class UploadImgPage : ContentPage
    {
        private readonly ScrollView _scrool;
        private readonly StackLayout _stack;

        public UploadImgPage()
        {
            BackgroundColor = ColorConstants.NewTripBackground;

            _stack = new StackLayout { Orientation = StackOrientation.Horizontal };
            _scrool = new ScrollView { Orientation = ScrollOrientation.Horizontal, Content = _stack };

            var instruction = new UploadImgLabelInstruction();

            var newPhotoBtn = new ToolbarItem { Icon = ImgConstants.Camera };
            var newImgBtn = new ToolbarItem { Icon = ImgConstants.Album };
            var nextBtn = new ToolbarItem { Icon = ImgConstants.Next };

            nextBtn.Clicked += (sender, e) => Navigation.PushAsync(new AddPlacePage());

            ToolbarItems.Add(newPhotoBtn);
            ToolbarItems.Add(newImgBtn);
            ToolbarItems.Add(nextBtn);

            newImgBtn.Clicked += async (sender, e) =>
            {
                if (!CrossMedia.Current.IsPickPhotoSupported)
                    return;

                var photo = await CrossMedia.Current.PickPhotoAsync();

                if (photo == null) return;
                if (Content == instruction) Content = _scrool;

                var image = new Image
                {
                    Margin = 10,
                    Aspect = Aspect.AspectFit,
                    WidthRequest = App.ScreenWidth - 20,
                    Source = ImageSource.FromStream(() =>
                    {
                        var stream = photo.GetStream();
                        photo.Dispose();
                        return stream;
                    })
                };

                var tgr = new TapGestureRecognizer { NumberOfTapsRequired = 2 };

                tgr.Tapped += async (iSender, iE) =>
                {
                    if (await DisplayAlert("Delete", "Would you like to delete this photo?", "Yes", "No"))
                        _stack.Children.Remove(image);
                };

                image.GestureRecognizers.Add(tgr);
                _stack.Children.Add(image);
            };

            Content = instruction;
        }
    }
}
