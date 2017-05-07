using NossaTrip.view.pages.basepage.components;
using NossaTrip.view.pages.feed;
using System.Collections.Generic;
using Xamarin.Forms;

namespace NossaTrip.view.pages.basepage
{
    public class BasePage : MasterDetailPage
    {
        public BasePage()
        {
            Detail = new NavigationPage(new FeedPage());
            Master = new ContentPage
            {
                Title = "NossaTrip",
                BackgroundColor = Color.FromHex("#323232"),
                Content = new OptionsStack()
            };
        }
    }
}

