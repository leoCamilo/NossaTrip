using Xamarin.Forms;

namespace NossaTrip.view.pages.basepage.components
{
    public class OptionsStack : StackLayout
    {
        public OptionsStack()
        {
            Children.Add(new ProfileGrid());
            Children.Add(new OptionsList());
        }
    }
}
