using Xamarin.Forms;

namespace NossaTrip.view.pages.login.components
{
    public enum ShapeType { Square, Line }

    public class CustomShape : BoxView
    {
        public bool Fill { get; set; }

        public float BorderWidth { get; set; }
        public float BorderRadius { get; set; }

        public ShapeType Type { get; set; }
    }
}
