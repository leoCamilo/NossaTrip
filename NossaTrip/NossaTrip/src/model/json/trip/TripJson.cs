using Newtonsoft.Json.Linq;
using NossaTrip.model.domain.place;
using NossaTrip.model.domain.trip;
using NossaTrip.model.domain.user;
using System.Collections.Generic;
using System.Linq;

namespace NossaTrip.model.json.trip
{
    public class TripJson
    {
        public static Trip Serialize(string json)
        {
            var tmp = new Trip();
            var jsonObj = JObject.Parse(json);

            if ((int)jsonObj["success"] == 1)
            {
                var tripJson = (JObject)jsonObj["data"];

                tmp.Url = (string)tripJson["url_picture"];
                tmp.Name = (string)tripJson["title"];
                tmp.Address = (string)tripJson["short_route"];
                tmp.Likes = (int)tripJson["rate"];
                tmp.Id = (int)tripJson["id_trip"];
                tmp.CreationDate = (string)tripJson["create_time"];
                tmp.Description = (string)tripJson["description"];

                if (tripJson["tags"].HasValues)
                {
                    var list = new List<string>();
                    var results = tripJson["tags"].Children().ToList();
                    list.AddRange(results.Select(result => result.ToString()));
                    tmp.Tags = list;
                }

                if (tripJson["comments"].HasValues)
                {
                    var list = new List<Comment>();
                    var results = tripJson["comments"].Children().ToList();
                    list.AddRange(results.Select(result => SerializeComment(result.ToString())));
                    tmp.Comments = list;
                }

                if (tripJson["route"].HasValues)
                {
                    var list = new List<Place>();
                    var results = tripJson["route"].Children().ToList();
                    list.AddRange(results.Select(result => SerializePlace(result.ToString())));
                    tmp.Places = list;
                }
            }

            return tmp;
        }

        private static Place SerializePlace(string json)
        {
            var placeJson = JObject.Parse(json);

            return new Place
            {
                Id = (int)placeJson["id_place"],
                Name = (string)placeJson["name_place"],
                Url = (string)placeJson["url_picture"],
                Likes = (int)placeJson["likes"]
            };
        }

        private static Comment SerializeComment(string json)
        {
            var commentJson = JObject.Parse(json);

            return new Comment
            {
                Commenter = new User { Url = (string)commentJson["url_user_picture"], Name = (string)commentJson["name_user"] },
                Date = (string)commentJson["date_time"],
                Txt = (string)commentJson["comment"]
            };
        }
    }
}