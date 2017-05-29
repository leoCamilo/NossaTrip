using Android.Graphics;
using NossaTrip.Droid.view.customRenderers.entry;
using NossaTrip.view.components.entry;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ColorEntry), typeof(ColorEntryRenderer))]

namespace NossaTrip.Droid.view.customRenderers.entry
{
    public class ColorEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var element = (ColorEntry) e.NewElement;

                Control.Background.SetColorFilter(element.EntryColor.ToAndroid(), PorterDuff.Mode.SrcIn);
            }
        }
    }
}