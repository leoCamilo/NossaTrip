using System;
using Xamarin.Forms;

namespace NossaTrip.view.pages.feed.components
{
    public class FeedListView : ListView
    {
        public FeedListView(ListViewCachingStrategy strategy) : base(strategy)
        {
            HasUnevenRows = true;
            SeparatorVisibility = SeparatorVisibility.None;
            ItemTemplate = new DataTemplate(typeof(FeedListCell));
        }

        public void AddTouchFunction(EventHandler<SelectedItemChangedEventArgs> function)
        {
            ItemSelected += function;
        }
    }
}
