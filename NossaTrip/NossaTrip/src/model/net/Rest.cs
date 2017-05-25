using System.Threading.Tasks;
using System.Net.Http;
using System;

namespace NossaTrip.model.net
{
    public enum Status { Error, Ok, Timeout, NoConnection }

    public struct RestAnswer
    {
        public Status Status { get; }
        public string Result { get; }

        public RestAnswer(Status status, string result)
        {
            Status = status;
            Result = result;
        }
    }

    public sealed class Rest
    {
        private static readonly HttpClient Client = new HttpClient();

        public static async Task<RestAnswer> Request(ApiQueryMaker apiMaker)
        {
            try
            {
                const int timeout = 5000;
                var task = Client.GetStringAsync(apiMaker.GetUrl());
                return await Task.WhenAny(task, Task.Delay(timeout)) == task ? new RestAnswer(Status.Ok, task.Result) : new RestAnswer(Status.Timeout, "timeout");
            }
            catch (AggregateException e)
            {
                return new RestAnswer(Status.Error, "error");
            }
        }
    }
}
