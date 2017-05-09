using NossaTrip.view.components;
using NossaTrip.view.pages.feed;
using System;
using Xamarin.Forms;

namespace NossaTrip.view.pages.basepage.components
{
    public class OptionsList : ListView
    {
        private BasePage _dad;

        public OptionsList(BasePage basePage)
        {
            _dad = basePage;

            MenuListItem[] strList = {
                new MenuListItem { PageType = typeof(FeedPage), Text = FontAwsomeXamarin.FAMapO + "  Trip Feed" },
                new MenuListItem { Text = FontAwsomeXamarin.FAUserO + "  Meu perfil" },
                new MenuListItem { Text = FontAwsomeXamarin.FAStarO + "  Trips favoritas" },
                new MenuListItem { Text = FontAwsomeXamarin.FAPlane + "  Minhas Trips" },
                new MenuListItem { Text = FontAwsomeXamarin.FACog + "  Configurações" }
            };

            SeparatorColor = Color.Gray;

            ItemTemplate = new DataTemplate(typeof(MenuListCell));
            ItemsSource = strList;

            ItemTapped += OptionsList_ItemTapped;
        }

        private void OptionsList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = sender as MenuListItem;

            if (item != null)
            {
                _dad.Detail = (Page) Activator.CreateInstance(item.PageType);
                _dad.IsPresented = false;
            }
        }
    }
}
