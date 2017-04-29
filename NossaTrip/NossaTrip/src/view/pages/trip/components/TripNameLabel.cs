using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.components
{
    public class TripNameLabel : Label
    {
        public TripNameLabel(string name)
        {
            TextColor = Color.White;
            Text = name;
            FontSize = 30;
        }
    }
}
