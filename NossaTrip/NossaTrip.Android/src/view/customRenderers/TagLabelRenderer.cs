using NossaTrip.Droid.view.customRenderers;
using NossaTrip.view.pages.trip.components;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TripTagsCard), typeof(TagLabelRenderer))]

namespace NossaTrip.Droid.view.customRenderers
{
    public class TagLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            var label = (TripTagsCard)Element;

            if (label == null || Control == null)
                return;

            if (e.OldElement == null)
            {
                Control.SetLineSpacing(1, label.LineSpacing);
                UpdateLayout();
            }
        }
    }
}