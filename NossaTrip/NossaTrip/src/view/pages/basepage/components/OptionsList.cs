using NossaTrip.view.components;
using Xamarin.Forms;

namespace NossaTrip.view.pages.basepage.components
{
    public class OptionsList : ListView
    {
        public OptionsList()
        {
            MenuListItem[] strList = {
                new MenuListItem { Text = FontAwsomeXamarin.FAUser + "  Meu perfil" },
                new MenuListItem { Text = FontAwsomeXamarin.FAStar + "  Trips favoritas" },
                new MenuListItem { Text = FontAwsomeXamarin.FAPlane + "  Minhas Trips" },
                new MenuListItem { Text = FontAwsomeXamarin.FACog + "  Configurações" }
            };

            SeparatorColor = Color.Gray;

            ItemTemplate = new DataTemplate(typeof(MenuListCell));
            ItemsSource = strList;
        }
    }
}
