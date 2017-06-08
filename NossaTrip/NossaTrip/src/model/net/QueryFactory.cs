namespace NossaTrip.model.net
{
    public sealed class QueryFactory
    {
        public static ApiQueryMaker UserLogin(string base64User, string md5Password)
        {
            var query = new ApiQueryMaker(QueryType.UserLogin);

            query.AddParameter("user", base64User);
            query.AddParameter("pass", md5Password);

            return query;
        }

        public static ApiQueryMaker AllTrips()
        {
            return new ApiQueryMaker(QueryType.AllTrips);
        }

        public static ApiQueryMaker MyTrips()
        {
            return new ApiQueryMaker(QueryType.UserTrips); // TODO: correct route
        }

        public static ApiQueryMaker FavoriteTrips()
        {
            return new ApiQueryMaker(QueryType.FollowTrip); // TODO: correct route
        }

        public static ApiQueryMaker TripById(int id)
        {
            var query = new ApiQueryMaker(QueryType.TripById);

            query.AddParameter("id", id.ToString());

            return query;
        }
    }
}
