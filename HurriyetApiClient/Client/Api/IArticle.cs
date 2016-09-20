using System.Collections.Generic;
using System.Threading.Tasks;
using HurriyetApiClient.Response;

namespace HurriyetApiClient.Api
{
    public interface IArticle
    {
        Task<List<ArticleResponse>> GetArticles();

    }
}