﻿using Httwrap.Interface;
using HurriyetApiClient.Api;

namespace HurriyetApiClient
{
    internal class ApiResourceFactory : IApiResourceFactory
    {
        private readonly IHttwrapClient _httwrapClient;

        public ApiResourceFactory(IHttwrapClient httwrapClient)
        {
            _httwrapClient = httwrapClient;
        }

        public IArticleResource ArticleResource => new ArticleResource(_httwrapClient);

        public IWriterResource WriterResource => new WriterResource(_httwrapClient);
    }
}