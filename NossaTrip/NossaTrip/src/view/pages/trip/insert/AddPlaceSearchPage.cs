using NossaTrip.global;
using NossaTrip.model.domain.place;
using NossaTrip.view.pages.trip.components;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.insert
{
    public class AddPlaceSearchPage : ContentPage
    {
        private readonly StackLayout stack;
        private readonly ListView _list;
        private readonly List<string> _src;

        public AddPlaceSearchPage(StackLayout stack)
        {
            this.stack = stack;
            BackgroundColor = ColorConstants.NewTripBackground;

            var search = new SearchBar { TextColor = ColorConstants.TextColor };

            _src = new List<string> { "Milk", "Cream", "Meat" };
            _list = new ListView { ItemsSource = _src };

            search.TextChanged += Search_TextChanged;
            _list.ItemTapped += _list_ItemTapped;

            Content = new StackLayout
            {
                Children = { search, _list}
            };
        }

        private void _list_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var element = (string)e.Item;
            var place = new Place { Name = element, Likes = 0, Url = "http://mundoeducacao.bol.uol.com.br/upload/conteudo_legenda/18bb470cea4196c18aad7349bcea9132.jpg" };
            stack.Children.Add(new TripPlaceCard(place));
            Navigation.PopModalAsync();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            var txt = (SearchBar)sender;

            if (string.IsNullOrEmpty(txt.Text))
            {
                _list.ItemsSource = _src;
            }
            else
            {
                _list.ItemsSource = _src.Where(x => x.StartsWith(txt.Text));
            }
        }
    }
}