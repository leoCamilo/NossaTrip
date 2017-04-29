using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.components
{
    public class Background
    {
        public static void SetLayoutBackground(AbsoluteLayout layout, string source)
        {
            var bg_opacity = new BoxView
            {
                Color = Color.Black,
                Opacity = 0.5
            };

            var bg = new Image
            {
                Source = source,
                Aspect = Aspect.AspectFill
            };

            AbsoluteLayout.SetLayoutBounds(bg_opacity, new Rectangle(0, 0, 1, 1));
            AbsoluteLayout.SetLayoutBounds(bg, new Rectangle(0, 0, 1, 1));

            AbsoluteLayout.SetLayoutFlags(bg_opacity, AbsoluteLayoutFlags.SizeProportional);
            AbsoluteLayout.SetLayoutFlags(bg, AbsoluteLayoutFlags.SizeProportional);

            layout.Children.Add(bg);
            layout.Children.Add(bg_opacity);
        }
    }
}
