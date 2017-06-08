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

            var search = new SearchBar { Placeholder = "search" };
            var searchContainer = new Frame
            {
                HasShadow = false,
                CornerRadius = 20,
                Margin = 10,
                Padding = 7,
                Content = search
            };

            _src = new List<string> { "about", "after", "again", "air", "all", "along", "also", "an", "and", "another", "any", "are", "around", "as", "at", "away", "back", "be", "because", "been", "before", "below", "between", "both", "but", "by", "came", "can", "come", "could", "day", "did", "different", "do", "does", "don't", "down", "each", "end", "even", "every", "few", "find", "first", "for", "found", "from", "get", "give", "go", "good", "great", "had", "has", "have", "he", "help", "her", "here", "him", "his", "home", "house", "how", "I", "if", "in", "into", "is", "it", "its", "just", "know", "large", "last", "left", "like", "line", "little", "long", "look", "made", "make", "man", "many", "may", "me", "men", "might", "more", "most", "Mr.", "must", "my", "name", "never", "new", "next", "no", "not", "now", "number", "of", "off", "old", "on", "one", "only", "or", "other", "our", "out", "over", "own", "part", "people", "place", "put", "read", "right", "said", "same", "saw", "say", "see", "she", "should", "show", "small", "so", "some", "something", "sound", "still", "such", "take", "tell", "than", "that", "the", "them", "then", "there", "these", "they", "thing", "think", "this", "those", "thought", "three", "through", "time", "to", "together", "too", "two", "under", "up", "us", "use", "very", "want", "water", "way", "we", "well", "went", "were", "what", "when", "where", "which", "while", "who", "why", "will", "with", "word", "work", "world", "would", "write", "year", "you", "your", "was" };
            _list = new ListView { ItemsSource = _src, Margin = 10 };

            search.TextChanged += Search_TextChanged;
            _list.ItemTapped += _list_ItemTapped;

            Content = new StackLayout
            {
                Children = { searchContainer, _list}
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