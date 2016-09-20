using System.Collections.Generic;
using System.Threading.Tasks;
using Httwrap;
using Httwrap.Interface;
using HurriyetApiClient.Api;
using HurriyetApiClient.Response;

namespace HurriyetApiClient
{
    public class HurriyetApiApiClient : IHurriyetApiClient
    {
        private readonly IHttwrapClient _httwrapClient;
        private readonly IArticle _article;
        private readonly IHurriyetApiConfiguration _apiConfiguration;

        public HurriyetApiApiClient(IHurriyetApiConfiguration apiConfiguration)
        {
            _apiConfiguration = apiConfiguration;

            IHttwrapConfiguration configuration = new HttwrapConfiguration(string.IsNullOrEmpty(_apiConfiguration.BaseUrl) ? Constants.BaseUrl : _apiConfiguration.BaseUrl);
            _httwrapClient = new HttwrapClient(configuration);
            _article = new Article(_httwrapClient);

            _httwrapClient.AddInterceptor(new ApiInterceptor(_apiConfiguration.ApiKey));
        }
        public async Task<List<ArticleResponse>> GetArticles()
        {
            List<ArticleResponse> result = await _article.GetArticles();

            return result;
        }

    }
}