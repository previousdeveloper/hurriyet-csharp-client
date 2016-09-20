using System.Collections.Generic;
using System.Threading.Tasks;
using Httwrap;
using Httwrap.Interface;
using HurriyetApiClient.Response;

namespace HurriyetApiClient.Api
{
    public class Article : IArticle
    {
        private readonly IHttwrapClient _httwrapClient;

        public Article(IHttwrapClient httwrapClient)
        {
            _httwrapClient = httwrapClient;
        }

        public async Task<List<ArticleResponse>> GetArticles()
        {
            IHttwrapResponse response = await _httwrapClient.GetAsync("articles");

            return response.ReadAs<List<ArticleResponse>>();
        }
    }
}