using System;

namespace HurriyetApiClient.Contract.Response
{
    public class WriterResponse
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string ContentType { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Path { get; set; }
        public string Url { get; set; }

    }
}
