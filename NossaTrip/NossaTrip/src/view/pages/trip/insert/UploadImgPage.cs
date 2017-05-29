using NossaTrip.global;
using NossaTrip.view.components;
using Plugin.Media;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.insert
{
    public class UploadImgPage : CarouselPage
    {
        public UploadImgPage()
        {
            var photoBtn = new Button
            {
                FontSize = 40,
                TextColor = Color.White,
                Text = FontAwsomeXamarin.FACamera,
                FontFamily = FontAwsomeXamarin.GetFontName()
            };

            var newPhotoPage = new ContentPage { BackgroundColor = ColorConstants.NewTripBackground, Content = photoBtn };

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

                Children.Remove(newPhotoPage);
                Children.Add(new ContentPage { BackgroundColor = ColorConstants.NewTripBackground, Content = image });
                Children.Add(newPhotoPage);
            };

            Children.Add(newPhotoPage);
        }
    }
}
