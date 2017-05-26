using NossaTrip.global;
using NossaTrip.model.domain.trip;
using NossaTrip.view.pages.trip.components;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip
{
    public class TripPage : ContentPage
    {
        public TripPage(Trip trip)
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var layout = new AbsoluteLayout { BackgroundColor = ColorConstants.PrimaryColor };
            var info_list = new TripPageStackLayout();
            var main_data = new TripMainData(trip.Url, trip.Name, trip.Address);
            var scroll = new TripScroll (main_data.Bg) { Content = info_list };

            info_list.Children.Add(main_data);
            info_list.Children.Add(new TripDescriptionLabel(trip.Description));

            var tags_label = new Label
            {
                Text = "tags:",
                Margin = new Thickness(20, 20, 0, 0),
                TextColor = ColorConstants.TextColor
            };

            info_list.Children.Add(tags_label);

            foreach (var tag in trip.Tags)
                info_list.Children.Add(new TripTagCard(tag));

            var places_label = new Label
            {
                Margin = new Thickness(20, 20, 0, 0),
                Text = "places:",
                TextColor = Color.White
            };

            info_list.Children.Add(places_label);

            info_list.Children.Add(new TripPlaceCard("Macgaiver's bar", "http://static.wixstatic.com/media/6d576695617ad2f8c0022066227abbe3.wix_mp_1024"));
            info_list.Children.Add(new TripPlaceCard("Central Park", "https://spoilednyc.com/wp-content/uploads///2015/11/13/nycparks-4612.jpg"));
            info_list.Children.Add(new TripPlaceCard("Wall Street", "http://homeandecoration.com/wp-content/uploads/2014/04/best-places-to-visit-nyc-new-york-design-week-icff-2.jpg"));
            info_list.Children.Add(new TripPlaceCard("Liberty Statue", "http://www.theplunge.com/image.php?width=800&height=800&image=http://www.theplunge.com/images/new_articles/top_20_places_to_propose_in_ny/NYC-1.jpg"));
            info_list.Children.Add(new TripPlaceCard("Some Bridge", "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTwEoRlSodkMwJ6Qo154njqWYyuievJ_o0gRn1ezLbgaFM02i31"));
            info_list.Children.Add(new TripPlaceCard("Philip's bar", "https://s-media-cache-ak0.pinimg.com/originals/27/a5/8a/27a58a1ab7a9e97fd4fc8ba463ca9438.jpg"));

            var map_label = new Label
            {
                Margin = new Thickness(20, 20, 0, 0),
                Text = "map:",
                TextColor = Color.White
            };

            info_list.Children.Add(map_label);

            info_list.Children.Add(new Image {
                Source = "http://www.droid-life.com/wp-content/uploads/2016/09/google-maps.jpg",
                Margin = new Thickness(20, 0)
            });

            var comments_label = new Label
            {
                Margin = new Thickness(20, 20, 0, 0),
                Text = "comments:",
                TextColor = Color.White
            };

            info_list.Children.Add(comments_label);

            foreach (var comment in trip.Comments)
                info_list.Children.Add(new TripPageComment (comment.Commenter.Url, comment.Commenter.Name, comment.Txt, comment.Date));

            info_list.Children.Add(new Entry { Placeholder = "comment...", PlaceholderColor = Color.FromHex("#ededed"), TextColor = Color.White });

            AbsoluteLayout.SetLayoutBounds(scroll, new Rectangle(0, 0, 1, 1));
            AbsoluteLayout.SetLayoutFlags(scroll, AbsoluteLayoutFlags.SizeProportional);

            layout.Children.Add(scroll);
            Content = layout;
        }
    }
}
