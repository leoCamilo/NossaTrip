using NossaTrip.control.controllers.feed;
using NossaTrip.global;
using NossaTrip.model.domain.trip;
using NossaTrip.view.pages.feed.components;
using NossaTrip.view.pages.trip;
using NossaTrip.view.pages.trip.insert;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace NossaTrip.view.pages.feed
{
    public class FeedPage : ContentPage
    {
        private IList<Trip> tripList;
        private ObservableCollection<FeedListItem> listContent;
        private FeedListView listView;

        public FeedPage()
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

            var newBtn = new ToolbarItem { Icon = ImgConstants.NewTrip };

            newBtn.Clicked += (sender, e) => Navigation.PushAsync(new NewTripPage());
            ToolbarItems.Add(newBtn);
            Content = listView;

            UpdateTripList();
        }

        private async void UpdateTripList()
        {
            tripList = await FeedController.GetAllTrips();

            foreach (var trip in tripList)
                listContent.Add(FeedListItem.SerializeFromTrip(trip));
        }
    }
}