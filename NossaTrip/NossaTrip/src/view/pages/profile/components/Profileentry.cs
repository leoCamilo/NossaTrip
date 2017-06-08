using NossaTrip.global;
using NossaTrip.view.components.entry;
using Xamarin.Forms;

namespace NossaTrip.view.pages.profile.components
{
    public class ProfileEntry : ColorEntry
    {
        public ProfileEntry()
        {
            EntryColor = ColorConstants.NewTripFontColor;
            TextColor = ColorConstants.NewTripFontColor;
            PlaceholderColor = Color.FromRgb(150, 150, 150);
        }
    }
}
