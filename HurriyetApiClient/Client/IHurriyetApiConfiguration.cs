namespace HurriyetApiClient
{
    public interface IHurriyetApiConfiguration
    {
        string ApiKey { get; set; }
        string BaseUrl { get; set; }

    }
}