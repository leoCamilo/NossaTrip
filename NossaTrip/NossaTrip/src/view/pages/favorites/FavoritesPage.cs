using NossaTrip.control.controllers.feed;
using NossaTrip.global;
using NossaTrip.model.domain.trip;
using NossaTrip.view.pages.feed.components;
using NossaTrip.view.pages.trip.view;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace NossaTrip.view.pages.favorites
{
    public class FavoritesPage : ContentPage
    {
        private IList<Trip> tripList;
        private ObservableCollection<FeedListItem> listContent;
        private FeedListView listView;

        public FavoritesPage()
        {
            BackgroundColor = ColorConstants.FeedBackground;

            listContent = new ObservableCollection<FeedListItem>();
            listView = new FeedListView(ListViewCachingStrategy.RecycleElement) { ItemsSource = listContent };

            listView.ItemTapped += (sender, e) => {
                ((ListView)sender).SelectedItem = null;
                var trip = FeedController.GetTrip(((FeedListItem)e.Item).Trip.Id);
                var result = trip.Result;
                Navigation.PushModalAsync(new TripPage(result));
            };

            Content = listView;
            UpdateTripList();
        }

        private async void UpdateTripList()
        {
            tripList = await FeedController.GetFavoritesTrips();

            foreach (var trip in tripList)
                listContent.Add(FeedListItem.SerializeFromTrip(trip));
        }
    }
}