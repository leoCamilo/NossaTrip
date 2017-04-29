using NossaTrip.view.pages.feed.components;
using NossaTrip.view.pages.place;
using NossaTrip.view.pages.trip;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace NossaTrip.view.pages.feed
{
    public class FeedPage : ContentPage
    {
        public FeedPage()
        {
            var listContent = new ObservableCollection<FeedListItem>();
            var listView = new FeedListView(ListViewCachingStrategy.RecycleElement);

            listView.ItemsSource = listContent;

            for (var i = 0; i < 100; i++)
                listContent.Add(new FeedListItem { TxtContent = "cell " + i });

            listView.ItemTapped += (sender, e) => {
                ((ListView)sender).SelectedItem = null;
                Navigation.PushAsync(new PlacePage(), true);
            };

            BackgroundImage = "feed__bg.jpg";
            Content = listView;
        }
    }
}