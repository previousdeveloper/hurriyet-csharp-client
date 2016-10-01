using System.Collections.Generic;
using System.Threading.Tasks;
using Httwrap;
using Httwrap.Interface;
using HurriyetApiClient.Api;
using HurriyetApiClient.Contract.Response;

namespace HurriyetApiClient
{
    public class HurriyetApiApiClient : IHurriyetApiClient
    {
        private readonly IHttwrapClient _httwrapClient;
        private readonly IHurriyetApiConfiguration _apiConfiguration;
        private readonly IApiResourceFactory _apiResourceFactory;

        public HurriyetApiApiClient(IHurriyetApiConfiguration apiConfiguration)
        {
            _apiConfiguration = apiConfiguration;

            IHttwrapConfiguration configuration = new HttwrapConfiguration(string.IsNullOrEmpty(_apiConfiguration.BaseUrl) ? Constants.BaseUrl : _apiConfiguration.BaseUrl);
            _httwrapClient = new HttwrapClient(configuration);

            _apiResourceFactory = new ApiResourceFactory(_httwrapClient);

            _httwrapClient.AddInterceptor(new ApiInterceptor(_apiConfiguration.ApiKey));
        }
        public async Task<List<ArticleResponse>> GetArticles()
        {
            List<ArticleResponse> result = await _apiResourceFactory.ArticleResource.GetArticles();

            return result;
        }

        public async Task<List<WriterResponse>> GetWriters()
        {
            List<WriterResponse> result = await _apiResourceFactory.WriterResource.GetWriters();

            return result;
        }
    }
}