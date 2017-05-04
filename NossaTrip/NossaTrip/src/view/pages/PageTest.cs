using Xamarin.Forms;

namespace NossaTrip.view.pages
{
    public class PageTest : ContentPage
    {
        public PageTest()
        {
            var scrollOut = new ScrollView();
            var scrollIn = new ScrollView();

            var stack = new StackLayout();
            var fixedBox = new BoxView { Color = Color.Yellow, HeightRequest = App.ScreenHeight / 2 };

            stack.Children.Add(new BoxView { Color = Color.Red, HeightRequest = 800 });
            stack.Children.Add(fixedBox);
            stack.Children.Add(scrollIn);

            scrollIn.Content = new BoxView { Color = Color.Purple, HeightRequest = 800 };
            scrollOut.Content = stack;

            /*
            scrollOut.ScrollToAsync(fixedBox, ScrollToPosition.Start, true);

            scrollOut.Scrolled += (object sender, ScrolledEventArgs e) =>
            {
                label.Text = "Position: " + e.ScrollX + " x " + e.ScrollY;
            };
            */

            Content = scrollOut;
        }
    }
}
