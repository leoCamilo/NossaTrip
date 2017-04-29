using NossaTrip.view.pages.place.components;
using Xamarin.Forms;

namespace NossaTrip.view.pages.place
{
    public class PlacePage : ContentPage
    {
        public PlacePage()
        {
            Title = "Ceará, fortaleza - Brasil";

            var paralax_bg = new Image
            {
                Source = "http://blog.emania.com.br/content/uploads/2015/12/paisagem-tropical-wallpaper-1.jpg",
                Aspect = Aspect.AspectFill,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Fill
            };

            var stack = new StackLayout();
            var scrool = new ScrollView { Content = stack };

            stack.Children.Add(new Frame { Content = paralax_bg, Padding = 0, HasShadow = false, CornerRadius = 0 });
            stack.Children.Add(new DescriptionCard());
            stack.Children.Add(new DescriptionCard());
            stack.Children.Add(new DescriptionCard());
            stack.Children.Add(new DescriptionCard());
            stack.Children.Add(new DescriptionCard());
            stack.Children.Add(new DescriptionCard());

            scrool.Scrolled += (sender, e) =>
            {
                var imageHeight = paralax_bg.Height * 2;
                var scrollRegion = paralax_bg.Height - scrool.Height;
                var parallexRegion = imageHeight - scrool.Height;
                paralax_bg.TranslationY = scrool.ScrollY - parallexRegion * (scrool.ScrollY / scrollRegion);
            };

            Content = scrool;
        }
    }
}
