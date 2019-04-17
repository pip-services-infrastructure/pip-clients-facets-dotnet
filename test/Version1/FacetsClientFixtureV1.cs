using PipServices.Facets.Client.Version1;
using PipServices3.Commons.Data;
using System.Threading.Tasks;
using Xunit;

namespace PipServices.Facets.Client.Test.Version1
{
    public class FacetsClientFixtureV1
    {
        private IFacetsClientV1 _client;

        public FacetsClientFixtureV1(IFacetsClientV1 client)
        {
            _client = client;
        }

        public async Task TestCrudOperationsAsync()
        {
            // Add facet 1
            var facet1 = await this._client.AddFacetAsync(null, "test", "group1");
            Assert.Equal("test", facet1.Group);
            Assert.Equal("group1", facet1.Name);
            Assert.Equal(1, facet1.Count);

            // Remove facet 1
            var facet_remove = await this._client.RemoveFacetAsync(null, "test", "group2");
            Assert.Equal("test", facet_remove.Group);
            Assert.Equal("group2", facet_remove.Name);
            Assert.Equal(0, facet_remove.Count);

            // Read facets
            var page = await this._client.GetFacetsByGroupAsync(null, "test", null);
            Assert.Single(page.Data);

            // Delete facets
            await this._client.DeleteFacetsByGroupAsync(null, "test");

            // Read facets
            var page_res = await this._client.GetFacetsByGroupAsync(null, "test", null);
            Assert.Empty(page_res.Data);
        }
    }
}
