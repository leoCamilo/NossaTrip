using Android.Graphics;
using NossaTrip.Droid.view.customRenderers.shape;
using NossaTrip.view.pages.login.components;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomShape), typeof(CustomShapeRenderer))]

namespace NossaTrip.Droid.view.customRenderers.shape
{
    public class CustomShapeRenderer : BoxRenderer
    {
        public CustomShapeRenderer()
        {
            SetWillNotDraw(true);
        }

        public override void Draw(Canvas canvas)
        {
            var customShape = (CustomShape)Element;

            var rc = new Rect();
            var p = new Paint()
            {
                Color = customShape.Color.ToAndroid(),
                AntiAlias = true,
            };

            GetDrawingRect(rc);

            var border = rc.Width() / customShape.BorderRadius;

            p.SetStyle(customShape.Fill ? Paint.Style.Fill : Paint.Style.Stroke);
            p.StrokeWidth = customShape.BorderWidth;

            if (customShape.Type == ShapeType.Square)
                canvas.DrawRoundRect(new RectF(rc), border, border, p);
            else
                canvas.DrawLine(0, rc.Height() / 2, rc.Width(), rc.Height() / 2, p);
        }
    }
}