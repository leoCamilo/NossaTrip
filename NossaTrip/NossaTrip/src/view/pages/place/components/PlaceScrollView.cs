using Xamarin.Forms;

namespace NossaTrip.view.pages.place.components
{
    public class PlaceScrollView : ScrollView
    {
        public PlaceScrollView(Image paralaxBg)
        {
            Scrolled += (sender, e) =>
            {
                var imageHeight = paralaxBg.Height * 2;
                var scrollRegion = paralaxBg.Height - Height;
                var parallexRegion = imageHeight - Height;

                paralaxBg.TranslationY = ScrollY - parallexRegion * (ScrollY / scrollRegion);
            };
        }
    }
}
