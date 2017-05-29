using NossaTrip.global;
using NossaTrip.view.components.entry;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.insert.components
{
    public class NewTripEntry : ColorEntry
    {
        public NewTripEntry()
        {
            EntryColor = ColorConstants.NewTripFontColor;
            TextColor = ColorConstants.NewTripFontColor;
            PlaceholderColor = Color.FromRgb(150, 150, 150);
        }
    }
}
