using NossaTrip.global;
using NossaTrip.model.domain.trip;
using NossaTrip.view.components;
using Xamarin.Forms;

namespace NossaTrip.view.pages.feed.components
{
    public class FeedListItem
    {
        public string Url { get; set; }
        public string UserName { get; set; }
        public string TripName { get; set; }
        public string Time { get; set; }
        public string TripPlace { get; set; }
        public int Likes { get; set; }
        public Color AvaliationColor { get; set; }

        public static FeedListItem SerializeFromTrip(Trip trip)
        {
            return new FeedListItem
            {
                Url = trip.Url,
                UserName = trip.UserCreator.Name,
                TripName = trip.Name,
                Time = trip.CreationDate,
                TripPlace = FontAwsomeXamarin.FAMapMarker + " " + trip.Address,
                Likes = trip.Likes,
                AvaliationColor = ColorByLikes(trip.Likes)
            };
        }

        private static Color ColorByLikes(int likeCount)
        {
            if (likeCount < 200)
                return ColorConstants.FeedCardAvaliationBad;

            if (likeCount < 500)
                return ColorConstants.FeedCardAvaliationMedium;
    
            return ColorConstants.FeedCardAvaliationGood;
        }

        /*
        private string _place;
        public string TripPlace
        {
            get { return _place; }
            set
            {
                _place = value;
                OnPropertyChanged("TripPlace");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        */
    }
}
