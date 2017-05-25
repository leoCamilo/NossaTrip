using NossaTrip.model.domain.user;
using NossaTrip.model.json.user;
using NossaTrip.model.net;
using System.Threading.Tasks;

namespace NossaTrip.control.restful.user
{
    public class UserRequester
    {
        public static async Task<User> DoLogin(ApiQueryMaker query)
        {
            var answer = await Rest.Request(query);

            if (answer.Status != Status.Ok)
                return null;

            return UserJson.Serialize(answer.Result);
        }
    }
}
