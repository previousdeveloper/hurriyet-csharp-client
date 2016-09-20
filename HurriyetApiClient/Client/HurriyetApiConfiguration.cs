namespace HurriyetApiClient
{
    public class HurriyetApiConfiguration : IHurriyetApiConfiguration
    {
        public string ApiKey { get; set; }
        public string BaseUrl { get; set; }

        public HurriyetApiConfiguration(string apiKey, string baseUrl = null)
        {
            ApiKey = apiKey;
            BaseUrl = baseUrl;

            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new ApiKeyNotFoundException("Api key not be empty");
            }
        }
    }
}