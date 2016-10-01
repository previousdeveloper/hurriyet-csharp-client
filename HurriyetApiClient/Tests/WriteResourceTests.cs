using System.Collections.Generic;
using Common.Testing.NUnit;
using FluentAssertions;
using HurriyetApiClient.Contract.Response;
using NUnit.Framework;

namespace HurriyetApiClient.Tests
{
    public class WriteResourceTests : TestBase
    {
        private IHurriyetApiClient _hurriyetApiClient;
        private IHurriyetApiConfiguration _apiConfiguration;
        protected override void FinalizeSetUp()
        {
            _apiConfiguration = new HurriyetApiConfiguration(Constants.ApiKey);

            _hurriyetApiClient = new HurriyetApiApiClient(_apiConfiguration);
        }

        [Test]
        public void Articles_Test()
        {
            List<WriterResponse> result = _hurriyetApiClient.GetWriters().Result;

            result.Should().NotBeNull();
        }

        [Test]
        public async void Article_Async_Test()
        {
            List<WriterResponse> result = await _hurriyetApiClient.GetWriters();

            result.Should().NotBeNull();
        }
    }
}
