using Newtonsoft.Json.Linq;
using NossaTrip.model.domain.user;

namespace NossaTrip.model.json.user
{
    public class UserJson
    {
        public static User Serialize(string json)
        {
            var userJson = JObject.Parse(json);

            if (1 == (int)userJson["success"])
                return new User
                {
                    Id = (int)userJson["id"],
                    // ....
                };

            return null;
        }
    }
}