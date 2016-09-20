using System.Net.Http;
using Httwrap.Interception;

namespace HurriyetApiClient
{
    internal class ApiInterceptor : IHttpInterceptor
    {
        private readonly string _apiKey;
        public ApiInterceptor(string apiKey)
        {
            _apiKey = apiKey;
        }

        public void OnRequest(HttpRequestMessage request)
        {
            request.Headers.Add(Constants.ApiKeyHeader, _apiKey);
        }

        public void OnResponse(HttpRequestMessage request, HttpResponseMessage response)
        {

        }
    }
}