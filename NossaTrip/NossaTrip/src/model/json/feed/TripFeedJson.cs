using Newtonsoft.Json.Linq;
using NossaTrip.model.domain.trip;
using NossaTrip.model.domain.user;
using System.Collections.Generic;
using System.Linq;

namespace NossaTrip.model.json.feed
{
    public class TripFeedJson
    {
        public static IList<Trip> Serialize(string json)
        {
            var list = new List<Trip>();
            var feedJson = JObject.Parse(json);

            if (1 == (int)feedJson["success"])
            {
                if (!feedJson["trips"].HasValues)
                    return null;

                var results = feedJson["trips"].Children().ToList();
                list.AddRange(results.Select(result => SerializeTrip(result.ToString())));
                return list;
            }

            return null;
        }

        private static Trip SerializeTrip(string json)
        {
            var tmp = new Trip();
            var tripJson = JObject.Parse(json);

            tmp.UserCreator = new User { Name = (string)tripJson["name_user"], Url = (string)tripJson["url_user_picture"] };
            tmp.Name = (string)tripJson["title"];
            tmp.Address = (string)tripJson["short_route"];
            tmp.Likes = (int)tripJson["rate"];
            tmp.Id = (int)tripJson["id_trip"];
            tmp.CreationDate = (string)tripJson["create_time"];

            return tmp;
        }
    }
}