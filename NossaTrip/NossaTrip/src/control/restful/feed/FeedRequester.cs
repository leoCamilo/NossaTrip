using NossaTrip.model.domain.trip;
using NossaTrip.model.json.feed;
using NossaTrip.model.net;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NossaTrip.control.restful.feed
{
    public class FeedRequester
    {
        public static async Task<IList<Trip>> GetTrips(ApiQueryMaker query)
        {
            var answer = await Rest.Request(query);

            if (answer.Status != Status.Ok)
                return null;

            return TripFeedJson.Serialize(answer.Result);
        }
    }
}
