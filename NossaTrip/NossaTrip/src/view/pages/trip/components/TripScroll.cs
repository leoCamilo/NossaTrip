using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.components
{
    public class TripScroll : ScrollView
    {
        public TripScroll(Image bg)
        {
            Scrolled += (sender, e) =>
            {
                bg.TranslationY = ScrollY / 2;
            };
        }
    }
}
