using System.ComponentModel;

namespace NossaTrip.view.pages.feed.components
{
    public class FeedListItem : INotifyPropertyChanged
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        // public string TripPlace { get; set; }
        public string Likes { get; set; }

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
    }
}
