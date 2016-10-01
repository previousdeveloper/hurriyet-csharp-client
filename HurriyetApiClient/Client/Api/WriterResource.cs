using System.Collections.Generic;
using System.Threading.Tasks;
using Httwrap;
using Httwrap.Interface;
using HurriyetApiClient.Contract.Response;

namespace HurriyetApiClient.Api
{
    public class WriterResource : IWriterResource
    {
        private readonly IHttwrapClient _httwrapClient;

        public WriterResource(IHttwrapClient httwrapClient)
        {
            _httwrapClient = httwrapClient;
        }

        public async Task<List<WriterResponse>> GetWriters()
        {
            IHttwrapResponse response = await _httwrapClient.GetAsync("writers");

            return response.ReadAs<List<WriterResponse>>();
        }
    }
}