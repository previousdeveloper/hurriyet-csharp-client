using System.Collections.Generic;
using System.Threading.Tasks;
using HurriyetApiClient.Contract.Response;

namespace HurriyetApiClient.Api
{
    public interface IWriterResource
    {
        Task<List<WriterResponse>> GetWriters();
    }
}