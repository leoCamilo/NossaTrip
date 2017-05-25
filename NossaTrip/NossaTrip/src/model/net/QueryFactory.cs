﻿namespace NossaTrip.model.net
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
    }
}
