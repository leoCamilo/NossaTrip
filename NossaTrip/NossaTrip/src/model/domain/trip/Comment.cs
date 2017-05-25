using NossaTrip.model.domain.user;

namespace NossaTrip.model.domain.trip
{
    public class Comment
    {
        public User Commenter { get; set; }
        public string Txt { get; set; }
        public string Date { get; set; }
    }
}
