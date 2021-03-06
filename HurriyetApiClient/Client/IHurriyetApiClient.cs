﻿using System.Collections.Generic;
using System.Threading.Tasks;
using HurriyetApiClient.Contract.Response;

namespace HurriyetApiClient
{
    public interface IHurriyetApiClient
    {
        Task<List<ArticleResponse>> GetArticles();

        Task<List<WriterResponse>> GetWriters();
    }
}