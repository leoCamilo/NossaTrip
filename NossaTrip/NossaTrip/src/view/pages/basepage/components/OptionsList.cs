using NossaTrip.control.page;
using NossaTrip.view.components;
using Xamarin.Forms;

namespace NossaTrip.view.pages.basepage.components
{
    public class OptionsList : ListView
    {
        private AppPage _lastPage;
        private BasePage _dad;

        public OptionsList(BasePage basePage)
        {
            _lastPage = 0;
            _dad = basePage;

            MenuListItem[] srcList = {
                new MenuListItem { Page = AppPage.Feed,         Text = FontAwsomeXamarin.FAMapO     + "  Trip Feed" },
                new MenuListItem { Page = AppPage.Profile,      Text = FontAwsomeXamarin.FAUserO    + "  Meu perfil" },
                new MenuListItem { Page = AppPage.Favorites,    Text = FontAwsomeXamarin.FAStarO    + "  Trips favoritas" },
                new MenuListItem { Page = AppPage.MyTrips,      Text = FontAwsomeXamarin.FAPlane    + "  Minhas Trips" },
                new MenuListItem { Page = AppPage.Config,       Text = FontAwsomeXamarin.FACog      + "  Configurações" }
            };

            SeparatorColor = Color.Gray;

            ItemTemplate = new DataTemplate(typeof(MenuListCell));
            ItemsSource = srcList;

            ItemTapped += OptionsList_ItemTapped;
        }

        private void OptionsList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is MenuListItem item)
            {
                if (_lastPage != item.Page)
                    _dad.Detail = ScreenController.Instance.GetPage(item.Page);

                _lastPage = item.Page;
                _dad.IsPresented = false;
            }
        }
    }
}