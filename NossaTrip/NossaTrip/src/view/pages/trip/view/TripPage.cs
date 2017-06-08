using NossaTrip.global;
using NossaTrip.model.domain.trip;
using NossaTrip.view.pages.trip.components;
using Xamarin.Forms;

namespace NossaTrip.view.pages.trip.view
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

            foreach (var place in trip.Places)
                info_list.Children.Add(new TripPlaceCard(place));

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
                Text = trip.Comments.Count + " comments:",
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
