using NossaTrip.model.domain.trip;
using NossaTrip.model.domain.user;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NossaTrip.control.controllers.feed
{
    public class FeedController
    {
        public async static Task<IList<Trip>> GetAllTrips()
        {
            var rnd = new Random();
            var list = new List<Trip>();

            for (var i = 0; i < 50; i++)
                list.Add(new Trip
                {
                    Url = "http://www.lovemarks.com/wp-content/uploads/profile-avatars/default-avatar-tech-guy.png",
                    CreationDate = "06:30 pm\nMay 16, 2017",
                    UserCreator = new User { Name = "Leonardo Camilo" },
                    Name = "Best trip USA ever!!",
                    Address = "New York, USA",
                    Likes = rnd.Next(0, 999)
                });

            return list;
        }
    }
}
