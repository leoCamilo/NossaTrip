using System.Collections.Generic;

namespace NossaTrip.model.net
{
    public enum QueryType
    {
        UserLogin,
        UserTrips,
        NewUserTrip,
        AllTrips,
        LikeTrip,
        FollowTrip,
        UploadImg,
        TripAddRoute,
        RateTrip
    }

    public static class QueryUrl
    {
        private static readonly IDictionary<int, string> getUrl = new Dictionary<int, string> {
            { (int) QueryType.UserLogin,    "/user/login/{user}/{pass}" },
            { (int) QueryType.UserTrips,    "/user/trips/my/{user_id}/" },
            { (int) QueryType.NewUserTrip,  "/user/trips/new/{user_id}/{hash}/" },
            { (int) QueryType.AllTrips,     "/trip/all" },
            { (int) QueryType.LikeTrip,     "/trip/like/{id_trip}/{id_user}/{like_or_unlike}/" },
            { (int) QueryType.FollowTrip,   "/trip/follow/{id_trip}/{id_user}/{follow}/" },
            { (int) QueryType.RateTrip,     "/trip/rate/{id_trip}/{id_user}/{rate}/" },
            { (int) QueryType.UploadImg,    "/trip/images/upload/{trip_id}/{user_id}/{hash}/" },
            { (int) QueryType.TripAddRoute, "/trip/routes/add/{trip_id}/{user_id}/{hash}/" }
        };

        public static string Get(QueryType key)
        {
            return getUrl[(int)key];
        }
    }
}