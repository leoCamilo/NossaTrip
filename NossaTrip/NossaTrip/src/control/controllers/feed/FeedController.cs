using NossaTrip.control.restful.feed;
using NossaTrip.control.restful.trip;
using NossaTrip.model.domain.trip;
using NossaTrip.model.json.feed;
using NossaTrip.model.json.trip;
using NossaTrip.model.net;
using NossaTrip.test.json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NossaTrip.control.controllers.feed
{
    public class FeedController
    {
        public async static Task<Trip> GetTrip(int id)
        {
            if (App.StaticData)
            {
                return TripJson.Serialize(id % 2 == 0 ? StaticJsonData.testTripJson1 : StaticJsonData.testTripJson2);
            }
            else
            {
                return TripJson.Serialize(await TripRequester.GetTrip(QueryFactory.TripById(id)));
            }
        }

        public async static Task<IList<Trip>> GetAllTrips()
        {
            if (App.StaticData)
            {
                return TripFeedJson.Serialize(StaticJsonData.FeedJson);
            }
            else
            {
                return await FeedRequester.GetTrips(QueryFactory.AllTrips());
            }
        }

        public async static Task<IList<Trip>> GetFavoritesTrips()
        {
            if (App.StaticData)
            {
                return TripFeedJson.Serialize(StaticJsonData.FavoritesTripJson);
            }
            else
            {
                return await FeedRequester.GetTrips(QueryFactory.FavoriteTrips());
            }
        }

        public async static Task<IList<Trip>> GetMyTrips()
        {
            if (App.StaticData)
            {
                return TripFeedJson.Serialize(StaticJsonData.MyTripsJson);
            }
            else
            {
                return await FeedRequester.GetTrips(QueryFactory.MyTrips());
            }
        }
    }
}