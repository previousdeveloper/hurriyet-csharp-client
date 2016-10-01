using System.Collections.Generic;
using System.Threading.Tasks;
using HurriyetApiClient.Contract.Response;

namespace HurriyetApiClient.Api
{
    public interface IArticleResource
    {
        Task<List<ArticleResponse>> GetArticles();

    }
}