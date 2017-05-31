using NossaTrip.model.net;
using System.Threading.Tasks;

namespace NossaTrip.control.restful.trip
{
    public class TripRequester
    {
        public static async Task<string> GetTrip(ApiQueryMaker query)
        {
            var answer = await Rest.Request(query);

            if (answer.Status != Status.Ok)
                return null;

            return answer.Result;
        }
    }
}
