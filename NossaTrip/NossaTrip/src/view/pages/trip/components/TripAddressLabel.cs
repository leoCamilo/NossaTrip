using NossaTrip.view.components;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.components
{
    public class TripAddressLabel : Label
    {
        public TripAddressLabel(string address)
        {
            FontFamily = Device.OnPlatform("FontAwesome", "FontAwesome.ttf#FontAwesome", null);
            TextColor = Color.White;
            Text = FontAwsomeXamarin.FAMapMarker + " " + address;
        }
    }
}
