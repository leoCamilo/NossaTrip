using Xamarin.Forms;

namespace NossaTrip.view.pages.basepage.components
{
    public class OptionsStack : StackLayout
    {
        private BasePage basePage;

        public OptionsStack(BasePage basePage)
        {
            Children.Add(new ProfileGrid());
            Children.Add(new OptionsList(basePage));
        }
    }
}
