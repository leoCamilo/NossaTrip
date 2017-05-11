using NossaTrip.view.pages.place.components;
using Xamarin.Forms;

namespace NossaTrip.view.pages.place
{
    public class PlacePage : ContentPage
    {
        public PlacePage()
        {
            BackgroundColor = Color.FromHex("#565656");

            var paralax_bg = new Image
            {
                Source = "http://blog.emania.com.br/content/uploads/2015/12/paisagem-tropical-wallpaper-1.jpg",
                Aspect = Aspect.AspectFill,
                HeightRequest = 250,
                HorizontalOptions = LayoutOptions.Fill
            };

            var stack = new StackLayout { Spacing = 10 };
            var scrool = new PlaceScrollView (paralax_bg) { Content = stack };

            stack.Children.Add(new Frame { Content = paralax_bg, Padding = 0, HasShadow = false, CornerRadius = 0 });
            stack.Children.Add(new PlaceMainData());
            stack.Children.Add(new PlaceButtonsCard());
            stack.Children.Add(new DescriptionCard());
            stack.Children.Add(new AddressCard());
            stack.Children.Add(new PlaceInfo());

            Content = scrool;
        }
    }
}
