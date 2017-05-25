using System;
using System.Collections.Generic;
using System.Linq;

namespace NossaTrip.model.net
{
    public class ApiQueryMaker
    {
        private const string serverUrl = "http://";
        private const string serverPort = ":1337";

        private readonly QueryType type;
        private readonly IDictionary<string, string> parameters;

        public ApiQueryMaker(QueryType type)
        {
            this.type = type;
            parameters = new Dictionary<string, string>();
        }

        public void AddParameter(string name, string value)
        {
            parameters.Add(name, value);
        }

        public string GetUrl()
        {
            try
            {
                var url = QueryUrl.Get(type);
                return serverUrl + serverPort + parameters.Aggregate(url, (current, entry) => current.Replace("{" + entry.Key + "}", entry.Value));
            }
            catch (Exception) { /* bad url */ throw new Exception(); }
        }
    }
}
