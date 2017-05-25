using NossaTrip.model.domain.place;
using NossaTrip.model.domain.user;
using System.Collections.Generic;

namespace NossaTrip.model.domain.trip
{
    public class Trip
    {
        public int Id { get; set; }
        public int Likes { get; set; }

        public string Url { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string CreationDate { get; set; }

        public IList<string> Tags { get; set; }
        public IList<Place> Places { get; set; }
        public IList<Comment> Comments { get; set; }

        public User UserCreator { get; set; }
    }
}
