﻿using NossaTrip.control.controllers.feed;
using NossaTrip.global;
using NossaTrip.view.pages.feed.components;
using NossaTrip.view.pages.trip;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace NossaTrip.view.pages.feed
{
    public class FeedPage : ContentPage
    {
        private ObservableCollection<FeedListItem> listContent;
        private FeedListView listView;

        public FeedPage()
        {
            BackgroundColor = ColorConstants.FeedBackground;

            listContent = new ObservableCollection<FeedListItem>();
            listView = new FeedListView(ListViewCachingStrategy.RecycleElement) { ItemsSource = listContent };

            listView.ItemTapped += (sender, e) => {
                ((ListView)sender).SelectedItem = null;
                Navigation.PushModalAsync(new TripPage());
            };

            var newBtn = new ToolbarItem { Text = "new trip" };

            newBtn.Clicked += (sender, e) => Navigation.PushAsync(new NewTripPage());
            ToolbarItems.Add(newBtn);
            Content = listView;

            UpdateTripList();
        }

        private async void UpdateTripList()
        {
            var list = await FeedController.GetAllTrips();

            foreach (var trip in list)
                listContent.Add(FeedListItem.SerializeFromTrip(trip));
        }
    }
}