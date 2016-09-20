using System.Collections.Generic;
using Common.Testing.NUnit;
using FluentAssertions;
using HurriyetApiClient.Response;
using NUnit.Framework;

namespace HurriyetApiClient.Tests
{
    public class ArticleTests : TestBase
    {
        private IHurriyetApiClient _hurriyetApiClient;
        private IHurriyetApiConfiguration _apiConfiguration;
        protected override void FinalizeSetUp()
        {
            _apiConfiguration = new HurriyetApiConfiguration("3cc23baca72a4abc81c8e7ed2fb60f0e");

            _hurriyetApiClient = new HurriyetApiApiClient(_apiConfiguration);
        }

        [Test]
        public void Articles_Test()
        {
            List<ArticleResponse> result = _hurriyetApiClient.GetArticles().Result;

            result.Should().NotBeEmpty();
        }
    }
}