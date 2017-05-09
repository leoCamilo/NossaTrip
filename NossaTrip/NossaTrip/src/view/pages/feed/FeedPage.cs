﻿using NossaTrip.view.pages.feed.components;
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
                listContent.Add(new FeedListItem
                {
                    Url = "http://www.lovemarks.com/wp-content/uploads/profile-avatars/default-avatar-tech-guy.png",
                    Name = "Leonardo Camilo",
                    Likes = "12,442\npeople liked this",
                    Time = "06:30 pm\nMay 16, 2017"
                });

            listView.ItemTapped += (sender, e) => {
                ((ListView)sender).SelectedItem = null;
                Navigation.PushModalAsync(new TripPage());
            };

            BackgroundImage = "feed__bg.jpg";
            Content = listView;
        }
    }
}