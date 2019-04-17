using PipServices.Facets.Client.Version1;
using PipServices3.Commons.Config;
using System.Threading.Tasks;
using Xunit;

namespace PipServices.Facets.Client.Test.Version1
{
    public class FacetsHttpClientV1Test
    {
        private static readonly ConfigParams HttpConfig = ConfigParams.FromTuples(
            "connection.protocol", "http",
            "connection.host", "localhost",
            "connection.port", 8080
        );

        private FacetsHttpClientV1 _client;
        private FacetsClientFixtureV1 _fixture;

        public FacetsHttpClientV1Test()
        {
            _client = new FacetsHttpClientV1();
            _client.Configure(HttpConfig);

            _fixture = new FacetsClientFixtureV1(_client);
            _client.OpenAsync(null);
        }

        public void Dispose()
        {
            _client.CloseAsync(null).Wait();
        }

        [Fact]
        public async Task TestCrudOperationsAsync()
        {
            await _fixture.TestCrudOperationsAsync();
        }
    }
}
