using NossaTrip.model.net;
using System.Threading.Tasks;

namespace NossaTrip.control.restful.feed
{
    public class FeedRequester
    {
        public static async Task<string> GetAllTrips(ApiQueryMaker query)
        {
            var answer = await Rest.Request(query);

            if (answer.Status != Status.Ok)
                return null;

            return answer.Result;
        }
    }
}
