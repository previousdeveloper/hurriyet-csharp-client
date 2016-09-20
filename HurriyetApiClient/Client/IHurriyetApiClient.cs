using System.Collections.Generic;
using System.Threading.Tasks;
using HurriyetApiClient.Response;

namespace HurriyetApiClient
{
    public interface IHurriyetApiClient
    {
        Task<List<ArticleResponse>> GetArticles();
    }
}