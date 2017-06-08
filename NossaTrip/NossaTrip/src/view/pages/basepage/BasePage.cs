using NossaTrip.control.page;
using NossaTrip.global;
using NossaTrip.view.pages.basepage.components;
using Xamarin.Forms;

namespace NossaTrip.view.pages.basepage
{
    public class BasePage : MasterDetailPage
    {
        public BasePage()
        {
            Detail = ScreenController.Instance.GetPage(AppPage.Feed);
            Master = new ContentPage
            {
                Title = StrConstants.AppName,
                BackgroundColor = ColorConstants.PrimaryColor,
                Content = new OptionsStack(this)
            };
        }
    }
}