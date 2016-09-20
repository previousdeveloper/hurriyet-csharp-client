using System;

namespace HurriyetApiClient.Response
{
    public class ArticleResponse
    {
        public long Id { get; set; }
        public string ContentType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

    }
}